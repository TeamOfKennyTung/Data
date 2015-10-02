create database QuanLiNhanSu
go
create table tblChucVu
(
	MaCV varchar(10) not null primary key,
	TenCV nvarchar(10) null
)
create table tblPhongBan
(
	MaPB varchar(10) not null primary key,
	TenPB nvarchar(50) null,
	DiaDiem nvarchar(50) null,
)
create table tblNhanVien
(
	MaNV varchar(10) not null primary key,
	TenNV nvarchar(50) null,
	NgaySinh datetime null,
	GioiTinh nvarchar(5) null,
	QueQuan nvarchar(100) null,
	Luong int null,
	MaCV varchar(10) null
	constraint NV_CV_FK foreign key(MaCV) references tblChucVu(MaCV),
	MaPB varchar(10) null
	constraint NV_PB_FK foreign key(MaPB) references tblPhongBan(MaPB)
)
create table tblThanNhan
(
	MaTN varchar(10) not null primary key,
	TenTN nvarchar(50) not null,
	NgaySinh datetime not null,
	GioiTinh nvarchar(5) null,
	NgheNghiep nvarchar(50) null,
	QuanHe nvarchar(20) null,
	MaNV varchar(10) null
		constraint TN_NV_FK foreign key(MaNV) references tblNhanVien(MaNV)
)
go

insert into tblPhongBan values	('PB1',N'Phòng Marketing',N'Phòng 501')
insert into tblPhongBan values	('PB2',N'Phòng Hành Chính',N'Phòng 502')
insert into tblPhongBan values	('PB3',N'Phòng Thiết Kế',N'Phòng 503')
insert into tblPhongBan values	('PB4',N'Phòng Kĩ Thuật',N'Phòng 504')
go
insert into tblChucVu values('CV1',N'Thư kí')
insert into tblChucVu values('CV2',N'Kĩ sư')
insert into tblChucVu values('CV3', N'Tổ trưởng')
insert into tblChucVu values ('CV4', N'Manager')
insert into tblChucVu values('CV5', N'Designer')
insert into tblChucVu values('CV6',N'Nhân viên')

insert into tblNhanVien values( 'NV11',N'Lê Công Tuấn','1989/2/3',N'Nam',N'Vĩnh phúc',5000000,'CV5','PB3')
insert into tblNhanVien values( 'NV12',N'Nguyễn Đức Cảnh','1985/6/3',N'Nam',N'Hà Nội',5500000,'CV5','PB3')
insert into tblNhanVien values( 'NV13',N'Nguyễn Chí Công','1985/11/13',N'Nam',N'Hà Nam',6000000,'CV3','PB4')
insert into tblNhanVien values( 'NV14',N'Nguyễn Thị Hương','1991/12/13',N'Nữ',N'Hòa Bình',5000000,'CV1','PB4')
insert into tblNhanVien values( 'NV15',N'Nguyễn Ngọc Anh','1983/10/23',N'Nam',N'Vĩnh phúc',6000000,'CV4','PB4')
insert into tblNhanVien values( 'NV16',N'Phí Xuân Đạo','1986/12/13',N'Nam',N'Vĩnh phúc',7000000,'CV1','PB4')
insert into tblNhanVien values( 'NV17',N'Nguyễn Thị Phượng Hồng','1984/4/23',N'Nam',N'Vĩnh phúc',6000000,'CV5','PB3')
insert into tblNhanVien values( 'NV18',N'Lưu Kim Hương','1992/7/13',N'Nam',N'Vĩnh phúc',6000000,'CV5','PB3')
insert into tblNhanVien values( 'NV19',N'Hoàng Thị Phương Thảo','1992/12/14',N'Nam',N'Vĩnh phúc',6000000,'CV6','PB2')
insert into tblNhanVien values( 'NV20',N'Lê Văn Sơn','1982/5/5',N'Nam',N'Vĩnh phúc',6000000,'CV2','PB3')

insert into tblThanNhan values( 'TN1',N'Lê Công Hoàng','2004-10-9',N'Nam',N'Học sinh',N'Con','NV11')
insert into tblThanNhan values( 'TN2',N'Hoàng Thị Mai','1992-12-19',N'Nữ',N'Công Nhân',N'Vợ','NV11')
insert into tblThanNhan values( 'TN3',N'Phí Mỹ Hạnh','2010-8-4',N'Nữ',N'Học sinh',N'Con','NV16')
insert into tblThanNhan values( 'TN4',N'Nguyễn Thị Lan','1990-4-9',N'Nam',N'Giáo viên',N'Vợ','NV16')
insert into tblThanNhan values( 'TN5',N'Nguyễn Cao Cường','2008-5-9',N'Nam',N'Học sinh',N'Con','NV13')
insert into tblThanNhan values( 'TN6',N'Nguyễn Thu Hương','2010-10-9',N'Nữ',N'Chưa có',N'Con','NV13')
insert into tblThanNhan values( 'TN7',N'Trần Thùy Trang','1989-11-1',N'Nữ',N'Giảng viên',N'Vợ','NV13')

--proc_Thêm NHân viên-------------------
create proc ThemNhanVien(@ten nvarchar(50),@ns datetime,@gt nvarchar(5),@qq nvarchar(100),@l int,
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
			set	@manv=N'NV'+ CONVERT(varchar(3),@sl)
			insert into tblNhanVien values
			(@manv,@Ten,@ns,@gt,@qq,@l,@macv,@mapb)
			set @kq=2
		end
end
------------SuaNhan vien
create proc SuaNhanVien(@manv varchar(10),@ten nvarchar(50),@ns datetime,@gt nvarchar(5),@qq nvarchar(100),@l int,
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
--------XoaNhanVien
create proc XoaNhanVien(@manv varchar(10),@kq int  out)
as
begin
	if(@manv not in (select MaNV from tblNhanVien)) set @kq=0
	else
	begin
		delete from tblNhanVien where MaNV=@manv
		set @kq=1
	end
end
-----TimKiem------
create proc TimKiemNhanVien(@ten nvarchar(50),@mapb varchar(10),@namsinh varchar(4),@chose int)
as
begin
	if(@chose=1)
		select * from tblNhanVien where TenNV like N'%'+@ten+N'%'
	else 
		if(@chose=2)
		select * from tblNhanVien where MaPB=@mapb
		else
			if(@chose=3)
				select * from tblNhanVien where NgaySinh like N'%'+@namsinh+N'%'
end