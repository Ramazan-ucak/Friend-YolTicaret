USE [master]
GO
/****** Object:  Database [BitirmeBanka]    Script Date: 15.09.2022 20:42:59 ******/
CREATE DATABASE [BitirmeBanka]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BitirmeBanka', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BitirmeBanka.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BitirmeBanka_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\BitirmeBanka_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BitirmeBanka] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BitirmeBanka].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BitirmeBanka] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BitirmeBanka] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BitirmeBanka] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BitirmeBanka] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BitirmeBanka] SET ARITHABORT OFF 
GO
ALTER DATABASE [BitirmeBanka] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BitirmeBanka] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BitirmeBanka] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BitirmeBanka] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BitirmeBanka] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BitirmeBanka] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BitirmeBanka] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BitirmeBanka] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BitirmeBanka] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BitirmeBanka] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BitirmeBanka] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BitirmeBanka] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BitirmeBanka] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BitirmeBanka] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BitirmeBanka] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BitirmeBanka] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BitirmeBanka] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BitirmeBanka] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BitirmeBanka] SET  MULTI_USER 
GO
ALTER DATABASE [BitirmeBanka] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BitirmeBanka] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BitirmeBanka] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BitirmeBanka] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BitirmeBanka] SET DELAYED_DURABILITY = DISABLED 
GO
USE [BitirmeBanka]
GO
/****** Object:  Table [dbo].[MusteriHesaplar]    Script Date: 15.09.2022 20:42:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriHesaplar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Musteri_ID] [int] NULL,
	[KartNumarasi] [nvarchar](16) NULL,
	[SonKullanmaAy] [int] NULL,
	[SonKullanmaYil] [int] NULL,
	[CVV] [int] NULL,
	[Bakiye] [decimal](18, 2) NULL,
 CONSTRAINT [PK_MusteriHesaplar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Musteriler]    Script Date: 15.09.2022 20:42:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteriler](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Isim] [nvarchar](50) NULL,
	[Soyisim] [nvarchar](50) NULL,
	[Telefon] [nchar](11) NULL,
 CONSTRAINT [PK_Musteriler] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanalPosMusteri]    Script Date: 15.09.2022 20:42:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanalPosMusteri](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Isim] [nvarchar](50) NULL,
	[SaticiNo] [nvarchar](10) NULL,
	[SaticiSifre] [nvarchar](10) NULL,
	[Bakiye] [decimal](18, 2) NULL,
	[Durum] [bit] NULL,
 CONSTRAINT [PK_SanalPosMusteri] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[MusteriHesaplar] ON 

INSERT [dbo].[MusteriHesaplar] ([ID], [Musteri_ID], [KartNumarasi], [SonKullanmaAy], [SonKullanmaYil], [CVV], [Bakiye]) VALUES (1, 1, N'1234567891234567', 5, 2025, 654, CAST(5253.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[MusteriHesaplar] OFF
SET IDENTITY_INSERT [dbo].[Musteriler] ON 

INSERT [dbo].[Musteriler] ([ID], [Isim], [Soyisim], [Telefon]) VALUES (1, N'Ali', N'Veli', N'05070029662')
SET IDENTITY_INSERT [dbo].[Musteriler] OFF
SET IDENTITY_INSERT [dbo].[SanalPosMusteri] ON 

INSERT [dbo].[SanalPosMusteri] ([ID], [Isim], [SaticiNo], [SaticiSifre], [Bakiye], [Durum]) VALUES (1, N'Friendyol', N'1234567', N'1234', CAST(124747.00 AS Decimal(18, 2)), 1)
SET IDENTITY_INSERT [dbo].[SanalPosMusteri] OFF
ALTER TABLE [dbo].[MusteriHesaplar]  WITH CHECK ADD  CONSTRAINT [FK_MusteriHesaplar_Musteriler] FOREIGN KEY([Musteri_ID])
REFERENCES [dbo].[Musteriler] ([ID])
GO
ALTER TABLE [dbo].[MusteriHesaplar] CHECK CONSTRAINT [FK_MusteriHesaplar_Musteriler]
GO
USE [master]
GO
ALTER DATABASE [BitirmeBanka] SET  READ_WRITE 
GO
