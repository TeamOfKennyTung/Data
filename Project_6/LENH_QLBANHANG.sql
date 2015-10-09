create proc LoadHangHoa
as
begin
	select *from HangHoa
end

create proc Add_HangHoa(@ID_HangHoa char(10),@TenHang char (50),@GiaHang int,@NgayNhap date,@Hansd date)
as
begin
insert into HangHoa(ID_HangHoa,TenHang,GiaHang,NgayNhap,HanSd)
values(@ID_HangHoa,@TenHang,@GiaHang,@NgayNhap,@Hansd)
end

create proc LoadKhachHang
as
begin
	select *from KhachHang
end

create proc Add_KhachHang(@ID_KhachHang char(10),@Ten_KhachHang nvarchar(50),@SDT_KhachHang int,@GioiTinh_KhachHang char(3))
as
begin
	insert into KhachHang(ID_KhachHang,Ten_KhachHang,SDT_KhachHang,GioiTinh_KhachHang)
	values(@ID_KhachHang,@Ten_KhachHang,@SDT_KhachHang,@GioiTinh_KhachHang)
end

create proc Edit_KhachHang(@ID_KhachHang char(10),@Ten_KhachHang char(20),@SDT_KhachHang int,@GioiTinh_KhachHang char(3))
as
begin
	update KhachHang
	set ID_KhachHang=@ID_KhachHang,Ten_KhachHang=@Ten_KhachHang,SDT_KhachHang=@SDT_KhachHang,GioiTinh_KhachHang=@GioiTinh_KhachHang
	where ID_KhachHang=@ID_KhachHang
end

create proc Delete_NhanVien(@ID_NhanVien char(10))
as
begin
	delete from NhanVien
		where ID_NhanVien=@ID_NhanVien	
end			

create proc Add_NhanVien(@ID_NhanVien char(10),@Hoten nvarchar(50),@QueQuan nvarchar(100),@GT char(3),@CMND int, @NgaySinh date)
as
begin
	insert into NhanVien(ID_NhanVien,HoTen,Quequan,GT,CMND,NgaySinh)
	values(@ID_NhanVien,@Hoten,@QueQuan,@GT,@CMND,@NgaySinh)
end

--create proc Edit_NhanVien(@ID_NhanVien char(10),@HoTen char(50),@QueQuan nvarchar(100),@GT char(3),@CMND int,@NgaySinh date)			
--as
--begin
--	update NhanVien
--	set ID_NhanVien=@ID_NhanVien,HoTen=@Hoten,Quequan=@QueQuan,GT=@GT,NgaySinh=@Ngaysinh,CMND=@CMND,NgaySinh=@NgaySinh
--	where ID_NhanVien=@ID_NhanVien
--end
create proc timkienhanghoa(@tim nvarchar(max))
as
begin
	select *from HangHoa
	where TenHang like '%' + @tim + '%' or ID_HangHoa like '%' + @tim + '%'
end

create proc timkiemnhanvien(@tim nvarchar(max))
as
begin
	select *from NhanVien
	where HoTen like '%'+@tim+ '%' or ID_NhanVien like '%' +@tim+ '%'
end