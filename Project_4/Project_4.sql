create database Project_4

create table tblNhaCungCap
(
	MaNCC varchar(10) primary key,
	TenNCC nvarchar(50) not null
)

create table tblHangHoa
(
	MaHH varchar(10) primary key,
	TenHH nvarchar(50) not null,
	MaNCC varchar(10) constraint FK_HH_NCC foreign key (MaNCC) references tblNhaCungCap(MaNCC),
	SoLuong int
	
)

create table tblPhieuNhap
(
	MaPN varchar(10) primary key,
	MaHH varchar(10) constraint FK_PN_HH foreign key (MaHH) references tblHangHoa(MaHH),
	NgayNhap datetime,
	SoLuong int
)

create table tblPhieuXuat
(
	MaPX varchar(10) primary key,
	MaHH varchar(10) constraint FK_PX_HH foreign key (MaHH) references tblHangHoa(MaHH),
	NgayXuat datetime,
	SoLuong int
)

insert into tblNhaCungCap values('NCC0001',N'Hoàng Hà')
insert into tblNhaCungCap values('NCC0002',N'Thăng Long')
insert into tblNhaCungCap values('NCC0003',N'Hải Tiến')

insert into tblHangHoa values('HH0001',N'Hàng hóa 01','NCC0001','100')
insert into tblHangHoa values('HH0002',N'Hàng hóa 02','NCC0003','150')
insert into tblHangHoa values('HH0003',N'Hàng hóa 03','NCC0002','200')
insert into tblHangHoa values('HH0004',N'Hàng hóa 04','NCC0003','250')
insert into tblHangHoa values('HH0005',N'Hàng hóa 05','NCC0001','100')
insert into tblHangHoa values('HH0006',N'Hàng hóa 06','NCC0002','200')
insert into tblHangHoa values('HH0007',N'Hàng hóa 07','NCC0002','150')
insert into tblHangHoa values('HH0008',N'Hàng hóa 08','NCC0003','200')

insert into tblPhieuNhap values('PN0001','HH0001','1/15/2015','200')
insert into tblPhieuNhap values('PN0002','HH0003','1/15/2015','150')
insert into tblPhieuNhap values('PN0003','HH0002','1/30/2015','100')
insert into tblPhieuNhap values('PN0004','HH0005','2/10/2015','250')
insert into tblPhieuNhap values('PN0005','HH0007','2/24/2015','150')
insert into tblPhieuNhap values('PN0006','HH0004','3/11/2015','100')
insert into tblPhieuNhap values('PN0007','HH0003','4/20/2015','200')
insert into tblPhieuNhap values('PN0008','HH0006','5/1/2015','250')
insert into tblPhieuNhap values('PN0009','HH0008','5/18/2015','100')

insert into tblPhieuXuat values('PX0001','HH0003','2/5/2015','100')
insert into tblPhieuXuat values('PX0002','HH0001','3/15/2015','150')
insert into tblPhieuXuat values('PX0003','HH0002','3/26/2015','100')
insert into tblPhieuXuat values('PX0004','HH0005','4/12/2015','200')
insert into tblPhieuXuat values('PX0005','HH0007','5/5/2015','150')
insert into tblPhieuXuat values('PX0006','HH0008','6/1/2015','250')

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


create proc NhapMoi(@TenHH nvarchar(50), @MaNCC varchar(10), @Soluong int)
as
declare @i int
begin
	set @i =(select Count(MaHH) from tblHangHoa)
	if @i <10 insert into tblHangHoa values ('HH000'+convert(varchar(5),@i+1),@TenHH, @mancc,@soluong)
	else if @i<100 and @i>=10 insert into tblHangHoa values ('HH00'+convert(varchar(6),@i+1),@TenHH, @mancc,@soluong)
	else if @i<1000 and @i >=100 insert into tblHangHoa values ('HH0'+convert(varchar(7),@i+1),@TenHH, @mancc,@soluong)
	else if @i<10000 and @i >=1000 insert into tblHangHoa values ('HH'+convert(varchar(8),@i+1),@TenHH, @mancc,@soluong)
end

create proc NhapThem (@mahh varchar(10), @soluong int)
as
begin
update tblHangHoa set SoLuong = SoLuong + @soluong where MaHH = @mahh
end

create proc XuatHang(@mahh varchar(10), @soluong int)
as
begin
update tblHangHoa set SoLuong = SoLuong - @soluong where MaHH = @mahh
end

create proc ThongKe (@ngaythongke datetime)
as
begin

end