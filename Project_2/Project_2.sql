USE [QUANLY_HS_GV]
GO
/****** Object:  StoredProcedure [dbo].[Add_GV]    Script Date: 04/12/2015 8:35:11 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Add_GV](@Id_gv char(10),@Hoten nvarchar(50),@quequan nvarchar(100),@Gt nvarChar(3),@Ngaysinh datetime,
					@cmnd char(20),@chucvu nvarchar(50),@Id_monhoc char(10),@Id_lop char(10))
as
begin
	insert into GiaoVien(ID_Gv,HoTen,Quequan,GT,NgaySinh,CMND,ChucVu,ID_Lop,ID_MonHoc)
	values(@Id_gv,@Hoten,@quequan,@Gt,@Ngaysinh,@cmnd,@chucvu,@Id_lop,@Id_monhoc)
end
GO
/****** Object:  StoredProcedure [dbo].[Add_HS]    Script Date: 04/12/2015 8:35:11 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Add_HS](@Id_hs char(10),@Hoten nvarchar(50),@quequan nvarchar(100),@Gt nvarchar(3),
				@Ngaysinh datetime,@Id_lop char(10),@Id_monhoc char(10))
as
begin
	insert into HocSinh(ID_Hs,HoTen,Quequan,GT,NgaySinh,ID_Lop,ID_MonHoc)
	values(@Id_hs,@Hoten,@quequan,@Gt,@Ngaysinh,@Id_lop,@Id_monhoc)
end

GO
/****** Object:  StoredProcedure [dbo].[Delete_GV]    Script Date: 04/12/2015 8:35:11 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Delete_GV](@Id_Gv char(10))
as
begin
	delete from GiaoVien
		where ID_Gv=@Id_Gv	
end	


GO
/****** Object:  StoredProcedure [dbo].[Delete_HS]    Script Date: 04/12/2015 8:35:11 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Delete_HS](@ID_Hs char(10))
as
begin
	delete from HocSinh
		where ID_Hs=@ID_Hs	
end			


GO
/****** Object:  StoredProcedure [dbo].[Edit_GV]    Script Date: 04/12/2015 8:35:11 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Edit_GV](@ID_gv char(10),@Hoten nvarchar(50),@Quequan nvarchar(100),@Gt nvarChar(3)
,@CMND char(20),@Ngaysinh datetime,@Chucvu nvarchar(50),@Id_monhoc char(10),@Id_lop char(10),@kq int output)
as
begin
if(@ID_gv='') begin set @kq=0 return end
else if(@ID_gv not in (select ID_Gv from GiaoVien)) begin set @kq=1 return end
else
begin
	update GiaoVien
	set
	HoTen=@Hoten,Quequan=@Quequan,GT=@Gt,CMND=@CMND,NgaySinh=@Ngaysinh,ChucVu=@Chucvu
	,ID_Lop=@Id_lop,ID_MonHoc=@Id_monhoc
	where ID_Gv=@ID_gv
	set @kq=2
end
end


GO
/****** Object:  StoredProcedure [dbo].[Edit_HS]    Script Date: 04/12/2015 8:35:11 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Edit_HS](@Id_hs char(10),@Hoten nvarchar(50),@quequan nvarchar(100),@Gt nvarchar(3),
				@Ngaysinh datetime,@Id_lop char(10),@Id_monhoc char(10),@kq int output)
as
begin
if(@Id_hs='') set @kq=0
else if(@Id_hs not in (select ID_Hs from HocSinh)) set @kq=1
else
begin
	update HocSinh
	set
	HoTen=@Hoten,Quequan=@Quequan,GT=@Gt,NgaySinh=@Ngaysinh,HocSinh.ID_Lop=@Id_lop,HocSinh.ID_MonHoc=@Id_monhoc
	where ID_Hs=@Id_hs
	set @kq=2
end
end

GO
/****** Object:  StoredProcedure [dbo].[LoadGV]    Script Date: 04/12/2015 8:35:11 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[LoadGV]
as
begin
	select *from GiaoVien
end

GO
/****** Object:  StoredProcedure [dbo].[LoadHS]    Script Date: 04/12/2015 8:35:11 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------------
create proc [dbo].[LoadHS]
as
begin
	select *from HocSinh
end
--------

GO
/****** Object:  StoredProcedure [dbo].[timkiemhocsinh]    Script Date: 04/12/2015 8:35:11 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[timkiemhocsinh](@tim nvarchar(max))
as
begin
	select *from HocSinh
	where HoTen like '%'+@tim+ '%' or ID_Hs like '%' +@tim+ '%'
end

GO
/****** Object:  StoredProcedure [dbo].[timkiengiaovien]    Script Date: 04/12/2015 8:35:11 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[timkiengiaovien](@tim nvarchar(max))
as
begin
	select *from GiaoVien
	where HoTen like '%' + @tim + '%' or ID_Gv like '%' + @tim + '%'
end


GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 04/12/2015 8:35:11 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[ID_Gv] [char](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[Quequan] [nvarchar](100) NULL,
	[GT] [nvarchar](3) NULL,
	[CMND] [int] NULL,
	[NgaySinh] [datetime] NULL,
	[ChucVu] [nvarchar](50) NULL,
	[ID_MonHoc] [char](10) NULL,
	[ID_Lop] [char](10) NULL,
 CONSTRAINT [GV_ID_PK] PRIMARY KEY CLUSTERED 
(
	[ID_Gv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 04/12/2015 8:35:11 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HocSinh](
	[ID_Hs] [char](10) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[Quequan] [nvarchar](100) NULL,
	[GT] [nvarchar](3) NULL,
	[NgaySinh] [datetime] NULL,
	[ID_Lop] [char](10) NULL,
	[ID_MonHoc] [char](10) NULL,
 CONSTRAINT [HS_ID_PK] PRIMARY KEY CLUSTERED 
(
	[ID_Hs] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Login]    Script Date: 04/12/2015 8:35:11 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Login](
	[TaiKhoan] [varchar](30) NOT NULL,
	[MatKhau] [varchar](30) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LopHoc]    Script Date: 04/12/2015 8:35:11 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LopHoc](
	[ID_Lop] [char](10) NOT NULL,
	[Ten_Lop] [nvarchar](30) NULL,
	[ID_Gv] [char](10) NULL,
 CONSTRAINT [LH_ID_PK] PRIMARY KEY CLUSTERED 
(
	[ID_Lop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 04/12/2015 8:35:11 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MonHoc](
	[ID_MonHoc] [char](10) NOT NULL,
	[Ten_MonHoc] [nvarchar](50) NULL,
 CONSTRAINT [MH_ID_PK] PRIMARY KEY CLUSTERED 
(
	[ID_MonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[GiaoVien] ([ID_Gv], [HoTen], [Quequan], [GT], [CMND], [NgaySinh], [ChucVu], [ID_MonHoc], [ID_Lop]) VALUES (N'GV01      ', N'Đào Thanh Tĩnh', NULL, N'Nam', NULL, NULL, NULL, N'MH01      ', N'LOP01     ')
INSERT [dbo].[GiaoVien] ([ID_Gv], [HoTen], [Quequan], [GT], [CMND], [NgaySinh], [ChucVu], [ID_MonHoc], [ID_Lop]) VALUES (N'GV02      ', N'Ngô Thành Long', N'', N'Nam', 121324243, CAST(0x0000A54800000000 AS DateTime), N'Phó khoa', N'MH04      ', N'LOP02     ')
INSERT [dbo].[GiaoVien] ([ID_Gv], [HoTen], [Quequan], [GT], [CMND], [NgaySinh], [ChucVu], [ID_MonHoc], [ID_Lop]) VALUES (N'GV04      ', N'Phan Nguyên Hải', N'', N'Nam', 345678, CAST(0x0000652100000000 AS DateTime), N'Chủ nhiệm bộ môn', N'MH03      ', N'LOP04     ')
INSERT [dbo].[GiaoVien] ([ID_Gv], [HoTen], [Quequan], [GT], [CMND], [NgaySinh], [ChucVu], [ID_MonHoc], [ID_Lop]) VALUES (N'GV99      ', N'da', N'adf', N'Nữ', 32342, CAST(0x0000A54C00000000 AS DateTime), N'', N'MH02      ', N'LOP02     ')
INSERT [dbo].[HocSinh] ([ID_Hs], [HoTen], [Quequan], [GT], [NgaySinh], [ID_Lop], [ID_MonHoc]) VALUES (N'HS001     ', N'Lê Công Tuấn Anh', N'Vĩnh Phúc', N'Nam', CAST(0x0000861D00000000 AS DateTime), N'LOP01     ', N'MH01      ')
INSERT [dbo].[HocSinh] ([ID_Hs], [HoTen], [Quequan], [GT], [NgaySinh], [ID_Lop], [ID_MonHoc]) VALUES (N'HS002     ', N'Nguyễn Chí Công', N'Hà Giang', N'Nam', CAST(0x0000861D00000000 AS DateTime), N'LOP01     ', N'MH01      ')
INSERT [dbo].[HocSinh] ([ID_Hs], [HoTen], [Quequan], [GT], [NgaySinh], [ID_Lop], [ID_MonHoc]) VALUES (N'HS003     ', N'Nguyễn Đức Cảnh', N'Nam Định', N'Nam', CAST(0x0000861D00000000 AS DateTime), N'LOP01     ', N'MH01      ')
INSERT [dbo].[HocSinh] ([ID_Hs], [HoTen], [Quequan], [GT], [NgaySinh], [ID_Lop], [ID_MonHoc]) VALUES (N'HS004     ', N'Nguyễn Anh Dũng', N'Hà Nội', N'Nam', CAST(0x0000861D00000000 AS DateTime), N'LOP01     ', N'MH01      ')
INSERT [dbo].[HocSinh] ([ID_Hs], [HoTen], [Quequan], [GT], [NgaySinh], [ID_Lop], [ID_MonHoc]) VALUES (N'HS005     ', N'Phí Xuân Đạo', N'Hà Tây', N'Nữ', CAST(0x0000861D00000000 AS DateTime), N'LOP02     ', N'MH01      ')
INSERT [dbo].[HocSinh] ([ID_Hs], [HoTen], [Quequan], [GT], [NgaySinh], [ID_Lop], [ID_MonHoc]) VALUES (N'HS006     ', N'Hoàng Đình Đạt', N'Bắc Giang', N'Nam', CAST(0x0000861D00000000 AS DateTime), N'LOP02     ', N'MH01      ')
INSERT [dbo].[HocSinh] ([ID_Hs], [HoTen], [Quequan], [GT], [NgaySinh], [ID_Lop], [ID_MonHoc]) VALUES (N'HS007     ', N'Khương Duy Hoàng', N'Thanh Hóa', N'Nữ', CAST(0x0000861D00000000 AS DateTime), N'LOP04     ', N'MH03      ')
INSERT [dbo].[HocSinh] ([ID_Hs], [HoTen], [Quequan], [GT], [NgaySinh], [ID_Lop], [ID_MonHoc]) VALUES (N'HS008     ', N'Nguyễn Mạnh Hải', N'Hà Nam', N'Nam', CAST(0x0000861D00000000 AS DateTime), N'LOP02     ', N'MH01      ')
INSERT [dbo].[HocSinh] ([ID_Hs], [HoTen], [Quequan], [GT], [NgaySinh], [ID_Lop], [ID_MonHoc]) VALUES (N'HS009     ', N'Lưu Văn Lâm', N'Hải Phòng', N'Nam', CAST(0x0000861D00000000 AS DateTime), N'LOP03     ', N'MH02      ')
INSERT [dbo].[HocSinh] ([ID_Hs], [HoTen], [Quequan], [GT], [NgaySinh], [ID_Lop], [ID_MonHoc]) VALUES (N'HS010     ', N'Lương Văn Luận', N'Bắc Giang', N'Nam', CAST(0x0000861D00000000 AS DateTime), N'LOP03     ', N'MH02      ')
INSERT [dbo].[HocSinh] ([ID_Hs], [HoTen], [Quequan], [GT], [NgaySinh], [ID_Lop], [ID_MonHoc]) VALUES (N'HS011     ', N'Võ Khương Lĩnh', N'Sài Gòn', N'Nam', CAST(0x0000861D00000000 AS DateTime), N'LOP03     ', N'MH02      ')
INSERT [dbo].[HocSinh] ([ID_Hs], [HoTen], [Quequan], [GT], [NgaySinh], [ID_Lop], [ID_MonHoc]) VALUES (N'HS012     ', N'Lê Tuấn Minh', N'Hà Nội', N'Nam', CAST(0x0000861D00000000 AS DateTime), N'LOP03     ', N'MH02      ')
INSERT [dbo].[HocSinh] ([ID_Hs], [HoTen], [Quequan], [GT], [NgaySinh], [ID_Lop], [ID_MonHoc]) VALUES (N'HS013     ', N'Phạm Đình Minh', N'Thái Bình', N'Nam', CAST(0x0000861D00000000 AS DateTime), N'LOP04     ', N'MH03      ')
INSERT [dbo].[HocSinh] ([ID_Hs], [HoTen], [Quequan], [GT], [NgaySinh], [ID_Lop], [ID_MonHoc]) VALUES (N'HS014     ', N'Ngô Hồng Quân', N'Hà Nội', N'Nam', CAST(0x0000861D00000000 AS DateTime), N'LOP04     ', N'MH03      ')
INSERT [dbo].[HocSinh] ([ID_Hs], [HoTen], [Quequan], [GT], [NgaySinh], [ID_Lop], [ID_MonHoc]) VALUES (N'HS015     ', N'Đinh Ngọc San', N'Ninh Bình', N'Nam', CAST(0x0000861D00000000 AS DateTime), N'LOP04     ', N'MH03      ')
INSERT [dbo].[HocSinh] ([ID_Hs], [HoTen], [Quequan], [GT], [NgaySinh], [ID_Lop], [ID_MonHoc]) VALUES (N'HS016     ', N'Nguyễn Quang Trường', N'Hải Dương', N'Nam', CAST(0x0000861D00000000 AS DateTime), N'LOP04     ', N'MH03      ')
INSERT [dbo].[HocSinh] ([ID_Hs], [HoTen], [Quequan], [GT], [NgaySinh], [ID_Lop], [ID_MonHoc]) VALUES (N'HS017     ', N'Lê Văn Vũ', N'Hà Nam', N'Nam', CAST(0x0000861D00000000 AS DateTime), N'LOP01     ', N'LOP04     ')
INSERT [dbo].[HocSinh] ([ID_Hs], [HoTen], [Quequan], [GT], [NgaySinh], [ID_Lop], [ID_MonHoc]) VALUES (N'HS018     ', N'Trần Văn Anh Tuấn', N'Đà Nẵng', N'Nam', CAST(0x0000861D00000000 AS DateTime), N'LOP04     ', N'MH03      ')
INSERT [dbo].[HocSinh] ([ID_Hs], [HoTen], [Quequan], [GT], [NgaySinh], [ID_Lop], [ID_MonHoc]) VALUES (N'HS100     ', N'Lê Thị B', N'Hà Nam', N'Nữ', CAST(0x00008CF100000000 AS DateTime), N'LOP04     ', N'MH04      ')
INSERT [dbo].[Login] ([TaiKhoan], [MatKhau]) VALUES (N'nguyenanhdung', N'nguyenanhdung')
INSERT [dbo].[Login] ([TaiKhoan], [MatKhau]) VALUES (N'luongvanluan', N'luongvanluan')
INSERT [dbo].[Login] ([TaiKhoan], [MatKhau]) VALUES (N'hoangdinhdat', N'hoangdinhdat')
INSERT [dbo].[Login] ([TaiKhoan], [MatKhau]) VALUES (N'phixuandao', N'phixuandao')
INSERT [dbo].[Login] ([TaiKhoan], [MatKhau]) VALUES (N'levanvu', N'levanvu')
INSERT [dbo].[Login] ([TaiKhoan], [MatKhau]) VALUES (N'phamdinhminh', N'phamdinhminh')
INSERT [dbo].[LopHoc] ([ID_Lop], [Ten_Lop], [ID_Gv]) VALUES (N'LOP01     ', N'10A1', N'GV01      ')
INSERT [dbo].[LopHoc] ([ID_Lop], [Ten_Lop], [ID_Gv]) VALUES (N'LOP02     ', N'11A1', N'GV03      ')
INSERT [dbo].[LopHoc] ([ID_Lop], [Ten_Lop], [ID_Gv]) VALUES (N'LOP03     ', N'12A1', N'GV04      ')
INSERT [dbo].[LopHoc] ([ID_Lop], [Ten_Lop], [ID_Gv]) VALUES (N'LOP04     ', N'9A1', N'GV05      ')
INSERT [dbo].[MonHoc] ([ID_MonHoc], [Ten_MonHoc]) VALUES (N'MH01      ', N'Toán')
INSERT [dbo].[MonHoc] ([ID_MonHoc], [Ten_MonHoc]) VALUES (N'MH02      ', N'Văn')
INSERT [dbo].[MonHoc] ([ID_MonHoc], [Ten_MonHoc]) VALUES (N'MH03      ', N'Hóa')
ALTER TABLE [dbo].[GiaoVien]  WITH NOCHECK ADD  CONSTRAINT [fk_giaovien_lophoc] FOREIGN KEY([ID_Lop])
REFERENCES [dbo].[LopHoc] ([ID_Lop])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GiaoVien] NOCHECK CONSTRAINT [fk_giaovien_lophoc]
GO
ALTER TABLE [dbo].[GiaoVien]  WITH NOCHECK ADD  CONSTRAINT [fk_giaovien_monhoc] FOREIGN KEY([ID_MonHoc])
REFERENCES [dbo].[MonHoc] ([ID_MonHoc])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GiaoVien] NOCHECK CONSTRAINT [fk_giaovien_monhoc]
GO
ALTER TABLE [dbo].[HocSinh]  WITH NOCHECK ADD  CONSTRAINT [fk_hocsinh_lophoc] FOREIGN KEY([ID_Lop])
REFERENCES [dbo].[LopHoc] ([ID_Lop])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HocSinh] NOCHECK CONSTRAINT [fk_hocsinh_lophoc]
GO
ALTER TABLE [dbo].[HocSinh]  WITH NOCHECK ADD  CONSTRAINT [fk_hocsinh_monhoc] FOREIGN KEY([ID_MonHoc])
REFERENCES [dbo].[MonHoc] ([ID_MonHoc])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HocSinh] NOCHECK CONSTRAINT [fk_hocsinh_monhoc]
GO
