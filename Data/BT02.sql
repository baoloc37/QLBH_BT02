Create Database QLBH
Use QLBH

BACKUP DATABASE [QLBH] 
TO  DISK = N'E:\.NET BE\BT02\DB_QLBH.bak' 
WITH  DESCRIPTION = N'BaiTap', NOFORMAT, NOINIT,  
NAME = N'QLBH-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10
GO

Create TABLE TaiKhoan
(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	Username varchar(100) UNIQUE not null,
	Pass varchar(100) not null,
	Loai nvarchar(50) not null 
)

CREATE TABLE KhachHang
(
	MaKH varchar(10) PRIMARY KEY,
	HoTen nvarchar(40) NOT NULL,
	DiaChi nvarchar(100) NOT NULL,
	SDT varchar(12) NOT NULL
)

CREATE TABLE SanPham
(
	MaSP varchar(10) PRIMARY KEY,
	TenSanPham nvarchar(30) NOT NULL,
	SoLuong int NOT NULL,
	GiaBan int NOT NULL
)

CREATE TABLE HoaDon
(
	MaHD varchar(10) PRIMARY KEY,
	MaKH varchar(10) NOT NULL,
	NgayBan date NOT NULL,
	CONSTRAINT FK_KH FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
)

CREATE TABLE CTHD
(
	MaHD varchar(10),
	MaSP varchar(10),
	SoLuong int NOT NULL,
	ThanhTien int,
	CONSTRAINT PK_CTHD PRIMARY KEY (MaHD, MaSP),
	CONSTRAINT FK_SP FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP) ON DELETE CASCADE,
	CONSTRAINT FK_HD FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD) ON DELETE CASCADE
)


-----TRIGGER-----
Create TRIGGER trg_InsertCTHD 
ON CTHD after insert
as
begin
	UPDATE SanPham SET SanPham.SoLuong = SanPham.SoLuong - inserted.SoLuong
	FROM SanPham JOIN inserted ON inserted.MaSP = SanPham.MaSP
end
go

Create TRIGGER trg_UpdateCTHD
ON CTHD FOR UPDATE
AS
BEGIN
	UPDATE SanPham SET SanPham.SoLuong = SanPham.SoLuong + deleted.SoLuong - inserted.SoLuong
	FROM SanPham 
	JOIN deleted ON deleted.MaSP = SanPham.MaSP 
	JOIN inserted ON inserted.MaSP = SanPham.MaSP
END
go

create trigger trg_ThanhTien
on CTHD
after insert, update
as 
begin
	declare @MaHD varchar(10), @MaSP varchar(10), @ThanhTien int
	Select @MaHD = MaHD, @MaSP = MaSP from inserted
	--
	Select @ThanhTien = inserted.SoLuong * GiaBan 
	from inserted join SanPham on inserted.MaSP = SanPham.MaSP
	where (MaHD = @MaHD) and (inserted.MaSP = @MaSP)
	--
	Update CTHD 
	set ThanhTien = @ThanhTien
	where (MaHD = @MaHD) and (MaSP = @MaSP)
end

-----INSERT DATA-----
INSERT INTO KhachHang
VALUES
('KH001', N'Nguyễn Tố Như', N'Ngũ Hành Sơn', '0943445621'),
('KH002', N'Nguyễn Công Phúc', N'Sơn Trà', '0364125345'),
('KH003', N'Lương Ngọc Hoàng', N'Thanh Khê', '0375412354')

INSERT INTO SanPham
VALUES
('SP001', N'Bút chì', 50, 3000),
('SP002', N'Bút bi', 100, 5000),
('SP003', N'Vở 200 trang', 80, 10000),
('SP004', N'Thước kẻ', 50, 8000),
('SP005', N'Sổ tay', 60, 20000)

select * from SanPham

INSERT INTO HoaDon
VALUES
('HD001', 'KH001', '2021/12/20'),
('HD002', 'KH002', '2021/12/18'),
('HD003', 'KH003', '2021/12/05'),
('HD004', 'KH001', '2021/11/10'),
('HD005', 'KH002', '2021/10/25'),
('HD006', 'KH003', '2021/10/10')


INSERT INTO CTHD (MaHD, MaSP, SoLuong) VALUES('HD001', 'SP001', 5)
INSERT INTO CTHD (MaHD, MaSP, SoLuong) VALUES('HD001', 'SP003', 10)
INSERT INTO CTHD (MaHD, MaSP, SoLuong) VALUES('HD002', 'SP004', 7)
INSERT INTO CTHD (MaHD, MaSP, SoLuong) VALUES('HD002', 'SP002', 5)
INSERT INTO CTHD (MaHD, MaSP, SoLuong) VALUES('HD002', 'SP003', 6)
INSERT INTO CTHD (MaHD, MaSP, SoLuong) VALUES('HD003', 'SP005', 10)
INSERT INTO CTHD (MaHD, MaSP, SoLuong) VALUES('HD004', 'SP001', 5)
INSERT INTO CTHD (MaHD, MaSP, SoLuong) VALUES('HD004', 'SP002', 5)
INSERT INTO CTHD (MaHD, MaSP, SoLuong) VALUES('HD004', 'SP003', 5)
INSERT INTO CTHD (MaHD, MaSP, SoLuong) VALUES('HD005', 'SP005', 7)
INSERT INTO CTHD (MaHD, MaSP, SoLuong) VALUES('HD005', 'SP004', 6)
INSERT INTO CTHD (MaHD, MaSP, SoLuong) VALUES('HD006', 'SP001', 8)
INSERT INTO CTHD (MaHD, MaSP, SoLuong) VALUES('HD006', 'SP002', 8)
INSERT INTO CTHD (MaHD, MaSP, SoLuong) VALUES('HD006', 'SP003', 5)
INSERT INTO CTHD (MaHD, MaSP, SoLuong) VALUES('HD006', 'SP004', 2)
INSERT INTO CTHD (MaHD, MaSP, SoLuong) VALUES('HD006', 'SP005', 4)
INSERT INTO CTHD (MaHD, MaSP, SoLuong) VALUES('HD003', 'SP004', 2)


-----STORE PROCEDURE & FUNCTION-----
create proc USP_Login (@User nvarchar(100), @Pass nvarchar(100))
as
begin
		select * from TaiKhoan 
		where Username = @User and Pass = @Pass
end
go

---Tài Khoản---
-- Thêm TK
create proc USP_ThemTK (@User nvarchar(100), @Pass nvarchar(100), @Loai varchar(50))
as
begin
		Insert Into TaiKhoan
		(Username, Pass, Loai)
		Values
			(@User, @Pass, @Loai)
end
go

--Xoá TK
create proc USP_XoaTK (@Id int)
as
begin
	delete from TaiKhoan where ID = @Id
end
go

--Sửa TK
create proc USP_SuaTK (@Id int, @Loai nvarchar(10))
as
begin
	update TaiKhoan
	Set Loai = @Loai
	where ID = @Id
end
go


---KHACH HANG---
--Tang ma khach hang
create function fGetNewMaKH()
returns varchar(10)
as
begin
	declare @iCount int, @MaKH_new varchar(10)
	select @iCount = COUNT(MaKH) from KhachHang 
	if (@iCount <= 0) 
	begin
		set @MaKH_new = 'KH' + '001'
	end
	else
	begin
		select @MaKH_new = MAX(RIGHT(MaKH, 3)) + 1 from KhachHang
		set @MaKH_new = 'KH' + RIGHT(REPLICATE('0', 2) + @MaKH_new, 3)
	end
	return @MaKH_new
end

--Trùng tên, SDT 
create function fGetKH(@TenKH nvarchar(50), @DienThoai varchar(15))
returns bit
as
begin
	declare @count int
	select @count = COUNT(MaKH) from KhachHang where HoTen = @TenKH and SDT = @DienThoai
	if @count > 0
		return 1
	return 0
end
go

--Thêm Khách hàng
create proc USP_ThemKH  
(@tenKH nvarchar(100), @DiaChi nvarchar(100), @DienThoai varchar(13))
as
begin
	if (dbo.fGetKH(@tenKH, @DienThoai) = 1)
	begin
		return
	end
	else 
	begin
		Insert Into KhachHang 
		(MaKH, HoTen, DiaChi, SDT)
		Values
			(dbo.fGetNewMaKH(), @tenKH, @DiaChi,  @DienThoai)
	end
end
go

--Sửa khách hàng
create proc USP_UpdateKH (@MaKH varchar(10), @HoTen nvarchar(100), @DienThoai varchar(13), @DiaChi nvarchar(100))
as
begin
	update KhachHang set HoTen = @HoTen, SDT = @DienThoai, DiaChi = @DiaChi
	where MaKH = @MaKH 
end
go

--Xóa Khách hàng
create proc USP_DeleteKH (@MaKH varchar(10))
as
begin
	Delete From KhachHang where MaKH = @MaKH
end
go

--Tìm kiếm khách hàng
create proc USP_TimKiemKH (@TieuChi nvarchar(100), @Text nvarchar(100))
as
begin
	if (@TieuChi = N'Tên khách hàng') 
	begin
		select * from KhachHang where HoTen like CONCAT('%', @Text ,'%')
	end 
	else if (@TieuChi = N'Số điện thoại') 
	begin
		select * from KhachHang where SDT like CONCAT('%', @Text ,'%')
	end 
end
go

---SAN PHAM---
-- Tự tăng Mã sản phẩm
create function fGetNewMaSP ()
returns varchar(10)
as
begin
	declare @iCount int, @MaSP_new varchar(10)
	select @iCount = COUNT(MaSP) from SanPham 
	if (@iCount <= 0) 
	begin
		set @MaSP_new = 'SP' + '001'
	end
	else
	begin
		select @MaSP_new = MAX(RIGHT(MaSP, 3)) + 1 from SanPham
		set @MaSP_new = 'SP' + RIGHT(REPLICATE('0', 2) + @MaSP_new, 3)
	end
	return @MaSP_new
end
go

-- Hàm Trường hợp trùng tên sp
create function fGetSP(@TenSP nvarchar(50))
returns bit
as
begin
	declare @count int
	select @count = COUNT(MaSP) from SanPham where TenSanPham = @TenSP
	if @count > 0
		return 1
	return 0
end
go

--Thêm sản phẩm
create proc USP_ThemSP 
(@tenSP nvarchar(100), @SoLuong int, @DonGiaBan int)
as
begin
	if (dbo.fGetSP(@tenSP) = 1)
	begin
		return
	end
	else 
	begin
		Insert Into SanPham 
		Values
			(dbo.fGetNewMaSP(), @tenSP, @SoLuong, @DonGiaBan)
	end
end
go

-- SP Sửa sản phẩm
create proc USP_UpdateSP
(@MaSP varchar(10), @tenSP nvarchar(100), @SoLuong int, @DonGiaBan int)
As
Begin
	Update SanPham 
	set  TenSanPham = @tenSP, SoLuong = @SoLuong, GiaBan = @DonGiaBan
	where MaSP = @MaSP
End
Go

--Xóa sản phẩm
create proc USP_DeleteSP (@MaSP varchar(10))
as
begin
	Delete From SanPham where MaSP = @MaSP
end
go

--SP Tìm kiếm sản phẩm
create proc USP_TimKiemSP (@TieuChi nvarchar(100), @Text nvarchar(100))
as
begin
	if (@TieuChi = N'Tên sản phẩm') 
	begin
		select * from SanPham where TenSanPham like CONCAT('%', @Text ,'%')
	end 
	else if (@TieuChi = N'Mã sản phẩm') 
	begin
		select * from SanPham where MaSP like CONCAT('%', @Text ,'%')
	end 
end

---HOA DON---
--Tự động tăng Mã HD
create function fGetNewMaHD ()
returns varchar(10)
as
begin
	declare @iCount int, @MaHD_new varchar(10)
	select @iCount = COUNT(MaHD) from HoaDon 
	if (@iCount <= 0) 
	begin
		set @MaHD_new = 'HD' + '001'
	end
	else
	begin
		select @MaHD_new = MAX(RIGHT(MaHD, 3)) + 1 from HoaDon
		set @MaHD_new = 'HD' + RIGHT(REPLICATE('0', 2) + @MaHD_new, 3)
	end
	return @MaHD_new
end
go

-- Select All Hóa đơn
create proc SelectAllHD
as
begin
	select  HoaDon.MaHD, KhachHang.HoTen, KhachHang.MaKH, NgayBan, SUM(ThanhTien) as TongTien
	from HoaDon join CTHD on HoaDon.MaHD = CTHD.MaHD
				join SanPham on SanPham.MaSP = CTHD.MaSP
				join KhachHang on KhachHang.MaKH = HoaDon.MaKH
	group by HoaDon.MaHD, KhachHang.MaKH, KhachHang.HoTen, NgayBan
end
go



--Xóa Hóa đơn
create proc USP_DeleteHD (@MaHD varchar(10))
as
begin
	Delete From HoaDon where MaHD = @MaHD
end
go

--Thêm Hóa đơn
create proc USP_ThemHD 
(@MaKH varchar(10), @NgayBan date)
as
begin
	Insert Into HoaDon 
	(MaHD, MaKH, NgayBan)
	Values
		(dbo.fGetNewMaHD(), @MaKH, @NgayBan)
end
go

--Sửa hóa đơn
create proc USP_UpdateHD
(@MaHD varchar(10), @MaKH varchar(10), @NgayBan datetime)
As
Begin
	declare @iCount int
	set @iCount = (select COUNT(MaKH) from KhachHang where MaKH = @MaKH )
	if (@iCount < 1) 
		begin
			return
		end
	Update HoaDon set MaKH = @MaKH, NgayBan = @NgayBan
	where MaHD = @MaHD
End
Go


-- Tìm kiếm hóa đơn
alter proc USP_TimKiemHD (@TieuChi nvarchar(100), @Text nvarchar(100))
as
begin

	if (@TieuChi = N'Tên khách hàng') 
		begin
		select  HoaDon.MaHD, KhachHang.HoTen, KhachHang.MaKH, NgayBan,
					SUM(ThanhTien) as TongTien
		from HoaDon join CTHD on HoaDon.MaHD = CTHD.MaHD
					join SanPham on SanPham.MaSP = CTHD.MaSP
					join KhachHang on KhachHang.MaKH = HoaDon.MaKH
		where HoTen like CONCAT('%', @Text ,'%')
		group by HoaDon.MaHD, KhachHang.MaKH, KhachHang.HoTen, NgayBan
		end 
end
go

---ChiTietHoaDon---
--HienThiCTHD
alter proc USP_SelectAllCTHD(@MaHD varchar(10))
as
begin
	select cthd.*, TenSanPham, GiaBan
	from CTHD join SanPham on SanPham.MaSP = CTHD.MaSP
			join HoaDon on CTHD.MaHD = HoaDon.MaHD
	where HoaDon.MaHD = @MaHD
end
go

--Xóa CTHD
create proc USP_DeleteCTHD (@MaHD varchar(10), @MaSP varchar(10))
as
begin
	Delete From CTHD where MaHD = @MaHD and MaSP = @MaSP
end
go

-- Sửa CTHD
create proc USP_UpdateCTHD(@MaHD varchar(10), @MaSP varchar(10), @SoLuong int)
as
begin
	Update CTHD 
	Set SoLuong = @SoLuong
	where MaHD = @MaHD and MaSP = @MaSP
end
go

-- Thêm CTHD
alter proc USP_InsertCTHD(@MaHD varchar(10), @MaSP varchar(10), @SoLuong int)
as
begin
	Insert Into CTHD
		(MaHD, MaSP, SoLuong)
		Values
			(@MaHD, @MaSP, @SoLuong)
end

--Báo cáo
Create proc USP_BaoCao (@MaSP varchar(10))
as
begin
	Select SanPham.MaSP, TenSanPham, GiaBan, SUM(CTHD.SoLuong) as SoLuongBan, SUM(ThanhTien) as ThanhTien
	from SanPham join CTHD on CTHD.MaSP = SanPham.MaSP
	where CTHD.MaSP = @MaSP
	group by SanPham.MaSP, TenSanPham, GiaBan
end
