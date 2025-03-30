CREATE DATABASE ComputerStoreDB;


USE ComputerStoreDB;


CREATE TABLE LoaiHang (
    MaLoai INT PRIMARY KEY IDENTITY(1,1),
    TenLoai NVARCHAR(100) NOT NULL
);


CREATE TABLE MatHang (
    MaHang INT PRIMARY KEY IDENTITY(1,1),
    TenHang NVARCHAR(100) NOT NULL,
    MaLoai INT,
    SoLuongTon INT NOT NULL CHECK (SoLuongTon >= 0),
    GiaBan DECIMAL(18,2) NOT NULL CHECK (GiaBan >= 0),
    FOREIGN KEY (MaLoai) REFERENCES LoaiHang(MaLoai)
);


CREATE TABLE KhachHang (
    MaKH INT PRIMARY KEY IDENTITY(1,1),
    TenKH NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(200),
    SoDienThoai NVARCHAR(15)
);


CREATE TABLE HoaDon (
    MaHD INT PRIMARY KEY IDENTITY(1,1),
    MaKH INT,
    NgayLap DATE NOT NULL,
    TongTien DECIMAL(18,2) NOT NULL CHECK (TongTien >= 0),
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
);


CREATE TABLE ChiTietHoaDon (
    MaHD INT,
    MaHang INT,
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGia DECIMAL(18,2) NOT NULL CHECK (DonGia >= 0),
    ThanhTien DECIMAL(18,2) NOT NULL CHECK (ThanhTien >= 0),
    PRIMARY KEY (MaHD, MaHang),
    FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD),
    FOREIGN KEY (MaHang) REFERENCES MatHang(MaHang)
);


