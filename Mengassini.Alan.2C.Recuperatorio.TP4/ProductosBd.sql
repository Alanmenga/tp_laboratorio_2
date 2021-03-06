USE [master]
GO
/****** Object:  Database [ProductosSupermercado]    Script Date: 7/12/2020 02:38:26 ******/
CREATE DATABASE [ProductosSupermercado]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProductosSupermercado', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ProductosSupermercado.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProductosSupermercado_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ProductosSupermercado_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ProductosSupermercado] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProductosSupermercado].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProductosSupermercado] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProductosSupermercado] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProductosSupermercado] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProductosSupermercado] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProductosSupermercado] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProductosSupermercado] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProductosSupermercado] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProductosSupermercado] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProductosSupermercado] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProductosSupermercado] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProductosSupermercado] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProductosSupermercado] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProductosSupermercado] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProductosSupermercado] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProductosSupermercado] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProductosSupermercado] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProductosSupermercado] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProductosSupermercado] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProductosSupermercado] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProductosSupermercado] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProductosSupermercado] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProductosSupermercado] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProductosSupermercado] SET RECOVERY FULL 
GO
ALTER DATABASE [ProductosSupermercado] SET  MULTI_USER 
GO
ALTER DATABASE [ProductosSupermercado] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProductosSupermercado] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProductosSupermercado] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProductosSupermercado] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProductosSupermercado] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProductosSupermercado] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProductosSupermercado', N'ON'
GO
ALTER DATABASE [ProductosSupermercado] SET QUERY_STORE = OFF
GO
USE [ProductosSupermercado]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 7/12/2020 02:38:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[id] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Productos] ([id], [nombre]) VALUES (1, N'Coca Cola')
INSERT [dbo].[Productos] ([id], [nombre]) VALUES (2, N'Fanta')
INSERT [dbo].[Productos] ([id], [nombre]) VALUES (8, N'alankpo')
INSERT [dbo].[Productos] ([id], [nombre]) VALUES (12, N'alang')
INSERT [dbo].[Productos] ([id], [nombre]) VALUES (13, N'alanga')
INSERT [dbo].[Productos] ([id], [nombre]) VALUES (15, N'asdkjasdkjlasd')
INSERT [dbo].[Productos] ([id], [nombre]) VALUES (20, N'desodorante')
INSERT [dbo].[Productos] ([id], [nombre]) VALUES (21, N'shampoo')
INSERT [dbo].[Productos] ([id], [nombre]) VALUES (22, N'cocacola')
INSERT [dbo].[Productos] ([id], [nombre]) VALUES (23, N'galletitas')
INSERT [dbo].[Productos] ([id], [nombre]) VALUES (24, N'fideos')
INSERT [dbo].[Productos] ([id], [nombre]) VALUES (25, N'leche')
INSERT [dbo].[Productos] ([id], [nombre]) VALUES (26, N'carne')
INSERT [dbo].[Productos] ([id], [nombre]) VALUES (55, N'desodorante')
INSERT [dbo].[Productos] ([id], [nombre]) VALUES (108, N'alankpo')
INSERT [dbo].[Productos] ([id], [nombre]) VALUES (12345, N'desodorante')
INSERT [dbo].[Productos] ([id], [nombre]) VALUES (12346, N'shampoo')
INSERT [dbo].[Productos] ([id], [nombre]) VALUES (12347, N'cocacola')
INSERT [dbo].[Productos] ([id], [nombre]) VALUES (12348, N'galletitas')
INSERT [dbo].[Productos] ([id], [nombre]) VALUES (12349, N'fideos')
INSERT [dbo].[Productos] ([id], [nombre]) VALUES (12350, N'leche')
INSERT [dbo].[Productos] ([id], [nombre]) VALUES (12351, N'carne')
INSERT [dbo].[Productos] ([id], [nombre]) VALUES (123456, N'alan')
GO
USE [master]
GO
ALTER DATABASE [ProductosSupermercado] SET  READ_WRITE 
GO
