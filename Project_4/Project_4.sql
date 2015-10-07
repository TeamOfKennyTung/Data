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

create proc NhapMoi(@TenHH nvarchar(50), @MaNCC, @Soluong int)
as
declare @i int
begin
(
	set @i =(select Count(MaHH) from tblHangHoa)
	if @i <10 insert into tblHangHoa values ('HH000'+convert(varchar(5),@i+1), @mancc,@soluong)
	else if @i<100 and @i>=10 insert into tblHangHoa values ('HH00'+convert(varchar(6),@i+1), @mancc,@soluong)
	else if @i<1000 and @i >=100 insert into tblHangHoa values ('HH0'+convert(varchar(7),@i+1), @mancc,@soluong)
	else if @i<10000 and @i >=1000 insert into tblHangHoa values ('HH'+convert(varchar(8),@i+1), @mancc,@soluong)
)
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