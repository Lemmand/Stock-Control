USE [master]
GO
/****** Object:  Database [InventoryManagmentSystem]    Script Date: 10/20/2018 11:47:11 AM ******/
CREATE DATABASE [InventoryManagmentSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'InventoryManagmentSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\InventoryManagmentSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'InventoryManagmentSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\InventoryManagmentSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [InventoryManagmentSystem] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [InventoryManagmentSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [InventoryManagmentSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [InventoryManagmentSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [InventoryManagmentSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [InventoryManagmentSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [InventoryManagmentSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [InventoryManagmentSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [InventoryManagmentSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [InventoryManagmentSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [InventoryManagmentSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [InventoryManagmentSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [InventoryManagmentSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [InventoryManagmentSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [InventoryManagmentSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [InventoryManagmentSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [InventoryManagmentSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [InventoryManagmentSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [InventoryManagmentSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [InventoryManagmentSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [InventoryManagmentSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [InventoryManagmentSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [InventoryManagmentSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [InventoryManagmentSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [InventoryManagmentSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [InventoryManagmentSystem] SET  MULTI_USER 
GO
ALTER DATABASE [InventoryManagmentSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [InventoryManagmentSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [InventoryManagmentSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [InventoryManagmentSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [InventoryManagmentSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [InventoryManagmentSystem] SET QUERY_STORE = OFF
GO
USE [InventoryManagmentSystem]
GO
/****** Object:  Table [dbo].[tbl_contacts]    Script Date: 10/20/2018 11:47:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_contacts](
	[contact_id] [int] IDENTITY(1,1) NOT NULL,
	[contact_fname] [varchar](50) NULL,
	[contact_lname] [varchar](50) NULL,
	[contact_phone] [varchar](50) NULL,
	[contact_email] [varchar](50) NULL,
	[contact_is_supplier] [bit] NULL,
 CONSTRAINT [PK_tbl_contacts] PRIMARY KEY CLUSTERED 
(
	[contact_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_items]    Script Date: 10/20/2018 11:47:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_items](
	[prod_id] [int] NOT NULL,
	[prod_name] [varchar](50) NULL,
	[prod_quantity] [int] NULL,
	[prod_supplier] [int] NULL,
 CONSTRAINT [PK_tbl_items] PRIMARY KEY CLUSTERED 
(
	[prod_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_login]    Script Date: 10/20/2018 11:47:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_login](
	[user_id] [int] NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_login] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_order]    Script Date: 10/20/2018 11:47:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_order](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[order_date] [date] NULL,
 CONSTRAINT [PK_tbl_order] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_order_line]    Script Date: 10/20/2018 11:47:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_order_line](
	[order_id] [int] NOT NULL,
	[order_line] [int] NOT NULL,
	[order_prod] [int] NOT NULL,
	[order_quantity] [int] NOT NULL,
 CONSTRAINT [tbl_order_line_PK] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC,
	[order_line] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_items] ([prod_id], [prod_name], [prod_quantity], [prod_supplier]) VALUES (1, N'Lentils', 20, NULL)
INSERT [dbo].[tbl_items] ([prod_id], [prod_name], [prod_quantity], [prod_supplier]) VALUES (2, N'Shampoo', 50, NULL)
INSERT [dbo].[tbl_items] ([prod_id], [prod_name], [prod_quantity], [prod_supplier]) VALUES (3, N'Rice', 10, NULL)
INSERT [dbo].[tbl_items] ([prod_id], [prod_name], [prod_quantity], [prod_supplier]) VALUES (4, N'Liquor', 15, NULL)
INSERT [dbo].[tbl_items] ([prod_id], [prod_name], [prod_quantity], [prod_supplier]) VALUES (5, N'Kit Kat', 60, NULL)
INSERT [dbo].[tbl_items] ([prod_id], [prod_name], [prod_quantity], [prod_supplier]) VALUES (6, N'Lacta', 55, NULL)
SET IDENTITY_INSERT [dbo].[tbl_order] ON 

INSERT [dbo].[tbl_order] ([order_id], [order_date]) VALUES (1, NULL)
INSERT [dbo].[tbl_order] ([order_id], [order_date]) VALUES (2, NULL)
INSERT [dbo].[tbl_order] ([order_id], [order_date]) VALUES (3, NULL)
INSERT [dbo].[tbl_order] ([order_id], [order_date]) VALUES (4, NULL)
INSERT [dbo].[tbl_order] ([order_id], [order_date]) VALUES (5, NULL)
INSERT [dbo].[tbl_order] ([order_id], [order_date]) VALUES (6, CAST(N'2018-05-05' AS Date))
INSERT [dbo].[tbl_order] ([order_id], [order_date]) VALUES (7, CAST(N'2018-05-05' AS Date))
INSERT [dbo].[tbl_order] ([order_id], [order_date]) VALUES (8, CAST(N'2018-05-05' AS Date))
INSERT [dbo].[tbl_order] ([order_id], [order_date]) VALUES (9, CAST(N'2018-05-05' AS Date))
INSERT [dbo].[tbl_order] ([order_id], [order_date]) VALUES (10, CAST(N'2018-05-05' AS Date))
INSERT [dbo].[tbl_order] ([order_id], [order_date]) VALUES (11, CAST(N'2018-05-05' AS Date))
INSERT [dbo].[tbl_order] ([order_id], [order_date]) VALUES (12, CAST(N'2018-05-05' AS Date))
INSERT [dbo].[tbl_order] ([order_id], [order_date]) VALUES (13, CAST(N'2018-05-05' AS Date))
INSERT [dbo].[tbl_order] ([order_id], [order_date]) VALUES (14, CAST(N'2018-05-05' AS Date))
INSERT [dbo].[tbl_order] ([order_id], [order_date]) VALUES (15, CAST(N'2018-05-05' AS Date))
INSERT [dbo].[tbl_order] ([order_id], [order_date]) VALUES (16, CAST(N'2018-05-05' AS Date))
SET IDENTITY_INSERT [dbo].[tbl_order] OFF
INSERT [dbo].[tbl_order_line] ([order_id], [order_line], [order_prod], [order_quantity]) VALUES (1, 0, 2, 7)
INSERT [dbo].[tbl_order_line] ([order_id], [order_line], [order_prod], [order_quantity]) VALUES (2, 0, 6, 7)
INSERT [dbo].[tbl_order_line] ([order_id], [order_line], [order_prod], [order_quantity]) VALUES (3, 0, 1, 7)
INSERT [dbo].[tbl_order_line] ([order_id], [order_line], [order_prod], [order_quantity]) VALUES (5, 0, 5, 7)
INSERT [dbo].[tbl_order_line] ([order_id], [order_line], [order_prod], [order_quantity]) VALUES (5, 1, 4, 7)
INSERT [dbo].[tbl_order_line] ([order_id], [order_line], [order_prod], [order_quantity]) VALUES (6, 0, 6, 4)
INSERT [dbo].[tbl_order_line] ([order_id], [order_line], [order_prod], [order_quantity]) VALUES (7, 0, 4, 4)
INSERT [dbo].[tbl_order_line] ([order_id], [order_line], [order_prod], [order_quantity]) VALUES (8, 0, 5, 5)
INSERT [dbo].[tbl_order_line] ([order_id], [order_line], [order_prod], [order_quantity]) VALUES (8, 1, 6, 6)
INSERT [dbo].[tbl_order_line] ([order_id], [order_line], [order_prod], [order_quantity]) VALUES (14, 0, 5, 5)
INSERT [dbo].[tbl_order_line] ([order_id], [order_line], [order_prod], [order_quantity]) VALUES (15, 0, 5, 5)
INSERT [dbo].[tbl_order_line] ([order_id], [order_line], [order_prod], [order_quantity]) VALUES (16, 0, 5, 4)
INSERT [dbo].[tbl_order_line] ([order_id], [order_line], [order_prod], [order_quantity]) VALUES (16, 1, 6, 4)
ALTER TABLE [dbo].[tbl_items]  WITH CHECK ADD  CONSTRAINT [FK__tbl_items__prod___68487DD7] FOREIGN KEY([prod_supplier])
REFERENCES [dbo].[tbl_contacts] ([contact_id])
GO
ALTER TABLE [dbo].[tbl_items] CHECK CONSTRAINT [FK__tbl_items__prod___68487DD7]
GO
ALTER TABLE [dbo].[tbl_order_line]  WITH CHECK ADD  CONSTRAINT [tbl_order_line_HEADER_FK] FOREIGN KEY([order_id])
REFERENCES [dbo].[tbl_order] ([order_id])
GO
ALTER TABLE [dbo].[tbl_order_line] CHECK CONSTRAINT [tbl_order_line_HEADER_FK]
GO
/****** Object:  StoredProcedure [dbo].[ProdAdd]    Script Date: 10/20/2018 11:47:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ProdAdd]
@prod_name varchar(50),
@quantity int
AS 
INSERT INTO tbl_items(prod_name,quantity)
VALUES(@prod_name,@quantity)
GO
USE [master]
GO
ALTER DATABASE [InventoryManagmentSystem] SET  READ_WRITE 
GO
