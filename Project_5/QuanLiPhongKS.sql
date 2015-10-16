USE [PHONG_KHACHSAN]
GO
/****** Object:  Table [dbo].[tblThietbi_phong]    Script Date: 10/16/2015 13:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblThietbi_phong](
	[ID_TB] [char](10) NOT NULL,
	[Ten_TB] [nvarchar](50) NULL,
	[DVtien] [nchar](10) NULL,
	[Gia_TB] [money] NULL,
 CONSTRAINT [PK_THIETBIPHONG] PRIMARY KEY CLUSTERED 
(
	[ID_TB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB01      ', N'Giường gỗ', N'chiếc     ', 500000.0000)
INSERT [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB02      ', N'Tủ quần áo to', N'chiếc     ', 400000.0000)
INSERT [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB03      ', N'Tivi', N'chiếc     ', 4000000.0000)
INSERT [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB04      ', N'Máy điều hòa', N'chiếc     ', 10000000.0000)
INSERT [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB05      ', N'Máy nóng lạnh', N'chiếc     ', 7000000.0000)
INSERT [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB06      ', N'Chăn nhung', N'chiếc     ', 400000.0000)
INSERT [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB07      ', N'Quạt tường', N'chiếc     ', 150000.0000)
INSERT [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB08      ', N'Gạt tàn', N'chiếc     ', 10000.0000)
INSERT [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB09      ', N'Dép trong phòng', N'đôi       ', 20000.0000)
INSERT [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB10      ', N'Gối', N'chiếc     ', 50000.0000)
INSERT [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB11      ', N'Bàn + ghế', N'bộ        ', 400000.0000)
INSERT [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB12      ', N'Khăn + Bàn chải', N'bộ        ', 50000.0000)
INSERT [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB13      ', N'Đầu kĩ thuất số', N'bộ        ', 2000000.0000)
INSERT [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB14      ', N'tủ lạnh', N'chiếc     ', 6000000.0000)
INSERT [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB15      ', N'Khăn tắm', N'chiếc     ', 50000.0000)
INSERT [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB16      ', N'Đầu CD', N'chiếc     ', 1100000.0000)
INSERT [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB17      ', N'Đèn leon', N'chiếc     ', 50000.0000)
INSERT [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB18      ', N'Tủ quần áo nhỏ', N'chiếc     ', 200000.0000)
INSERT [dbo].[tblThietbi_phong] ([ID_TB], [Ten_TB], [DVtien], [Gia_TB]) VALUES (N'TB19      ', N'Sổ hướng dẫn dịch vụ', N'cuốn      ', 0.0000)
/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 10/16/2015 13:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblKhachHang](
	[ID_Khach] [char](10) NOT NULL,
	[Ten_Khach] [nvarchar](50) NULL,
	[Que_Quan] [nvarchar](50) NULL,
	[GioiTinh] [nchar](10) NULL,
	[CMND] [nchar](10) NULL,
	[SDT] [varchar](12) NULL,
	[Quoc_Tich] [nvarchar](50) NULL,
 CONSTRAINT [PK_Khach_Hang] PRIMARY KEY CLUSTERED 
(
	[ID_Khach] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblKhachHang] ([ID_Khach], [Ten_Khach], [Que_Quan], [GioiTinh], [CMND], [SDT], [Quoc_Tich]) VALUES (N'KH1       ', N'Lê Công Tuấn Anh', N'Vĩnh Phúc', N'Nam       ', N'12213668  ', N'01673182234', N'Việt Nam')
INSERT [dbo].[tblKhachHang] ([ID_Khach], [Ten_Khach], [Que_Quan], [GioiTinh], [CMND], [SDT], [Quoc_Tich]) VALUES (N'KH10      ', N'luan', N'bf', N'Nam       ', N'12345828  ', N'0339939', N'vn')
INSERT [dbo].[tblKhachHang] ([ID_Khach], [Ten_Khach], [Que_Quan], [GioiTinh], [CMND], [SDT], [Quoc_Tich]) VALUES (N'KH11      ', N'luan', N'bf', N'Nam       ', N'21291828  ', N'0339939', N'vn')
INSERT [dbo].[tblKhachHang] ([ID_Khach], [Ten_Khach], [Que_Quan], [GioiTinh], [CMND], [SDT], [Quoc_Tich]) VALUES (N'KH12      ', N'luong van luan', N'bg', N'Nam       ', N'28218282  ', N'8291912', N'viet nam')
INSERT [dbo].[tblKhachHang] ([ID_Khach], [Ten_Khach], [Que_Quan], [GioiTinh], [CMND], [SDT], [Quoc_Tich]) VALUES (N'KH13      ', N'Lê Minh', N'HN', N'Nam       ', N'999999999 ', N'92388293', N'Việt Nam')
INSERT [dbo].[tblKhachHang] ([ID_Khach], [Ten_Khach], [Que_Quan], [GioiTinh], [CMND], [SDT], [Quoc_Tich]) VALUES (N'KH14      ', N'Lê Tuấn Minh', N'Hà Nội', N'Nam       ', N'12345678  ', N'098765432', N'Việt Nam')
INSERT [dbo].[tblKhachHang] ([ID_Khach], [Ten_Khach], [Que_Quan], [GioiTinh], [CMND], [SDT], [Quoc_Tich]) VALUES (N'KH2       ', N'Lưu Văn Lâm', N'Hải Phòng', N'Nam       ', N'38838380  ', N'0972112113', N'Việt Nam')
INSERT [dbo].[tblKhachHang] ([ID_Khach], [Ten_Khach], [Que_Quan], [GioiTinh], [CMND], [SDT], [Quoc_Tich]) VALUES (N'KH3       ', N'Nguyễn Chí Công', N'Hà Giang', N'Nam       ', N'28282812  ', N'0932213231', N'Việt Nam')
INSERT [dbo].[tblKhachHang] ([ID_Khach], [Ten_Khach], [Que_Quan], [GioiTinh], [CMND], [SDT], [Quoc_Tich]) VALUES (N'KH4       ', N'Rooney', N'Manchester', N'Nam       ', N'28128218  ', NULL, N'Anh')
INSERT [dbo].[tblKhachHang] ([ID_Khach], [Ten_Khach], [Que_Quan], [GioiTinh], [CMND], [SDT], [Quoc_Tich]) VALUES (N'KH5       ', N'Neymar', N'Santos', N'Nam       ', N'38838374  ', NULL, N'Brazil')
INSERT [dbo].[tblKhachHang] ([ID_Khach], [Ten_Khach], [Que_Quan], [GioiTinh], [CMND], [SDT], [Quoc_Tich]) VALUES (N'KH6       ', N'Lê Công Phượng', N'Thanh Hóa', N'Nam       ', N'28128218  ', N'0973823412', N'Việt Nam')
INSERT [dbo].[tblKhachHang] ([ID_Khach], [Ten_Khach], [Que_Quan], [GioiTinh], [CMND], [SDT], [Quoc_Tich]) VALUES (N'KH7       ', N'Nguyễn Tuấn Anh', N'Bắc Giang', N'Nam       ', N'38839283  ', N'01679824312', N'Việt Nam')
INSERT [dbo].[tblKhachHang] ([ID_Khach], [Ten_Khach], [Que_Quan], [GioiTinh], [CMND], [SDT], [Quoc_Tich]) VALUES (N'KH8       ', N'Nguyễn Lan Hương', N'Hà Nội', N'Nữ        ', N'38239832  ', N'0974567890', N'Việt Nam')
INSERT [dbo].[tblKhachHang] ([ID_Khach], [Ten_Khach], [Que_Quan], [GioiTinh], [CMND], [SDT], [Quoc_Tich]) VALUES (N'KH9       ', N'David DeGea', N'Marid', N'Nam       ', N'38239832  ', NULL, N'Tây Ban Nha')
/****** Object:  Table [dbo].[tblDichvu_Phong]    Script Date: 10/16/2015 13:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblDichvu_Phong](
	[ID_DV] [char](10) NOT NULL,
	[Ten_DV] [nvarchar](50) NULL,
	[Dvtien] [nchar](10) NULL,
	[Gia_DV] [money] NULL,
 CONSTRAINT [PK_DICHVUPHONG] PRIMARY KEY CLUSTERED 
(
	[ID_DV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblDichvu_Phong] ([ID_DV], [Ten_DV], [Dvtien], [Gia_DV]) VALUES (N'DVU1      ', N'Giặt là quần áo', N'Bộ        ', 5000.0000)
INSERT [dbo].[tblDichvu_Phong] ([ID_DV], [Ten_DV], [Dvtien], [Gia_DV]) VALUES (N'DVU10     ', N'Bia Hà Nội', N'Chai      ', 10000.0000)
INSERT [dbo].[tblDichvu_Phong] ([ID_DV], [Ten_DV], [Dvtien], [Gia_DV]) VALUES (N'DVU11     ', N'Bia Đại Việt', N'Thùng     ', 235000.0000)
INSERT [dbo].[tblDichvu_Phong] ([ID_DV], [Ten_DV], [Dvtien], [Gia_DV]) VALUES (N'DVU12     ', N'Nước Hoa Quả', N'Cốc       ', 20000.0000)
INSERT [dbo].[tblDichvu_Phong] ([ID_DV], [Ten_DV], [Dvtien], [Gia_DV]) VALUES (N'DVU13     ', N'Fax trong nước', N'Trang     ', 2000.0000)
INSERT [dbo].[tblDichvu_Phong] ([ID_DV], [Ten_DV], [Dvtien], [Gia_DV]) VALUES (N'DVU14     ', N'Vận chuyển', N'Lượt     ', 20000.0000)
INSERT [dbo].[tblDichvu_Phong] ([ID_DV], [Ten_DV], [Dvtien], [Gia_DV]) VALUES (N'DVU15     ', N'Fax quốc tế', N'Trang     ', 3000.0000)
INSERT [dbo].[tblDichvu_Phong] ([ID_DV], [Ten_DV], [Dvtien], [Gia_DV]) VALUES (N'DVU16     ', N'Bóng đá', N'Giờ      ', 100000.0000)
INSERT [dbo].[tblDichvu_Phong] ([ID_DV], [Ten_DV], [Dvtien], [Gia_DV]) VALUES (N'DVU17     ', N'Ăn uống', N'Xuất     ', 50000.0000)
INSERT [dbo].[tblDichvu_Phong] ([ID_DV], [Ten_DV], [Dvtien], [Gia_DV]) VALUES (N'DVU18     ', N'masage', N'Giờ      ', 28888.0000)
INSERT [dbo].[tblDichvu_Phong] ([ID_DV], [Ten_DV], [Dvtien], [Gia_DV]) VALUES (N'DVU19     ', N'db', N'Lượt      ', 200000.0000)
INSERT [dbo].[tblDichvu_Phong] ([ID_DV], [Ten_DV], [Dvtien], [Gia_DV]) VALUES (N'DVU2      ', N'Mạng Wifi', N'Ngày      ', 20000.0000)
INSERT [dbo].[tblDichvu_Phong] ([ID_DV], [Ten_DV], [Dvtien], [Gia_DV]) VALUES (N'DVU3      ', N'Thuê xe máy', N'Giờ      ', 30000.0000)
INSERT [dbo].[tblDichvu_Phong] ([ID_DV], [Ten_DV], [Dvtien], [Gia_DV]) VALUES (N'DVU4      ', N'Phục vụ tận nơi', N'Lượt      ', 20000.0000)
INSERT [dbo].[tblDichvu_Phong] ([ID_DV], [Ten_DV], [Dvtien], [Gia_DV]) VALUES (N'DVU5      ', N'Bơi lội', N'Lượt      ', 30000.0000)
INSERT [dbo].[tblDichvu_Phong] ([ID_DV], [Ten_DV], [Dvtien], [Gia_DV]) VALUES (N'DVU6      ', N'Karaoke', N'Giờ      ', 50000.0000)
INSERT [dbo].[tblDichvu_Phong] ([ID_DV], [Ten_DV], [Dvtien], [Gia_DV]) VALUES (N'DVU7      ', N'Thuê đồ', N'Bộ        ', 10000.0000)
INSERT [dbo].[tblDichvu_Phong] ([ID_DV], [Ten_DV], [Dvtien], [Gia_DV]) VALUES (N'DVU8      ', N'Xông hơi', N'Lượt      ', 100000.0000)
INSERT [dbo].[tblDichvu_Phong] ([ID_DV], [Ten_DV], [Dvtien], [Gia_DV]) VALUES (N'DVU9      ', N'Bia Heineken', N'Thùng     ', 365000.0000)
/****** Object:  Table [dbo].[tblDangNhap]    Script Date: 10/16/2015 13:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDangNhap](
	[name] [nvarchar](50) NULL,
	[pass] [nvarchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tblDangNhap] ([name], [pass]) VALUES (N'luanmu1994', N'13081994')
INSERT [dbo].[tblDangNhap] ([name], [pass]) VALUES (N'luanjr', N'luanjr')
/****** Object:  Table [dbo].[tblLoai_Phong]    Script Date: 10/16/2015 13:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblLoai_Phong](
	[Ma_Ploai] [char](10) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[GiaTien_ngay] [money] NULL,
	[GiaTien_gio] [money] NULL,
	[ViTri] [nvarchar](50) NULL,
	[soluong] [int] NULL,
 CONSTRAINT [PK_LOAIPHONG] PRIMARY KEY CLUSTERED 
(
	[Ma_Ploai] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblLoai_Phong] ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [soluong]) VALUES (N'ABC       ', N'siêu vip', 2000000.0000, 22222.0000, N'Tầng 9', 4)
INSERT [dbo].[tblLoai_Phong] ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [soluong]) VALUES (N'CNR       ', N'Connect room - Loại phòng thông nhau', 400.0000, 40000.0000, N'Tầng 5', 7)
INSERT [dbo].[tblLoai_Phong] ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [soluong]) VALUES (N'DLX1      ', N'Deluxe - Loại cao cấp 1-2 người', 300.0000, 30000.0000, N'Tầng 4', 5)
INSERT [dbo].[tblLoai_Phong] ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [soluong]) VALUES (N'DLX2      ', N'Deluxe - Loại cao cấp 3-4 người', 350.0000, 35000.0000, N'Tầng 4', 2)
INSERT [dbo].[tblLoai_Phong] ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [soluong]) VALUES (N'STD1      ', N'Standard - Loại bình dân 1-2 người', 200.0000, 20000.0000, N'Tầng 1', 2)
INSERT [dbo].[tblLoai_Phong] ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [soluong]) VALUES (N'STD2      ', N'Standard - Loại bình dân 3-4 người', 250.0000, 25000.0000, N'Tầng 1', 4)
INSERT [dbo].[tblLoai_Phong] ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [soluong]) VALUES (N'SUP1      ', N'Superior - Loại tương đối tốt 1-2 người', 400.0000, 40000.0000, N'Tầng 2', 4)
INSERT [dbo].[tblLoai_Phong] ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [soluong]) VALUES (N'SUP2      ', N'Superior - Loại tương đối tốt 3-4 người', 450.0000, 45000.0000, N'Tầng 2', 5)
INSERT [dbo].[tblLoai_Phong] ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [soluong]) VALUES (N'VIP1      ', N'Suite - Loại cao cấp nhất 1-2 người', 450.0000, 45000.0000, N'Tầng 6', 3)
INSERT [dbo].[tblLoai_Phong] ([Ma_Ploai], [TenLoai], [GiaTien_ngay], [GiaTien_gio], [ViTri], [soluong]) VALUES (N'VIP2      ', N'Suite - Loại cao cấp nhất 3-4 người', 500.0000, 50000.0000, N'Tầng 6', 2)
/****** Object:  StoredProcedure [dbo].[SuaPhong]    Script Date: 10/16/2015 13:48:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SuaPhong](@id_phong char(10),@ma_ploai char(10),@tinhtrang nvarchar(20),
		@hientrang nvarchar(20),@so_dt int,@kq int output)
as
begin
	if(@id_phong='')set @kq=0
	else
		if(@id_phong not in (select ID_Phong from Phong)) set @kq=1
		else 
		begin
			update Phong
			set Ma_Ploai=@ma_ploai,TinhTrang=@tinhtrang,HienTrang=@hientrang,So_DT=@so_dt
			where ID_Phong=@id_phong
			set @kq=2
		end
end
GO
/****** Object:  StoredProcedure [dbo].[SuaLoaiPhong]    Script Date: 10/16/2015 13:48:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SuaLoaiPhong] (@ma_ploai char(10),@tenloai nvarchar(50),
@giatienngay money,@giatiengio money,@vitri nvarchar(50),@kq int output)
as
begin
if(@ma_ploai='') set @kq=0
else if(@ma_ploai not in (select Ma_Ploai from Loai_Phong)) set @kq=1
else
begin
	update Loai_Phong
	set
	TenLoai=@tenloai,GiaTien_ngay=@giatienngay
	,GiaTien_gio=@giatiengio,ViTri=@vitri
	where Ma_Ploai=@ma_ploai
	set @kq=2
end
end
GO
/****** Object:  StoredProcedure [dbo].[SuaKhachHang]    Script Date: 10/16/2015 13:48:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaKhachHang](@idkh char(10),@gt nchar(10),@qq nvarchar(50),@cmnd varchar(12),@sdt varchar(12),@quoctich nvarchar(50),@kq int output)
as
begin
	if(@idkh not in (select ID_Khach from KhachHang))
	begin
		set @kq=1
		return
	end
	else
	begin
		update KhachHang
		set GioiTinh=@gt,Que_Quan=@qq,CMND=@cmnd,SDT=@sdt,Quoc_Tich=@quoctich
		where ID_Khach=@idkh
		set @kq=2
	end
end
GO
/****** Object:  StoredProcedure [dbo].[SuaDV]    Script Date: 10/16/2015 13:48:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaDV](@id_dv char(10),@ten_dv nvarchar(50),@dvtien nchar(10),@gia_dv money,@kq int output)
as
begin
	if(@id_dv='')set @kq=0
	else
		if(@id_dv not in (select ID_DV from Dichvu_Phong))set @kq=1
		else
		begin
			update Dichvu_Phong
			set Ten_DV=@ten_dv,Dvtien=@dvtien,Gia_DV=@gia_dv
			where ID_DV=@id_dv
			set @kq=2
		end
end
GO
/****** Object:  StoredProcedure [dbo].[capnhatsl]    Script Date: 10/16/2015 13:48:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[capnhatsl]
as
begin
declare @sl int,@ma varchar(10)
declare cur_sl cursor forward_only 
for select Ma_Ploai from LoaiPhong
open cur_sl
while 0=0
begin
	fetch next from cur_sl
	into @ma
	if @@FETCH_STATUS <> 0 break
	select @sl=COUNT(p.Ma_Ploai) from Loai_Phong, Phong p where p.Ma_Ploai=Loai_Phong.Ma_Ploai
	update Loai_Phong
	set soluong=@sl
	where Current of cur_sl
end
close cur_sl
deallocate cur_sl
end
GO
/****** Object:  StoredProcedure [dbo].[XoaSDDV]    Script Date: 10/16/2015 13:48:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[XoaSDDV](@id_phong int,@id_dv char(10),@ngaysd date,@kq int output)
as
begin
declare @test int
set @test=0 
	if(@id_phong=0 or @id_dv='' or @ngaysd ='')set @kq=0
	else
	begin
	if(@id_phong in (select ID_Phong from SuDung_DV))
		begin
			if(@id_dv in (select ID_DV from SuDung_DV where ID_Phong=@id_phong))
			begin
				if(@ngaysd in (select NgaySD from SuDung_DV where ID_Phong=@id_phong and ID_DV=@id_dv))
				begin
					delete from SuDung_DV
					where ID_Phong=@id_phong and ID_DV=@id_dv and NgaySD=@ngaysd
					set @kq=2
				end
			end
			else set @kq=1
		end
		else set @kq=1
	end
end
GO
/****** Object:  StoredProcedure [dbo].[XoaPhong]    Script Date: 10/16/2015 13:48:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[XoaPhong](@id_phong int,@kq int output)
as
begin
	if(@id_phong=0) set @kq=0
	else 
		if(@id_phong not in (select ID_Phong from Phong))set @kq=1
		else
			if((select HienTrang from Phong where ID_Phong=@id_phong) = N'Đã thuê') set @kq=3
			else
			begin
				delete from Phong
				where ID_Phong=@id_phong
				set @kq=2
			end
end
GO
/****** Object:  StoredProcedure [dbo].[XoaLoaiPhong]    Script Date: 10/16/2015 13:48:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[XoaLoaiPhong](@ma_ploai char(10),@kq int output)
as
begin
	if(@ma_ploai not in (select Ma_Ploai from Loai_Phong)) set @kq=0
	if(@ma_ploai in (select Ma_Ploai from Phong)) set @kq=1
	else 
	begin
		delete from Loai_Phong
		where Ma_Ploai=@ma_ploai
	end
end
GO
/****** Object:  StoredProcedure [dbo].[XoaKH]    Script Date: 10/16/2015 13:48:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[XoaKH](@tenkhach nvarchar(50),@kq int output)
as
begin
declare @test int
	if(@tenkhach not in (select Ten_Khach from KhachHang)) set @kq=0
	else
	begin
		delete from KhachHang
		where Ten_Khach=@tenkhach
		set @kq=1
	end
end
GO
/****** Object:  StoredProcedure [dbo].[XoaDV]    Script Date: 10/16/2015 13:48:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[XoaDV](@id_dv char(10),@kq int output)
as
begin
	if(@id_dv='')set @kq=0
	else
		if(@id_dv not in (select ID_DV from Dichvu_Phong))set @kq=1
		else
			if(@id_dv in (select distinct ID_DV from SuDung_DV)) set @kq=3
			else
			begin
				delete from Dichvu_Phong
				where ID_DV=@id_dv
				set @kq=2
			end
end
GO
/****** Object:  StoredProcedure [dbo].[XoaTBTB]    Script Date: 10/16/2015 13:48:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[XoaTBTB](@idlphong char(10),@idtb char(10),@kq int output)
as
begin
	if(@idlphong='' or @idtb='') set @kq=0
	else
		if(@idlphong not in (select ID_LPhong from Trangbi_TB))set @kq=1
		else 
			if(@idtb not in (select ID_TB from Trangbi_TB where ID_LPhong=@idlphong)) set @kq=3
		else
		begin
			delete from Trangbi_TB where ID_LPhong=@idlphong and ID_TB=@idtb
			set @kq=2
		end
end
GO
/****** Object:  StoredProcedure [dbo].[TKPhong]    Script Date: 10/16/2015 13:48:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TKPhong](@idphong char(10),@idploai char(10),@tinhtrang nvarchar(50),@hientrang nvarchar(50),@chose int)
as
begin
	if(@chose=1)
	begin
		select * from Phong where ID_Phong=@idphong
	end
	else
		if(@chose=2)
		begin
			select * from Phong where Ma_Ploai=@idploai
		end
		else 
			if(@chose=3)
			begin
				select * from Phong where TinhTrang like N'%'+@tinhtrang+N'%'
			end
			else
				if(@chose=4)
				begin
					select * from Phong where HienTrang like N'%' +@hientrang+N'%'
				end
end
GO
/****** Object:  StoredProcedure [dbo].[TKLPhong]    Script Date: 10/16/2015 13:48:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TKLPhong](@tenlphong nvarchar(50),@giatienngay money,@giatiengio money,@chose int)
as
begin
	if(@chose=1)
	begin
		select * from Loai_Phong
		where TenLoai like N'%'+@tenlphong+N'%'
	end
	else
	if(@chose=2)
	begin
		select * from Loai_Phong
		where GiaTien_ngay=@giatienngay
	end
	else
	if(@chose=3)
	begin
		select * from Loai_Phong
		where GiaTien_gio=@giatiengio
	end
end
GO
/****** Object:  UserDefinedFunction [dbo].[tinh_tien_phong]    Script Date: 10/16/2015 13:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[tinh_tien_phong](@ID_Phong int,@tgbd datetime, @tgtptt datetime) 
returns @TBres table
(
	LoaiPhong nvarchar(50),
	GiaTien int,
	tgThue float
)
as
begin
	
	declare @lp char(10)
	select @lp = Phong.Ma_Ploai from Phong where Phong.ID_Phong = @ID_Phong
	declare @tien money 
	 select @tien = GiaTien_ngay from Loai_Phong where Loai_Phong.Ma_Ploai = @lp
	declare @itien int
	set @itien =CONVERT(int,@tien)
	declare @tenloai nvarchar(50)
	select @tenloai = Loai_Phong.TenLoai from Loai_Phong where Loai_Phong.Ma_Ploai = @lp ;
	 
	declare @res float
		
	set	@res = (select DATEDIFF(day,@tgbd,@tgtptt) )
	declare @h int 
	set @h = DATEPART(HH,@tgbd) 
	if (@h >= 12 ) 
	begin
		set @res = @res - 0.5
	end
	set @h = DATEPART(HH,@tgtptt)
	if (@h > 12)
	begin
		set @res = @res + 1
	end
	 else set @res =@res + 0.5
	insert @TBres  values (@tenloai,@itien,@res) 
		 

	return
end
GO
/****** Object:  StoredProcedure [dbo].[TimKiemTBTB]    Script Date: 10/16/2015 13:48:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TimKiemTBTB](@idlphong char(10),@idtb char(10),@chose int)
as
begin
	if(@chose=1)
	begin
		select * from Trangbi_TB where ID_LPhong=@idlphong
	end
	else
	if(@chose=2)
	begin
		select * from Trangbi_TB where ID_TB=@idtb
	end
end
GO
/****** Object:  StoredProcedure [dbo].[TimKiemSDDV]    Script Date: 10/16/2015 13:48:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TimKiemSDDV](@idphong int,@iddv char(10),@ngaysd date, @chose int)
as
begin
	if(@chose=1)
		select * from SuDung_DV where ID_Phong=@idphong
		else
		if(@chose=2)
			select * from SuDung_DV where ID_DV=@iddv
			else
			if(@chose=3)
				select * from SuDung_DV where NgaySD=@ngaysd
end
GO
/****** Object:  StoredProcedure [dbo].[TimKiemDV]    Script Date: 10/16/2015 13:48:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TimKiemDV](@id_dv char(10),@tendv nvarchar(50),@giadv money,@chose int)
as
begin
	if(@chose=1)
	begin
		select * from Dichvu_Phong where ID_DV=@id_dv
	end
	else 
		if(@chose=2)
		begin
			 select * from Dichvu_Phong where Ten_DV like N'%'+@tendv+N'%'
		end
		else 
			if(@chose=3)
			begin
				select * from Dichvu_Phong where (Gia_DV <= @giadv+5000) and (Gia_DV >= @giadv-5000)
			end
end
GO
/****** Object:  StoredProcedure [dbo].[TimKiemDichVu]    Script Date: 10/16/2015 13:48:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TimKiemDichVu] (@iddv char(10),@tendv nvarchar(50),@giadv money,@chose int)
as
begin
	if(@chose=1)
	begin
		select * from Dichvu_Phong where ID_DV=@iddv
	end
	else 
		if(@chose=2)
		begin
			 select * from Dichvu_Phong where Ten_DV like N'%'+@tendv+N'%'
		end
		else 
			if(@chose=3)
			begin
				select * from Dichvu_Phong where (Gia_DV <= @giadv+5000) and (Gia_DV >= @giadv-5000)
			end
end
GO
/****** Object:  StoredProcedure [dbo].[XoaThuePhong]    Script Date: 10/16/2015 13:48:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[XoaThuePhong](@idphong int,@kq int output)
as
begin
	if(@idphong=0) set @kq=0
	else
		if(@idphong not in (select ID_Phong from ThuePhong)) set @kq=1
		else
		begin
			delete from ThuePhong
			where ID_Phong=@idphong
			set @kq=2 
		end
end
GO
/****** Object:  UserDefinedFunction [dbo].[tinh_trang_phong]    Script Date: 10/16/2015 13:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[tinh_trang_phong](@magd char(10), @idp int )
returns @res table
(
	tgbd datetime,
	tgtp datetime,
	tenkh nvarchar(50),
	cmnd varchar(12)
)
as
begin
	insert @res 
	select ThuePhong.TG_BatDau,ThuePhong.TG_TraPhong,KhachHang.Ten_Khach,KhachHang.CMND
	from ThuePhong,KhachHang 
	where 	ThuePhong.MaGiaoDich != @magd and
		    ThuePhong.ID_Phong = @idp 	and 
	 	 	ThuePhong.MaThanhToan = 0	and
	 	 	ThuePhong.ID_Khach = KhachHang.ID_Khach
	return
end
GO
/****** Object:  StoredProcedure [dbo].[TimKiemKH]    Script Date: 10/16/2015 13:48:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TimKiemKH](@idKhach char(10),@cmnd varchar(12),@tenkh nvarchar(20),@chose int output)
as
begin
	if(@chose=1)
		select * from KhachHang where ID_Khach=@idKhach
	else
		if(@chose=2)
			select * from KhachHang where CMND=@cmnd
			else
				if(@chose=3)
					select * from KhachHang where Ten_Khach like N'%'+@tenkh+N'%'
end
update ThuePhong 
set Tien_DatCoc=Tien_DatCoc/1000
GO
/****** Object:  UserDefinedFunction [dbo].[TimGDtheoPhong]    Script Date: 10/16/2015 13:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[TimGDtheoPhong](@ID_phong int) returns table
as
return (
	 select MaGiaoDich, KhachHang.Ten_Khach,ID_Phong,TG_BatDau,TG_TraPhong,TG_TraPhongTT,Tien_DatCoc 
	  from KhachHang,ThuePhong
	  where 
	  (
		ID_Phong = @ID_Phong and KhachHang.ID_Khach = ThuePhong.ID_Khach
		and ThuePhong.MaThanhToan = 0 
		
	  )
	
	)
GO
/****** Object:  UserDefinedFunction [dbo].[TimGDtheoCMND]    Script Date: 10/16/2015 13:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[TimGDtheoCMND](@cmnd varchar(12)) returns table

as 

	return (
	 select MaGiaoDich, KhachHang.Ten_Khach,ID_Phong,TG_BatDau,TG_TraPhong,TG_TraPhongTT,Tien_DatCoc 
	  from KhachHang,ThuePhong
	  where 
	  (
		KhachHang.CMND = @cmnd and KhachHang.ID_Khach = ThuePhong.ID_Khach
		and ThuePhong.MaThanhToan = 0 
		
	  )
	)
GO
/****** Object:  UserDefinedFunction [dbo].[tim_hd_kh]    Script Date: 10/16/2015 13:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[tim_hd_kh](@idkh varchar(12)) returns table
as
	return (
	Select ThuePhong.MaGiaoDich, KhachHang.Ten_Khach,ThuePhong.ID_Phong,
	ThuePhong.TG_BatDau,ThuePhong.TG_TraPhong,ThuePhong.TG_TraPhongTT,ThuePhong.Tien_DatCoc
	from ThuePhong,KhachHang
	where 
	   ThuePhong.ID_Khach = @idkh and 
	   KhachHang.ID_Khach = @idkh and
	    ThuePhong.MaThanhToan=0
	)
GO
/****** Object:  StoredProcedure [dbo].[sua_thue_phong]    Script Date: 10/16/2015 13:48:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sua_thue_phong](@magd char(10),@tgbd datetime , @tgtp datetime,@maP int)
as
begin
	update ThuePhong 
	set TG_BatDau = @tgbd,TG_TraPhongTT = @tgtp,ID_Phong = @maP
	where MaGiaoDich = @magd
	
end
GO
/****** Object:  UserDefinedFunction [dbo].[DanhSachPhongTrong]    Script Date: 10/16/2015 13:48:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[DanhSachPhongTrong] (@tgbd Datetime, @tgkt Datetime) returns table
as
return(Select  ID_Phong ,TenLoai  from Phong ,Loai_Phong
	 where (  ID_Phong not in
	  (select ID_Phong from ThuePhong 
	  where not
	  (TG_TraPhongTT <= @tgbd or TG_BatDau >= @tgkt  )
			       )
			       )
		 and (Loai_Phong.Ma_Ploai = Phong.Ma_Ploai  )
		 and Phong.TinhTrang = N'Tốt'
		 
		 )
GO
/****** Object:  StoredProcedure [dbo].[CapNhat]    Script Date: 10/16/2015 13:48:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  proc [dbo].[CapNhat]( @today datetime)
as
begin
	declare @d1 date
	--set @d1 = (select MAX(TG_TraPhong) from ThuePhong where TG_BatDau<=@today)
	--if (@d1 != null)
	update Phong set HienTrang = N'Đã thuê' where
		(
			
			@today < (select MAX(TG_TraPhong) as d from ThuePhong 
				where TG_BatDau<=@today  and Phong.ID_Phong = ThuePhong.ID_Phong) 
			 
		)
	--update Phong set HienTrang = N'Chưa thuê' where @today >@d1
	update Phong set HienTrang = N'Chưa thuê' where
	(
		(select MAX(TG_TraPhongTT) as d from ThuePhong 
				where TG_BatDau<=@today  and Phong.ID_Phong = ThuePhong.ID_Phong) is null
		or 
			@today >= 
			(select MAX(TG_TraPhongTT) as d from ThuePhong 
				where TG_BatDau<=@today  and Phong.ID_Phong = ThuePhong.ID_Phong) 
	)	
	 						
end
GO
/****** Object:  StoredProcedure [dbo].[XoaTB]    Script Date: 10/16/2015 13:48:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[XoaTB](@id_tb char(10),@kq int output)
as
begin
	if(@id_tb in (select distinct ID_TB from Trangbi_TB))set @kq=0
	else
		if(@id_tb not in (select ID_TB from Thietbi_phong))set @kq=1
		else
		begin
			delete from Thietbi_phong
			where ID_TB=@id_tb
			set @kq=2
		end
end
GO
/****** Object:  StoredProcedure [dbo].[TimKiemTB]    Script Date: 10/16/2015 13:48:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TimKiemTB](@tentb nvarchar(50),@giatb money,@chose int)
as
begin
	if(@chose=1)
	begin
		select * from Thietbi_phong where Ten_TB like N'%'+@tentb+N'%'
	end
	else 
	if(@chose=2)
	begin
		select * from Thietbi_phong where Gia_TB=@giatb
	end
end
GO
/****** Object:  StoredProcedure [dbo].[SuaTBTB]    Script Date: 10/16/2015 13:48:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SuaTBTB](@idlphong char(10),@idtb char(10),@soluong int,@kq int output)
as
begin
	if(@idlphong='' or @idtb='' or @soluong=0) set @kq=0
	else 
	if(@idlphong not in (select ID_LPhong from Trangbi_TB))set @kq=3
		else
				if((@idtb not in(select ID_TB from Thietbi_phong)) or (@idtb not in (select ID_TB from Trangbi_TB where ID_LPhong=@idlphong)))set @kq=1
			else
				begin 
					update Trangbi_TB
					set SOLUONG=@soluong
					where ID_LPhong=@idlphong and ID_TB=@idtb
					set @kq=2
				end
end
GO
/****** Object:  StoredProcedure [dbo].[SuaTB]    Script Date: 10/16/2015 13:48:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaTB](@id_tb char(10),@ten_tb nvarchar(50),@dvtien nchar(10),@gia_tb money,@kq int output)
as
begin 
	if(@id_tb='')set @kq=0
	else
		if(@id_tb not in (select ID_TB from Thietbi_phong)) set @kq=1
		else
		begin
			update Thietbi_phong
			set Ten_TB=@ten_tb,DVtien=@dvtien,Gia_TB=@gia_tb
			where ID_TB=@id_tb
		end
end
GO
/****** Object:  StoredProcedure [dbo].[ThemThuePhong]    Script Date: 10/16/2015 13:48:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ThemThuePhong] (@id_Khach char(10),@Id_Phong int, @tgbd datetime, @tgTP datetime,@toDay datetime , @Tien_Dc money, @kq int output)
as
begin
	set @kq = 0;
	if ( (select TinhTrang from Phong where ID_Phong = @Id_Phong) like N'Không đảm bảo') 	
	begin
		set @kq = 1
		return
	end 	
	--kq=1 trang thai phong khong tot
	declare @cnt int
	set @cnt = (select COUNT(MaGiaoDich) from ThuePhong)
	declare @magd char(10)
	set @magd = 'GD' + convert(char(8),@cnt + 1)
	insert into ThuePhong values(@id_Khach,@Id_Phong,@tgbd,@tgTP,@Tien_Dc,@tgTP,0,@magd)		
	--kq = 0 thuc hien thanh cong
	
end
GO
/****** Object:  StoredProcedure [dbo].[ThemTBTB]    Script Date: 10/16/2015 13:48:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ThemTBTB](@id_lphong char(10),@id_tb char(10),@soluong int ,@kq int output)
as
begin
declare @test int
set @test=0
	if(@id_lphong='' or @id_tb='' or @soluong=0) set @kq=0
	if(@id_lphong not in (select Ma_Ploai from Loai_Phong))set @kq=3
	else 
	begin
			if(@id_tb not in(select ID_TB from Thietbi_phong))set @kq=1
		else
		begin
			if((@id_lphong in(select ID_LPhong from Trangbi_TB)) and (@id_tb in(select ID_TB from Trangbi_TB where ID_LPhong=@id_lphong)))set @kq=4
			else
			begin 
				insert into Trangbi_TB
				values (@id_lphong,@id_tb,@soluong)
				set @kq=2
			end
		end
	end
	
end
GO
/****** Object:  StoredProcedure [dbo].[ThemTB]    Script Date: 10/16/2015 13:48:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ThemTB](@ten_tb nvarchar(50),@dvtien nchar(10),@gia_tb money,@kq int output)
as
begin
	declare @sl int
	declare @id_tb char(10)
	if(@ten_tb='') set @kq=0
	else
		if(@ten_tb in (select Ten_TB from Thietbi_phong)) set @kq=1
		else
		begin
			set @sl=(select COUNT(ID_TB)from Thietbi_phong)+1
			set @id_tb='TB'+CONVERT(varchar(3),@sl)
			while(@id_tb in (select ID_TB from Thietbi_phong))
			begin
				set @sl=@sl-1
				set @id_tb='TB'+CONVERT(varchar(5),@sl)
			end
			insert into Thietbi_phong(ID_TB,Ten_TB,DVtien,Gia_TB)
			values(@id_tb,@ten_tb,@dvtien,@gia_tb)
			set @kq=2
		end
end
GO
/****** Object:  StoredProcedure [dbo].[ThemSDDV]    Script Date: 10/16/2015 13:48:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ThemSDDV](@id_phong int,@id_dv char(10),@soluong int,@ngaysd date,@kq int output)
as
begin
if (@id_phong=0 or @id_dv='' or @soluong=0 or @ngaysd='') set @kq=0
else
if((@id_phong not in (select ID_Phong from ThuePhong)) or (@id_dv not in (select ID_DV from Dichvu_Phong)))
	set @kq=3
	else
		if((@ngaysd < (select TG_BatDau from ThuePhong where ID_Phong=@id_phong)) or (@ngaysd > (select TG_TraPhong from ThuePhong where ID_Phong=@id_phong)))
			set @kq=4
		else
			if(@id_dv in (select ID_DV from SuDung_DV where ID_Phong=@id_phong))
			begin
				if(@ngaysd in (select NgaySD from SuDung_DV where ID_Phong=@id_phong and ID_DV=@id_dv))
					set @kq=1
				else set @kq=2
			end
	
	if(@kq=2)
	begin
		insert into SuDung_DV(id_phong,id_dv,soluong,ngaysd)
		values(@id_phong,@id_dv,@soluong,@ngaysd)
	end
	else
		if(@kq=1)
		begin
			update SuDung_DV
			set SoLuong=SoLuong+@soluong
			where ID_DV=@id_dv and ID_Phong=@id_phong and NgaySD=@ngaysd
		end
end
--declare @kq int
--exec ThemSDDV 102,'dvu1',3,'2015/2/5',@kq out
--print @kq
GO
/****** Object:  StoredProcedure [dbo].[ThemPhong]    Script Date: 10/16/2015 13:48:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ThemPhong](@ma_ploai char(10),@tinhtrang nvarchar(20),
@hientrang nvarchar(20),@so_dt int,@kq int output)
as
begin
declare @test int

set @test=0
	if(@ma_ploai='' ) set @kq=0
	else
	begin
		if(@ma_ploai not in (select Ma_Ploai from Loai_Phong))set @test=1
		else
		begin 
			if(@so_dt in (select So_DT from Phong)) set @test=3
		end
	end
	if(@test=1)set @kq=1
	else if(@test=3) set @kq=3
	else
	begin
		declare @ma varchar(3)
		set @ma=(select LEFT(@ma_ploai,3))
		declare @vt nvarchar(50)
		declare @tang char(10)
		set @vt=(select ViTri from Loai_Phong where Ma_Ploai =@ma_ploai)
		set @tang=(select RIGHT(@vt,1))
		declare @sl1 int
		declare @idphong int
		set @sl1 = (select COUNT(ID_Phong) from Phong where Ma_Ploai like '%'+@ma+'%')
		set @idphong=CONVERT(int,@tang)*100+@sl1+1
		while(@idphong in (select ID_Phong from Phong where Ma_Ploai like '%'+@ma+'%'))
		begin
			set @idphong = @idphong -1
		end
		insert into Phong(ID_Phong,Ma_Ploai,TinhTrang,HienTrang,So_DT)
		values(@idphong,@ma_ploai,@tinhtrang,@hientrang,@so_dt)
		set @kq=2
	end		
end
GO
/****** Object:  StoredProcedure [dbo].[ThemLPhong]    Script Date: 10/16/2015 13:48:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThemLPhong] (@malphong char(10),@tenlphong nvarchar(50),@giatienngay money, @giatiengio money, @vitri nvarchar(50),@kq int out)
as
begin
	if(@malphong='') set @kq=0
	else
		if(@malphong in (select Ma_Ploai from Loai_Phong)) set @kq=1
		else
		begin
			insert into Loai_Phong
			values(@malphong,@tenlphong,@giatienngay,@giatiengio,@vitri)
			set @kq=2
		end
end
GO
/****** Object:  StoredProcedure [dbo].[ThemKH]    Script Date: 10/16/2015 13:48:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ThemKH](@tenkhach nvarchar(50),@quequan nvarchar(50),@gioitinh nchar(10),@cmnd varchar(12),@quoctich nvarchar(50),@sdt varchar(12) , @kq int output)
as
begin
if(@tenkhach='') set @kq=0
	else
	begin
		if(@cmnd in (select CMND from KhachHang))
		begin
			set @kq = 1
		end
		 else 
		 begin
			set @kq = 2
			declare @cnt int
			set @cnt = (select COUNT(ID_KHACH) from KhachHang);
			insert into KhachHang values ('KH'+CONVERT(char(10),@cnt + 1),@tenkhach,@quequan,@gioitinh,@cmnd,@sdt,@quoctich)
		 end
	end
	
	-- kq = 0 ko thuc hien duoc
	-- kq = 2 kh moi
	-- kq =1 kh nay da co trong he thong
end
GO
/****** Object:  StoredProcedure [dbo].[ThemDV]    Script Date: 10/16/2015 13:48:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ThemDV](@ten_dv nvarchar(50),@dvtien nchar(10),@gia_dv money,@kq int output)
as
begin
	declare @id char(10)
	declare @sl int
	if(@ten_dv='') set @kq=0
	else
		if(@ten_dv in (select Ten_DV from Dichvu_Phong)) set @kq=1
		else
		begin
			set @sl= (select COUNT(ID_DV)from Dichvu_Phong) +1
			set @id='DVU'+CONVERT(varchar(3),@sl)
			while(@id in (select ID_DV from Dichvu_Phong))
			begin
				set @sl=@sl-1
				set @id='DVU'+CONVERT(nchar(10),@sl)
			end
			insert into Dichvu_Phong(ID_DV,Ten_DV,Dvtien,Gia_DV)
			values(@id,@ten_dv,@dvtien,@gia_dv)
			set @kq=2
		end
end
GO
/****** Object:  Table [dbo].[tblTrangbi_TB]    Script Date: 10/16/2015 13:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTrangbi_TB](
	[ID_LPhong] [char](10) NOT NULL,
	[ID_TB] [char](10) NOT NULL,
	[SOLUONG] [int] NULL,
 CONSTRAINT [PK_Trangbi_TB] PRIMARY KEY CLUSTERED 
(
	[ID_LPhong] ASC,
	[ID_TB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB01      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB02      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB03      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB04      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB05      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB06      ', 5)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB07      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB08      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB09      ', 6)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB10      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB11      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB13      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB14      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB17      ', 8)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'CNR       ', N'TB19      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX1      ', N'TB01      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX1      ', N'TB02      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX1      ', N'TB03      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX1      ', N'TB04      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX1      ', N'TB05      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX1      ', N'TB06      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX1      ', N'TB08      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX1      ', N'TB09      ', 3)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX1      ', N'TB10      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX1      ', N'TB13      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX1      ', N'TB17      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX2      ', N'TB01      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX2      ', N'TB02      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX2      ', N'TB03      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX2      ', N'TB04      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX2      ', N'TB05      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX2      ', N'TB06      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX2      ', N'TB08      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX2      ', N'TB09      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX2      ', N'TB10      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX2      ', N'TB13      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'DLX2      ', N'TB17      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD1      ', N'TB01      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD1      ', N'TB03      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD1      ', N'TB06      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD1      ', N'TB07      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD1      ', N'TB10      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD1      ', N'TB11      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD1      ', N'TB16      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD1      ', N'TB18      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD1      ', N'TB19      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD2      ', N'TB01      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD2      ', N'TB03      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD2      ', N'TB04      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD2      ', N'TB06      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD2      ', N'TB07      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD2      ', N'TB10      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD2      ', N'TB11      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD2      ', N'TB16      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'STD2      ', N'TB18      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB01      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB02      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB03      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB04      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB05      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB06      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB09      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB10      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB11      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB12      ', 3)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB13      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB14      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP1      ', N'TB17      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB01      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB02      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB03      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB04      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB05      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB06      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB09      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB10      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB11      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB12      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB13      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB14      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'SUP2      ', N'TB17      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB01      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB02      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB03      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB04      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB05      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB06      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB07      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB08      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB09      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB10      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB11      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB12      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB13      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB14      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB15      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB17      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP1      ', N'TB19      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP2      ', N'TB01      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP2      ', N'TB02      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP2      ', N'TB03      ', 2)
GO
print 'Processed 100 total records'
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP2      ', N'TB04      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP2      ', N'TB05      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP2      ', N'TB06      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP2      ', N'TB07      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP2      ', N'TB08      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP2      ', N'TB09      ', 5)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP2      ', N'TB10      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP2      ', N'TB11      ', 2)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP2      ', N'TB12      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP2      ', N'TB13      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP2      ', N'TB14      ', 1)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP2      ', N'TB15      ', 4)
INSERT [dbo].[tblTrangbi_TB] ([ID_LPhong], [ID_TB], [SOLUONG]) VALUES (N'VIP2      ', N'TB17      ', 4)
/****** Object:  Table [dbo].[tblPhong]    Script Date: 10/16/2015 13:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPhong](
	[ID_Phong] [int] NOT NULL,
	[Ma_Ploai] [char](10) NULL,
	[TinhTrang] [nvarchar](20) NULL,
	[HienTrang] [nvarchar](20) NULL,
	[So_DT] [int] NULL,
 CONSTRAINT [PK_Phong] PRIMARY KEY CLUSTERED 
(
	[ID_Phong] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (101, N'cnr       ', N'Tốt', N'Đã thuê', 444411)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (102, N'STD1      ', N'Tốt', N'Đã thuê', 444412)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (103, N'STD2      ', N'Tốt', N'Đã thuê', 444413)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (104, N'STD2      ', N'Tốt', N'Chưa thuê', 444414)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (105, N'STD1      ', N'Tốt', N'Đã thuê', 444415)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (106, N'STD2      ', N'Tốt', N'Chưa thuê', 444416)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (107, N'STD2      ', N'Tốt', N'Đã thuê', 444417)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (201, N'SUP1      ', N'Tốt', N'Đã thuê', 444421)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (202, N'SUP1      ', N'Không đảm bảo', N'Chưa thuê', 444422)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (203, N'SUP1      ', N'Không đảm bảo', N'Chưa thuê', 444423)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (204, N'SUP1      ', N'Tốt', N'Chưa thuê', 444424)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (205, N'SUP2      ', N'Tốt', N'Đã thuê', 444425)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (206, N'SUP2      ', N'Tốt', N'Đã thuê', 444426)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (207, N'SUP2      ', N'Không đảm bảo', N'Chưa thuê', 444427)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (208, N'SUP2      ', N'Không đảm bảo', N'Chưa thuê', 444428)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (209, N'SUP2      ', N'Không đảm bảo', N'Chưa thuê', 444429)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (401, N'DLX1      ', N'Tốt', N'Chưa thuê', 444431)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (402, N'DLX1      ', N'Tốt', N'Chưa thuê', 122122)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (403, N'DLX1      ', N'Tốt', N'Chưa thuê', 444431)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (404, N'DLX2      ', N'Tốt', N'Chưa thuê', 444431)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (405, N'DLX2      ', N'Không đảm bảo', N'Chưa thuê', 444432)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (406, N'DLX1      ', N'Tốt', N'Chưa thuê', 122121)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (407, N'DLX1      ', N'Tốt', N'Chưa thuê', 323333)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (501, N'CNR       ', N'Tốt', N'Chưa thuê', 444501)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (502, N'CNR       ', N'Tốt', N'Chưa thuê', 0)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (503, N'CNR       ', N'Tốt', N'Chưa thuê', 444503)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (504, N'CNR       ', N'Tốt', N'Đã thuê', 444504)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (505, N'CNR       ', N'Tốt', N'Chưa thuê', 323283)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (506, N'CNR       ', N'Tốt', N'Chưa thuê', 329839)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (601, N'VIP1      ', N'Tốt', N'Chưa thuê', 444601)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (602, N'VIP1      ', N'Tốt', N'Chưa thuê', 444602)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (603, N'VIP1      ', N'Không đảm bảo', N'Chưa thuê', 444603)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (604, N'VIP2      ', N'Tốt', N'Chưa thuê', 444604)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (605, N'VIP2      ', N'Tốt', N'Chưa thuê', 444605)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (901, N'ABC       ', N'Tốt', N'Chưa thuê', 838383)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (902, N'ABC       ', N'Tốt', N'Chưa thuê', 838383)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (903, N'ABC       ', N'Tốt', N'Chưa thuê', 838383)
INSERT [dbo].[tblPhong] ([ID_Phong], [Ma_Ploai], [TinhTrang], [HienTrang], [So_DT]) VALUES (904, N'ABC       ', N'Tốt', N'Chưa thuê', 838383)
/****** Object:  Table [dbo].[tblSuDung_DV]    Script Date: 10/16/2015 13:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblSuDung_DV](
	[ID_Phong] [int] NOT NULL,
	[ID_DV] [char](10) NOT NULL,
	[SoLuong] [int] NULL,
	[NgaySD] [datetime] NOT NULL,
 CONSTRAINT [MP_MDV_PK] PRIMARY KEY CLUSTERED 
(
	[ID_Phong] ASC,
	[ID_DV] ASC,
	[NgaySD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblSuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (106, N'DVU10     ', 3, CAST(0x0000A43500000000 AS DateTime))
INSERT [dbo].[tblSuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (107, N'DVU4      ', 3, CAST(0x0000A43500000000 AS DateTime))
INSERT [dbo].[tblSuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (201, N'DVU6      ', 2, CAST(0x0000A43100000000 AS DateTime))
INSERT [dbo].[tblSuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (201, N'DVU7      ', 3, CAST(0x0000A43300000000 AS DateTime))
INSERT [dbo].[tblSuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (206, N'DVU11     ', 20, CAST(0x0000A43600000000 AS DateTime))
INSERT [dbo].[tblSuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (206, N'DVU12     ', 5, CAST(0x0000A43700000000 AS DateTime))
INSERT [dbo].[tblSuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (206, N'DVU6      ', 4, CAST(0x0000A43700000000 AS DateTime))
INSERT [dbo].[tblSuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (401, N'DVU2      ', 3, CAST(0x0000A43600000000 AS DateTime))
INSERT [dbo].[tblSuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (401, N'DVU4      ', 10, CAST(0x0000A43600000000 AS DateTime))
INSERT [dbo].[tblSuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (401, N'DVU7      ', 2, CAST(0x0000A43700000000 AS DateTime))
INSERT [dbo].[tblSuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (401, N'DVU9      ', 10, CAST(0x0000A43900000000 AS DateTime))
INSERT [dbo].[tblSuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (403, N'DVU2      ', 2, CAST(0x0000A43800000000 AS DateTime))
INSERT [dbo].[tblSuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (501, N'DVU13     ', 20, CAST(0x0000A43800000000 AS DateTime))
INSERT [dbo].[tblSuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (501, N'DVU2      ', 2, CAST(0x0000A43800000000 AS DateTime))
INSERT [dbo].[tblSuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (501, N'DVU4      ', 3, CAST(0x0000A43B00000000 AS DateTime))
INSERT [dbo].[tblSuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (501, N'DVU8      ', 3, CAST(0x0000A43F00000000 AS DateTime))
INSERT [dbo].[tblSuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (601, N'DVU2      ', 3, CAST(0x0000A43F00000000 AS DateTime))
INSERT [dbo].[tblSuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (601, N'DVU5      ', 2, CAST(0x0000A44000000000 AS DateTime))
INSERT [dbo].[tblSuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (604, N'DVU1      ', 3, CAST(0x0000A44000000000 AS DateTime))
INSERT [dbo].[tblSuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (604, N'DVU8      ', 3, CAST(0x0000A44000000000 AS DateTime))
INSERT [dbo].[tblSuDung_DV] ([ID_Phong], [ID_DV], [SoLuong], [NgaySD]) VALUES (604, N'DVU9      ', 10, CAST(0x0000A44300000000 AS DateTime))
/****** Object:  Table [dbo].[tblThuePhong]    Script Date: 10/16/2015 13:48:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblThuePhong](
	[ID_Khach] [char](10) NOT NULL,
	[ID_Phong] [int] NOT NULL,
	[TG_BatDau] [datetime] NULL,
	[TG_TraPhong] [datetime] NULL,
	[Tien_DatCoc] [money] NULL,
	[TG_TraPhongTT] [datetime] NULL,
	[MaThanhToan] [int] NULL,
	[MaGiaoDich] [char](10) NOT NULL,
 CONSTRAINT [PK_ThuePhong] PRIMARY KEY CLUSTERED 
(
	[ID_Khach] ASC,
	[ID_Phong] ASC,
	[MaGiaoDich] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblThuePhong] ([ID_Khach], [ID_Phong], [TG_BatDau], [TG_TraPhong], [Tien_DatCoc], [TG_TraPhongTT], [MaThanhToan], [MaGiaoDich]) VALUES (N'KH1       ', 101, CAST(0x0000A4AD00000000 AS DateTime), CAST(0x0000A4AF00000000 AS DateTime), 2000.0000, CAST(0x0000A4AF00000000 AS DateTime), 0, N'GD1       ')
INSERT [dbo].[tblThuePhong] ([ID_Khach], [ID_Phong], [TG_BatDau], [TG_TraPhong], [Tien_DatCoc], [TG_TraPhongTT], [MaThanhToan], [MaGiaoDich]) VALUES (N'KH1       ', 106, CAST(0x0000A48F00000000 AS DateTime), CAST(0x0000A49400000000 AS DateTime), 1000.0000, CAST(0x0000A49400000000 AS DateTime), 1, N'GD13      ')
INSERT [dbo].[tblThuePhong] ([ID_Khach], [ID_Phong], [TG_BatDau], [TG_TraPhong], [Tien_DatCoc], [TG_TraPhongTT], [MaThanhToan], [MaGiaoDich]) VALUES (N'KH10      ', 101, CAST(0x0000A49800000000 AS DateTime), CAST(0x0000A4A200000000 AS DateTime), 2000.0000, CAST(0x0000A4A200000000 AS DateTime), 1, N'GD14      ')
INSERT [dbo].[tblThuePhong] ([ID_Khach], [ID_Phong], [TG_BatDau], [TG_TraPhong], [Tien_DatCoc], [TG_TraPhongTT], [MaThanhToan], [MaGiaoDich]) VALUES (N'KH11      ', 504, CAST(0x0000A49800000000 AS DateTime), CAST(0x0000A4A300000000 AS DateTime), 3000.0000, CAST(0x0000A4A300000000 AS DateTime), 1, N'GD15      ')
INSERT [dbo].[tblThuePhong] ([ID_Khach], [ID_Phong], [TG_BatDau], [TG_TraPhong], [Tien_DatCoc], [TG_TraPhongTT], [MaThanhToan], [MaGiaoDich]) VALUES (N'KH13      ', 103, CAST(0x0000A49F015A11C0 AS DateTime), CAST(0x0000A4A100C5C100 AS DateTime), 0.5000, CAST(0x0000A4A300C5C100 AS DateTime), 0, N'GD16      ')
INSERT [dbo].[tblThuePhong] ([ID_Khach], [ID_Phong], [TG_BatDau], [TG_TraPhong], [Tien_DatCoc], [TG_TraPhongTT], [MaThanhToan], [MaGiaoDich]) VALUES (N'KH14      ', 102, CAST(0x0000A49F0083D600 AS DateTime), CAST(0x0000A4A3016A8C80 AS DateTime), 1000.0000, CAST(0x0000A4A3016A8C80 AS DateTime), 1, N'GD20      ')
INSERT [dbo].[tblThuePhong] ([ID_Khach], [ID_Phong], [TG_BatDau], [TG_TraPhong], [Tien_DatCoc], [TG_TraPhongTT], [MaThanhToan], [MaGiaoDich]) VALUES (N'KH14      ', 105, CAST(0x0000A49F0083D600 AS DateTime), CAST(0x0000A4A3016A8C80 AS DateTime), 1000.0000, CAST(0x0000A4A3016A8C80 AS DateTime), 0, N'GD17      ')
INSERT [dbo].[tblThuePhong] ([ID_Khach], [ID_Phong], [TG_BatDau], [TG_TraPhong], [Tien_DatCoc], [TG_TraPhongTT], [MaThanhToan], [MaGiaoDich]) VALUES (N'KH14      ', 205, CAST(0x0000A49F0083D600 AS DateTime), CAST(0x0000A4A3016A8C80 AS DateTime), 1000.0000, CAST(0x0000A4A3016A8C80 AS DateTime), 0, N'GD18      ')
INSERT [dbo].[tblThuePhong] ([ID_Khach], [ID_Phong], [TG_BatDau], [TG_TraPhong], [Tien_DatCoc], [TG_TraPhongTT], [MaThanhToan], [MaGiaoDich]) VALUES (N'KH14      ', 206, CAST(0x0000A49F0083D600 AS DateTime), CAST(0x0000A4A3016A8C80 AS DateTime), 1000.0000, CAST(0x0000A4A3016A8C80 AS DateTime), 0, N'GD19      ')
INSERT [dbo].[tblThuePhong] ([ID_Khach], [ID_Phong], [TG_BatDau], [TG_TraPhong], [Tien_DatCoc], [TG_TraPhongTT], [MaThanhToan], [MaGiaoDich]) VALUES (N'KH2       ', 103, CAST(0x0000A49700000000 AS DateTime), CAST(0x0000A49C00000000 AS DateTime), 1000.0000, CAST(0x0000A49C00000000 AS DateTime), 1, N'GD10      ')
INSERT [dbo].[tblThuePhong] ([ID_Khach], [ID_Phong], [TG_BatDau], [TG_TraPhong], [Tien_DatCoc], [TG_TraPhongTT], [MaThanhToan], [MaGiaoDich]) VALUES (N'KH2       ', 107, CAST(0x0000A49600000000 AS DateTime), CAST(0x0000A4A000000000 AS DateTime), 3000.0000, CAST(0x0000A4A000000000 AS DateTime), 0, N'GD2       ')
INSERT [dbo].[tblThuePhong] ([ID_Khach], [ID_Phong], [TG_BatDau], [TG_TraPhong], [Tien_DatCoc], [TG_TraPhongTT], [MaThanhToan], [MaGiaoDich]) VALUES (N'KH3       ', 104, CAST(0x0000A49300000000 AS DateTime), CAST(0x0000A49F00000000 AS DateTime), 1000.0000, CAST(0x0000A49F00000000 AS DateTime), 1, N'GD11      ')
INSERT [dbo].[tblThuePhong] ([ID_Khach], [ID_Phong], [TG_BatDau], [TG_TraPhong], [Tien_DatCoc], [TG_TraPhongTT], [MaThanhToan], [MaGiaoDich]) VALUES (N'KH3       ', 201, CAST(0x0000A49400000000 AS DateTime), CAST(0x0000A4A200000000 AS DateTime), 2500.0000, CAST(0x0000A4A200000000 AS DateTime), 0, N'GD3       ')
INSERT [dbo].[tblThuePhong] ([ID_Khach], [ID_Phong], [TG_BatDau], [TG_TraPhong], [Tien_DatCoc], [TG_TraPhongTT], [MaThanhToan], [MaGiaoDich]) VALUES (N'KH4       ', 106, CAST(0x0000A49300000000 AS DateTime), CAST(0x0000A49E00000000 AS DateTime), 2000.0000, CAST(0x0000A49E00000000 AS DateTime), 1, N'GD12      ')
INSERT [dbo].[tblThuePhong] ([ID_Khach], [ID_Phong], [TG_BatDau], [TG_TraPhong], [Tien_DatCoc], [TG_TraPhongTT], [MaThanhToan], [MaGiaoDich]) VALUES (N'KH4       ', 206, CAST(0x0000A43600000000 AS DateTime), CAST(0x0000A43900000000 AS DateTime), 1500.0000, CAST(0x0000A43900000000 AS DateTime), 1, N'GD4       ')
INSERT [dbo].[tblThuePhong] ([ID_Khach], [ID_Phong], [TG_BatDau], [TG_TraPhong], [Tien_DatCoc], [TG_TraPhongTT], [MaThanhToan], [MaGiaoDich]) VALUES (N'KH5       ', 401, CAST(0x0000A43600000000 AS DateTime), CAST(0x0000A43A00000000 AS DateTime), 2000.0000, CAST(0x0000A43A00000000 AS DateTime), 1, N'GD5       ')
INSERT [dbo].[tblThuePhong] ([ID_Khach], [ID_Phong], [TG_BatDau], [TG_TraPhong], [Tien_DatCoc], [TG_TraPhongTT], [MaThanhToan], [MaGiaoDich]) VALUES (N'KH6       ', 403, CAST(0x0000A43800000000 AS DateTime), CAST(0x0000A43B00000000 AS DateTime), 2500.0000, CAST(0x0000A43B00000000 AS DateTime), 1, N'GD6       ')
INSERT [dbo].[tblThuePhong] ([ID_Khach], [ID_Phong], [TG_BatDau], [TG_TraPhong], [Tien_DatCoc], [TG_TraPhongTT], [MaThanhToan], [MaGiaoDich]) VALUES (N'KH7       ', 501, CAST(0x0000A43800000000 AS DateTime), CAST(0x0000A43F00000000 AS DateTime), 5000.0000, CAST(0x0000A43F00000000 AS DateTime), 1, N'GD7       ')
INSERT [dbo].[tblThuePhong] ([ID_Khach], [ID_Phong], [TG_BatDau], [TG_TraPhong], [Tien_DatCoc], [TG_TraPhongTT], [MaThanhToan], [MaGiaoDich]) VALUES (N'KH8       ', 601, CAST(0x0000A43F00000000 AS DateTime), CAST(0x0000A44200000000 AS DateTime), 4000.0000, CAST(0x0000A44200000000 AS DateTime), 1, N'GD8       ')
INSERT [dbo].[tblThuePhong] ([ID_Khach], [ID_Phong], [TG_BatDau], [TG_TraPhong], [Tien_DatCoc], [TG_TraPhongTT], [MaThanhToan], [MaGiaoDich]) VALUES (N'KH9       ', 604, CAST(0x0000A44000000000 AS DateTime), CAST(0x0000A44400000000 AS DateTime), 4500.0000, CAST(0x0000A44400000000 AS DateTime), 1, N'GD9       ')
/****** Object:  ForeignKey [FK_Phong_Loai_Phong]    Script Date: 10/16/2015 13:48:16 ******/
ALTER TABLE [dbo].[tblPhong]  WITH NOCHECK ADD  CONSTRAINT [FK_Phong_Loai_Phong] FOREIGN KEY([Ma_Ploai])
REFERENCES [dbo].[tblLoai_Phong] ([Ma_Ploai])
GO
ALTER TABLE [dbo].[tblPhong] CHECK CONSTRAINT [FK_Phong_Loai_Phong]
GO
/****** Object:  ForeignKey [FK_SuDung_DV_Dichvu_Phong]    Script Date: 10/16/2015 13:48:16 ******/
ALTER TABLE [dbo].[tblSuDung_DV]  WITH CHECK ADD  CONSTRAINT [FK_SuDung_DV_Dichvu_Phong] FOREIGN KEY([ID_DV])
REFERENCES [dbo].[tblDichvu_Phong] ([ID_DV])
GO
ALTER TABLE [dbo].[tblSuDung_DV] CHECK CONSTRAINT [FK_SuDung_DV_Dichvu_Phong]
GO
/****** Object:  ForeignKey [FK_SuDung_DV_Phong]    Script Date: 10/16/2015 13:48:16 ******/
ALTER TABLE [dbo].[tblSuDung_DV]  WITH CHECK ADD  CONSTRAINT [FK_SuDung_DV_Phong] FOREIGN KEY([ID_Phong])
REFERENCES [dbo].[tblPhong] ([ID_Phong])
GO
ALTER TABLE [dbo].[tblSuDung_DV] CHECK CONSTRAINT [FK_SuDung_DV_Phong]
GO
/****** Object:  ForeignKey [FK_ThuePhong_KhachHang]    Script Date: 10/16/2015 13:48:16 ******/
ALTER TABLE [dbo].[tblThuePhong]  WITH CHECK ADD  CONSTRAINT [FK_ThuePhong_KhachHang] FOREIGN KEY([ID_Khach])
REFERENCES [dbo].[tblKhachHang] ([ID_Khach])
GO
ALTER TABLE [dbo].[tblThuePhong] CHECK CONSTRAINT [FK_ThuePhong_KhachHang]
GO
/****** Object:  ForeignKey [FK_ThuePhong_Phong1]    Script Date: 10/16/2015 13:48:16 ******/
ALTER TABLE [dbo].[tblThuePhong]  WITH CHECK ADD  CONSTRAINT [FK_ThuePhong_Phong1] FOREIGN KEY([ID_Phong])
REFERENCES [dbo].[tblPhong] ([ID_Phong])
GO
ALTER TABLE [dbo].[tblThuePhong] CHECK CONSTRAINT [FK_ThuePhong_Phong1]
GO
/****** Object:  ForeignKey [FK_Trangbi_TB_Loai_Phong]    Script Date: 10/16/2015 13:48:16 ******/
ALTER TABLE [dbo].[tblTrangbi_TB]  WITH CHECK ADD  CONSTRAINT [FK_Trangbi_TB_Loai_Phong] FOREIGN KEY([ID_LPhong])
REFERENCES [dbo].[tblLoai_Phong] ([Ma_Ploai])
GO
ALTER TABLE [dbo].[tblTrangbi_TB] CHECK CONSTRAINT [FK_Trangbi_TB_Loai_Phong]
GO
/****** Object:  ForeignKey [FK_Trangbi_TB_Thietbi_phong]    Script Date: 10/16/2015 13:48:16 ******/
ALTER TABLE [dbo].[tblTrangbi_TB]  WITH CHECK ADD  CONSTRAINT [FK_Trangbi_TB_Thietbi_phong] FOREIGN KEY([ID_TB])
REFERENCES [dbo].[tblThietbi_phong] ([ID_TB])
GO
ALTER TABLE [dbo].[tblTrangbi_TB] CHECK CONSTRAINT [FK_Trangbi_TB_Thietbi_phong]
GO
