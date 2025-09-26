CREATE DATABASE TiemCatToc; 
GO
USE TiemCatToc;
GO
-- KHÁCH HÀNG
CREATE TABLE KhachHang(
  MaKH INT IDENTITY PRIMARY KEY,
  TenKH NVARCHAR(100) NOT NULL,
  SDT VARCHAR(15) NOT NULL UNIQUE,
  GioiTinh NVARCHAR(10) NULL,
  NgaySinh DATE NULL,
  GhiChu NVARCHAR(200) NULL
);

-- DỊCH VỤ
CREATE TABLE DichVu(
  MaDV INT IDENTITY PRIMARY KEY,
  TenDV NVARCHAR(100) NOT NULL,
  DonGia DECIMAL(18,2) NOT NULL CHECK (DonGia > 0),
  IsActive BIT NOT NULL DEFAULT 1
);

-- NHÂN VIÊN
CREATE TABLE NhanVien(
  MaNV INT IDENTITY PRIMARY KEY,
  TenNV NVARCHAR(100) NOT NULL,
  SDT VARCHAR(15) NULL,
  VaiTro NVARCHAR(50) NULL,   -- Cắt/Gội/Thu ngân...
  TrangThai BIT NOT NULL DEFAULT 1
);

-- LỊCH HẸN
CREATE TABLE LichHen(
  MaLich INT IDENTITY PRIMARY KEY,
  MaKH INT NOT NULL REFERENCES KhachHang(MaKH),
  MaNV INT NOT NULL REFERENCES NhanVien(MaNV),
  MaDV INT NOT NULL REFERENCES DichVu(MaDV),
  Ngay DATE NOT NULL,
  Gio  TIME(0) NOT NULL,       -- 10:30...
  TrangThai NVARCHAR(20) NOT NULL DEFAULT N'Đặt', -- Đặt/Hoàn tất/Hủy
  GhiChu NVARCHAR(200) NULL
);
-- Chống trùng lịch cùng nhân viên cùng thời điểm
CREATE UNIQUE INDEX UX_LichHen_MaNV_Ngay_Gio ON LichHen(MaNV, Ngay, Gio);

-- HÓA ĐƠN
CREATE TABLE HoaDon(
  MaHD INT IDENTITY PRIMARY KEY,
  MaKH INT NOT NULL REFERENCES KhachHang(MaKH),
  NgayLap DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
  GiamGia DECIMAL(5,2) NOT NULL DEFAULT 0 CHECK (GiamGia BETWEEN 0 AND 100),
  Thue    DECIMAL(5,2) NOT NULL DEFAULT 0 CHECK (Thue    BETWEEN 0 AND 100)
);

-- CHI TIẾT HÓA ĐƠN
CREATE TABLE ChiTietHoaDon(
  MaHD INT NOT NULL REFERENCES HoaDon(MaHD) ON DELETE CASCADE,
  MaDV INT NOT NULL REFERENCES DichVu(MaDV),
  SoLuong INT NOT NULL CHECK (SoLuong > 0),
  DonGia  DECIMAL(18,2) NOT NULL CHECK (DonGia >= 0),
  PRIMARY KEY (MaHD, MaDV)
);

-- TÀI KHOẢN
CREATE TABLE dbo.TaiKhoan(
    MaTK INT IDENTITY(1,1) PRIMARY KEY,
    UserName NVARCHAR(50) UNIQUE NOT NULL,
    Password NVARCHAR(50) NOT NULL,   -- mật khẩu lưu thẳng, không hash
    Role NVARCHAR(20) NOT NULL DEFAULT N'NV',
    TrangThai BIT NOT NULL DEFAULT 1
);
CREATE VIEW vw_HoaDonTong AS
SELECT 
  hd.MaHD, hd.MaKH, hd.NgayLap, hd.GiamGia, hd.Thue,
  SUM(ct.SoLuong * ct.DonGia) AS TienHang,
  SUM(ct.SoLuong * ct.DonGia) * (1 - hd.GiamGia/100.0) * (1 + hd.Thue/100.0) AS TongThanhToan
FROM HoaDon hd
LEFT JOIN ChiTietHoaDon ct ON ct.MaHD = hd.MaHD
GROUP BY hd.MaHD, hd.MaKH, hd.NgayLap, hd.GiamGia, hd.Thue;


 
SELECT * FROM vw_HoaDonTong WHERE MaHD = 1;
