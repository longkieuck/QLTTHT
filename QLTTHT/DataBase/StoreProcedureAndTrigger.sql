﻿--TRIGGER
--update muc uu dai cho hoc vien sau khi dang ki them lop hoc moi(muc hoc phi toi da la 3)
use QL_TTHT
go
CREATE TRIGGER UPDATE_MUCUUDAI
ON HOCVIEN_LOPHOC AFTER INSERT
AS
BEGIN
	DECLARE @MAHV INT;
	SET @MAHV=(SELECT MAHV FROM INSERTED)
	
	DECLARE @MAMUD INT;
	SET @MAMUD=(SELECT MAMUD
				FROM HOCVIEN
				WHERE MaHV=@MAHV)
	IF(@MAMUD < 3)
	BEGIN
		UPDATE HOCVIEN
		SET MAMUD = HOCVIEN.MAMUD + 1
		WHERE MAHV = @MAHV
	END
END

GO
--update muc thanh toan cho giao vien sau khi dang ki them lop day moi(muc thanh toan toi da la 3)

CREATE TRIGGER UPDATE_MUCTHANHTOAN
ON LOPHOC AFTER INSERT
AS
BEGIN
	DECLARE @MAGV INT;
	SET @MAGV=(SELECT MAGV FROM INSERTED)
	
	DECLARE @MAMTT INT;
	SET @MAMTT=(SELECT MAMTT
				FROM GIAOVIEN
				WHERE MaGV=@MAGV)
	IF(@MAMTT < 3)
	BEGIN
		UPDATE GIAOVIEN
		SET MaMTT = GIAOVIEN.MaMTT + 1
		WHERE MAGV = @MAGV
	END
END
GO

--Trigger khi học viên xoá lớp đang học thì cập nhật lại mức ưu đãi
CREATE TRIGGER UPDATE_MUCUUDAI2
ON HOCVIEN_LOPHOC INSTEAD OF DELETE
AS
BEGIN
	DECLARE @MAHV INT;
	SET @MAHV=(SELECT MAHV FROM DELETED)

	DECLARE @SOLOP INT;
	SET @SOLOP=(SELECT COUNT(*)
				FROM HOCVIEN_LOPHOC
			    WHERE MaHV = @MAHV
				)
	
	IF(@SOLOP <=3)
	BEGIN
		DECLARE @MAMHP INT;
		SET @MAMHP=(SELECT MAMUD
					FROM HOCVIEN
					WHERE MaHV=@MAHV)
		UPDATE HOCVIEN
		SET MAMUD = HOCVIEN.MAMUD - 1
		WHERE MAHV = @MAHV
	END

	DELETE FROM HOCVIEN_LOPHOC
		   WHERE MALH IN(SELECT MALH FROM DELETED)
END

GO

--TRIGGER XOA BUOI HOC
CREATE TRIGGER XOA_BUOIHOC
ON BUOIHOC INSTEAD OF DELETE
AS
BEGIN
	DECLARE @MABH INT;
	SET @MABH=(SELECT MaBH FROM DELETED)

	DELETE FROM DIEMDANH
	WHERE MaBH=@MABH
	
	DELETE FROM BUOIHOC
	WHERE MaBH=@MABH

END
GO
--Trigger khi giáo viên xoá bỏ lớp học thì đồng thời xoá các buổi học,
--và các hocvien_lophoc của lớp học đó, cập nhật mức thanh toán.
CREATE TRIGGER UPDATE_MUCTHANHTOAN2
ON LOPHOC FOR DELETE
AS
BEGIN	
	DECLARE @SOLOP INT;
	SET @SOLOP=(SELECT COUNT(*)
				FROM LOPHOC
			    WHERE MaGV IN (SELECT MaGV FROM deleted)
				)
	
	IF(@SOLOP <=3)
	BEGIN
		DECLARE @MAMTT INT;
		SET @MAMTT=(SELECT MAMTT
					FROM GIAOVIEN
					WHERE MaGV IN (SELECT MaLH FROM deleted))
		UPDATE GIAOVIEN
		SET MaMTT = GIAOVIEN.MaMTT - 1
		WHERE MAGV IN (SELECT MaLH FROM deleted)
	END
	
	DELETE FROM HOCVIEN_LOPHOC
	WHERE MaLH IN (SELECT MaLH FROM deleted)

	DELETE FROM BUOIHOC
	WHERE MaLH IN (SELECT MaLH FROM deleted)

	DELETE FROM LOPHOC
	WHERE MALH IN (SELECT MaLH FROM deleted)
END
GO

--update hoc phi cho hoc vien,luong cho giao vien sau moi lan diem danh thanh cong

CREATE TRIGGER UPDATE_HOCPHI
ON DIEMDANH AFTER INSERT
AS
BEGIN
	
	DECLARE @MAHV INT;
	SET @MAHV=(SELECT MAHV FROM inserted)
	
	DECLARE @MUCUUDAI FLOAT;
	SET @MUCUUDAI=(SELECT MUCUUDAI FROM HOCVIEN,MUCUUDAI
				   WHERE HOCVIEN.MaHV=@MAHV AND MUCUUDAI.MaMUD=HOCVIEN.MaMUD
				  )
	
	DECLARE @MABH INT;
	SET @MABH=(SELECT MABH FROM inserted)
	
	DECLARE @HP1BUOI INT;
	SET @HP1BUOI=(SELECT HP1BUOI FROM LOPHOC,BUOIHOC,MUCHOCPHI
				  WHERE BUOIHOC.MaBH=@MABH AND BUOIHOC.MaLH=LOPHOC.MaLH AND LOPHOC.MaMHP=MUCHOCPHI.MaMHP
				 )

	DECLARE @MAGV INT;
	SET @MAGV=(SELECT MAGV FROM LOPHOC,BUOIHOC
				  WHERE BUOIHOC.MaBH=@MABH AND BUOIHOC.MaLH=LOPHOC.MaLH
				 )
	
	DECLARE @TILE FLOAT;
	SET @TILE=(SELECT TILE FROM GIAOVIEN AS GV,MUCTHANHTOAN AS M
			   WHERE GV.MAGV=@MAGV AND GV.MAMTT=M.MAMTT
			   )
	--Update hoc phi cho hoc vien
	UPDATE BIENLAITHUHOCPHI
	SET HocPhi = HocPhi + @MUCUUDAI*@HP1BUOI
	WHERE MaHV=@MAHV
	--Update luong cho giao vien
	UPDATE BIENLAITRALUONG
	SET LUONG = LUONG + @HP1BUOI*@TILE
	WHERE MAGV=@MAGV and DaThanhToan=0
END
GO

--SP Login
CREATE PROC SP_Login
@username nvarchar(50), @pass nvarchar(50)
AS
BEGIN
	SELECT * FROM dbo.TAIKHOAN WHERE TK = @username AND MK = @pass
END
GO

--SP_GetMaQuyenByUserName
CREATE PROC SP_GetMaQuyenByUserName
@username nvarchar(50), @pass nvarchar(50)
AS
BEGIN
	SELECT * FROM dbo.TAIKHOAN WHERE TK = @username
END
GO
--SP_GetMaGVByUserName
CREATE PROC SP_GetMaGVByUserName
@username nvarchar(50), @pass nvarchar(50)
AS
BEGIN
	SELECT * FROM dbo.GIAOVIEN WHERE TK = @username
END
GO

---------------------------------- Van--------------------------------------------------
-- Thu tuc lay danh sach giao vien va muc thanh toan tuong ung
create proc GetTeacherList
as
begin
	select gv.MaGV, gv.HoTen, gv.NgaySinh, gv.GioiTinh, gv.DiaChi, gv.SDT, mtt.TiLe
	from GIAOVIEN gv, MUCTHANHTOAN mtt
	where gv.MaMTT = mtt.MaMTT
end
go

-- Ham tim kiem ten
CREATE FUNCTION [dbo].[GetUnsignString](@strInput NVARCHAR(4000)) 
RETURNS NVARCHAR(4000)
AS
BEGIN     
    IF @strInput IS NULL RETURN @strInput
    IF @strInput = '' RETURN @strInput
    DECLARE @RT NVARCHAR(4000)
    DECLARE @SIGN_CHARS NCHAR(136)
    DECLARE @UNSIGN_CHARS NCHAR (136)

    SET @SIGN_CHARS       = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ'+NCHAR(272)+ NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'

    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
    SET @COUNTER = 1
 
    WHILE (@COUNTER <=LEN(@strInput))
    BEGIN   
      SET @COUNTER1 = 1
      --Tim trong chuoi mau
       WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1)
       BEGIN
     IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) )
     BEGIN           
          IF @COUNTER=1
              SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1)                   
          ELSE
              SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER)    
              BREAK         
               END
             SET @COUNTER1 = @COUNTER1 +1
       END
      --Tim tiep
       SET @COUNTER = @COUNTER +1
    END
    RETURN @strInput
END
go

-- Thu tuc tim kiem giao vien theo ten
create proc SearchGiaoVienByName
	@name nvarchar(50)
as
begin
	select gv.MaGV, gv.HoTen, gv.NgaySinh, gv.GioiTinh, gv.DiaChi, gv.SDT, mtt.TiLe
	from GIAOVIEN gv, MucThanhToan mtt
	where gv.MaMTT = mtt.MaMTT and [dbo].[GetUnsignString](HoTen) like N'%' + [dbo].[GetUnsignString](@name) + '%'
end
go

-- Thu tuc lay danh sach muc thanh toan cua giao vien
create proc GetMucTTList
as
begin
	select *
	from MUCTHANHTOAN
end
go

-- Thu tuc lay muc thanh toan theo giao vien
create proc GetMucTTByGiaoVien
	@magv int
as
begin
	select *
	from MUCTHANHTOAN mtt
	where mtt.MaMTT in (select gv.MaMTT
						from GIAOVIEN gv
						where gv.MaGV = @magv)
end

-- Thu tuc tim giao vien theo magv
create proc GetGiaoVien
	@magv int
as
begin
	select *
	from GIAOVIEN
	where MaGV = @magv
end

-- Thu tuc them giao vien
create proc InsertGiaoVien
	@hoten nvarchar(50),
	@ngaysinh date,
	@diachi nvarchar(50),
	@gioitinh nchar(3),
	@sdt char(10),
	@mamtt int,
	@tk nchar(50),
	@mk nchar(50)
as
begin
	insert into TAIKHOAN values(@tk, @mk, 1)
	insert into GIAOVIEN(HoTen, SDT, NgaySinh, DiaChi, GioiTinh, MaMTT, TK) values(@hoten, @sdt, @ngaysinh, @diachi, @gioitinh, @mamtt, @tk)
end
go

-- Trigger tao bien lai thanh toan luong khi them giao vien moi
CREATE TRIGGER TAO_BLTL_GVMOI ON GIAOVIEN
AFTER INSERT
AS
BEGIN
	DECLARE @NGAYHT DATE;
	DECLARE @THANGHT INT;
	DECLARE @MAGV INT;

	SET @MAGV = (SELECT MaGV FROM inserted)
	
	SELECT @NGAYHT = GETDATE()

	SELECT @THANGHT = MONTH (@NGAYHT)

	INSERT INTO BIENLAITRALUONG VALUES('',@THANGHT,0,0,@MAGV)
END
GO
-- Thu tuc dua ra danh sach lop hoc cua giao vien co id cu the
create proc GetLopHocByMaGV
	@magv int
as
begin
	select *
	from LOPHOC lh
	where lh.MaGV = @magv
end
go

-- Thu tuc cap nhat thong tin giao vien theo id
create proc UpdateGiaoVien
	@magv int,
	@hoten nvarchar(50),
	@sdt char(10),
	@ngaysinh date,
	@diachi nvarchar(50),
	@gioitinh nvarchar(3),
	@mamtt int
as
begin
	update GIAOVIEN
	set HoTen=@hoten, SDT=@sdt, NgaySinh=@ngaysinh, DiaChi=@diachi, GioiTinh=@gioitinh, MaMTT=@mamtt
	where MaGV = @magv
end
go
-- Thu tuc xoa thong tin giao vien theo id
create proc DeleteGiaoVien
	@magv int
as
begin
	DELETE LOPHOC
	WHERE MaGV in (select MaGV
					from GIAOVIEN
					where MaGV = @magv)

	DELETE BIENLAITRALUONG
	WHERE MaGV in (select MaGV
					from GIAOVIEN
					where MaGV = @magv)
				
	delete GIAOVIEN
	where MaGV = @magv
end
go

CREATE TRIGGER DELETE_TK ON GIAOVIEN
AFTER DELETE
AS
BEGIN
	DELETE TAIKHOAN
	WHERE TK IN (SELECT TK
				FROM deleted)
END
GO

-- Thu tuc tim muc thanh toan theo mamtt
create proc GetMucThanhToan
	@mamtt int
as
begin
	select *
	from MUCTHANHTOAN
	where MaMTT = @mamtt
end
go

-- Thu tuc tim hoc phi lop theo ma lop
create proc GetHocPhi
	@malh int
as
begin
	select *
	from MUCHOCPHI mhp
	where mhp.MaMHP in (select lh.MaMHP
						from LOPHOC lh
						where lh.MaLH = @malh)
end
go

-- Ham lay BLTL chua thanh toan cua giao vien
create proc GetBLTLByMaGV
	@magv int
as
begin
	select *
	from BIENLAITRALUONG
	where DaThanhToan = 0 and MaGV = @magv
end
go

-- Ham chuyen tinh trang thanh toan
CREATE FUNCTION [dbo].[GetDaThanhToan](@dathanhtoan INT) 
RETURNS NVARCHAR(50)
AS
BEGIN 
	declare @tinhtrang NVARCHAR(50);

	if(@dathanhtoan = 1)
		set @tinhtrang = N'Đã thanh toán'
	else
		set @tinhtrang = N'Chưa thanh toán'

	return @tinhtrang;
END
GO

-- Thu tuc lay danh sach BLTL cua giao vien
CREATE PROC GETALLBTLTBYMAGV
	@magv INT
AS
BEGIN
	DECLARE @SOBLTL INT;
	SELECT MaBLTL, NgayTra, Thang, Luong, [dbo].[GetDaThanhToan](DaThanhToan) as N'DaThanhToan'
	FROM BIENLAITRALUONG
	WHERE MaGV = @magv

END
GO

-- Thu tuc thanh toan luong giao vien
CREATE PROC THANHTOANLUONG
	@magv INT,
	@ngaytra DATE
AS
BEGIN
	DECLARE @THANGMOI INT;
	DECLARE @THANGCU INT;

	(SELECT @THANGCU = Thang FROM BIENLAITRALUONG WHERE DaThanhToan = 0 and MaGV = @magv)

	UPDATE BIENLAITRALUONG
	SET DaThanhToan = 1,
		NgayTra = @ngaytra
	WHERE MaGV = @magv and DaThanhToan = 0

	IF(@THANGCU < 12)
		SET @THANGMOI = @THANGCU + 1
	ELSE
		SET @THANGMOI = 1

	INSERT INTO BIENLAITRALUONG VALUES('',@THANGMOI,0,0,@magv)

END
GO

-- Thu tuc them, sua , xoa lop hoc cho 1 giao vien
CREATE PROC THEMLH
	@TenLH NVARCHAR(50),
	@MaMHP INT,
	@MaMH INT,
	@MaGV INT
AS
BEGIN
	INSERT INTO LOPHOC VALUES(@TenLH,@MaMHP,@MaMH,@MaGV)
END
GO

CREATE PROC XOALH
	@MaLH INT
AS
BEGIN
	DELETE LOPHOC
	WHERE MaLH = @MaLH
END
GO

CREATE PROC SUALH
	@MaLH INT,
	@TenLH NVARCHAR(50),
	@MaMHP INT,
	@MaMH INT
AS
BEGIN
	UPDATE LOPHOC
	SET TenLH = @TenLH,
		MaMHP = @MaMHP,
		MaMH = @MaMH
	WHERE MaLH = @MaLH
END
GO

-- Thu tuc lay danh sach mon hoc
CREATE PROC GETALLMONHOC
AS
BEGIN
	SELECT *
	FROM MONHOC
END
GO
-- Thu tuc lay danh sach muc hoc phi
CREATE PROC GETALLMUCHP
AS
BEGIN
	SELECT *
	FROM MUCHOCPHI
END
GO
---------------------------------- . / Van -----------------------------------------------