use QL_TTHT
INSERT INTO PHANQUYEN(TenQuyen,ChiTietQuyen) VALUES(N'Quyền Giáo Viên',N'chỉ có quyền quản lý lớp học mà mình dạy')
INSERT INTO PHANQUYEN(TenQuyen,ChiTietQuyen) VALUES(N'Quyền Nhân Viên',N'có tất cả các quyền')

insert into TAIKHOAN values('admin','admin',2)
INSERT INTO TAIKHOAN VALUES('minhngoc123','minhngoc123',1)
INSERT INTO TAIKHOAN VALUES('thanhhang123','thanhhang123',1)
INSERT INTO TAIKHOAN VALUES('thanhnam123','thanhnam123',1)
INSERT INTO TAIKHOAN VALUES('ducthang123','ducthang123',1)

INSERT INTO MUCTHANHTOAN VALUES(1)
INSERT INTO MUCTHANHTOAN VALUES(0.9)
INSERT INTO MUCTHANHTOAN VALUES(0.8)

INSERT INTO GIAOVIEN VALUES(N'Lê Minh Ngọc','0339654781','1994-09-21',N'Hà Đông, Hà Nội',N'Nữ',1,'minhngoc123')
INSERT INTO GIAOVIEN VALUES(N'Bùi Thanh Hằng','0374654781','1998-08-28',N'Cầu Giấy, Hà Nội',N'Nữ',2,'thanhhang123')
INSERT INTO GIAOVIEN VALUES(N'Nguyễn Thành Nam','0382654781','1996-11-10',N'Hà Đông, Hà Nội',N'Nam',3,'thanhnam123')
INSERT INTO GIAOVIEN VALUES(N'Tạ Đức Thắng','0399654781','1995-09-21',N'Cầu Giấy, Hà Nội',N'Nam',1,'ducthang123')

INSERT INTO BIENLAITRALUONG VALUES('',4,5500000,0,1)