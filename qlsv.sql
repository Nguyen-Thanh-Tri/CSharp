USE [master]
GO
/****** Object:  Database [QLSV]    Script Date: 19/12/2024 19:21:48 ******/
CREATE DATABASE [QLSV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLSV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\QLSV.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLSV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\QLSV_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QLSV] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLSV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLSV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLSV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLSV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLSV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLSV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLSV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLSV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLSV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLSV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLSV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLSV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLSV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLSV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLSV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLSV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLSV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLSV] SET RECOVERY FULL 
GO
ALTER DATABASE [QLSV] SET  MULTI_USER 
GO
ALTER DATABASE [QLSV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLSV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLSV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLSV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLSV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLSV] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLSV', N'ON'
GO
ALTER DATABASE [QLSV] SET QUERY_STORE = ON
GO
ALTER DATABASE [QLSV] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QLSV]
GO
/****** Object:  Table [dbo].[tbl_DangKyMonHoc]    Script Date: 19/12/2024 19:21:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_DangKyMonHoc](
	[sMaSV] [nvarchar](50) NULL,
	[sHovaTen] [nvarchar](50) NULL,
	[sLop] [nvarchar](50) NULL,
	[sMaMonHoc] [varchar](50) NULL,
	[sTenMonHoc] [nvarchar](50) NULL,
	[sMaHocKy] [varchar](11) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Diem]    Script Date: 19/12/2024 19:21:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Diem](
	[sMaSV] [nvarchar](50) NULL,
	[sHovaTen] [nvarchar](50) NULL,
	[sLop] [nvarchar](50) NULL,
	[sDiemCC] [int] NULL,
	[sDiemBT] [float] NULL,
	[sDiemGK] [float] NULL,
	[sDiemCK] [float] NULL,
	[sDiemTB] [decimal](4, 1) NULL,
	[sMaGiangVien] [nvarchar](50) NULL,
	[sMaHocKy] [varchar](11) NULL,
	[sMaMH] [varchar](50) NULL,
	[sTenMH] [nvarchar](50) NULL,
	[deleted_at] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_GiangVien]    Script Date: 19/12/2024 19:21:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_GiangVien](
	[PK_sMaGiangVien] [nvarchar](50) NOT NULL,
	[sTenGiangVien] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_GiangVien] PRIMARY KEY CLUSTERED 
(
	[PK_sMaGiangVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_HocKy]    Script Date: 19/12/2024 19:21:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_HocKy](
	[PK_sMaHocKy] [varchar](11) NOT NULL,
	[sHocKy] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_HocKy] PRIMARY KEY CLUSTERED 
(
	[PK_sMaHocKy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Khoa]    Script Date: 19/12/2024 19:21:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Khoa](
	[PK_sMaKhoa] [varchar](50) NOT NULL,
	[sTenKhoa] [nvarchar](max) NULL,
	[deleted_at] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_Khoa1] PRIMARY KEY CLUSTERED 
(
	[PK_sMaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Lop]    Script Date: 19/12/2024 19:21:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Lop](
	[PK_sMaLop] [nvarchar](50) NOT NULL,
	[sTenLop] [nvarchar](50) NULL,
	[sKhoa] [varchar](50) NULL,
	[sGiangVien] [nvarchar](50) NULL,
	[deleted_at] [nchar](10) NULL,
 CONSTRAINT [PK_tbl_Lop] PRIMARY KEY CLUSTERED 
(
	[PK_sMaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_MonHoc]    Script Date: 19/12/2024 19:21:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_MonHoc](
	[PK_sMaMonHoc] [varchar](50) NOT NULL,
	[sTenMonHoc] [nvarchar](50) NULL,
	[sMaGiangVien] [nvarchar](50) NULL,
	[sTenGiangVien] [nvarchar](50) NULL,
	[deleted_at] [datetime] NULL,
 CONSTRAINT [PK_tbl_MonHoc] PRIMARY KEY CLUSTERED 
(
	[PK_sMaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Role]    Script Date: 19/12/2024 19:21:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Role](
	[iRole] [int] NOT NULL,
	[sRoleName] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_SinhVien]    Script Date: 19/12/2024 19:21:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_SinhVien](
	[PK_sMaSv] [nvarchar](50) NOT NULL,
	[sHovaTen] [nvarchar](50) NULL,
	[sGioiTinh] [bit] NULL,
	[sNgaySinh] [datetime] NULL,
	[sLop] [nvarchar](50) NULL,
	[sKhoa] [nvarchar](50) NULL,
	[sSoDienThoai] [nvarchar](50) NULL,
	[sDiaChi] [nvarchar](50) NULL,
	[created_at] [datetime] NULL,
	[updated_at] [datetime] NULL,
	[deleted_at] [datetime] NULL,
 CONSTRAINT [PK_tbl_SinhVien] PRIMARY KEY CLUSTERED 
(
	[PK_sMaSv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_taikhoan]    Script Date: 19/12/2024 19:21:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_taikhoan](
	[sNameAccount] [nvarchar](50) NULL,
	[sUserName] [nvarchar](50) NOT NULL,
	[sPassWord] [nvarchar](100) NULL,
	[FK_iRole] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_DangKyMonHoc] ([sMaSV], [sHovaTen], [sLop], [sMaMonHoc], [sTenMonHoc], [sMaHocKy]) VALUES (N'3', N'Nhật Minh', N'345', N'T1', N'Toán 1', N'HK6')
INSERT [dbo].[tbl_DangKyMonHoc] ([sMaSV], [sHovaTen], [sLop], [sMaMonHoc], [sTenMonHoc], [sMaHocKy]) VALUES (N'2', N'Nguyễn Thanh Trí', N'21PFIEV3', N'T3', N'Toán 3', N'HK6')
INSERT [dbo].[tbl_DangKyMonHoc] ([sMaSV], [sHovaTen], [sLop], [sMaMonHoc], [sTenMonHoc], [sMaHocKy]) VALUES (N'1', N'Khoa Đẹp Trai', N'21PFIEV', N'T1', N'Toán 1', N'HK3 ')
INSERT [dbo].[tbl_DangKyMonHoc] ([sMaSV], [sHovaTen], [sLop], [sMaMonHoc], [sTenMonHoc], [sMaHocKy]) VALUES (N'3', N'Nhật Minh', N'345', N'T1', N'Toán 1', N'HK3 ')
GO
INSERT [dbo].[tbl_Diem] ([sMaSV], [sHovaTen], [sLop], [sDiemCC], [sDiemBT], [sDiemGK], [sDiemCK], [sDiemTB], [sMaGiangVien], [sMaHocKy], [sMaMH], [sTenMH], [deleted_at]) VALUES (N'3', N'Nhật Minh', N'345', NULL, NULL, NULL, NULL, NULL, N'KHANG_1', N'HK3 ', N'T4', N'Toán 4', NULL)
INSERT [dbo].[tbl_Diem] ([sMaSV], [sHovaTen], [sLop], [sDiemCC], [sDiemBT], [sDiemGK], [sDiemCK], [sDiemTB], [sMaGiangVien], [sMaHocKy], [sMaMH], [sTenMH], [deleted_at]) VALUES (N'2', N'Nguyễn Thanh Trí', N'21PFIEV3', NULL, NULL, NULL, NULL, NULL, N'KHANG_1', N'HK2', N'T4', N'Toán 4', NULL)
INSERT [dbo].[tbl_Diem] ([sMaSV], [sHovaTen], [sLop], [sDiemCC], [sDiemBT], [sDiemGK], [sDiemCK], [sDiemTB], [sMaGiangVien], [sMaHocKy], [sMaMH], [sTenMH], [deleted_at]) VALUES (N'1', N'Khoa Đẹp Trai', N'21PFIEV', NULL, NULL, NULL, NULL, NULL, N'TU_1', N'HK4', N'T1', N'Toán 1', NULL)
INSERT [dbo].[tbl_Diem] ([sMaSV], [sHovaTen], [sLop], [sDiemCC], [sDiemBT], [sDiemGK], [sDiemCK], [sDiemTB], [sMaGiangVien], [sMaHocKy], [sMaMH], [sTenMH], [deleted_at]) VALUES (N'3', N'Nhật Minh', N'345', 7, 7, 7, 7, CAST(7.0 AS Decimal(4, 1)), N'TU_1', N'HK5', N'T3', N'Toán 3', NULL)
INSERT [dbo].[tbl_Diem] ([sMaSV], [sHovaTen], [sLop], [sDiemCC], [sDiemBT], [sDiemGK], [sDiemCK], [sDiemTB], [sMaGiangVien], [sMaHocKy], [sMaMH], [sTenMH], [deleted_at]) VALUES (N'2', N'Nguyễn Thanh Trí', N'21PFIEV3', 8, 7, 7, 9, CAST(8.1 AS Decimal(4, 1)), N'TU_1', N'HK5', N'T3', N'Toán 3', NULL)
INSERT [dbo].[tbl_Diem] ([sMaSV], [sHovaTen], [sLop], [sDiemCC], [sDiemBT], [sDiemGK], [sDiemCK], [sDiemTB], [sMaGiangVien], [sMaHocKy], [sMaMH], [sTenMH], [deleted_at]) VALUES (N'1', N'Khoa Đẹp Trai', N'21PFIEV', NULL, NULL, NULL, NULL, NULL, N'TU_1', N'HK5', N'T1', N'Toán 1', NULL)
INSERT [dbo].[tbl_Diem] ([sMaSV], [sHovaTen], [sLop], [sDiemCC], [sDiemBT], [sDiemGK], [sDiemCK], [sDiemTB], [sMaGiangVien], [sMaHocKy], [sMaMH], [sTenMH], [deleted_at]) VALUES (N'1', N'Khoa Đẹp Trai', N'21PFIEV', 5, 5, 5, 5, CAST(5.0 AS Decimal(4, 1)), N'TU_1', N'HK5', N'T3', N'Toán 3', NULL)
GO
INSERT [dbo].[tbl_GiangVien] ([PK_sMaGiangVien], [sTenGiangVien]) VALUES (N'KHANG_1', N'Bùi Tuấn Khang')
INSERT [dbo].[tbl_GiangVien] ([PK_sMaGiangVien], [sTenGiangVien]) VALUES (N'TAO_1', N'Phan Thanh Tao')
INSERT [dbo].[tbl_GiangVien] ([PK_sMaGiangVien], [sTenGiangVien]) VALUES (N'TU_1', N'Nguyễn Chánh Tú')
GO
INSERT [dbo].[tbl_HocKy] ([PK_sMaHocKy], [sHocKy]) VALUES (N'HK1', N'Học kỳ 1')
INSERT [dbo].[tbl_HocKy] ([PK_sMaHocKy], [sHocKy]) VALUES (N'HK2', N'Học kỳ 2')
INSERT [dbo].[tbl_HocKy] ([PK_sMaHocKy], [sHocKy]) VALUES (N'HK3 ', N'Học kỳ 3')
INSERT [dbo].[tbl_HocKy] ([PK_sMaHocKy], [sHocKy]) VALUES (N'HK4', N'Học kỳ  4')
INSERT [dbo].[tbl_HocKy] ([PK_sMaHocKy], [sHocKy]) VALUES (N'HK5', N'Học kỳ 5')
INSERT [dbo].[tbl_HocKy] ([PK_sMaHocKy], [sHocKy]) VALUES (N'HK6', N'Học kỳ 6')
GO
INSERT [dbo].[tbl_Khoa] ([PK_sMaKhoa], [sTenKhoa], [deleted_at]) VALUES (N'CNTT', N'Công nghệ thông tin', NULL)
INSERT [dbo].[tbl_Khoa] ([PK_sMaKhoa], [sTenKhoa], [deleted_at]) VALUES (N'DIEN', N'Điện', NULL)
INSERT [dbo].[tbl_Khoa] ([PK_sMaKhoa], [sTenKhoa], [deleted_at]) VALUES (N'FAST', N'Công nghệ tiên tiến', NULL)
INSERT [dbo].[tbl_Khoa] ([PK_sMaKhoa], [sTenKhoa], [deleted_at]) VALUES (N'HOA', N'Hóa', NULL)
INSERT [dbo].[tbl_Khoa] ([PK_sMaKhoa], [sTenKhoa], [deleted_at]) VALUES (N'KT', N'Kiến trúc', NULL)
INSERT [dbo].[tbl_Khoa] ([PK_sMaKhoa], [sTenKhoa], [deleted_at]) VALUES (N'XD', N'Xây dựng', N'Dec 10 2024  2:49PM')
GO
INSERT [dbo].[tbl_Lop] ([PK_sMaLop], [sTenLop], [sKhoa], [sGiangVien], [deleted_at]) VALUES (N'21N89', N'21PFIEV3', N'CNTT', N'KHANG_1', NULL)
INSERT [dbo].[tbl_Lop] ([PK_sMaLop], [sTenLop], [sKhoa], [sGiangVien], [deleted_at]) VALUES (N'cntt', N'it', N'CNTT', N'TAO_1', N'Dec 10 202')
GO
INSERT [dbo].[tbl_MonHoc] ([PK_sMaMonHoc], [sTenMonHoc], [sMaGiangVien], [sTenGiangVien], [deleted_at]) VALUES (N'T1', N'Toán 1', N'TU_1', N'Nguyễn Chánh Tú', NULL)
INSERT [dbo].[tbl_MonHoc] ([PK_sMaMonHoc], [sTenMonHoc], [sMaGiangVien], [sTenGiangVien], [deleted_at]) VALUES (N'T2', N'Toán 2', N'KHANG_1', N'Bùi Tuấn Khang', NULL)
INSERT [dbo].[tbl_MonHoc] ([PK_sMaMonHoc], [sTenMonHoc], [sMaGiangVien], [sTenGiangVien], [deleted_at]) VALUES (N'T3', N'Toán 3', N'TU_1', N'Nguyễn Chánh Tú', NULL)
INSERT [dbo].[tbl_MonHoc] ([PK_sMaMonHoc], [sTenMonHoc], [sMaGiangVien], [sTenGiangVien], [deleted_at]) VALUES (N'T4', N'Toán 4', N'KHANG_1', N'Bùi Tuấn Khang', NULL)
GO
INSERT [dbo].[tbl_Role] ([iRole], [sRoleName]) VALUES (1, N'admin')
INSERT [dbo].[tbl_Role] ([iRole], [sRoleName]) VALUES (2, N'user')
GO
INSERT [dbo].[tbl_SinhVien] ([PK_sMaSv], [sHovaTen], [sGioiTinh], [sNgaySinh], [sLop], [sKhoa], [sSoDienThoai], [sDiaChi], [created_at], [updated_at], [deleted_at]) VALUES (N'1', N'Khoa Đẹp Trai', 1, CAST(N'2024-10-05T00:00:00.000' AS DateTime), N'21PFIEV', N'FAST', N'05080808008', N'San Fran Xích Long', CAST(N'2024-10-06T18:06:03.697' AS DateTime), CAST(N'2024-10-09T12:54:18.833' AS DateTime), NULL)
INSERT [dbo].[tbl_SinhVien] ([PK_sMaSv], [sHovaTen], [sGioiTinh], [sNgaySinh], [sLop], [sKhoa], [sSoDienThoai], [sDiaChi], [created_at], [updated_at], [deleted_at]) VALUES (N'2', N'Nguyễn Thanh Trí', 1, CAST(N'2024-10-06T00:00:00.000' AS DateTime), N'21PFIEV3', N'FAST', N'0702416518', N'Việt Nam', CAST(N'2024-10-06T19:28:34.400' AS DateTime), CAST(N'2024-10-06T22:19:18.710' AS DateTime), NULL)
INSERT [dbo].[tbl_SinhVien] ([PK_sMaSv], [sHovaTen], [sGioiTinh], [sNgaySinh], [sLop], [sKhoa], [sSoDienThoai], [sDiaChi], [created_at], [updated_at], [deleted_at]) VALUES (N'3', N'Nhật Minh', 1, CAST(N'2024-10-06T00:00:00.000' AS DateTime), N'345', N'hehe', N'0987654321', N'an dộ', CAST(N'2024-10-06T20:06:29.250' AS DateTime), CAST(N'2024-10-07T14:38:03.717' AS DateTime), NULL)
INSERT [dbo].[tbl_SinhVien] ([PK_sMaSv], [sHovaTen], [sGioiTinh], [sNgaySinh], [sLop], [sKhoa], [sSoDienThoai], [sDiaChi], [created_at], [updated_at], [deleted_at]) VALUES (N'7', N'none', 0, CAST(N'2024-09-30T00:00:00.000' AS DateTime), N'9', N'10', N'8', N'hee', CAST(N'2024-10-06T21:00:48.010' AS DateTime), NULL, CAST(N'2024-10-06T22:39:41.690' AS DateTime))
GO
INSERT [dbo].[tbl_taikhoan] ([sNameAccount], [sUserName], [sPassWord], [FK_iRole]) VALUES (N'1', N'admin', N'admin', 1)
INSERT [dbo].[tbl_taikhoan] ([sNameAccount], [sUserName], [sPassWord], [FK_iRole]) VALUES (N'2', N'KHANG_1', N'2', 2)
INSERT [dbo].[tbl_taikhoan] ([sNameAccount], [sUserName], [sPassWord], [FK_iRole]) VALUES (N'3', N'TAO_1', N'2', 2)
INSERT [dbo].[tbl_taikhoan] ([sNameAccount], [sUserName], [sPassWord], [FK_iRole]) VALUES (N'4', N'TU_1', N'2', 2)
INSERT [dbo].[tbl_taikhoan] ([sNameAccount], [sUserName], [sPassWord], [FK_iRole]) VALUES (NULL, N'admin1', N'admin', 2)
GO
ALTER TABLE [dbo].[tbl_DangKyMonHoc]  WITH CHECK ADD  CONSTRAINT [FK_tbl_DangKyMonHoc_tbl_HocKy] FOREIGN KEY([sMaHocKy])
REFERENCES [dbo].[tbl_HocKy] ([PK_sMaHocKy])
GO
ALTER TABLE [dbo].[tbl_DangKyMonHoc] CHECK CONSTRAINT [FK_tbl_DangKyMonHoc_tbl_HocKy]
GO
ALTER TABLE [dbo].[tbl_DangKyMonHoc]  WITH CHECK ADD  CONSTRAINT [FK_tbl_DangKyMonHoc_tbl_MonHoc] FOREIGN KEY([sMaMonHoc])
REFERENCES [dbo].[tbl_MonHoc] ([PK_sMaMonHoc])
GO
ALTER TABLE [dbo].[tbl_DangKyMonHoc] CHECK CONSTRAINT [FK_tbl_DangKyMonHoc_tbl_MonHoc]
GO
ALTER TABLE [dbo].[tbl_DangKyMonHoc]  WITH CHECK ADD  CONSTRAINT [FK_tbl_DangKyMonHoc_tbl_SinhVien] FOREIGN KEY([sMaSV])
REFERENCES [dbo].[tbl_SinhVien] ([PK_sMaSv])
GO
ALTER TABLE [dbo].[tbl_DangKyMonHoc] CHECK CONSTRAINT [FK_tbl_DangKyMonHoc_tbl_SinhVien]
GO
ALTER TABLE [dbo].[tbl_Diem]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Diem_tbl_MaGV] FOREIGN KEY([sMaGiangVien])
REFERENCES [dbo].[tbl_GiangVien] ([PK_sMaGiangVien])
GO
ALTER TABLE [dbo].[tbl_Diem] CHECK CONSTRAINT [FK_tbl_Diem_tbl_MaGV]
GO
ALTER TABLE [dbo].[tbl_Diem]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Diem_tbl_MaHK] FOREIGN KEY([sMaHocKy])
REFERENCES [dbo].[tbl_HocKy] ([PK_sMaHocKy])
GO
ALTER TABLE [dbo].[tbl_Diem] CHECK CONSTRAINT [FK_tbl_Diem_tbl_MaHK]
GO
ALTER TABLE [dbo].[tbl_Lop]  WITH CHECK ADD  CONSTRAINT [FK_tbl_GiangVien_tbl_Lop] FOREIGN KEY([sGiangVien])
REFERENCES [dbo].[tbl_GiangVien] ([PK_sMaGiangVien])
GO
ALTER TABLE [dbo].[tbl_Lop] CHECK CONSTRAINT [FK_tbl_GiangVien_tbl_Lop]
GO
ALTER TABLE [dbo].[tbl_Lop]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Khoa_tbl_Lop] FOREIGN KEY([sKhoa])
REFERENCES [dbo].[tbl_Khoa] ([PK_sMaKhoa])
GO
ALTER TABLE [dbo].[tbl_Lop] CHECK CONSTRAINT [FK_tbl_Khoa_tbl_Lop]
GO
ALTER TABLE [dbo].[tbl_MonHoc]  WITH CHECK ADD  CONSTRAINT [FK_sMaGiangVien] FOREIGN KEY([sMaGiangVien])
REFERENCES [dbo].[tbl_GiangVien] ([PK_sMaGiangVien])
GO
ALTER TABLE [dbo].[tbl_MonHoc] CHECK CONSTRAINT [FK_sMaGiangVien]
GO
/****** Object:  StoredProcedure [dbo].[proc_login]    Script Date: 19/12/2024 19:21:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_login]
@username varchar(50),
@password varchar(50)
as
BEGIN
SELECT * FROM tbl_taikhoan WHERE sUserName =@username AND sPassWord = @password
END
GO
USE [master]
GO
ALTER DATABASE [QLSV] SET  READ_WRITE 
GO
