--CREATE DATABASE QLBANHANG_ST

CREATE TABLE HangHoa(
	ID_HangHoa CHAR(10) NOT NULL,
	TenHang NVARCHAR(50) NOT NULL,
	GiaHang int,
	NgayNhap date,
	HanSd date
)

CREATE TABLE NhanVien(
	ID_NhanVien CHAR(10) NOT NULL,
	HoTen NVARCHAR(50) NOT NULL,
	Quequan nvarchar(100),
	GT CHAR(3),
	CMND int,
	NgaySinh date
)

CREATE TABLE KhachHang(
	ID_KhachHang CHAR(10) NOT NULL,
	Ten_KhachHang NVARCHAR(50),
	SDT_KhachHang int,
	GioiTinh_KhachHang NVARCHAR(100)
	
)

CREATE TABLE HoaDon(
	ID_HoaDon CHAR(10) NOT NULL,
	Ten_HoaDon NVARCHAR(30),
	ID_KhachHang char(10) not null,
	ID_HangHoa char(10) not null,
	ID_NhanVien char(10)not null
	
)

alter table HangHoa add constraint HH_ID_PK primary key(ID_HangHoa)
alter table NhanVien add constraint NV_ID_PK primary key(ID_NhanVien)
alter table KhachHang add constraint KH_ID_PK primary key(ID_KhachHang)
alter table HoaDon add constraint HD_ID_PK primary key(ID_HoaDon)

insert into HangHoa(ID_HangHoa,TenHang,GiaHang,NgayNhap,HanSd)
values
('HH001',N'Sữa Tắm Nam','100000','2015-01-01','2017-01-01'),
('HH002',N'Dầu Gội','50000','2015-03-01','2017-09-02'),
('HH003',N'Khăn Tắm','20000','2015-01-01','2020-09-02'),
('HH004',N'Ti Vi','3000000','2014-01-01','2020-03-04'),
('HH005',N'Quạt Điện','1000000','2015-3-01','2022-02-02'),
('HH006',N'Ấm Siêu Tốc','500000','2014-04-03','2021-02-02'),
('HH007',N'Chăn Bông','200000','2013-04-01','2017-02-04'),
('HH008',N'Màn','100000','2014-01-01','2020-02-01'),
('HH009',N'Nho Sấy','200000','2015-01-01','2015-06-02'),
('HH010',N'Dừa Khô','100000','2014-01-01','2015-02-01')

insert into NhanVien(ID_NhanVien,HoTen,Quequan,GT,CMND,NgaySinh)
values
('NV001',N'Đào Quang Tính',N'Hà Nam',N'Nam','12345678','1993-01-03'),
('NV002',N'Ngô Thành  Trung',N'Thanh Hóa',N'Nam','12435679','1994-02-05'),
('NV003',N'Phan Ngọc Anh',N'Nghệ An',N'Nam','12534686','1991-01-04'),
('NV004',N'Phí Vô Thường',N'Hà Tĩnh',N'Nam','11223389','1990-02-03'),
('NV005',N'Phạm Thị Thúy',N'An Giang',N'Nữ','13456789','1993-01-05')

insert into KhachHang(ID_KhachHang,Ten_KhachHang,SDT_KhachHang,GioiTinh_KhachHang)
values
('KH001',N'Trần Văn Anh Tuấn','01686976063',N'Nam'),
('KH002',N'Nguyễn Thị Ánh','0123456789',N'Nữ'),
('KH003',N'Trần Văn Hóa','0123456978',N'Nam'),
('KH004','Nguyễn Đình Văn','0985585027',N'Nam'),
('KH005','Lê Thị Thủy','0988234567',N'Nữ')

insert into HoaDon(ID_HoaDon,Ten_HoaDon,ID_KhachHang,ID_HangHoa,ID_NhanVien)
values
('HD001',N'Hóa Đơn 1','KH001','HH001','NV001'),
('HD002',N'Hóa Đơn 2','KH002','HH002','NV002'),
('HD003',N'Hóa Đơn 3','KH003','HH003','NV003'),
('HD004',N'Hóa Đơn 4','KH004','HH004','NV004'),
('HD005',N'Hóa Đơn 5','KH005','HH005','NV005')


alter table HangHoa add constraint fk_hanghoa_hoadon foreign key (ID_HangHoa) references HoaDon(ID_HangHoa)
alter table KhachHang add constraint fk_khachhang_hoadon foreign key(ID_KhachHang) references HoaDon(ID_KhachHang)
alter table NhanVien add constraint fk_nhanvien_hoadon foreign key(ID_NhanVien) references HoaDon(ID_NhanVien)
