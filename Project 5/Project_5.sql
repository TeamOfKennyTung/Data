create database XDHTQLKS
go
use [XDHTQLKS]


create table tblDichVu_Phong
(	ID_DV varchar(10) not null, Ten_DV nvarchar(50), DV_Tien nchar(10), Gia_DV money 
)

create table tblKhachHang 
(	ID_KhachHang varchar(10) not null, Ten_KhachHang nvarchar(50),QueQuan nvarchar(50), GioiTinh nchar(10),
	CMND nchar(12), QuocTich nvarchar(50)
)

create table  tblLoaiPhong 
(	Ma_Ploai char(10) not null ,TenLoai nvarchar(50), GiaTien_Ngay money, GiaTien_Gio money, 
	ViTri nvarchar(50), solong int
)
create table  tblPhong 
(	ID_Phong varchar(10) not null,Ma_Ploai char (10) not null, TinhTrang nvarchar(20), 
	HienTrang nvarchar(20), So_DT int
)
create table  tblSuDung_DV
(	ID_Phong varchar(10) not null, ID_DV varchar(10) not null, SoLuong int, NgaySD datetime 
)

create table  tblDangNhap
( name nvarchar(50) not null, pass nvarchar(50)
)
create table  tblThietBi_Phong 
( ID_TB char(10) not null, Ten_TB nvarchar(50), DvTien nchar(10), Gia_TB money
)
create table  tblThuePhong
(	ID_Khach varchar(10) not null, ID_Phong varchar(10) not null, TG_Bdau datetime , TG_TraPhong datetime,
	Tien_DatCoc money, TG_TraPhongTT datetime , MaThanhToan int, MaGiaoDich char(10) not null
)

create table  tblThietBi
(	ID_LPhong char(10) not null, ID_TB char(10) not null, SoLuong int
)

create table tblUser
(
	TaiKhoan varchar(50) not null,
	MatKhau varchar(50) not null
)


insert into tblUser values (N'nguyenanhdung', N'nguyenanhdung')
insert into tblUser values (N'hoangdinhdat', N'hoangdinhdat')
insert into tblUser values (N'phixuandao', N'phixuandao')
insert into tblUser values (N'phamdinhminh', N'phamdinhminh')
insert into tblUser values (N'levanvu', N'levanvu')
insert into tblUser values (N'luongvanluan', N'luongvanluan')

alter table  tblPhong add constraint FK_P primary key (ID_phong),
	constraint FK_P_LP foreign key (Ma_Ploai) references tblLoaiPhong (Ma_Ploai)
alter table  tblLoaiPhong add constraint FK_LP primary key (Ma_PLoai)
alter table  tblKhachHang add constraint FK_KH primary key (ID_KhachHang)
alter table  tblThietBi_Phong add constraint FK_TBP primary  key (ID_TB)
alter table  tblDichVu_Phong add constraint FK_DVP primary key (ID_DV)

alter table tblSuDung_DV add constraint FK_SDDV primary key (ID_Phong, ID_DV),
	constraint FK_SDDV_tblPhong foreign key (ID_Phong) references tblPhong(ID_Phong),
	constraint FK_SDDV_DV foreign key (ID_DV) references tblDichVu_Phong(ID_DV)

alter table tblThietBi add constraint FK_TB primary key (ID_LPhong, ID_TB),
	constraint FK_TB_LPhong foreign key (ID_LPhong) references tblLoaiPhong(Ma_Ploai)
alter table tblThietBi add constraint FK_TB_TB foreign key (ID_TB) references tblThietBi_Phong(ID_TB)

alter table  tblThuePhong add constraint FK_TP primary key (ID_Khach, ID_Phong),
	constraint FK_TP_tblPhong foreign key (ID_Phong) references tblPhong(ID_Phong),
	constraint FK_TP_tblKhachHang foreign key (ID_Khach) references tblKhachHang(ID_KhachHang)
	
	
INSERT into [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB02      ', N'Tủ quần áo to', N'chiếc     ', 400000.0000)
INSERT into [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB03      ', N'Tivi', N'chiếc     ', 4000000.0000)
INSERT into [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB04      ', N'Máy điều hòa', N'chiếc     ', 10000000.0000)
INSERT into [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB05      ', N'Máy nóng lạnh', N'chiếc     ', 7000000.0000)
INSERT into [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB06      ', N'Chăn nhung', N'chiếc     ', 400000.0000)
INSERT into [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB07      ', N'Quạt tường', N'chiếc     ', 150000.0000)
INSERT into [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB08      ', N'Gạt tàn', N'chiếc     ', 10000.0000)
INSERT into [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB09      ', N'Dép trong phòng', N'đôi       ', 20000.0000)
INSERT into [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB10      ', N'Gối', N'chiếc     ', 50000.0000)
INSERT into [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB11      ', N'Bàn + ghế', N'bộ        ', 400000.0000)
INSERT into [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB12      ', N'Khăn + Bàn chải', N'bộ        ', 50000.0000)
INSERT into [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB13      ', N'Đầu kĩ thuất số', N'bộ        ', 2000000.0000)
INSERT into [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB14      ', N'tủ lạnh', N'chiếc     ', 6000000.0000)
INSERT into [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB15      ', N'Khăn tắm', N'chiếc     ', 50000.0000)
INSERT into [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB16      ', N'Đầu CD', N'chiếc     ', 1100000.0000)
INSERT into [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB17      ', N'Đèn leon', N'chiếc     ', 50000.0000)
INSERT into [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB18      ', N'Tủ quần áo nhỏ', N'chiếc     ', 200000.0000)
INSERT into [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB19      ', N'Sổ hướng dẫn dịch vụ', N'cuốn      ', 0.0000)
INSERT into [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB01      ', N'Giường gỗ', N'chiếc     ', 500000.0000)




INSERT into [dbo].[tblLoaiPhong] ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [solong]) VALUES (N'ABC       ', N'siêu vip', 2000000.0000, 22222.0000, N'Tầng 9', 4)
INSERT into [dbo].[tblLoaiPhong]  ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [solong]) VALUES (N'CNR       ', N'Connect room - Loại phòng thông nhau', 400.0000, 40000.0000, N'Tầng 5', 7)
INSERT into [dbo].[tblLoaiPhong]  ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [solong]) VALUES (N'DLX1      ', N'Deluxe - Loại cao cấp 1-2 người', 300.0000, 30000.0000, N'Tầng 4', 5)
INSERT into [dbo].[tblLoaiPhong]  ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [solong]) VALUES (N'DLX2      ', N'Deluxe - Loại cao cấp 3-4 người', 350.0000, 35000.0000, N'Tầng 4', 2)
INSERT into [dbo].[tblLoaiPhong]  ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [solong]) VALUES (N'STD1      ', N'Standard - Loại bình dân 1-2 người', 200.0000, 20000.0000, N'Tầng 1', 2)
INSERT into [dbo].[tblLoaiPhong]  ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [solong]) VALUES (N'STD2      ', N'Standard - Loại bình dân 3-4 người', 250.0000, 25000.0000, N'Tầng 1', 4)
INSERT into [dbo].[tblLoaiPhong]  ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [solong]) VALUES (N'SUP1      ', N'Superior - Loại tương đối tốt 1-2 người', 400.0000, 40000.0000, N'Tầng 2', 4)
INSERT into [dbo].[tblLoaiPhong]  ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [solong]) VALUES (N'SUP2      ', N'Superior - Loại tương đối tốt 3-4 người', 450.0000, 45000.0000, N'Tầng 2', 5)
INSERT into [dbo].[tblLoaiPhong] ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [solong]) VALUES (N'VIP1      ', N'Suite - Loại cao cấp nhất 1-2 người', 450.0000, 45000.0000, N'Tầng 6', 3)
INSERT into [dbo].[tblLoaiPhong] ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [solong]) VALUES (N'VIP2      ', N'Suite - Loại cao cấp nhất 3-4 người', 500.0000, 50000.0000, N'Tầng 6', 2)




--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB01      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB02      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB03      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB04      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB05      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB06      ', 5)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB07      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB08      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB09      ', 6)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB10      ', 4)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB11      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB13      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB14      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB17      ', 8)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB19      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX1      ', N'TB01      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX1      ', N'TB02      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX1      ', N'TB03      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX1      ', N'TB04      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX1      ', N'TB05      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX1      ', N'TB06      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX1      ', N'TB08      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX1      ', N'TB09      ', 3)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX1      ', N'TB10      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX1      ', N'TB13      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX1      ', N'TB17      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX2      ', N'TB01      ', 4)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX2      ', N'TB02      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX2      ', N'TB03      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX2      ', N'TB04      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX2      ', N'TB05      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX2      ', N'TB06      ', 4)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX2      ', N'TB08      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX2      ', N'TB09      ', 4)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX2      ', N'TB10      ', 4)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX2      ', N'TB13      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX2      ', N'TB17      ', 4)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD1      ', N'TB01      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD1      ', N'TB03      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD1      ', N'TB06      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD1      ', N'TB07      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD1      ', N'TB10      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD1      ', N'TB11      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD1      ', N'TB16      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD1      ', N'TB18      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD1      ', N'TB19      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD2      ', N'TB01      ', 4)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD2      ', N'TB03      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD2      ', N'TB04      ', 4)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD2      ', N'TB06      ', 4)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD2      ', N'TB07      ', 4)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD2      ', N'TB10      ', 4)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD2      ', N'TB11      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD2      ', N'TB16      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD2      ', N'TB18      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB01      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB02      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB03      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB04      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB05      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB06      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB09      ', 4)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB10      ', 4)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB11      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB12      ', 3)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB13      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB14      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB17      ', 4)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB01      ', 4)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB02      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB03      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB04      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB05      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB06      ', 4)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB09      ', 4)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB10      ', 4)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB11      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB12      ', 4)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB13      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB14      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB17      ', 4)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB01      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB02      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB03      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB04      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB05      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB06      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB07      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB08      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB09      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB10      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB11      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB12      ', 4)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB13      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB14      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB15      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB17      ', 4)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB19      ', 1)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP2      ', N'TB01      ', 4)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP2      ', N'TB02      ', 2)
--INSERT [dbo].[Trangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP2      ', N'TB03      ', 2)


INSERT into [dbo].[tblDichVu_Phong] ([ID_DV], [Ten_DV], [DV_tien], [Gia_DV]) VALUES (N'DVU1      ', N'Giặt là quần áo', N'Bộ        ', 5000.0000)
INSERT into [dbo].[tblDichVu_Phong] ([ID_DV], [Ten_DV], [DV_tien], [Gia_DV]) VALUES (N'DVU10     ', N'Bia Hà Nội', N'Chai      ', 10000.0000)
INSERT into [dbo].[tblDichVu_Phong] ([ID_DV], [Ten_DV], [DV_tien], [Gia_DV]) VALUES (N'DVU11     ', N'Bia Đại Việt', N'Thùng     ', 235000.0000)
INSERT into [dbo].[tblDichVu_Phong] ([ID_DV], [Ten_DV], [DV_tien], [Gia_DV]) VALUES (N'DVU12     ', N'Nước Hoa Quả', N'Cốc       ', 20000.0000)
INSERT into [dbo].[tblDichVu_Phong] ([ID_DV], [Ten_DV], [DV_tien], [Gia_DV]) VALUES (N'DVU13     ', N'Fax trong nước', N'Trang     ', 2000.0000)
INSERT into [dbo].[tblDichVu_Phong] ([ID_DV], [Ten_DV], [DV_tien], [Gia_DV]) VALUES (N'DVU14     ', N'Vận chuyển', N'Lượt     ', 20000.0000)
INSERT into [dbo].[tblDichVu_Phong] ([ID_DV], [Ten_DV], [DV_tien], [Gia_DV]) VALUES (N'DVU15     ', N'Fax quốc tế', N'Trang     ', 3000.0000)
INSERT into [dbo].[tblDichVu_Phong] ([ID_DV], [Ten_DV], [DV_tien], [Gia_DV]) VALUES (N'DVU16     ', N'Bóng đá', N'Giờ      ', 100000.0000)
INSERT into [dbo].[tblDichVu_Phong] ([ID_DV], [Ten_DV], [DV_tien], [Gia_DV]) VALUES (N'DVU17     ', N'Ăn uống', N'Xuất     ', 50000.0000)
INSERT into [dbo].[tblDichVu_Phong] ([ID_DV], [Ten_DV], [DV_tien], [Gia_DV]) VALUES (N'DVU18     ', N'masage', N'Giờ      ', 28888.0000)
INSERT into [dbo].[tblDichVu_Phong] ([ID_DV], [Ten_DV], [DV_tien], [Gia_DV]) VALUES (N'DVU19     ', N'db', N'Lượt      ', 200000.0000)
INSERT into [dbo].[tblDichVu_Phong] ([ID_DV], [Ten_DV], [DV_tien], [Gia_DV]) VALUES (N'DVU2      ', N'Mạng Wifi', N'Ngày      ', 20000.0000)
INSERT into [dbo].[tblDichVu_Phong] ([ID_DV], [Ten_DV], [DV_tien], [Gia_DV]) VALUES (N'DVU3      ', N'Thuê xe máy', N'Giờ      ', 30000.0000)
INSERT into [dbo].[tblDichVu_Phong] ([ID_DV], [Ten_DV], [DV_tien], [Gia_DV]) VALUES (N'DVU4      ', N'Phục vụ tận nơi', N'Lượt      ', 20000.0000)
INSERT into [dbo].[tblDichVu_Phong] ([ID_DV], [Ten_DV], [DV_tien], [Gia_DV]) VALUES (N'DVU5      ', N'Bơi lội', N'Lượt      ', 30000.0000)
INSERT into [dbo].[tblDichVu_Phong] ([ID_DV], [Ten_DV], [DV_tien], [Gia_DV]) VALUES (N'DVU6      ', N'Karaoke', N'Giờ      ', 50000.0000)
INSERT into [dbo].[tblDichVu_Phong] ([ID_DV], [Ten_DV], [DV_tien], [Gia_DV]) VALUES (N'DVU7      ', N'Thuê đồ', N'Bộ        ', 10000.0000)
INSERT into [dbo].[tblDichVu_Phong] ([ID_DV], [Ten_DV], [DV_tien], [Gia_DV]) VALUES (N'DVU8      ', N'Xông hơi', N'Lượt      ', 100000.0000)
INSERT into [dbo].[tblDichVu_Phong] ([ID_DV], [Ten_DV], [DV_tien], [Gia_DV]) VALUES (N'DVU9      ', N'Bia Heineken', N'Thùng     ', 365000.0000)

INSERT into [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (101, N'cnr       ', N'Tốt', N'Đã thuê', 444411)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (102, N'STD1      ', N'Tốt', N'Đã thuê', 444412)
INSERT into [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (103, N'STD2      ', N'Tốt', N'Đã thuê', 444413)
INSERT into [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (104, N'STD2      ', N'Tốt', N'Chưa thuê', 444414)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (105, N'STD1      ', N'Tốt', N'Đã thuê', 444415)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (106, N'STD2      ', N'Tốt', N'Chưa thuê', 444416)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (107, N'STD2      ', N'Tốt', N'Đã thuê', 444417)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (201, N'SUP1      ', N'Tốt', N'Đã thuê', 444421)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (202, N'SUP1      ', N'Không đảm bảo', N'Chưa thuê', 444422)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (203, N'SUP1      ', N'Không đảm bảo', N'Chưa thuê', 444423)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (204, N'SUP1      ', N'Tốt', N'Chưa thuê', 444424)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (205, N'SUP2      ', N'Tốt', N'Đã thuê', 444425)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (206, N'SUP2      ', N'Tốt', N'Đã thuê', 444426)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (207, N'SUP2      ', N'Không đảm bảo', N'Chưa thuê', 444427)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (208, N'SUP2      ', N'Không đảm bảo', N'Chưa thuê', 444428)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (209, N'SUP2      ', N'Không đảm bảo', N'Chưa thuê', 444429)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (401, N'DLX1      ', N'Tốt', N'Chưa thuê', 444431)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (402, N'DLX1      ', N'Tốt', N'Chưa thuê', 122122)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (403, N'DLX1      ', N'Tốt', N'Chưa thuê', 444431)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (404, N'DLX2      ', N'Tốt', N'Chưa thuê', 444431)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (405, N'DLX2      ', N'Không đảm bảo', N'Chưa thuê', 444432)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (406, N'DLX1      ', N'Tốt', N'Chưa thuê', 122121)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (407, N'DLX1      ', N'Tốt', N'Chưa thuê', 323333)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (501, N'CNR       ', N'Tốt', N'Chưa thuê', 444501)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (502, N'CNR       ', N'Tốt', N'Chưa thuê', 0)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (503, N'CNR       ', N'Tốt', N'Chưa thuê', 444503)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (504, N'CNR       ', N'Tốt', N'Đã thuê', 444504)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (505, N'CNR       ', N'Tốt', N'Chưa thuê', 323283)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (506, N'CNR       ', N'Tốt', N'Chưa thuê', 329839)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (601, N'VIP1      ', N'Tốt', N'Chưa thuê', 444601)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (602, N'VIP1      ', N'Tốt', N'Chưa thuê', 444602)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (603, N'VIP1      ', N'Không đảm bảo', N'Chưa thuê', 444603)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (604, N'VIP2      ', N'Tốt', N'Chưa thuê', 444604)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (605, N'VIP2      ', N'Tốt', N'Chưa thuê', 444605)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (901, N'ABC       ', N'Tốt', N'Chưa thuê', 838383)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (902, N'ABC       ', N'Tốt', N'Chưa thuê', 838383)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (903, N'ABC       ', N'Tốt', N'Chưa thuê', 838383)
INSERT into [dbo].[tblPhong]  ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (904, N'ABC       ', N'Tốt', N'Chưa thuê', 838383)


INSERT into [dbo].[tblSuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (106, N'DVU10     ', 3, CAST(0x0000A43500000000 AS DateTime))
INSERT [dbo].[SuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (107, N'DVU4      ', 3, CAST(0x0000A43500000000 AS DateTime))
INSERT [dbo].[SuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (201, N'DVU6      ', 2, CAST(0x0000A43100000000 AS DateTime))
INSERT [dbo].[SuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (201, N'DVU7      ', 3, CAST(0x0000A43300000000 AS DateTime))
INSERT [dbo].[SuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (206, N'DVU11     ', 20, CAST(0x0000A43600000000 AS DateTime))
INSERT [dbo].[SuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (206, N'DVU12     ', 5, CAST(0x0000A43700000000 AS DateTime))
INSERT [dbo].[SuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (206, N'DVU6      ', 4, CAST(0x0000A43700000000 AS DateTime))
INSERT [dbo].[SuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (401, N'DVU2      ', 3, CAST(0x0000A43600000000 AS DateTime))
INSERT [dbo].[SuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (401, N'DVU4      ', 10, CAST(0x0000A43600000000 AS DateTime))
INSERT [dbo].[SuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (401, N'DVU7      ', 2, CAST(0x0000A43700000000 AS DateTime))
INSERT [dbo].[SuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (401, N'DVU9      ', 10, CAST(0x0000A43900000000 AS DateTime))
INSERT [dbo].[SuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (403, N'DVU2      ', 2, CAST(0x0000A43800000000 AS DateTime))
INSERT [dbo].[SuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (501, N'DVU13     ', 20, CAST(0x0000A43800000000 AS DateTime))
INSERT [dbo].[SuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (501, N'DVU2      ', 2, CAST(0x0000A43800000000 AS DateTime))
INSERT [dbo].[SuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (501, N'DVU4      ', 3, CAST(0x0000A43B00000000 AS DateTime))
INSERT [dbo].[SuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (501, N'DVU8      ', 3, CAST(0x0000A43F00000000 AS DateTime))
INSERT [dbo].[SuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (601, N'DVU2      ', 3, CAST(0x0000A43F00000000 AS DateTime))
INSERT [dbo].[SuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (601, N'DVU5      ', 2, CAST(0x0000A44000000000 AS DateTime))
INSERT [dbo].[SuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (604, N'DVU1      ', 3, CAST(0x0000A44000000000 AS DateTime))
INSERT [dbo].[SuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (604, N'DVU8      ', 3, CAST(0x0000A44000000000 AS DateTime))
INSERT [dbo].[SuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (604, N'DVU9      ', 10, CAST(0x0000A44300000000 AS DateTime))