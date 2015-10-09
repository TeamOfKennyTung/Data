create database Project_3

create table tblDauSach
(
	MaDS varchar(10) primary key,
	TenDS nvarchar(50) not null,
	GiaBan bigint not null
)

create table tblDocGia
(
	MaDG varchar(10) primary key,
	TenDG nvarchar(50) not null,
	NgaySinh datetime null,
	GioiTinh nvarchar(3) check (GioiTinh in (N'Nữ', N'Nam'))
)


create table tblMuonTra
(
	MaPM varchar(10) primary key,
	MaDG varchar(10) constraint FK_DG_MT foreign key (MaDG) references tblDocGia(MaDG),
	MaDS varchar(10) constraint FK_DS_MT foreign key (MaDS) references tblDauSach(MaDS),
	NgayMuon datetime null check (NgayMuon = getdate()),
	NgayTra datetime not null check (datediff(day,getdate(),NgayTra) >0)
)

create table tblUser
(
	Taikhoan varchar(30) not null,
	Matkhau varchar(30) not null,
)

insert into tblDauSach values ('DS0001', N'Dế mèn phiêu lưu kí', 10000)
insert into tblDauSach values ('DS0002', N'Hạt giống tâm hồn',15000)
insert into tblDauSach values ('DS0003', N'Hoa sen xanh',14000)
insert into tblDauSach values ('DS0004', N'Lập trình cơ bản',25000)
insert into tblDauSach values ('DS0005', N'Vật lí đại cương I',23000)
insert into tblDauSach values ('DS0006', N'Giải tích I', 15000)
insert into tblDauSach values ('DS0007', N'Đại số tuyến tính',21000)
insert into tblDauSach values ('DS0008', N'War and Peace',87000)
insert into tblDauSach values ('DS0009', N'Love story',56000)
insert into tblDauSach values ('DS0010', N'Công Nghệ WEB',34000)

insert into tblDocGia values ('DG0001', N'Lê Công Tuấn Anh', '12/10/1994','Nam')
insert into tblDocGia values ('DG0002', N'Nguyễn Ngọc Anh', '01/11/1994','Nam')
insert into tblDocGia values ('DG0003', N'Nguyễn Anh Dũng', '01/11/1994','Nam')
insert into tblDocGia values ('DG0004', N'Phí Xuân Đạo', '05/08/1994','Nam')
insert into tblDocGia values ('DG0005', N'Hoàng Đình Đạt', '11/07/1994','Nam')

insert into tblMuonTra values ('PM0001','DG0001', 'DS0002', getdate(), '12/08/2015')
insert into tblMuonTra values ('PM0002','DG0004', 'DS0005', getdate(), '12/07/2015')
insert into tblMuonTra values ('PM0003','DG0003', 'DS0007', getdate(), '10/17/2015')
insert into tblMuonTra values ('PM0004','DG0002', 'DS0001', getdate(), '11/13/2015')
insert into tblMuonTra values ('PM0005','DG0002', 'DS0003', getdate(), '12/25/2015')
insert into tblMuonTra values ('PM0006','DG0003', 'DS0006', getdate(), '12/31/2015')
insert into tblMuonTra values ('PM0007','DG0001', 'DS0004', getdate(), '09/25/2015')
insert into tblMuonTra values ('PM0008','DG0002', 'DS0008', getdate(), '09/30/2015')
insert into tblMuonTra values ('PM0009','DG0002', 'DS0001', getdate(), '09/15/2015')
insert into tblMuonTra values ('PM0010','DG0004', 'DS0002', getdate(), '12/08/2015')

insert into tblUser values('nguyenanhdung','nguyenanhdung')
insert into tblUser values('hoangdingdat','hoangdinhdat')
insert into tblUser values('luongvanluan','luongvanluan')
insert into tblUser values('levanvu','levanvu')
insert into tblUser values('phamdinhminh','phamdinhminh')
insert into tblUser values('phixuandao','phixuandao')

create proc AddDS(@tends nvarchar(50), @giaban bigint)
as
declare @i int
begin
set @i = (select Count(MaDS) from tblDauSach)
if @i <10 begin insert into tblDauSach values ('DS000'+ convert(varchar(5),@i+1),@tends,@giaban) end
else if @i <100  begin insert into tblDauSach values ('DS00'+ convert(varchar(6),@i+1),@tends,@giaban) end
else if @i <1000 begin insert into tblDauSach values ('DS0'+ convert(varchar(7),@i+1),@tends,@giaban) end
else if @i <10000 begin insert into tblDauSach values ('DS'+ convert(varchar(8),@i+1),@tends,@giaban) end
else begin insert into tblDauSach values ('DS'+ convert(varchar(8),@i+1),@tends,@giaban) end
end

create proc UpdDS(@mads varchar(10), @tends nvarchar(50), @giaban bigint)
as
begin
update tblDauSach set TenDS = @tends, Giaban = @giaban where MaDS = @mads
end

create proc DelDS(@mads varchar(10))
as
begin
delete from tblDauSach where MaDS = @mads
end

create proc FindDS(@str nvarchar(50))
as
begin
select * from tblDauSach where TenDS like '%' + @str + '%' or MaDS like '%' + @str +'%'
or convert(nvarchar(50),giaban) like '%' + @str + '%'
end

create proc AddDG(@tendg nvarchar(50), @ngaysinh datetime, @gioitinh nvarchar(3))
as
declare @i int
begin
set @i = (select count(MaDG) from tblDocGia)
if @i <10 begin insert into tblDocGia values ('DG000'+ convert(varchar(5),@i+1), @tendg, @ngaysinh, @gioitinh) end
else if @i <100  begin insert into tblDocGia values ('DG00'+ convert(varchar(6),@i+1), @tendg, @ngaysinh, @gioitinh) end
else if @i <1000 begin insert into tblDocGia values ('DG0'+ convert(varchar(7),@i+1), @tendg ,@ngaysinh, @gioitinh) end
else if @i <10000 begin insert into tblDocGia values ('DG'+ convert(varchar(8),@i+1), @tendg, @ngaysinh, @gioitinh) end
else begin insert into tblDocGia values ('DG'+ convert(varchar(8),@i+1), @tendg, @ngaysinh, @gioitinh) end
end

create proc UpdDG(@madg varchar(10), @tendg nvarchar(50), @ngaysinh datetime, @gioitinh nvarchar(3))
as
begin
update tblDocGia set TenDG = @tendg, Ngaysinh = @ngaysinh, GioiTinh = @gioitinh where MaDG = @madg
end

create proc DelDG(@madg varchar(10))
as
begin
delete from tblDocGia where MaDG = @madg
end

create proc FindDG(@str nvarchar(50))
as
begin
select * from tblDocGia where TenDG like '%' + @str + '%' or MaDG like '%' + @str + '%' 
or GioiTinh like '%' + @str + '%' or convert(nvarchar(50),Ngaysinh) like '%' + @str + '%' 
end


create proc AddMT(@madg varchar(10), @mads varchar(10), @ngaytra datetime)
as
declare @i int
begin
if @i <10 begin insert into tblMuonTra values ('PM000'+ convert(varchar(5),@i+1), @madg, @mads, getdate(), @ngaytra) end
else if @i <100  begin insert into tblMuonTra values ('PM00'+ convert(varchar(6),@i+1), @madg, @mads, getdate(), @ngaytra) end
else if @i <1000 begin insert into tblMuonTra values ('PM0'+ convert(varchar(7),@i+1), @madg, @mads, getdate(), @ngaytra) end
else if @i <10000 begin insert into tblMuonTra values ('PM'+ convert(varchar(8),@i+1), @madg, @mads, getdate(), @ngaytra) end
else begin insert into tblMuonTra values ('PM'+ convert(varchar(8),@i+1), @madg, @mads, getdate(), @ngaytra) end
end

create proc UpdMT(@mapm varchar(10), @madg varchar(10), @mads varchar(10), @ngaymuon datetime, @ngaytra datetime)
as
begin
update tblMuonTra set MaDG = @madg, MaDS = @mads, NgayMuon = @ngaymuon, NgayTra = @ngaytra
end

create proc DelMT(@mapm varchar(10))
as
begin
delete from tblMuonTra where MaPM = @mapm
end

create proc FindMT(@str nvarchar(50))
as
begin
select * from tblMuonTra where MaPM like '%' + @str + '%' or MaDS like '%' + @str +'%'
or MaDG like '%' + @str +'%' or convert(nvarchar(50),ngaymuon) like '%' + @str +'%' or convert(nvarchar(50),ngaytra) like '%' + @str +'%'
end
