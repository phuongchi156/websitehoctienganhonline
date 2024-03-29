USE [master]
GO
/****** Object:  Database [TiengAnh]    Script Date: 11/23/2019 9:47:58 AM ******/
CREATE DATABASE [TiengAnh]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TiengAnh', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\TiengAnh.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TiengAnh_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\TiengAnh_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [TiengAnh] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TiengAnh].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TiengAnh] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TiengAnh] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TiengAnh] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TiengAnh] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TiengAnh] SET ARITHABORT OFF 
GO
ALTER DATABASE [TiengAnh] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TiengAnh] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [TiengAnh] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TiengAnh] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TiengAnh] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TiengAnh] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TiengAnh] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TiengAnh] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TiengAnh] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TiengAnh] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TiengAnh] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TiengAnh] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TiengAnh] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TiengAnh] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TiengAnh] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TiengAnh] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TiengAnh] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TiengAnh] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TiengAnh] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TiengAnh] SET  MULTI_USER 
GO
ALTER DATABASE [TiengAnh] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TiengAnh] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TiengAnh] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TiengAnh] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [TiengAnh]
GO
/****** Object:  Table [dbo].[ADMIN]    Script Date: 11/23/2019 9:47:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ADMIN](
	[MaAD] [int] IDENTITY(1,1) NOT NULL,
	[HoTenAD] [nvarchar](50) NULL,
	[ĐiaChiAD] [nvarchar](100) NOT NULL,
	[DienThoaiAD] [nvarchar](10) NULL,
	[TenDNAD] [nvarchar](50) NULL,
	[PassAD] [nvarchar](50) NULL,
	[GioiTinh] [bit] NULL,
	[EmailAD] [nvarchar](50) NULL,
 CONSTRAINT [PK_ADMIN] PRIMARY KEY CLUSTERED 
(
	[MaAD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BaiHoc]    Script Date: 11/23/2019 9:47:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BaiHoc](
	[MaBH] [int] IDENTITY(1,1) NOT NULL,
	[TenBH] [nvarchar](50) NULL,
	[ChuDe] [nvarchar](50) NULL,
	[AnhChuDe] [varchar](250) NULL,
	[NoiDung] [varchar](max) NULL,
	[NoiDungAnh] [varchar](max) NULL,
 CONSTRAINT [PK_BaiHoc] PRIMARY KEY CLUSTERED 
(
	[MaBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CauHoi]    Script Date: 11/23/2019 9:47:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CauHoi](
	[MaCH] [int] IDENTITY(1,1) NOT NULL,
	[CauHoi] [nvarchar](250) NULL,
	[Picture] [image] NULL,
	[A] [nvarchar](50) NULL,
	[B] [nvarchar](50) NULL,
	[C] [nvarchar](50) NULL,
	[D] [nvarchar](50) NULL,
	[DapAn] [nvarchar](50) NULL,
 CONSTRAINT [PK_CauHoi] PRIMARY KEY CLUSTERED 
(
	[MaCH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ch_db]    Script Date: 11/23/2019 9:47:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ch_db](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaCH] [int] NULL,
	[MaDe] [int] NULL,
	[GhiChu] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DeThi]    Script Date: 11/23/2019 9:47:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeThi](
	[MaDe] [int] IDENTITY(1,1) NOT NULL,
	[MoTa] [nchar](500) NULL,
	[SoCauHoi] [int] NULL,
	[TrangThai] [bit] NULL,
	[ThoiGian] [int] NULL,
	[NgayTao] [date] NULL,
 CONSTRAINT [PK_DeThi] PRIMARY KEY CLUSTERED 
(
	[MaDe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 11/23/2019 9:47:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HocSinh](
	[MaHS] [int] IDENTITY(1,1) NOT NULL,
	[TenHS] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[PhuHuynh] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](15) NULL,
	[UserName] [varchar](50) NULL,
	[PassWord] [varchar](50) NULL,
 CONSTRAINT [PK_HocSinh] PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KetQua]    Script Date: 11/23/2019 9:47:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KetQua](
	[MaKQ] [int] IDENTITY(1,1) NOT NULL,
	[MaHS] [int] NULL,
	[NgayThi] [date] NULL,
	[Diem] [float] NULL,
	[MaDe] [int] NULL,
 CONSTRAINT [PK_KetQua] PRIMARY KEY CLUSTERED 
(
	[MaKQ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[ADMIN] ON 

INSERT [dbo].[ADMIN] ([MaAD], [HoTenAD], [ĐiaChiAD], [DienThoaiAD], [TenDNAD], [PassAD], [GioiTinh], [EmailAD]) VALUES (1, N'Hồ Phương Chi', N'Bình Phước', N'0343007508', N'chi', N'chi', 0, N'phuongchiokita@gmail.com')
INSERT [dbo].[ADMIN] ([MaAD], [HoTenAD], [ĐiaChiAD], [DienThoaiAD], [TenDNAD], [PassAD], [GioiTinh], [EmailAD]) VALUES (2, N'Admin', N'AT Home', N'0453567654', N'admin', N'1234', 1, N'admin@gmail.com')
SET IDENTITY_INSERT [dbo].[ADMIN] OFF
SET IDENTITY_INSERT [dbo].[BaiHoc] ON 

INSERT [dbo].[BaiHoc] ([MaBH], [TenBH], [ChuDe], [AnhChuDe], [NoiDung], [NoiDungAnh]) VALUES (1, N'Qua Hình Ảnh', N'Thức Ăn', N'/Content/images/food.jpg', N'/Content/images/food.png', N'/Content/images/food_b.png')
INSERT [dbo].[BaiHoc] ([MaBH], [TenBH], [ChuDe], [AnhChuDe], [NoiDung], [NoiDungAnh]) VALUES (2, N'Qua Hình Ảnh', N'Trái Cây', N'/Content/images/raucu.jpg', N'/Content/images/fruit_2.png', N'/Content/images/fruit_1.png')
INSERT [dbo].[BaiHoc] ([MaBH], [TenBH], [ChuDe], [AnhChuDe], [NoiDung], [NoiDungAnh]) VALUES (3, N'Qua Hình Ảnh', N'Trái Cây(2)', N'/Content/images/raucu.jpg', N'/Content/images/fruit_5.png', N'/Content/images/fruit_4.png')
INSERT [dbo].[BaiHoc] ([MaBH], [TenBH], [ChuDe], [AnhChuDe], [NoiDung], [NoiDungAnh]) VALUES (4, N'Qua Hình Ảnh', N'Động Vật', N'/Content/images/animal.jpg', NULL, N'~\Content\images\animal_2.png;~\Content\images\animal_1.png;~\Content\images\animal_4.png;~\Content\images\animal_3.png')
INSERT [dbo].[BaiHoc] ([MaBH], [TenBH], [ChuDe], [AnhChuDe], [NoiDung], [NoiDungAnh]) VALUES (5, N'Qua Video', N'Cơ Thể Người', N'/Content/images/cothe.jpg', N'
https://alisa.edu.vn/top-10-bai-hat-tieng-anh-cho-tre-em-mau-giao-hay-nhat.html', NULL)
SET IDENTITY_INSERT [dbo].[BaiHoc] OFF
SET IDENTITY_INSERT [dbo].[CauHoi] ON 

INSERT [dbo].[CauHoi] ([MaCH], [CauHoi], [Picture], [A], [B], [C], [D], [DapAn]) VALUES (1, N'Quả táo:', NULL, N'Apple', N'Banana', N'House', N'Sister', N'A')
INSERT [dbo].[CauHoi] ([MaCH], [CauHoi], [Picture], [A], [B], [C], [D], [DapAn]) VALUES (2, N'Mẹ:', NULL, N'Father', N'Honey', N'Morther', N'quest', N'C')
INSERT [dbo].[CauHoi] ([MaCH], [CauHoi], [Picture], [A], [B], [C], [D], [DapAn]) VALUES (3, N'Lion is', NULL, N'Sư tử cái', N'Mèo', N'Chó', N'Sư tử đực', N'D')
INSERT [dbo].[CauHoi] ([MaCH], [CauHoi], [Picture], [A], [B], [C], [D], [DapAn]) VALUES (4, N'Cat is:', NULL, N'Chó', N'Mèo', N'Heo', N'Thỏ', N'B')
INSERT [dbo].[CauHoi] ([MaCH], [CauHoi], [Picture], [A], [B], [C], [D], [DapAn]) VALUES (5, N'Cheese', NULL, N'Mật ong', N'Phô mát', N'Thịt heo', N'Bánh ngọt', N'B')
INSERT [dbo].[CauHoi] ([MaCH], [CauHoi], [Picture], [A], [B], [C], [D], [DapAn]) VALUES (6, N'Bánh ', NULL, N'Honey', N'cake', N'rice', N'dog', N'B')
INSERT [dbo].[CauHoi] ([MaCH], [CauHoi], [Picture], [A], [B], [C], [D], [DapAn]) VALUES (7, N'Happy birthday to you mean?', NULL, N'Xin chào bạn', N'Mình thích bạn', N'Chúc mừng sinh nhật', N'Đi ngủ', N'C')
INSERT [dbo].[CauHoi] ([MaCH], [CauHoi], [Picture], [A], [B], [C], [D], [DapAn]) VALUES (8, N'Goodbye mean:', NULL, N'Tạm biệt', N'Xin chào', N'Cảm ơn', N'Xin lỗi', N'A')
INSERT [dbo].[CauHoi] ([MaCH], [CauHoi], [Picture], [A], [B], [C], [D], [DapAn]) VALUES (9, N'Đi ngủ', NULL, N'Hello', N'Hi', N'go to bed', N'Thanhks', N'C')
INSERT [dbo].[CauHoi] ([MaCH], [CauHoi], [Picture], [A], [B], [C], [D], [DapAn]) VALUES (10, N'Vui vẻ', NULL, N'Sleep', N'Sad', N'unhappy', N'Happy', N'D')
INSERT [dbo].[CauHoi] ([MaCH], [CauHoi], [Picture], [A], [B], [C], [D], [DapAn]) VALUES (11, N'Sleep mean?', NULL, N'Bố', N'Trái cây', N'Hổ', N'Ngủ', N'D')
INSERT [dbo].[CauHoi] ([MaCH], [CauHoi], [Picture], [A], [B], [C], [D], [DapAn]) VALUES (12, N'Rainbow mean?', NULL, N'Cầu vồng', N'Mưa', N'Nắng', N'Táo', N'A')
INSERT [dbo].[CauHoi] ([MaCH], [CauHoi], [Picture], [A], [B], [C], [D], [DapAn]) VALUES (1002, N'Ngôi nhà', 0x, N'Horse', N'House', N'Bed', N'Here', N'B')
SET IDENTITY_INSERT [dbo].[CauHoi] OFF
SET IDENTITY_INSERT [dbo].[ch_db] ON 

INSERT [dbo].[ch_db] ([ID], [MaCH], [MaDe], [GhiChu]) VALUES (1, 3, 1, NULL)
INSERT [dbo].[ch_db] ([ID], [MaCH], [MaDe], [GhiChu]) VALUES (2, 5, 1, NULL)
INSERT [dbo].[ch_db] ([ID], [MaCH], [MaDe], [GhiChu]) VALUES (3, 2, 1, NULL)
INSERT [dbo].[ch_db] ([ID], [MaCH], [MaDe], [GhiChu]) VALUES (4, 6, 1, NULL)
INSERT [dbo].[ch_db] ([ID], [MaCH], [MaDe], [GhiChu]) VALUES (5, 1, 1, NULL)
INSERT [dbo].[ch_db] ([ID], [MaCH], [MaDe], [GhiChu]) VALUES (6, 4, 1, NULL)
INSERT [dbo].[ch_db] ([ID], [MaCH], [MaDe], [GhiChu]) VALUES (7, 7, 1, NULL)
INSERT [dbo].[ch_db] ([ID], [MaCH], [MaDe], [GhiChu]) VALUES (8, 12, 1, NULL)
INSERT [dbo].[ch_db] ([ID], [MaCH], [MaDe], [GhiChu]) VALUES (9, 11, 1, NULL)
INSERT [dbo].[ch_db] ([ID], [MaCH], [MaDe], [GhiChu]) VALUES (10, 9, 1, NULL)
SET IDENTITY_INSERT [dbo].[ch_db] OFF
SET IDENTITY_INSERT [dbo].[DeThi] ON 

INSERT [dbo].[DeThi] ([MaDe], [MoTa], [SoCauHoi], [TrangThai], [ThoiGian], [NgayTao]) VALUES (1, N'Đầu tiên                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            ', 10, 1, 15, CAST(0x683F0B00 AS Date))
INSERT [dbo].[DeThi] ([MaDe], [MoTa], [SoCauHoi], [TrangThai], [ThoiGian], [NgayTao]) VALUES (2, N'Đề Thêm                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             ', 3, NULL, 3, NULL)
SET IDENTITY_INSERT [dbo].[DeThi] OFF
SET IDENTITY_INSERT [dbo].[HocSinh] ON 

INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [PhuHuynh], [DiaChi], [SDT], [UserName], [PassWord]) VALUES (1, N'Nguyễn Mai Anh', CAST(0xF7330B00 AS Date), N'nữ', N'Nguyễn Văn An', N'Bình Dương', N'0347223452', N'anh', N'anh')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [PhuHuynh], [DiaChi], [SDT], [UserName], [PassWord]) VALUES (4, N'Lê Thị Hoa', CAST(0xA3340B00 AS Date), N'nữ', N'Lê Văn Hùng', N'Bình Dương', N'0456768566', N'hoa', N'hoa')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [PhuHuynh], [DiaChi], [SDT], [UserName], [PassWord]) VALUES (5, N'Hà Hoàng Hà', CAST(0xF7330B00 AS Date), N'nam', N'Hà Ngọc Mai', N'Bù Đăng', N'0897564332', N'ha', N'ha')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [PhuHuynh], [DiaChi], [SDT], [UserName], [PassWord]) VALUES (8, N'Hà Thị Hoa', CAST(0xF7330B00 AS Date), N'nữ', N'Hà Thị Mai', N'Bình Dương', N'0897564344', N'user', N'123')
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [NgaySinh], [GioiTinh], [PhuHuynh], [DiaChi], [SDT], [UserName], [PassWord]) VALUES (1008, N'Nguyễn Văn A', CAST(0x82350B00 AS Date), N'nam', N'Nguyễn Văn Hùng', N'Bình Dương', N'0765443432', N'123', N'123')
SET IDENTITY_INSERT [dbo].[HocSinh] OFF
ALTER TABLE [dbo].[ch_db]  WITH CHECK ADD  CONSTRAINT [FK_ch_db_CauHoi] FOREIGN KEY([MaCH])
REFERENCES [dbo].[CauHoi] ([MaCH])
GO
ALTER TABLE [dbo].[ch_db] CHECK CONSTRAINT [FK_ch_db_CauHoi]
GO
ALTER TABLE [dbo].[ch_db]  WITH CHECK ADD  CONSTRAINT [FK_ch_db_DeThi] FOREIGN KEY([MaDe])
REFERENCES [dbo].[DeThi] ([MaDe])
GO
ALTER TABLE [dbo].[ch_db] CHECK CONSTRAINT [FK_ch_db_DeThi]
GO
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD  CONSTRAINT [FK_KetQua_HocSinh] FOREIGN KEY([MaHS])
REFERENCES [dbo].[HocSinh] ([MaHS])
GO
ALTER TABLE [dbo].[KetQua] CHECK CONSTRAINT [FK_KetQua_HocSinh]
GO
USE [master]
GO
ALTER DATABASE [TiengAnh] SET  READ_WRITE 
GO
