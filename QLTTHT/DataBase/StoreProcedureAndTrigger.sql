--TRIGGEG
USE QL_TTHT
--update muc uu dai cho hoc vien sau khi dang ki them lop hoc moi(muc hoc phi toi da la 3)
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


	DECLARE @SOLOP INT;
	SET @SOLOP=(SELECT COUNT(*)
				FROM HOCVIEN_LOPHOC
			    WHERE MaHV in(SELECT MAHV FROM DELETED)
				)
	
	IF(@SOLOP <=3)
	BEGIN
		DECLARE @MAMHP INT;
		SET @MAMHP=(SELECT MAMUD
					FROM HOCVIEN
					WHERE MaHV in (SELECT MAHV FROM DELETED))
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
ON LOPHOC INSTEAD OF DELETE
AS
BEGIN
	DECLARE @MAGV INT;
	SET @MAGV=(SELECT MaGV FROM DELETED)

	DECLARE @MALH INT;
	SET @MALH=(SELECT MALH FROM DELETED)
	
	DECLARE @SOLOP INT;
	SET @SOLOP=(SELECT COUNT(*)
				FROM LOPHOC
			    WHERE MaGV = @MAGV
				)
	
	IF(@SOLOP <=3)
	BEGIN
		DECLARE @MAMTT INT;
		SET @MAMTT=(SELECT MAMTT
					FROM GIAOVIEN
					WHERE MaGV=@MAGV)
		UPDATE GIAOVIEN
		SET MaMTT = GIAOVIEN.MaMTT - 1
		WHERE MAGV = @MAGV
	END
	
	DELETE FROM HOCVIEN_LOPHOC
	WHERE MaLH=@MALH

	DELETE FROM BUOIHOC
	WHERE MaLH=@MALH

	DELETE FROM LOPHOC
	WHERE MALH = @MALH
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
	WHERE MAGV=@MAGV
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
-------------------------quynh-----------------------------------
--HocSinh-GetAll
CREATE PROCEDURE HocSinh_GetAll
AS
BEGIN
  SELECT *
  FROM HOCVIEN
END
GO
--proc tim kiem hoc vien
CREATE PROCEDURE SP_Student_Search
  @searchValue NVARCHAR(200)
AS
BEGIN
  SELECT *
  FROM HOCVIEN
  WHERE  MaHV LIKE N'%' + @searchValue + '%'
    OR HoTen LIKE N'%' + @searchValue + '%'
    OR SDT LIKE N'%' + @searchValue + '%'
    OR NgaySinh LIKE N'%' + @searchValue + '%'
    OR DiaChi LIKE N'%' + @searchValue + '%'
    OR GioiTinh LIKE N'%' + @searchValue + '%'
	OR MaMUD LIKE N'%' + @searchValue+ '%'
END
GO

-- Thu tuc lay danh sach hoc vien va muc uu dai tuong ung
create proc Getstudenandmud
as
begin
	select hv.MaHV, hv.HoTen, hv.SDT , hv.NgaySinh, hv.DiaChi ,hv.GioiTinh, mud.MucUuDai
	from HOCVIEN hv, MUCUUDAI mud
	where hv.MaMUD = mud.MaMUD
end
go
-- Thu tuc lay danh sach muc uu dai cua hocvien
create proc GetMucUDList
as
begin
	select *
	from MUCUUDAI
end
go
-- Thu tuc lay muc uu dai theo hocvien
create proc GetMucUDByHocVien
	@mahv int
as
begin
	select *
	from MUCUUDAI mud
	where mud.MaMUD in (select hv.MaMUD
						from HOCVIEN hv
						where hv.MaHV = @mahv)
end
-- Thu tuc them hoc vien

create proc InsertHocVien
	@hoten nvarchar(50),
	@sdt char(10),
	@ngaysinh date,
	@diachi nvarchar(50),
	@gioitinh nchar(3),
	@mamud int

	
as
begin
	
	insert into HOCVIEN(HoTen, SDT,NgaySinh, DiaChi, GioiTinh, MaMUD) values(@hoten, @sdt, @ngaysinh, @diachi, @gioitinh,@mamud)
	
end
go
-- Thu tuc dua ra danh sach ma lop hoc cua hoc sinh có id cụ thể
create proc GetLopHocByMaHV
	@mahv int
as
begin
	select *
	from LOPHOC lh,HOCVIEN_LOPHOC
	where lh.MaLH=HOCVIEN_LOPHOC.MaLH and HOCVIEN_LOPHOC.MaHV=@mahv
end
go

create proc GetMaLopHocByMaHV
	@mahv int
as
begin
	select *
	from HOCVIEN_LOPHOC
	where HOCVIEN_LOPHOC.MaHV=@mahv
end
go
--thu tuc lay lop hoc theo ma lop hoc 
create proc GetLopHocByMaLH
    @malh int
as 
begin 
     select *
     from LOPHOC
     where LOPHOC.MaLH=@malh
end 
go



--THU TUC THEM LOP HOC khi hoc sinh dang ki
CREATE PROC ThemLopHocForHocVien
	@MaLH int,
	@MaHV int
AS
BEGIN
	
	INSERT INTO HOCVIEN_LOPHOC VAlUES(@MaLH,@MaHV)
END
GO

--xoa lop hoc

CREATE PROC XOALH	
	@MaLH INT
AS
BEGIN
    DELETE HOCVIEN_LOPHOC
	WHERE MaLH=@MaLH
	

END
GO


--thu luc lay danh sach lop hoc
create proc GetLopHoc 
AS
BEGIN
  SELECT *
  FROM LopHoc
END
GO







--thu tuc lay ten  mon hoc theo ma lop
create proc GetMonHocByMaLH
	@malh int
as
begin
	select *
	from MONHOC mh
	where mh.MaMH in (select lh.MaMH
						from LOPHOC lh
						where lh.MaLH = @malh)
end
go
--thu tuc lay ten giao vien theo ma lop
create proc GetGiaoVienByMalH
	@malh int
as
begin
	select *
	from GIAOVIEN gv
	where gv.MaGV in (select lh.MaGV
						from LOPHOC lh
						where lh.MaLH = @malh)
end
go




-- Thu tuc cap nhat thong tin hoc vien theo id??

create proc UpdateHocVien
    @mahv int,
	@hoten nvarchar(50),
	@sdt char(10),
	@ngaysinh date,
	@diachi nvarchar(50),
	@gioitinh nchar(3)
as
begin
	update HOCVIEN
	set HoTen=@hoten, SDT=@sdt, NgaySinh=@ngaysinh, DiaChi=@diachi, GioiTinh=@gioitinh
	where MaHV = @mahv
	
end
-- Thu tuc xoa thong tin hoc vien theo id??

create proc DeleteHocVien
	@mahv int
as
begin
    
	delete BIENLAITHUHOCPHI
	where MaHV in (select MaHV
	               from HOCVIEN where MaHV=@mahv)
    delete HOCVIEN_LOPHOC
	where MaHV in (select MaHV
	               from HOCVIEN where MaHV=@mahv)
	delete DIEMDANH
	where MaHV in (select MaHV
	               from HOCVIEN where MaHV=@mahv)
	delete HOCVIEN
	where MaHV = @mahv

	
end
go
exec DeleteHocVien 1





-- Thu tuc tim muc uu dai theo ma muc uu dai
create proc GetMucUuDai
	@mamud int
as
begin
	select *
	from MUCUUDAI
	where MaMUD = @mamud
end
go
-- Thu tuc tim hocvien theo mahv
create proc GetHocVien
	@mahv int
as
begin
	select *
	from HOCVIEN
	where MaHV = @mahv
end
---tao trigger khi them hoc vien moi se tao bien lai moi

CREATE TRIGGER TAO_BLTHP_HVMOi ON HOCVIEN
AFTER INSERT
AS
BEGIN
	DECLARE @NGAY DATE;
	DECLARE @THANG INT;
	DECLARE @MAHV INT;

	SET @MAHV = (SELECT MaHV FROM inserted)
	
	SELECT @NGAY = GETDATE()

	SELECT @THANG = MONTH (@NGAY)

	INSERT INTO BIENLAITHUHOCPHI VALUES('',@THANG,0,0,@MAHV)
END
GO
---lay bien lai chua thu cua hoc vien
create proc GetBLTHPByMaHV
	@mahv int
as
begin
	select *
	from BIENLAITHUHOCPHI
	where DaThanhToan = 0 and MaHV = @mahv
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

-- Thu tuc lay danh sach bien lai thu hoc phi roi cua hoc virn
CREATE PROC GETALLBLTHPBYMAHV
	@mahv INT
AS
BEGIN
	DECLARE @SOBLTHP INT;
	SELECT MaBLTHP, NgayThu, Thang, HocPhi, [dbo].[GetDaThanhToan](DaThanhToan) as N'DaThanhToan'
	FROM BIENLAITHUHOCPHI
	WHERE MaHV = @mahv

END
GO

-- Thu tuc thanh thu hoc phi
CREATE PROC THUHOCPHI
	@mahv INT,
	@ngaythu DATE
AS
BEGIN
	DECLARE @THANGMOI INT;
	DECLARE @THANGCU INT;

	(SELECT @THANGCU = Thang FROM BIENLAITHUHOCPHI WHERE DaThanhToan = 0 and MaHV = @mahv)

	UPDATE BIENLAITHUHOCPHI
	SET DaThanhToan = 1,
		NgayThu = @ngaythu
	WHERE MaHV= @mahv and DaThanhToan = 0

	IF(@THANGCU < 12)
		SET @THANGMOI = @THANGCU + 1
	ELSE
		SET @THANGMOI = 1

	INSERT INTO BIENLAITHUHOCPHI VALUES('',@THANGMOI,0,0,@mahv)

END
GO
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
exec GetHocPhi 1


-- tao bien lai moi
--drop trigger UPDATE_HOCPHI

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
	--Update hoc phi cho hoc vien neu da ton tai bien lai thi cap nhat vao bien lai
	--neu chua ton tai bien lai thi them moi bien lai
	IF EXISTS (SELECT * FROM BIENLAITHUHOCPHI WHERE MaHV=@MAHV and Thang=MONTH(GETDATE())) 
	BEGIN
		UPDATE BIENLAITHUHOCPHI
		SET HocPhi = HocPhi + @MUCUUDAI*@HP1BUOI
		WHERE MaHV=@MAHV and Thang=MONTH(GETDATE())
	END
	ELSE
	BEGIN
		Insert into BIENLAITHUHOCPHI(Thang,HocPhi,DaThanhToan,MaHV)
		Values(MONTH(GETDATE()),@MUCUUDAI*@HP1BUOI,0,@MAHV)
	END
	--Update luong cho giao vien
	UPDATE BIENLAITRALUONG
	SET LUONG = LUONG + @HP1BUOI*@TILE
	WHERE MAGV=@MAGV and DaThanhToan=0
END
GO