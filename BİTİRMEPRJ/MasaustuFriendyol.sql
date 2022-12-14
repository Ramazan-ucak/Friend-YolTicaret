USE [master]
GO
/****** Object:  Database [MasaustuFriendyolDB]    Script Date: 15.09.2022 20:46:52 ******/
CREATE DATABASE [MasaustuFriendyolDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MasaustuFriendyolDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\MasaustuFriendyolDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MasaustuFriendyolDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\MasaustuFriendyolDB_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MasaustuFriendyolDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MasaustuFriendyolDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MasaustuFriendyolDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET  MULTI_USER 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MasaustuFriendyolDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [MasaustuFriendyolDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [MasaustuFriendyolDB]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 15.09.2022 20:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Categories]    Script Date: 15.09.2022 20:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](50) NULL,
	[Status] [bit] NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductImage]    Script Date: 15.09.2022 20:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductImage](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Product_ID] [int] NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
 CONSTRAINT [PK_ProductImage] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 15.09.2022 20:46:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Category_ID] [int] NOT NULL,
	[Brand_ID] [int] NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Stock] [decimal](18, 2) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[ConverImage] [nvarchar](100) NULL,
	[CreationDay] [datetime] NULL,
	[SellStatus] [bit] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Brands] ON 

INSERT [dbo].[Brands] ([ID], [Name], [Status]) VALUES (3, N'Adidas', 1)
INSERT [dbo].[Brands] ([ID], [Name], [Status]) VALUES (4, N'Mavi', 1)
INSERT [dbo].[Brands] ([ID], [Name], [Status]) VALUES (5, N'Yeni Marka', 1)
INSERT [dbo].[Brands] ([ID], [Name], [Status]) VALUES (6, N'', 0)
SET IDENTITY_INSERT [dbo].[Brands] OFF
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([ID], [Name], [Description], [Status]) VALUES (1, N'Giyim1', N'Yazlık kıyafetler', 1)
INSERT [dbo].[Categories] ([ID], [Name], [Description], [Status]) VALUES (4, N'Ayakkabı', N'Yazlık ayakkabı', 0)
INSERT [dbo].[Categories] ([ID], [Name], [Description], [Status]) VALUES (5, N'Erkek Giyim', N'Erkek yazlık kıyafet', 1)
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ID], [Category_ID], [Brand_ID], [Name], [Description], [Stock], [Price], [ConverImage], [CreationDay], [SellStatus]) VALUES (33, 1, 4, N'Pantolon', N's,m,l', CAST(200.00 AS Decimal(18, 2)), CAST(238.00 AS Decimal(18, 2)), N'C:\Users\Ramo\Desktop\SonProjeFoto\GirisYapp1.jpg', CAST(N'2022-09-15 19:04:32.207' AS DateTime), 0)
INSERT [dbo].[Products] ([ID], [Category_ID], [Brand_ID], [Name], [Description], [Stock], [Price], [ConverImage], [CreationDay], [SellStatus]) VALUES (34, 1, 4, N'Kazak', N'Tüm Bedenler', CAST(30.00 AS Decimal(18, 2)), CAST(129.00 AS Decimal(18, 2)), N'C:\Users\Ramo\Desktop\SonProjeFoto\GirisYapp.jpg', CAST(N'2022-09-15 19:07:23.407' AS DateTime), 0)
INSERT [dbo].[Products] ([ID], [Category_ID], [Brand_ID], [Name], [Description], [Stock], [Price], [ConverImage], [CreationDay], [SellStatus]) VALUES (35, 1, 4, N'Tshirt', N'sml', CAST(93.00 AS Decimal(18, 2)), CAST(199.00 AS Decimal(18, 2)), N'C:\Users\Ramo\Desktop\SonProjeFoto\kus1.jpg', CAST(N'2022-09-15 19:11:47.073' AS DateTime), 0)
INSERT [dbo].[Products] ([ID], [Category_ID], [Brand_ID], [Name], [Description], [Stock], [Price], [ConverImage], [CreationDay], [SellStatus]) VALUES (36, 1, 5, N'Montt', N'KışlıkMont', CAST(50.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)), N'C:\Users\Ramo\Desktop\SonProjeFoto\kus1.jpg', CAST(N'2022-09-15 19:13:10.540' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Products] OFF
ALTER TABLE [dbo].[ProductImage]  WITH CHECK ADD  CONSTRAINT [FK_ProductImage_Products] FOREIGN KEY([Product_ID])
REFERENCES [dbo].[Products] ([ID])
GO
ALTER TABLE [dbo].[ProductImage] CHECK CONSTRAINT [FK_ProductImage_Products]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Brands] FOREIGN KEY([Brand_ID])
REFERENCES [dbo].[Brands] ([ID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Brands]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([Category_ID])
REFERENCES [dbo].[Categories] ([ID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
USE [master]
GO
ALTER DATABASE [MasaustuFriendyolDB] SET  READ_WRITE 
GO
