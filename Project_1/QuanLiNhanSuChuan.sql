USE [QuanLiNhanSu]
GO
/****** Object:  Table [dbo].[tblDangNhap]    Script Date: 12/04/2015 08:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblDangNhap](
	[TaiKhoan] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblDangNhap] ([TaiKhoan], [MatKhau]) VALUES (N'luan', N'luanjr')
/****** Object:  Table [dbo].[tblChucVu]    Script Date: 12/04/2015 08:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblChucVu](
	[MaCV] [varchar](10) NOT NULL,
	[TenCV] [nvarchar](50) NULL,
 CONSTRAINT [PK__tblChucV__27258E767F60ED59] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblChucVu] ([MaCV], [TenCV]) VALUES (N'CV1', N'Thư kí')
INSERT [dbo].[tblChucVu] ([MaCV], [TenCV]) VALUES (N'CV2', N'Kĩ sư')
INSERT [dbo].[tblChucVu] ([MaCV], [TenCV]) VALUES (N'CV3', N'Tổ trưởng')
INSERT [dbo].[tblChucVu] ([MaCV], [TenCV]) VALUES (N'CV4', N'Phòng trưởng')
INSERT [dbo].[tblChucVu] ([MaCV], [TenCV]) VALUES (N'CV5', N'Nhà thiết kế')
INSERT [dbo].[tblChucVu] ([MaCV], [TenCV]) VALUES (N'CV6', N'Nhân viên')
/****** Object:  Table [dbo].[tblPhongBan]    Script Date: 12/04/2015 08:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPhongBan](
	[MaPB] [varchar](10) NOT NULL,
	[TenPB] [nvarchar](50) NULL,
	[DiaDiem] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblPhongBan] ([MaPB], [TenPB], [DiaDiem]) VALUES (N'PB1', N'Phòng Marketing', N'Phòng 501')
INSERT [dbo].[tblPhongBan] ([MaPB], [TenPB], [DiaDiem]) VALUES (N'PB2', N'Phòng Hành Chính', N'Phòng 502')
INSERT [dbo].[tblPhongBan] ([MaPB], [TenPB], [DiaDiem]) VALUES (N'PB3', N'Phòng Thiết Kế', N'Phòng 503')
INSERT [dbo].[tblPhongBan] ([MaPB], [TenPB], [DiaDiem]) VALUES (N'PB4', N'Phòng Kĩ Thuật', N'Phòng 504')
/****** Object:  StoredProcedure [dbo].[QuanLiDangNhap]    Script Date: 12/04/2015 08:47:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[QuanLiDangNhap](@tk varchar(50),@mk varchar(50),@kq int output)
as
begin
	if(@tk not in (select TaiKhoan from tblDangNhap))set @kq=0
	else
		if(@mk not in (select MatKhau from tblDangNhap where TaiKhoan=@tk)) set @kq=1
		else set @kq=2
end
GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 12/04/2015 08:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[MaNV] [varchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[QueQuan] [nvarchar](100) NULL,
	[Luong] [int] NULL,
	[MaCV] [varchar](10) NULL,
	[MaPB] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [QueQuan], [Luong], [MaCV], [MaPB]) VALUES (N'NV1', N'Lê Công Tuấn Quang1', CAST(0x77140B00 AS Date), N'50000', N'Vĩnh phúc', 5000000, N'CV5', N'PB3')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [QueQuan], [Luong], [MaCV], [MaPB]) VALUES (N'NV10', N'Lê Văn Sơn', CAST(0xD50A0B00 AS Date), N'Nam', N'Vĩnh phúc', 6000000, N'CV2', N'PB3')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [QueQuan], [Luong], [MaCV], [MaPB]) VALUES (N'NV11', N'Lê Công Tuấn', CAST(0x77140B00 AS Date), N'Nam', N'Vĩnh phúc', 5000000, N'CV5', N'PB3')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [QueQuan], [Luong], [MaCV], [MaPB]) VALUES (N'NV12', N'Nguyễn Đức Cảnh', CAST(0x3A0F0B00 AS Date), N'Nam', N'Hà Nội', 5500000, N'CV5', N'PB3')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [QueQuan], [Luong], [MaCV], [MaPB]) VALUES (N'NV13', N'Nguyễn Chí Công', CAST(0xDD0F0B00 AS Date), N'Nam', N'Hà Nam', 6000000, N'CV3', N'PB4')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [QueQuan], [Luong], [MaCV], [MaPB]) VALUES (N'NV14', N'Nguyễn Thị Hương', CAST(0x8A180B00 AS Date), N'Nữ', N'Hòa Bình', 5000000, N'CV1', N'PB4')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [QueQuan], [Luong], [MaCV], [MaPB]) VALUES (N'NV15', N'Nguyễn Ngọc Anh', CAST(0xED0C0B00 AS Date), N'Nam', N'Vĩnh phúc', 6000000, N'CV4', N'PB4')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [QueQuan], [Luong], [MaCV], [MaPB]) VALUES (N'NV16', N'Phí Xuân Đạo', CAST(0x68110B00 AS Date), N'Nam', N'Vĩnh phúc', 7000000, N'CV1', N'PB4')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [QueQuan], [Luong], [MaCV], [MaPB]) VALUES (N'NV17', N'Nguyễn Thị Phượng Hồng', CAST(0xA40D0B00 AS Date), N'Nam', N'Vĩnh phúc', 6000000, N'CV5', N'PB3')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [QueQuan], [Luong], [MaCV], [MaPB]) VALUES (N'NV18', N'Lưu Kim Hương', CAST(0x5F190B00 AS Date), N'Nam', N'Vĩnh phúc', 6000000, N'CV5', N'PB3')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [QueQuan], [Luong], [MaCV], [MaPB]) VALUES (N'NV2', N'Nguyễn Đức Minh', CAST(0x3A0F0B00 AS Date), N'Nam', N'Hà Nội', 5500000, N'CV5', N'PB3')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [QueQuan], [Luong], [MaCV], [MaPB]) VALUES (N'NV20', N'Lê Văn Sơn', CAST(0xD50A0B00 AS Date), N'Nam', N'Vĩnh phúc', 6000000, N'CV2', N'PB3')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [QueQuan], [Luong], [MaCV], [MaPB]) VALUES (N'NV21', N'ds', CAST(0xBF180B00 AS Date), N'Nam', N'ba', 3232, N'Cv3', N'PB2')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [QueQuan], [Luong], [MaCV], [MaPB]) VALUES (N'NV22', N'Neymar', CAST(0x9D180B00 AS Date), N'Nam', N'Brazil', 200000, N'CV1', N'PB1')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [QueQuan], [Luong], [MaCV], [MaPB]) VALUES (N'NV3', N'Nguyễn Văn Thắng', CAST(0xDD0F0B00 AS Date), N'Nam', N'Hà Nam', 6000000, N'CV3', N'PB4')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [QueQuan], [Luong], [MaCV], [MaPB]) VALUES (N'NV4', N'Nguyễn Thị Hương', CAST(0x8A180B00 AS Date), N'Nữ', N'Hòa Bình', 5000000, N'CV1', N'PB4')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [QueQuan], [Luong], [MaCV], [MaPB]) VALUES (N'NV5', N'Nguyễn Ngọc Anh', CAST(0xED0C0B00 AS Date), N'Nam', N'Vĩnh phúc', 6000000, N'CV4', N'PB4')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [QueQuan], [Luong], [MaCV], [MaPB]) VALUES (N'NV6', N'Phí Xuân Đạo', CAST(0x68110B00 AS Date), N'Nam', N'Vĩnh phúc', 7000000, N'CV1', N'PB4')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [QueQuan], [Luong], [MaCV], [MaPB]) VALUES (N'NV7', N'Nguyễn Thị Phượng Hồng', CAST(0xA40D0B00 AS Date), N'Nam', N'Vĩnh phúc', 6000000, N'CV5', N'PB3')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [QueQuan], [Luong], [MaCV], [MaPB]) VALUES (N'NV8', N'Lưu Kim Hương', CAST(0x5F190B00 AS Date), N'Nam', N'Vĩnh phúc', 6000000, N'CV5', N'PB3')
INSERT [dbo].[tblNhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [QueQuan], [Luong], [MaCV], [MaPB]) VALUES (N'NV9', N'Hoàng Thị Phương Thảo', CAST(0xF9190B00 AS Date), N'Nam', N'Vĩnh phúc', 6000000, N'CV6', N'PB2')
/****** Object:  StoredProcedure [dbo].[TimKiemNhanVien]    Script Date: 12/04/2015 08:47:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TimKiemNhanVien](@manv varchar(10),@ten nvarchar(50),@macv varchar(10),@chose int)
as
begin
	if(@chose=1)
		select * from tblNhanVien where MaNV=@manv
	else 
		if(@chose=2)
		select * from tblNhanVien where TenNV like N'%'+@ten+N'%'
		else
			if(@chose=3)
				select * from tblNhanVien where MaCV=@macv
end
GO
/****** Object:  StoredProcedure [dbo].[ThemNhanVien]    Script Date: 12/04/2015 08:47:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ThemNhanVien](@ten nvarchar(50),@ns date,@gt nvarchar(5),@qq nvarchar(100),@l int,
	@macv varchar(10),@mapb varchar(10),@kq int out)
as
begin
	if(@macv not in (select MaCV from tblChucVu)) set @kq=0			
	else
		if(@mapb not in (select MaPB from tblPhongBan)) set @kq=1
		else
		begin
			declare @manv varchar(10)
			declare @sl int
			set @sl=(select COUNT(MaNV) from tblNhanVien)+1
			set	@manv='NV'+ CONVERT(varchar(3),@sl)
			while(@manv in (select MaNV from tblNhanVien)) 
			begin
				set @sl=@sl-1
				set	@manv='NV'+ CONVERT(varchar(3),@sl)
			end
			insert into tblNhanVien values
			(@manv,@ten,@ns,@gt,@qq,@l,@macv,@mapb)
			set @kq=2
		end
end
GO
/****** Object:  Table [dbo].[tblThanNhan]    Script Date: 12/04/2015 08:47:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblThanNhan](
	[MaTN] [varchar](10) NOT NULL,
	[TenTN] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[NgheNghiep] [nvarchar](50) NULL,
	[QuanHe] [nvarchar](20) NULL,
	[MaNV] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblThanNhan] ([MaTN], [TenTN], [NgaySinh], [GioiTinh], [NgheNghiep], [QuanHe], [MaNV]) VALUES (N'TN1', N'Lê Công Hoàng', CAST(0xD62A0B00 AS Date), N'Nam', N'Học sinh', N'Con', N'NV1')
INSERT [dbo].[tblThanNhan] ([MaTN], [TenTN], [NgaySinh], [GioiTinh], [NgheNghiep], [QuanHe], [MaNV]) VALUES (N'TN2', N'Hoàng Thị Mai', CAST(0xFE190B00 AS Date), N'Nữ', N'Công Nhân', N'Vợ', N'NV1')
INSERT [dbo].[tblThanNhan] ([MaTN], [TenTN], [NgaySinh], [GioiTinh], [NgheNghiep], [QuanHe], [MaNV]) VALUES (N'TN3', N'Phí Mỹ Hạnh', CAST(0x23330B00 AS Date), N'Nữ', N'Học sinh', N'Con', N'NV6')
INSERT [dbo].[tblThanNhan] ([MaTN], [TenTN], [NgaySinh], [GioiTinh], [NgheNghiep], [QuanHe], [MaNV]) VALUES (N'TN4', N'Nguyễn Thị Lan', CAST(0x25160B00 AS Date), N'Nam', N'Giáo viên', N'Vợ', N'NV6')
INSERT [dbo].[tblThanNhan] ([MaTN], [TenTN], [NgaySinh], [GioiTinh], [NgheNghiep], [QuanHe], [MaNV]) VALUES (N'TN5', N'Nguyễn Cao Cường', CAST(0xF22F0B00 AS Date), N'Nam', N'Học sinh', N'Con', N'NV3')
INSERT [dbo].[tblThanNhan] ([MaTN], [TenTN], [NgaySinh], [GioiTinh], [NgheNghiep], [QuanHe], [MaNV]) VALUES (N'TN6', N'Nguyễn Thu Hương', CAST(0x65330B00 AS Date), N'Nữ', N'Chưa có', N'Con', N'NV3')
INSERT [dbo].[tblThanNhan] ([MaTN], [TenTN], [NgaySinh], [GioiTinh], [NgheNghiep], [QuanHe], [MaNV]) VALUES (N'TN7', N'Trần Thùy Trang', CAST(0x86150B00 AS Date), N'Nữ', N'Giảng viên', N'Vợ', N'NV3')
/****** Object:  StoredProcedure [dbo].[SuaNhanVien]    Script Date: 12/04/2015 08:47:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SuaNhanVien](@manv varchar(10),@ten nvarchar(50),@ns date,@gt nvarchar(5),@qq nvarchar(100),@l int,
	@macv varchar(10),@mapb varchar(10),@kq int out)
as
begin
	if(@manv not in (select MaNV from tblNhanVien)) set @kq=0
	else
		if(@macv not in (select MaCV from tblChucVu )) set @kq=1
		else
			if(@mapb not in (select MaPB from tblPhongBan)) set @kq=2
			else
			begin
				update tblNhanVien
				set MaNV=@manv,TenNV=@ten,NgaySinh=@ns,GioiTinh=@gt,
					QueQuan=@qq,Luong=@l,MaCV=@macv,MaPB=@mapb
				where MaNV=@manv
				set @kq=3
			end
end
GO
/****** Object:  StoredProcedure [dbo].[XoaNhanVien]    Script Date: 12/04/2015 08:47:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[XoaNhanVien](@manv varchar(10),@kq int  out)
as
begin
	if(@manv not in (select MaNV from tblNhanVien)) set @kq=0
	else
		if(@manv in (select MaNV from tblThanNhan)) set @kq=2
	else
	begin
		delete from tblNhanVien where MaNV=@manv
		set @kq=1
	end
end
GO
/****** Object:  ForeignKey [NV_CV_FK]    Script Date: 12/04/2015 08:47:56 ******/
ALTER TABLE [dbo].[tblNhanVien]  WITH CHECK ADD  CONSTRAINT [NV_CV_FK] FOREIGN KEY([MaCV])
REFERENCES [dbo].[tblChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[tblNhanVien] CHECK CONSTRAINT [NV_CV_FK]
GO
/****** Object:  ForeignKey [NV_PB_FK]    Script Date: 12/04/2015 08:47:56 ******/
ALTER TABLE [dbo].[tblNhanVien]  WITH CHECK ADD  CONSTRAINT [NV_PB_FK] FOREIGN KEY([MaPB])
REFERENCES [dbo].[tblPhongBan] ([MaPB])
GO
ALTER TABLE [dbo].[tblNhanVien] CHECK CONSTRAINT [NV_PB_FK]
GO
/****** Object:  ForeignKey [TN_NV_FK]    Script Date: 12/04/2015 08:47:56 ******/
ALTER TABLE [dbo].[tblThanNhan]  WITH CHECK ADD  CONSTRAINT [TN_NV_FK] FOREIGN KEY([MaNV])
REFERENCES [dbo].[tblNhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[tblThanNhan] CHECK CONSTRAINT [TN_NV_FK]
GO
