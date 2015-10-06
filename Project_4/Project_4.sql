--create database Project_4
go
use Project_4

create table HangHoa
(
	MaHH char(10)not null,
	TenHH nvarchar(50)null,
	DonViTinh nvarchar(50)null,
	ThoiGianBaoHanh char(10)null,
)

create table NhaCungCap
(
	MaNCC char(10)not null,
	TenNCC nvarchar(50)null,
	DiaChiNCC nvarchar(200)null,
	SdtNCC char(10)null,
)

create table NhanVien
(
	MaNV char(10)not null,
	TenNV nvarchar(50)null,
	NgaySinh date null,
	GioiTinh nchar(3)null,
	MaDV nvarchar(10)not null,
)

create table DonVi
(
	MaDV char(10)not null,
	TenDV nvarchar(50)null,
	ChucNang nvarchar(50)null,
)

create table PhieuNhap
(
	SpNhap nvarchar(50)not null,
	NgayNhap date null,
	MaNCC char(10)not null,
	LiDoNhap nvarchar(200)null,
	MaNV char(10)not null,
	MaHH char(10)not null,
	SlNhap char(10)null,
)

create table PhieuXuat
(
	SpXuat nvarchar(50)not null,
	NgayXuat date null,
	LiDoXuat nvarchar(200)null,
	MaNV char(10)not null,
	MaHH char(10)not null,
	SlXuat char(10)null,
)

alter table HangHoa add constraint pk_mahh primary key (MaHH)
alter table NhaCungCap add constraint pk_mancc primary key (MaNCC)
alter table NhanVien add constraint pk_manv_madv foreign key (MaNV) references DonVi(MaDV)
alter table DonVi add constraint pk_madv primary key(MaDV)
alter table PhieuNhap add constraint pk_spnhap_mancc_manv_mahh foreign key (SpNhap) references NhaCungCap(MaNCC),NhanVien(MaNV),HangHoa(MaHH)
alter table PhieuXuat add constraint pk_spxuat_manv_mahh foreign key (SpXuat) references NhanVien(MaNV),HangHoa(MaHH)

insert into HangHoa
values 
('HH01',N'Hàng hóa 01',N'Hộp','12'),
('HH02',N'Hàng hóa 02',N'Thanh','18'),
('HH03',N'Hàng hóa 03',N'Cái','12'),
('HH04',N'Hàng hóa 04',N'Cái','12'),
('HH05',N'Hàng hóa 05',N'Hộp','24')

insert into NhaCungCap
values
('NCC01',N'Hoàng Hà',N'43 Đinh Tiên Hoàng, Hải Phòng','0989123456'),
('NCC02',N'Thăng Long',N'123 Hoàng Quốc Việt, Hà Nội','0123456789'),
('NCC03',N'Hải Tiến',N'15 Hồ Tùng Mậu, Hà Nội','0987656789')

insert into NhanVien
values
('NV01',N'Nhân Viên 01','1/3/1990',N'Nam','DV01'),
('NV02',N'Nhân Viên 02','5/5/1992',N'Nữ','DV01'),
('NV03',N'Nhân Viên 03','6/3/1989',N'Nam','DV02'),
('NV04',N'Nhân Viên 04','9/7/1988',N'Nam','DV03'),
('NV05',N'Nhân Viên 05','12/8/1989',N'Nữ','DV03'),
('NV06',N'Nhân Viên 06','11/4/1991',N'Nữ','DV04')

insert into DonVi
values
('DV01',N'Đơn Vị 01',N'Chức năng 01'),
('DV02',N'Đơn Vị 02',N'Chức năng 02'),
('DV03',N'Đơn Vị 03',N'Chức năng 03'),
('DV04',N'Đơn Vị 04',N'Chức năng 04')

insert into PhieuNhap
values
('PN01','2/10/2015','NCC01',N'Nhập mới','NV02','HH02','10'),
('PN01','2/10/2015','NCC02',N'Nhập mới','NV01','HH03','15'),
('PN02','3/15/2015','NCC02',N'Nhập mới','NV03','HH01','15'),
('PN03','4/11/2015','NCC01',N'Nhập mới','NV02','HH04','15'),
('PN03','4/11/2015','NCC03',N'Nhập mới','NV06','HH05','30'),
('PN04','5/20/2015','NCC02',N'Nhập mới','NV04','HH02','10'),
('PN05','7/9/2015','NCC02',N'Nhập mới','NV03','HH01','13'),
('PN06','9/2/2015','NCC03',N'Nhập mới','NV05','HH03','20')

insert into PhieuXuat
values
('PX01','3/20/2015',N'Xuất bán','NV01','HH02','10'),
('PX01','3/20/2015',N'Xuất bán','NV02','HH03','15'),
('PX02','4/11/2015',N'Xuất bán','NV03','HH01','20'),
('PX03','5/18/2015',N'Xuất bán','NV01','HH05','15'),
('PX04','6/4/2015',N'Xuất bán','NV05','HH04','10'),
('PX05','8/14/2015',N'Xuất bán','NV04','HH05','15')

create proc NhapHH
(
	@SpNhap nvarchar(50),
	@NgayNhap date,
	@MaNCC char(10),
	@LiDoNhap nvarchar(200),
	@MaNV char(10),
	@MaHH char(10),
	@SlNhap char(10)
)
as
begin
	insert into PhieuNhap
	values (@SpNhap,@NgayNhap,@MaNCC,@LiDoNhap,@MaNV,@MaHH,@SlNhap)
end
go

create proc XuatHH
(
	@SpXuat nvarchar(50),
	@NgayXuat date,
	@LiDoXuat nvarchar(200),
	@MaNV char(10),
	@MaHH char(10),
	@SlXuat char(10)
)
as
begin
	insert into PhieuXuat
	values (@SpXuat,@NgayXuat,@LiDoXuat,@MaNV,@MaHH,@SlXuat)
end
go

create proc TimHH
(
	
)

create proc ThongKe
(
	
)