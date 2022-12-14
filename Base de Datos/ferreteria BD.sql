USE [master]
GO
/****** Object:  Database [Ferreteria]    Script Date: 8/12/2022 10:17:07 ******/
CREATE DATABASE [Ferreteria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Ferreteria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL\MSSQL\DATA\Ferreteria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Ferreteria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL\MSSQL\DATA\Ferreteria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Ferreteria] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Ferreteria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Ferreteria] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Ferreteria] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Ferreteria] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Ferreteria] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Ferreteria] SET ARITHABORT OFF 
GO
ALTER DATABASE [Ferreteria] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Ferreteria] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Ferreteria] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Ferreteria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Ferreteria] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Ferreteria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Ferreteria] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Ferreteria] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Ferreteria] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Ferreteria] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Ferreteria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Ferreteria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Ferreteria] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Ferreteria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Ferreteria] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Ferreteria] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Ferreteria] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Ferreteria] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Ferreteria] SET  MULTI_USER 
GO
ALTER DATABASE [Ferreteria] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Ferreteria] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Ferreteria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Ferreteria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Ferreteria] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Ferreteria] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Ferreteria] SET QUERY_STORE = OFF
GO
USE [Ferreteria]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 8/12/2022 10:17:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[id_categoria] [int] NOT NULL,
	[nom_categoria] [varchar](50) NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ciudad]    Script Date: 8/12/2022 10:17:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudad](
	[id_ciudad] [int] NOT NULL,
	[nom_ciudad] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Ciudad] PRIMARY KEY CLUSTERED 
(
	[id_ciudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 8/12/2022 10:17:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[id_cliente] [int] NOT NULL,
	[nom_cliente] [varchar](60) NULL,
	[id_ciudad] [int] NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_ordenes]    Script Date: 8/12/2022 10:17:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_ordenes](
	[id_orden] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[cantidad] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 8/12/2022 10:17:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[id_empleado] [int] NOT NULL,
	[nom_empleado] [varchar](60) NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ordenes]    Script Date: 8/12/2022 10:17:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ordenes](
	[id_orden] [int] NOT NULL,
	[fecha] [date] NULL,
	[id_cliente] [int] NOT NULL,
	[id_empleado] [int] NOT NULL,
 CONSTRAINT [PK_Ordenes] PRIMARY KEY CLUSTERED 
(
	[id_orden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 8/12/2022 10:17:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[id_producto] [int] NOT NULL,
	[nom_producto] [varchar](50) NULL,
	[precio] [decimal](18, 2) NULL,
	[id_proveedor] [int] NOT NULL,
	[id_categoria] [int] NOT NULL,
	[existencia] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 8/12/2022 10:17:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[id_proveedor] [int] NOT NULL,
	[nom_proveedor] [varchar](60) NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Categoria] ([id_categoria], [nom_categoria]) VALUES (1, N'Ceramicas')
INSERT [dbo].[Categoria] ([id_categoria], [nom_categoria]) VALUES (2, N'Electricidad')
INSERT [dbo].[Categoria] ([id_categoria], [nom_categoria]) VALUES (3, N'Fontaneria')
INSERT [dbo].[Categoria] ([id_categoria], [nom_categoria]) VALUES (4, N'Madera')
INSERT [dbo].[Categoria] ([id_categoria], [nom_categoria]) VALUES (5, N'Pintura')
INSERT [dbo].[Categoria] ([id_categoria], [nom_categoria]) VALUES (6, N'Herramientas')
INSERT [dbo].[Categoria] ([id_categoria], [nom_categoria]) VALUES (7, N'Techos')
INSERT [dbo].[Categoria] ([id_categoria], [nom_categoria]) VALUES (8, N'Puertas')
INSERT [dbo].[Categoria] ([id_categoria], [nom_categoria]) VALUES (9, N'Automotriz')
INSERT [dbo].[Categoria] ([id_categoria], [nom_categoria]) VALUES (10, N'Jardineria')
GO
INSERT [dbo].[Ciudad] ([id_ciudad], [nom_ciudad]) VALUES (1, N'La Ceiba')
INSERT [dbo].[Ciudad] ([id_ciudad], [nom_ciudad]) VALUES (2, N'San Pedro Sula')
INSERT [dbo].[Ciudad] ([id_ciudad], [nom_ciudad]) VALUES (3, N'Tela')
INSERT [dbo].[Ciudad] ([id_ciudad], [nom_ciudad]) VALUES (4, N'El Porvenir')
INSERT [dbo].[Ciudad] ([id_ciudad], [nom_ciudad]) VALUES (5, N'Tegucigalpa')
INSERT [dbo].[Ciudad] ([id_ciudad], [nom_ciudad]) VALUES (6, N'Comayagua')
INSERT [dbo].[Ciudad] ([id_ciudad], [nom_ciudad]) VALUES (7, N'Choluteca')
INSERT [dbo].[Ciudad] ([id_ciudad], [nom_ciudad]) VALUES (8, N'Danli')
INSERT [dbo].[Ciudad] ([id_ciudad], [nom_ciudad]) VALUES (9, N'Catacamas')
INSERT [dbo].[Ciudad] ([id_ciudad], [nom_ciudad]) VALUES (10, N'La Paz')
GO
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [id_ciudad]) VALUES (1, N'Fabian', 1)
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [id_ciudad]) VALUES (2, N' David ', 1)
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [id_ciudad]) VALUES (3, N' Juan ', 1)
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [id_ciudad]) VALUES (4, N' Daniel ', 2)
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [id_ciudad]) VALUES (5, N' Sofia ', 5)
INSERT [dbo].[Clientes] ([id_cliente], [nom_cliente], [id_ciudad]) VALUES (6, N' Johan ', 7)
GO
INSERT [dbo].[detalle_ordenes] ([id_orden], [id_producto], [cantidad]) VALUES (1, 2, 5)
INSERT [dbo].[detalle_ordenes] ([id_orden], [id_producto], [cantidad]) VALUES (2, 1, 9)
GO
INSERT [dbo].[Empleado] ([id_empleado], [nom_empleado]) VALUES (1, N'Juan')
INSERT [dbo].[Empleado] ([id_empleado], [nom_empleado]) VALUES (2, N'Daniel')
INSERT [dbo].[Empleado] ([id_empleado], [nom_empleado]) VALUES (3, N'Fabian')
INSERT [dbo].[Empleado] ([id_empleado], [nom_empleado]) VALUES (4, N'David')
GO
INSERT [dbo].[Ordenes] ([id_orden], [fecha], [id_cliente], [id_empleado]) VALUES (1, CAST(N'2022-06-12' AS Date), 2, 2)
INSERT [dbo].[Ordenes] ([id_orden], [fecha], [id_cliente], [id_empleado]) VALUES (2, CAST(N'2022-06-12' AS Date), 3, 1)
GO
INSERT [dbo].[Producto] ([id_producto], [nom_producto], [precio], [id_proveedor], [id_categoria], [existencia]) VALUES (1, N'Sierra', CAST(2000.00 AS Decimal(18, 2)), 3, 6, 8)
INSERT [dbo].[Producto] ([id_producto], [nom_producto], [precio], [id_proveedor], [id_categoria], [existencia]) VALUES (2, N'Martillo', CAST(20.00 AS Decimal(18, 2)), 3, 6, 4)
GO
INSERT [dbo].[Proveedor] ([id_proveedor], [nom_proveedor]) VALUES (1, N'Amanco')
INSERT [dbo].[Proveedor] ([id_proveedor], [nom_proveedor]) VALUES (2, N'Truper')
INSERT [dbo].[Proveedor] ([id_proveedor], [nom_proveedor]) VALUES (3, N'DeWalt')
INSERT [dbo].[Proveedor] ([id_proveedor], [nom_proveedor]) VALUES (4, N'Samboro')
INSERT [dbo].[Proveedor] ([id_proveedor], [nom_proveedor]) VALUES (5, N'Tamko')
INSERT [dbo].[Proveedor] ([id_proveedor], [nom_proveedor]) VALUES (6, N'Protecto')
INSERT [dbo].[Proveedor] ([id_proveedor], [nom_proveedor]) VALUES (7, N'Do it Best')
INSERT [dbo].[Proveedor] ([id_proveedor], [nom_proveedor]) VALUES (8, N'Makita')
INSERT [dbo].[Proveedor] ([id_proveedor], [nom_proveedor]) VALUES (9, N'Black + Decker')
INSERT [dbo].[Proveedor] ([id_proveedor], [nom_proveedor]) VALUES (10, N'Argos')
INSERT [dbo].[Proveedor] ([id_proveedor], [nom_proveedor]) VALUES (11, N'ADMIX')
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Ciudad] FOREIGN KEY([id_ciudad])
REFERENCES [dbo].[Ciudad] ([id_ciudad])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Ciudad]
GO
ALTER TABLE [dbo].[detalle_ordenes]  WITH CHECK ADD  CONSTRAINT [FK_detalle_ordenes_Ordenes] FOREIGN KEY([id_orden])
REFERENCES [dbo].[Ordenes] ([id_orden])
GO
ALTER TABLE [dbo].[detalle_ordenes] CHECK CONSTRAINT [FK_detalle_ordenes_Ordenes]
GO
ALTER TABLE [dbo].[detalle_ordenes]  WITH CHECK ADD  CONSTRAINT [FK_detalle_ordenes_Producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Producto] ([id_producto])
GO
ALTER TABLE [dbo].[detalle_ordenes] CHECK CONSTRAINT [FK_detalle_ordenes_Producto]
GO
ALTER TABLE [dbo].[Ordenes]  WITH CHECK ADD  CONSTRAINT [FK_Ordenes_Clientes] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Clientes] ([id_cliente])
GO
ALTER TABLE [dbo].[Ordenes] CHECK CONSTRAINT [FK_Ordenes_Clientes]
GO
ALTER TABLE [dbo].[Ordenes]  WITH CHECK ADD  CONSTRAINT [FK_Ordenes_Empleado] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[Empleado] ([id_empleado])
GO
ALTER TABLE [dbo].[Ordenes] CHECK CONSTRAINT [FK_Ordenes_Empleado]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Categoria] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[Categoria] ([id_categoria])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Categoria]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Proveedor] FOREIGN KEY([id_proveedor])
REFERENCES [dbo].[Proveedor] ([id_proveedor])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Proveedor]
GO
USE [master]
GO
ALTER DATABASE [Ferreteria] SET  READ_WRITE 
GO
