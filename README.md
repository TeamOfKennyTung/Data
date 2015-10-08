# Datacreate table DichVu_Phong
(	ID_DV varchar(10) not null, Ten_DV nvarchar(50), DV_Tien nchar(10), Gia_DV money 
)
drop table DichVu_Phong
create table KhachHang 
(	ID_KhachHang varchar(10) not null, Ten_KhachHang nvarchar(50),QueQuan nvarchar(50), GioiTinh nchar(10),
	CMND nchar(12), QuocTich nvarchar(50)
)
drop table KhachHang
create table LoaiPhong 
(	Ma_Ploai char(10) not null ,TenLoai nvarchar(50), GiaTien_Ngay money, GiaTien_Gio money, 
	ViTri nvarchar(50), solong int
)
create table Phong 
(	ID_Phong varchar(10) not null,Ma_Ploai char (10) not null, TinhTrang nvarchar(20), 
	HienTrang nvarchar(20), So_DT int
)
create table SuDung_DV
(	ID_Phong varchar(10) not null, ID_DV varchar(10) not null, SoLuong int, NgaySD datetime 
)
drop table SuDung_DV
create table DangNhap
( name nvarchar(50) not null, pass nvarchar(50)
)
create table ThietBi_Phong 
( ID_TB char(10) not null, Ten_TB nvarchar(50), DvTien nchar(10), Gia_TB money
)
create table ThuePhong
(	ID_Khach varchar(10) not null, ID_Phong varchar(10) not null, TG_Bdau datetime , TG_TraPhong datetime,
	Tien_DatCoc money, TG_TraPhongTT datetime , MaThanhToan int, MaGiaoDich char(10) not null
)
drop table ThuePhong
create table ThietBi
(	ID_LPhong char(10) not null, ID_TB char(10) not null, SoLuong int
)

alter table Phong add constraint FK_P primary key (ID_phong),
	constraint FK_P_LP foreign key (Ma_Ploai) references LoaiPhong (Ma_Ploai)
alter table LoaiPhong add constraint FK_LP primary key (Ma_PLoai)
alter table KhachHang add constraint FK_KH primary key (ID_KhachHang)
alter table ThietBi_Phong add constraint FK_TBP primary  key (ID_TB)
alter table DichVu_Phong add constraint FK_DVP primary key (ID_DV)

alter table SuDung_DV add constraint FK_SDDV primary key (ID_Phong, ID_DV),
	constraint FK_SDDV_Phong foreign key (ID_Phong) references Phong(ID_Phong),
	constraint FK_SDDV_DV foreign key (ID_DV) references DichVu_Phong(ID_DV)

alter table ThietBi add constraint FK_TB primary key (ID_LPhong, ID_TB),
	constraint FK_TB_LPhong foreign key (ID_LPhong) references LoaiPhong(Ma_Ploai)
alter table ThietBi add constraint FK_TB_TB foreign key (ID_TB) references ThietBi_Phong(ID_TB)

alter table ThuePhong add constraint FK_TP primary key (ID_Khach, ID_Phong),
	constraint FK_TP_Phong foreign key (ID_Phong) references Phong(ID_Phong),
	constraint FK_TP_KhachHang foreign key (ID_Khach) references KhachHang(ID_KhachHang)
	
	
INSERT [dbo].[Loai_Phong] ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [soluong]) VALUES (N'ABC       ', N'siêu vip', 2000000.0000, 22222.0000, N'Tầng 9', 4)
INSERT [dbo].[Loai_Phong] ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [soluong]) VALUES (N'CNR       ', N'Connect room - Loại phòng thông nhau', 400.0000, 40000.0000, N'Tầng 5', 7)
INSERT [dbo].[Loai_Phong] ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [soluong]) VALUES (N'DLX1      ', N'Deluxe - Loại cao cấp 1-2 người', 300.0000, 30000.0000, N'Tầng 4', 5)
INSERT [dbo].[Loai_Phong] ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [soluong]) VALUES (N'DLX2      ', N'Deluxe - Loại cao cấp 3-4 người', 350.0000, 35000.0000, N'Tầng 4', 2)
INSERT [dbo].[Loai_Phong] ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [soluong]) VALUES (N'STD1      ', N'Standard - Loại bình dân 1-2 người', 200.0000, 20000.0000, N'Tầng 1', 2)
INSERT [dbo].[Loai_Phong] ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [soluong]) VALUES (N'STD2      ', N'Standard - Loại bình dân 3-4 người', 250.0000, 25000.0000, N'Tầng 1', 4)
INSERT [dbo].[Loai_Phong] ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [soluong]) VALUES (N'SUP1      ', N'Superior - Loại tương đối tốt 1-2 người', 400.0000, 40000.0000, N'Tầng 2', 4)
INSERT [dbo].[Loai_Phong] ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [soluong]) VALUES (N'SUP2      ', N'Superior - Loại tương đối tốt 3-4 người', 450.0000, 45000.0000, N'Tầng 2', 5)
INSERT [dbo].[Loai_Phong] ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [soluong]) VALUES (N'VIP1      ', N'Suite - Loại cao cấp nhất 1-2 người', 450.0000, 45000.0000, N'Tầng 6', 3)
INSERT [dbo].[Loai_Phong] ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [soluong]) VALUES (N'VIP2      ', N'Suite - Loại cao cấp nhất 3-4 người', 500.0000, 50000.0000, N'Tầng 6', 2)
