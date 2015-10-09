create proc LoadGV
as
begin
	select *from GiaoVien
end

create proc LoadHS
as
begin
	select *from HocSinh
end

create proc Add_HS(@Id_hs char(10),@Hoten nvarchar(50),@Gt char(3),@Ngaysinh datetime,
					@Id_lop char(10),@Id_monhoc char(10))
as
begin
	insert into HocSinh(ID_Hs,HoTen,GT,NgaySinh,ID_Lop,ID_MonHoc)
	values(@Id_hs,@Hoten,@Gt,@Ngaysinh,@Id_lop,@Id_monhoc)
end

create proc Edit_HS(@ID_sua char(10),@Id_hs char(10),@Hoten nvarchar(50),@Gt char(3),
				@Ngaysinh datetime,@Id_lop char(10),@Id_monhoc char(10))
as
begin
	update HocSinh
	set ID_Hs=@Id_hs,HoTen=@Hoten,GT=@Gt,NgaySinh=@Ngaysinh,ID_Lop=@Id_lop,
			ID_MonHoc=@Id_monhoc
	where ID_Hs=@ID_sua
end

create proc Delete_HS(@ID_Hs char(10))
as
begin
	delete from HocSinh
		where ID_Hs=@ID_Hs	
end			

create proc Add_GV(@Id_gv char(10),@Hoten nvarchar(50),@Gt Char(3),@Ngaysinh datetime,
					@Id_monhoc char(10),@Id_lop char(10))
as
begin
	insert into GiaoVien(ID_Gv,HoTen,GT,NgaySinh,ID_MonHoc,ID_Lop)
	values(@ID_Gv,@Hoten,@Gt,@Ngaysinh,@Id_monhoc,@Id_lop)
end

create proc Edit_GV(@ID_sua char(10),@Id_gv char(10),@Hoten nvarchar(50),@Gt char(3),
				@Ngaysinh datetime,@Id_monhoc char(10),@Id_lop char(10))
as
begin
	update GiaoVien
	set ID_Gv=@Id_gv,HoTen=@Hoten,GT=@Gt,NgaySinh=@Ngaysinh,ID_MonHoc=@Id_monhoc,ID_Lop=@Id_lop
	where ID_Gv=@ID_sua
end

create proc Delete_GV(@Id_Gv char(10))
as
begin
	delete from GiaoVien
		where ID_Gv=@Id_Gv	
end	

create proc timkiengiaovien(@tim nvarchar(max))
as
begin
	select *from GiaoVien
	where HoTen like '%' + @tim + '%' or ID_Gv like '%' + @tim + '%'
end

create proc timkiemhocsinh(@tim nvarchar(max))
as
begin
	select *from HocSinh
	where HoTen like '%'+@tim+ '%' or ID_Hs like '%' +@tim+ '%'
end