USE [master]
GO
/****** Object:  Database [TpIngSoftware_2026]    Script Date: 3/6/2026 20:25:46 ******/
CREATE DATABASE [TpIngSoftware_2026]

GO
ALTER DATABASE [TpIngSoftware_2026] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TpIngSoftware_2026].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TpIngSoftware_2026] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TpIngSoftware_2026] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TpIngSoftware_2026] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TpIngSoftware_2026] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TpIngSoftware_2026] SET ARITHABORT OFF 
GO
ALTER DATABASE [TpIngSoftware_2026] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TpIngSoftware_2026] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TpIngSoftware_2026] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TpIngSoftware_2026] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TpIngSoftware_2026] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TpIngSoftware_2026] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TpIngSoftware_2026] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TpIngSoftware_2026] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TpIngSoftware_2026] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TpIngSoftware_2026] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TpIngSoftware_2026] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TpIngSoftware_2026] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TpIngSoftware_2026] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TpIngSoftware_2026] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TpIngSoftware_2026] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TpIngSoftware_2026] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TpIngSoftware_2026] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TpIngSoftware_2026] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TpIngSoftware_2026] SET  MULTI_USER 
GO
ALTER DATABASE [TpIngSoftware_2026] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TpIngSoftware_2026] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TpIngSoftware_2026] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TpIngSoftware_2026] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TpIngSoftware_2026] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TpIngSoftware_2026] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TpIngSoftware_2026] SET QUERY_STORE = OFF
GO
USE [TpIngSoftware_2026]
GO
/****** Object:  Table [dbo].[BITACORA]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BITACORA](
	[IdBitacora] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[Actividad] [varchar](100) NOT NULL,
	[InformacionAsociada] [varchar](200) NOT NULL,
 CONSTRAINT [PK_BITACORA] PRIMARY KEY CLUSTERED 
(
	[IdBitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DIGITO_VERIFICADOR]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIGITO_VERIFICADOR](
	[NombreTabla] [nvarchar](50) NOT NULL,
	[DVV] [nvarchar](300) NOT NULL,
 CONSTRAINT [PK_DIGITO_VERIFICADOR] PRIMARY KEY CLUSTERED 
(
	[NombreTabla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PERMISO]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERMISO](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[EsFamilia] [bit] NOT NULL,
 CONSTRAINT [PK_Permiso] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PERMISO_RELACION]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERMISO_RELACION](
	[IdPadre] [int] NOT NULL,
	[IdHijo] [int] NOT NULL,
 CONSTRAINT [PK_Permiso_Relacion] PRIMARY KEY CLUSTERED 
(
	[IdPadre] ASC,
	[IdHijo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCTO]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTO](
	[IdProducto] [int] NOT NULL,
	[NombreProducto] [nvarchar](50) NOT NULL,
	[PrecioProducto] [decimal](18, 0) NOT NULL,
	[TipoProducto] [nvarchar](50) NOT NULL,
	[Descripcion] [nvarchar](300) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[CodigoProducto] [int] NOT NULL,
	[DVH] [nvarchar](300) NULL,
 CONSTRAINT [PK_PRODUCTO] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIO](
	[IdUsuario] [int] NOT NULL,
	[NombreUsuario] [nvarchar](50) NOT NULL,
	[ApellidoUsuario] [nvarchar](50) NOT NULL,
	[Dni] [int] NOT NULL,
	[CorreoElectronico] [nvarchar](50) NOT NULL,
	[ContraseñaUsuario] [nvarchar](300) NOT NULL,
	[IdIdioma] [int] NULL,
 CONSTRAINT [PK_USUARIO] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIO_PERMISO]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIO_PERMISO](
	[IdUsuario] [int] NOT NULL,
	[IdPermiso] [int] NOT NULL,
 CONSTRAINT [PK_Usuario_Permiso] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC,
	[IdPermiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Objeto: Table [dbo].[Idioma] Fecha de script: 04/06/2026 11:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idioma](
	[IdIdioma] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[IsDisponible] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdIdioma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Objeto: Table [dbo].[Control] Fecha de script: 04/06/2026 11:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Control](
	[IdControl] [int] IDENTITY(1,1) NOT NULL,
	[NombreControl] [nvarchar](100) NOT NULL,
	[NombreFormulario] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdControl] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Objeto: Table [dbo].[Traduccion] Fecha de script: 04/06/2026 11:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traduccion](
	[IdTraduccion] [int] IDENTITY(1,1) NOT NULL,
	[IdControl] [int] NOT NULL,
	[IdIdioma] [int] NOT NULL,
	[TextoTraducido] [nvarchar](500) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTraduccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (1, 1, CAST(N'2026-05-06T21:27:09.547' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (2, 1, CAST(N'2026-05-06T21:28:14.167' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (3, 1, CAST(N'2026-05-06T21:34:07.200' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (4, 1, CAST(N'2026-05-06T21:41:52.310' AS DateTime), N'Alta de usuario', N'Se agrego el usuario: mario@gmail.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (5, 1, CAST(N'2026-05-06T21:44:23.837' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (6, 1, CAST(N'2026-05-06T21:45:06.037' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (7, 1, CAST(N'2026-05-06T21:46:14.837' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (8, 1, CAST(N'2026-05-06T21:46:23.000' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (9, 1, CAST(N'2026-05-06T21:48:26.700' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (10, 1, CAST(N'2026-05-06T21:48:40.563' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (11, 1, CAST(N'2026-05-06T21:49:57.343' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (12, 1, CAST(N'2026-05-06T21:50:15.390' AS DateTime), N'Edición de usuario', N'Se modificó el usuario: marioc@gmail.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (13, 1, CAST(N'2026-05-06T21:50:30.593' AS DateTime), N'Baja de usuario', N'Se eliminó el usuario: ')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (14, 1, CAST(N'2026-05-07T11:46:34.733' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (15, 1, CAST(N'2026-05-07T11:47:19.453' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (16, 1, CAST(N'2026-05-07T11:48:58.670' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (17, 1, CAST(N'2026-05-07T11:49:07.610' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (18, 1, CAST(N'2026-05-07T19:04:55.817' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (19, 1, CAST(N'2026-05-07T19:05:29.123' AS DateTime), N'Alta de producto', N'Se agrego el producto: Lapicera Bic')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (20, 1, CAST(N'2026-05-07T19:08:21.997' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (21, 1, CAST(N'2026-05-07T19:15:31.903' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (22, 1, CAST(N'2026-05-07T19:16:09.380' AS DateTime), N'Modificación de producto', N'Se modificó el producto: Lapicera')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (23, 1, CAST(N'2026-05-07T19:16:16.390' AS DateTime), N'Baja de producto', N'Se eliminó el producto: ')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (24, 1, CAST(N'2026-05-07T19:16:24.717' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (25, 1, CAST(N'2026-05-07T20:44:35.550' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (26, 1, CAST(N'2026-05-07T20:46:10.473' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (27, 1, CAST(N'2026-05-14T18:54:49.043' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (28, 1, CAST(N'2026-05-14T18:55:14.117' AS DateTime), N'Alta de producto', N'Se agrego el producto: Lapicera')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (29, 1, CAST(N'2026-05-14T18:57:36.890' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (30, 1, CAST(N'2026-05-26T21:04:15.340' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (31, 1, CAST(N'2026-05-26T21:04:33.310' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (32, 1, CAST(N'2026-05-26T21:12:19.620' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (33, 1, CAST(N'2026-05-26T21:12:40.210' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (34, 1, CAST(N'2026-05-27T10:35:35.820' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (35, 1, CAST(N'2026-05-27T10:42:52.360' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (36, 1, CAST(N'2026-05-27T14:19:52.903' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (37, 1, CAST(N'2026-05-27T14:20:12.917' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (38, 1, CAST(N'2026-05-27T14:22:39.533' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (39, 1, CAST(N'2026-05-27T14:22:45.567' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (40, 1, CAST(N'2026-05-27T14:24:01.613' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (41, 1, CAST(N'2026-05-27T14:24:08.927' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (42, 1, CAST(N'2026-05-27T14:27:43.140' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (43, 1, CAST(N'2026-05-27T14:29:55.597' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (44, 1, CAST(N'2026-05-27T14:30:02.907' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (45, 1, CAST(N'2026-05-27T14:32:05.880' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (46, 1, CAST(N'2026-05-27T14:32:13.477' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (47, 1, CAST(N'2026-05-27T14:32:52.340' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (48, 1, CAST(N'2026-05-27T14:33:28.213' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (49, 1, CAST(N'2026-05-27T14:34:01.917' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (50, 1, CAST(N'2026-05-27T14:34:14.997' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (51, 1, CAST(N'2026-05-27T14:35:15.490' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (52, 1, CAST(N'2026-05-27T14:35:22.263' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (53, 1, CAST(N'2026-05-27T14:36:15.610' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (54, 1, CAST(N'2026-05-27T14:36:23.637' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (55, 1, CAST(N'2026-05-27T14:38:17.690' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (56, 1, CAST(N'2026-05-27T14:38:24.333' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (57, 1, CAST(N'2026-05-27T14:39:30.203' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (58, 1, CAST(N'2026-05-27T14:39:36.230' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (59, 1, CAST(N'2026-05-27T14:43:05.480' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (60, 1, CAST(N'2026-05-27T14:43:13.993' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (61, 1, CAST(N'2026-05-27T14:45:19.937' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (62, 1, CAST(N'2026-05-27T14:45:43.060' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (63, 1, CAST(N'2026-05-27T14:45:46.270' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (64, 1, CAST(N'2026-05-27T14:48:20.723' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (65, 1, CAST(N'2026-05-27T14:48:27.827' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (66, 1, CAST(N'2026-05-27T14:48:55.057' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (67, 1, CAST(N'2026-05-27T14:50:14.680' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (68, 1, CAST(N'2026-05-27T15:05:12.907' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (69, 1, CAST(N'2026-05-27T15:05:34.087' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (70, 1, CAST(N'2026-05-27T15:06:42.693' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (71, 1, CAST(N'2026-05-27T15:06:45.970' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (72, 1, CAST(N'2026-05-27T15:07:52.513' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (73, 1, CAST(N'2026-05-27T15:07:55.807' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (74, 1, CAST(N'2026-05-27T15:08:20.760' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (75, 1, CAST(N'2026-05-27T15:08:35.830' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (76, 1, CAST(N'2026-05-27T15:12:52.483' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (77, 1, CAST(N'2026-05-27T15:14:46.897' AS DateTime), N'Alta de usuario', N'Se agrego el usuario: mario@cajal.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (78, 1, CAST(N'2026-05-27T15:14:58.207' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (79, 2, CAST(N'2026-05-27T15:15:14.203' AS DateTime), N'Inicio de sesion', N'Usuario: mario@cajal.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (80, 2, CAST(N'2026-05-27T15:15:44.793' AS DateTime), N'Cierre de sesion', N'El Usuario: mario@cajal.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (81, 2, CAST(N'2026-05-27T15:21:11.777' AS DateTime), N'Inicio de sesion', N'Usuario: mario@cajal.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (82, 2, CAST(N'2026-05-27T15:21:21.830' AS DateTime), N'Cierre de sesion', N'El Usuario: mario@cajal.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (83, 1, CAST(N'2026-05-27T15:25:15.160' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (84, 1, CAST(N'2026-05-27T15:31:06.190' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (85, 1, CAST(N'2026-05-27T15:31:42.353' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (86, 1, CAST(N'2026-05-27T15:31:48.463' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (87, 2, CAST(N'2026-05-27T15:32:03.393' AS DateTime), N'Inicio de sesion', N'Usuario: mario@cajal.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (88, 2, CAST(N'2026-05-27T15:32:17.597' AS DateTime), N'Cierre de sesion', N'El Usuario: mario@cajal.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (89, 2, CAST(N'2026-05-27T15:52:37.987' AS DateTime), N'Inicio de sesion', N'Usuario: mario@cajal.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (90, 2, CAST(N'2026-05-27T15:52:45.153' AS DateTime), N'Cierre de sesion', N'El Usuario: mario@cajal.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (91, 2, CAST(N'2026-05-27T15:57:20.067' AS DateTime), N'Inicio de sesion', N'Usuario: mario@cajal.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (92, 2, CAST(N'2026-05-27T15:57:43.590' AS DateTime), N'Cierre de sesion', N'El Usuario: mario@cajal.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (93, 1, CAST(N'2026-05-27T15:57:54.987' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (94, 1, CAST(N'2026-05-27T15:58:08.210' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (95, 1, CAST(N'2026-05-27T16:33:22.047' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (96, 1, CAST(N'2026-05-27T16:33:47.470' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (97, 1, CAST(N'2026-05-28T21:10:48.927' AS DateTime), N'Inicio de sesion', N'Usuario: test@test.com')
INSERT [dbo].[BITACORA] ([IdBitacora], [IdUsuario], [FechaHora], [Actividad], [InformacionAsociada]) VALUES (98, 1, CAST(N'2026-05-28T21:12:28.490' AS DateTime), N'Cierre de sesion', N'El Usuario: test@test.com Cerró la sesion.')
GO
INSERT [dbo].[DIGITO_VERIFICADOR] ([NombreTabla], [DVV]) VALUES (N'PRODUCTO', N'8ece82e7f9df2f7c91bcc2da876cf0ac4f942064c3c55bc7d394c6cc65950805')
GO
INSERT [dbo].[PERMISO] ([Id], [Nombre], [EsFamilia]) VALUES (1, N'Gestion Usuarios', 0)
INSERT [dbo].[PERMISO] ([Id], [Nombre], [EsFamilia]) VALUES (2, N'Gestion Productos', 0)
INSERT [dbo].[PERMISO] ([Id], [Nombre], [EsFamilia]) VALUES (3, N'Administracion', 0)
INSERT [dbo].[PERMISO] ([Id], [Nombre], [EsFamilia]) VALUES (4, N'Gestion Idiomas', 0)
INSERT [dbo].[PERMISO] ([Id], [Nombre], [EsFamilia]) VALUES (5, N'BackUp', 0)
INSERT [dbo].[PERMISO] ([Id], [Nombre], [EsFamilia]) VALUES (10, N'Rol - Gerente', 1)
INSERT [dbo].[PERMISO] ([Id], [Nombre], [EsFamilia]) VALUES (11, N'Rol - Cliente', 1)
GO
INSERT [dbo].[PERMISO_RELACION] ([IdPadre], [IdHijo]) VALUES (10, 1)
INSERT [dbo].[PERMISO_RELACION] ([IdPadre], [IdHijo]) VALUES (10, 2)
INSERT [dbo].[PERMISO_RELACION] ([IdPadre], [IdHijo]) VALUES (10, 3)
INSERT [dbo].[PERMISO_RELACION] ([IdPadre], [IdHijo]) VALUES (10, 4)
INSERT [dbo].[PERMISO_RELACION] ([IdPadre], [IdHijo]) VALUES (10, 5)
INSERT [dbo].[PERMISO_RELACION] ([IdPadre], [IdHijo]) VALUES (11, 4)
GO
INSERT [dbo].[PRODUCTO] ([IdProducto], [NombreProducto], [PrecioProducto], [TipoProducto], [Descripcion], [Cantidad], [CodigoProducto], [DVH]) VALUES (1, N'Lapicera', CAST(100 AS Decimal(18, 0)), N'Lapicera Bic', N'Trazo Fino', 5, 1, N'7a06c9c0d16dd20d209d219f2f40deb097259fb2f5f4ccf2b0d3f6b3081b38e9')
INSERT [dbo].[PRODUCTO] ([IdProducto], [NombreProducto], [PrecioProducto], [TipoProducto], [Descripcion], [Cantidad], [CodigoProducto], [DVH]) VALUES (2, N'Regla', CAST(200 AS Decimal(18, 0)), N'ReglaPlastico', N'Transparente', 10, 2, N'863efcca079b74a9a4a381f5a5a3ef56443244a0ddb4e3f27099b9f98b61e1a5')
GO
INSERT [dbo].[USUARIO] ([IdUsuario], [NombreUsuario], [ApellidoUsuario], [Dni], [CorreoElectronico], [ContraseñaUsuario]) VALUES (1, N'test', N'test', 12345678, N'test@test.com', N'9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08')
INSERT [dbo].[USUARIO] ([IdUsuario], [NombreUsuario], [ApellidoUsuario], [Dni], [CorreoElectronico], [ContraseñaUsuario]) VALUES (2, N'Mario', N'Cajal', 11222333, N'mario@cajal.com', N'5f5a8ed8f139be6df7cf8f4a91d3e4649961a98c82fd521c18d6f292b031a319')
GO
INSERT [dbo].[USUARIO_PERMISO] ([IdUsuario], [IdPermiso]) VALUES (1, 10)
INSERT [dbo].[USUARIO_PERMISO] ([IdUsuario], [IdPermiso]) VALUES (2, 11)
GO
ALTER TABLE [dbo].[PERMISO] ADD  DEFAULT ((0)) FOR [EsFamilia]
GO
ALTER TABLE [dbo].[BITACORA]  WITH CHECK ADD  CONSTRAINT [FK_BITACORA_USUARIO] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[USUARIO] ([IdUsuario])
GO
ALTER TABLE [dbo].[BITACORA] CHECK CONSTRAINT [FK_BITACORA_USUARIO]
GO
ALTER TABLE [dbo].[PERMISO_RELACION]  WITH CHECK ADD  CONSTRAINT [FK_PR_Hijo] FOREIGN KEY([IdHijo])
REFERENCES [dbo].[PERMISO] ([Id])
GO
ALTER TABLE [dbo].[PERMISO_RELACION] CHECK CONSTRAINT [FK_PR_Hijo]
GO
ALTER TABLE [dbo].[PERMISO_RELACION]  WITH CHECK ADD  CONSTRAINT [FK_PR_Padre] FOREIGN KEY([IdPadre])
REFERENCES [dbo].[PERMISO] ([Id])
GO
ALTER TABLE [dbo].[PERMISO_RELACION] CHECK CONSTRAINT [FK_PR_Padre]
GO
ALTER TABLE [dbo].[USUARIO_PERMISO]  WITH CHECK ADD  CONSTRAINT [FK_UP_Permiso] FOREIGN KEY([IdPermiso])
REFERENCES [dbo].[PERMISO] ([Id])
GO
ALTER TABLE [dbo].[USUARIO_PERMISO] CHECK CONSTRAINT [FK_UP_Permiso]
GO
ALTER TABLE [dbo].[USUARIO_PERMISO]  WITH CHECK ADD  CONSTRAINT [FK_UP_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[USUARIO] ([IdUsuario])
GO
ALTER TABLE [dbo].[USUARIO_PERMISO] CHECK CONSTRAINT [FK_UP_Usuario]
GO

-- ====== Observer: Datos iniciales ======
SET IDENTITY_INSERT [dbo].[Idioma] ON 

INSERT [dbo].[Idioma] ([IdIdioma], [Nombre], [IsDisponible]) VALUES (1, N'Español', 1)
INSERT [dbo].[Idioma] ([IdIdioma], [Nombre], [IsDisponible]) VALUES (2, N'English', 1)
SET IDENTITY_INSERT [dbo].[Idioma] OFF
GO

SET IDENTITY_INSERT [dbo].[Control] ON 

INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (1, N'lblLeyendaIniciofrmLogin', N'frmLogin')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (2, N'lblCorreoElectronicofrmLogin', N'frmLogin')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (3, N'lblContraseñafrmLogin', N'frmLogin')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (4, N'btnlniciarSesionfrmLogin', N'frmLogin')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (5, N'btnMostrarContraseñafrmLogIn', N'frmLogin')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (6, N'lblNombrefrmUsuario', N'frmUsuario')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (7, N'lblApellidofrmUsuario', N'frmUsuario')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (8, N'lblDnifrmUsuario', N'frmUsuario')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (9, N'lblCorreoElectronicofrmUsuario', N'frmUsuario')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (10, N'lblContraseñafrmUsuario', N'frmUsuario')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (11, N'btnAltafrmUsuario', N'frmUsuario')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (12, N'btnBajafrmUsuario', N'frmUsuario')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (13, N'btnModificacionfrmUsuario', N'frmUsuario')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (14, N'lblNombrefrmProducto', N'frmProducto')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (15, N'lblPreciofrmProducto', N'frmProducto')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (16, N'lblTipofrmProducto', N'frmProducto')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (17, N'lblDescripcionfrmProducto', N'frmProducto')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (18, N'lblCantidadfrmProducto', N'frmProducto')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (19, N'label1', N'frmProducto')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (20, N'btnAltafrmProducto', N'frmProducto')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (21, N'btnBajafrmProducto', N'frmProducto')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (22, N'btnModificacionfrmProducto', N'frmProducto')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (23, N'lblUsuarioBitacora', N'frmBitacora')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (24, N'lblDesdeBitacora', N'frmBitacora')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (25, N'lblHastaBitacora', N'frmBitacora')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (26, N'btnBuscarBitacora', N'frmBitacora')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (27, N'btnLimpiarBitacora', N'frmBitacora')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (28, N'lblRolesfrmRolyPer', N'frmRolesyPermisos')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (29, N'lblPermisosfrmRolyPer', N'frmRolesyPermisos')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (30, N'lblfrmRolyPer', N'frmRolesyPermisos')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (31, N'lblfrmRolyPerNombrePer', N'frmRolesyPermisos')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (32, N'lblUsuariofrmRolyPer', N'frmRolesyPermisos')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (33, N'lblRolAsigfrmRolyPer', N'frmRolesyPermisos')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (34, N'btn1frmRolyPer', N'frmRolesyPermisos')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (35, N'btn2frmRolyPer', N'frmRolesyPermisos')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (36, N'btn3frmRolyPer', N'frmRolesyPermisos')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (37, N'btn4frmRolyPer', N'frmRolesyPermisos')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (38, N'btn5frmRolyPer', N'frmRolesyPermisos')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (39, N'btn6frmRolyPer', N'frmRolesyPermisos')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (40, N'btnCerrarSesionfrmMenu', N'frmMenú')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (41, N'gestiónUsuariosToolStripMenuItem', N'frmMenú')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (42, N'formularioUsuariosToolStripMenuItem', N'frmMenú')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (43, N'admRolesToolStripMenuItem', N'frmMenú')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (44, N'gestiónProductosToolStripMenuItem', N'frmMenú')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (45, N'formularioProductosToolStripMenuItem', N'frmMenú')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (46, N'adminitraciónToolStripMenuItem', N'frmMenú')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (47, N'bitacoraToolStripMenuItem', N'frmMenú')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (48, N'idiomaToolStripMenuItem', N'frmMenú')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (49, N'admIdiomasToolStripMenuItem', N'frmMenú')
INSERT [dbo].[Control] ([IdControl], [NombreControl], [NombreFormulario]) VALUES (50, N'backUpToolStripMenuItem', N'frmMenú')
SET IDENTITY_INSERT [dbo].[Control] OFF
GO

SET IDENTITY_INSERT [dbo].[Traduccion] ON 

INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (1, 1, 1, N'¡Bienvenido a nuestro sistema!')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (2, 2, 1, N'Correo Electrónico')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (3, 3, 1, N'Contraseña')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (4, 4, 1, N'Iniciar Sesión')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (5, 5, 1, N'Mostrar')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (6, 6, 1, N'Nombre')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (7, 7, 1, N'Apellido')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (8, 8, 1, N'DNI')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (9, 9, 1, N'Correo Electrónico')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (10, 10, 1, N'Contraseña')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (11, 11, 1, N'Alta')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (12, 12, 1, N'Baja')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (13, 13, 1, N'Modificar')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (14, 14, 1, N'Nombre')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (15, 15, 1, N'Precio')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (16, 16, 1, N'Tipo')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (17, 17, 1, N'Descripción')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (18, 18, 1, N'Cantidad')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (19, 19, 1, N'Código')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (20, 20, 1, N'Alta')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (21, 21, 1, N'Baja')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (22, 22, 1, N'Modificar')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (23, 23, 1, N'Usuario')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (24, 24, 1, N'Desde')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (25, 25, 1, N'Hasta')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (26, 26, 1, N'Buscar')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (27, 27, 1, N'Limpiar')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (28, 28, 1, N'Roles:')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (29, 29, 1, N'Permisos:')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (30, 30, 1, N'Permisos Disponibles:')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (31, 31, 1, N'Nombre Permiso:')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (32, 32, 1, N'Usuario:')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (33, 33, 1, N'Rol a asignar:')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (34, 34, 1, N'Agregar')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (35, 35, 1, N'Modificar')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (36, 36, 1, N'Eliminar')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (37, 37, 1, N'Agregar Hijo')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (38, 38, 1, N'Quitar Hijo')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (39, 39, 1, N'Asignar Rol')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (40, 40, 1, N'Cerrar Sesión')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (41, 41, 1, N'Gestión Usuarios')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (42, 42, 1, N'Formulario Usuarios')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (43, 43, 1, N'Adm Roles y Permisos')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (44, 44, 1, N'Gestión Productos')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (45, 45, 1, N'Formulario Productos')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (46, 46, 1, N'Administración')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (47, 47, 1, N'Bitácora')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (48, 48, 1, N'Gestión Idiomas')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (49, 49, 1, N'Adm Idiomas')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (50, 50, 1, N'BackUp')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (51, 1, 2, N'Welcome to our system!')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (52, 2, 2, N'Email')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (53, 3, 2, N'Password')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (54, 4, 2, N'Log In')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (55, 5, 2, N'Show')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (56, 6, 2, N'Name')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (57, 7, 2, N'Last Name')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (58, 8, 2, N'ID Number')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (59, 9, 2, N'Email')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (60, 10, 2, N'Password')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (61, 11, 2, N'Add')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (62, 12, 2, N'Delete')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (63, 13, 2, N'Edit')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (64, 14, 2, N'Name')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (65, 15, 2, N'Price')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (66, 16, 2, N'Type')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (67, 17, 2, N'Description')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (68, 18, 2, N'Quantity')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (69, 19, 2, N'Code')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (70, 20, 2, N'Add')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (71, 21, 2, N'Delete')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (72, 22, 2, N'Edit')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (73, 23, 2, N'User')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (74, 24, 2, N'From')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (75, 25, 2, N'To')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (76, 26, 2, N'Search')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (77, 27, 2, N'Clear')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (78, 28, 2, N'Roles:')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (79, 29, 2, N'Permissions:')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (80, 30, 2, N'Available Permissions:')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (81, 31, 2, N'Permission Name:')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (82, 32, 2, N'User:')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (83, 33, 2, N'Assign Role:')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (84, 34, 2, N'Add')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (85, 35, 2, N'Edit')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (86, 36, 2, N'Delete')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (87, 37, 2, N'Add Child')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (88, 38, 2, N'Remove Child')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (89, 39, 2, N'Assign Role')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (90, 40, 2, N'Log Out')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (91, 41, 2, N'User Management')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (92, 42, 2, N'Users Form')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (93, 43, 2, N'Roles & Permissions')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (94, 44, 2, N'Product Management')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (95, 45, 2, N'Products Form')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (96, 46, 2, N'Administration')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (97, 47, 2, N'Audit Log')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (98, 48, 2, N'Language Management')
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (99, 49, 2, N'Manage Languages')
GO
INSERT [dbo].[Traduccion] ([IdTraduccion], [IdControl], [IdIdioma], [TextoTraducido]) VALUES (100, 50, 2, N'BackUp')
SET IDENTITY_INSERT [dbo].[Traduccion] OFF
GO


-- ====== Observer: Constraints y Defaults ======
ALTER TABLE [dbo].[Idioma] ADD  DEFAULT ((1)) FOR [IsDisponible]
GO

ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD FOREIGN KEY([IdControl])
REFERENCES [dbo].[Control] ([IdControl])
GO

ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD FOREIGN KEY([IdIdioma])
REFERENCES [dbo].[Idioma] ([IdIdioma])
GO

ALTER TABLE [dbo].[USUARIO]  WITH CHECK ADD FOREIGN KEY([IdIdioma])
REFERENCES [dbo].[Idioma] ([IdIdioma])
GO

/****** Object:  StoredProcedure [dbo].[ActualizarDVHProducto]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ══════════════════════════════════════════
--  NUEVO SP ActualizarDVHProducto
-- ══════════════════════════════════════════
CREATE PROCEDURE [dbo].[ActualizarDVHProducto]
    @IdProducto INT,
    @DVH        NVARCHAR(300)
AS BEGIN
    UPDATE PRODUCTO SET DVH = @DVH WHERE IdProducto = @IdProducto
END
GO
/****** Object:  StoredProcedure [dbo].[AgregarPermisoHijo]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AgregarPermisoHijo]
    @IdPadre INT,
    @IdHijo  INT
AS BEGIN
    IF NOT EXISTS (SELECT 1 FROM PERMISO_RELACION
                   WHERE IdPadre = @IdPadre AND IdHijo = @IdHijo)
        INSERT INTO PERMISO_RELACION (IdPadre, IdHijo)
        VALUES (@IdPadre, @IdHijo)
END
GO
/****** Object:  StoredProcedure [dbo].[AltaPermiso]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AltaPermiso]
    @Nombre    NVARCHAR(100),
    @EsFamilia BIT
AS BEGIN
    DECLARE @Id INT
    SET @Id = (SELECT ISNULL(MAX(Id), 0) + 1 FROM PERMISO)
    INSERT INTO PERMISO (Id, Nombre, EsFamilia)
    VALUES (@Id, @Nombre, @EsFamilia)
END
GO
/****** Object:  StoredProcedure [dbo].[AltaProducto]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ══════════════════════════════════════════
--  MODIFICAR SP AltaProducto
-- ══════════════════════════════════════════
CREATE PROCEDURE [dbo].[AltaProducto]
    @CodigoProducto  INT,
    @NombreProducto  NVARCHAR(50),
    @PrecioProducto  DECIMAL,
    @TipoProducto    NVARCHAR(50),
    @Descripcion     NVARCHAR(300),
    @Cantidad        INT,
    @DVH             NVARCHAR(300)
AS BEGIN
    IF EXISTS (SELECT 1 FROM PRODUCTO WHERE CodigoProducto = @CodigoProducto)
    BEGIN
        RAISERROR('Ya existe un producto con ese código.',16,1)
        RETURN
    END
    DECLARE @IdProducto INT
    SET @IdProducto = (SELECT ISNULL(MAX(IdProducto),0)+1 FROM PRODUCTO)
    INSERT INTO PRODUCTO (IdProducto, CodigoProducto, NombreProducto,
                          PrecioProducto, TipoProducto, Descripcion, Cantidad, DVH)
    VALUES (@IdProducto, @CodigoProducto, @NombreProducto,
            @PrecioProducto, @TipoProducto, @Descripcion, @Cantidad, @DVH)
END
GO
/****** Object:  StoredProcedure [dbo].[AltaUsuario]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AltaUsuario]
(
    @CorreoElectronico NVARCHAR(50),
    @ContraseñaUsuario NVARCHAR(300),
    @NombreUsuario NVARCHAR(50),
    @ApellidoUsuario NVARCHAR(50),
    @Dni INT
)
AS
BEGIN
IF EXISTS (SELECT 1 FROM USUARIO WHERE CorreoElectronico = @CorreoElectronico)
BEGIN
RAISERROR('Ya existe un usuario con ese correo electrónico.',16,1)
RETURN
END

IF EXISTS (SELECT 1 FROM USUARIO WHERE Dni = @Dni)
BEGIN
RAISERROR('Ya existe un usuario con ese DNI.',16,2)
RETURN
END

DECLARE @IdUsuario INT
SET @IdUsuario =(SELECT ISNULL(MAX(IdUsuario),0) + 1 FROM USUARIO)
INSERT INTO USUARIO(IdUsuario,CorreoElectronico,ContraseñaUsuario,NombreUsuario,ApellidoUsuario,Dni)
VALUES(@IdUsuario,@CorreoElectronico,@ContraseñaUsuario,@NombreUsuario,@ApellidoUsuario,@Dni)
END
GO
/****** Object:  StoredProcedure [dbo].[AsignarPermisoAUsuario]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AsignarPermisoAUsuario]
    @IdUsuario INT,
    @IdPermiso INT
AS BEGIN
    IF NOT EXISTS (SELECT 1 FROM USUARIO_PERMISO
                   WHERE IdUsuario = @IdUsuario AND IdPermiso = @IdPermiso)
        INSERT INTO USUARIO_PERMISO (IdUsuario, IdPermiso)
        VALUES (@IdUsuario, @IdPermiso)
END
GO
/****** Object:  StoredProcedure [dbo].[BajaProducto]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BajaProducto]
@IdProducto int 
AS
BEGIN
DELETE FROM PRODUCTO WHERE IdProducto=@IdProducto
END
GO
/****** Object:  StoredProcedure [dbo].[BajaUsuario]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BajaUsuario]
@IdUsuario int 
AS
BEGIN
DELETE FROM USUARIO WHERE IdUsuario=@IdUsuario
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarPermiso]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EliminarPermiso]
    @Id INT
AS BEGIN
    DELETE FROM PERMISO_RELACION WHERE IdPadre = @Id OR IdHijo = @Id
    DELETE FROM USUARIO_PERMISO   WHERE IdPermiso = @Id
    DELETE FROM PERMISO           WHERE Id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[EsHijoDeAlguien]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EsHijoDeAlguien]
    @IdHijo INT
AS BEGIN
    SELECT IdPadre FROM PERMISO_RELACION WHERE IdHijo = @IdHijo
END
GO
/****** Object:  StoredProcedure [dbo].[GuardarDVV]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ══════════════════════════════════════════
--  NUEVO SP GuardarDVV
-- ══════════════════════════════════════════
CREATE PROCEDURE [dbo].[GuardarDVV]
    @NombreTabla NVARCHAR(50),
    @DVV         NVARCHAR(300)
AS BEGIN
    IF EXISTS (SELECT 1 FROM DIGITO_VERIFICADOR WHERE NombreTabla = @NombreTabla)
        UPDATE DIGITO_VERIFICADOR SET DVV = @DVV WHERE NombreTabla = @NombreTabla
    ELSE
        INSERT INTO DIGITO_VERIFICADOR (NombreTabla, DVV) VALUES (@NombreTabla, @DVV)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarBitacora]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarBitacora]
    @IdUsuario INT,
    @Actividad VARCHAR(100),
    @InformacionAsociada VARCHAR(200)
AS
BEGIN
DECLARE @NuevoId INT;
SELECT @NuevoId = ISNULL(MAX(IdBitacora), 0) + 1 FROM BITACORA;

INSERT INTO BITACORA (
        IdBitacora,   
        IdUsuario, 
        FechaHora, 
        Actividad, 
        InformacionAsociada
    )
VALUES (
        @NuevoId,       -- Insertamos el número que acabamos de calcular
        @IdUsuario, 
        GETDATE(), 
        @Actividad, 
        @InformacionAsociada
    );

END
GO
/****** Object:  StoredProcedure [dbo].[LeerUsuario]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LeerUsuario]
@CorreoElectronico nvarchar(50), @ContraseñaUsuario nvarchar(300)
AS
BEGIN
SELECT NombreUsuario
      ,ApellidoUsuario
      ,Dni
      ,CorreoElectronico
      ,ContraseñaUsuario
	  ,IdUsuario
	  FROM USUARIO
WHERE CorreoElectronico = @CorreoElectronico
AND ContraseñaUsuario = @ContraseñaUsuario
END
GO
/****** Object:  StoredProcedure [dbo].[ListarPermisos]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ListarPermisos]
AS BEGIN
    SELECT Id, Nombre, EsFamilia FROM PERMISO
END
GO
/****** Object:  StoredProcedure [dbo].[ListarPermisosPorUsuario]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ListarPermisosPorUsuario]
    @IdUsuario INT
AS BEGIN
    SELECT IdPermiso FROM USUARIO_PERMISO WHERE IdUsuario = @IdUsuario
END
GO
/****** Object:  StoredProcedure [dbo].[ListarPermisosRaiz]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ListarPermisosRaiz]
AS BEGIN
    SELECT Id FROM PERMISO
    WHERE Id NOT IN (SELECT IdHijo FROM PERMISO_RELACION)
END
GO
/****** Object:  StoredProcedure [dbo].[ListarPermisosRelaciones]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ListarPermisosRelaciones]
AS BEGIN
    SELECT IdPadre, IdHijo FROM PERMISO_RELACION
END
GO
/****** Object:  StoredProcedure [dbo].[ListarProducto]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarProducto]
AS
BEGIN
SELECT * FROM PRODUCTO
END
GO
/****** Object:  StoredProcedure [dbo].[ListarProductoConDVH]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ══════════════════════════════════════════
--  NUEVO SP ListarProductoConDVH
-- ══════════════════════════════════════════
CREATE PROCEDURE [dbo].[ListarProductoConDVH]
AS BEGIN
    SELECT IdProducto, NombreProducto, PrecioProducto, TipoProducto,
           Descripcion, Cantidad, CodigoProducto, DVH
    FROM PRODUCTO
END
GO
/****** Object:  StoredProcedure [dbo].[ListarUsuario]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarUsuario]
AS
BEGIN
SELECT * FROM USUARIO
END
GO
/****** Object:  StoredProcedure [dbo].[ModificarPermiso]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ModificarPermiso]
    @Id        INT,
    @Nombre    NVARCHAR(100),
    @EsFamilia BIT
AS BEGIN
    UPDATE PERMISO SET Nombre = @Nombre, EsFamilia = @EsFamilia
    WHERE Id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[ModificarProducto]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ══════════════════════════════════════════
--  MODIFICAR SP ModificarProducto
-- ══════════════════════════════════════════
CREATE PROCEDURE [dbo].[ModificarProducto]
    @IdProducto     INT,
    @NombreProducto NVARCHAR(50),
    @PrecioProducto DECIMAL,
    @TipoProducto   NVARCHAR(50),
    @Cantidad       INT,
    @Descripcion    NVARCHAR(300),
    @CodigoProducto INT,
    @DVH            NVARCHAR(300)
AS BEGIN
    UPDATE PRODUCTO SET
        NombreProducto = @NombreProducto,
        PrecioProducto = @PrecioProducto,
        TipoProducto   = @TipoProducto,
        Cantidad       = @Cantidad,
        Descripcion    = @Descripcion,
        CodigoProducto = @CodigoProducto,
        DVH            = @DVH
    WHERE IdProducto = @IdProducto
END
GO
/****** Object:  StoredProcedure [dbo].[ModificarUsuario]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ModificarUsuario]
@IdUsuario int, @NombreUsuario nvarchar(50), @ApellidoUsuario nvarchar(50), @Dni int, @CorreoElectronico nvarchar(50), @ContraseñaUsuario nvarchar(300) 
AS
BEGIN
UPDATE USUARIO SET NombreUsuario = @NombreUsuario, ApellidoUsuario = @ApellidoUsuario, Dni = @Dni,
CorreoElectronico = @CorreoElectronico, ContraseñaUsuario = @ContraseñaUsuario
WHERE IdUsuario = @IdUsuario
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerBitacora]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerBitacora]
    @IdUsuario INT = NULL,
    @Actividad VARCHAR(100) = NULL,
    @FechaDesde DATETIME = NULL,
    @FechaHasta DATETIME = NULL
AS
BEGIN
   SELECT 
        IdBitacora,
        FechaHora, 
        IdUsuario, 
        Actividad, 
        InformacionAsociada
    FROM 
        BITACORA
    WHERE 
        -- Filtra por IdUsuario solo si se envió un valor
        (@IdUsuario IS NULL OR IdUsuario = @IdUsuario)
        
        -- Filtra por Actividad solo si se envió un valor (búsqueda exacta)
        AND (@Actividad IS NULL OR Actividad = @Actividad)
        
        -- Filtra por rango de fechas. Si solo envías 'Desde', trae de ahí en adelante.
        -- Si solo envías 'Hasta', trae todo hasta esa fecha.
        AND (@FechaDesde IS NULL OR FechaHora >= @FechaDesde)
        AND (@FechaHasta IS NULL OR FechaHora <= @FechaHasta)
    
    --Ordenamos los resultados del más reciente al más antiguo
    ORDER BY 
        FechaHora DESC;
END

GO
/****** Object:  StoredProcedure [dbo].[ObtenerDVV]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ══════════════════════════════════════════
--  NUEVO SP ObtenerDVV
-- ══════════════════════════════════════════
CREATE PROCEDURE [dbo].[ObtenerDVV]
    @NombreTabla NVARCHAR(50)
AS BEGIN
    SELECT NombreTabla, DVV
    FROM DIGITO_VERIFICADOR
    WHERE NombreTabla = @NombreTabla
END
GO
/****** Object:  StoredProcedure [dbo].[QuitarPermisoHijo]    Script Date: 3/6/2026 20:25:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[QuitarPermisoHijo]
    @IdPadre INT,
    @IdHijo  INT
AS BEGIN
    DELETE FROM PERMISO_RELACION
    WHERE IdPadre = @IdPadre AND IdHijo = @IdHijo
END
GO

-- ====== Observer: Stored Procedures ======
/****** Objeto: StoredProcedure [dbo].[ActualizarIdiomaUsuario] Fecha de script: 04/06/2026 11:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarIdiomaUsuario]
    @IdUsuario INT,
    @IdIdioma  INT
AS
    UPDATE Usuario
    SET    IdIdioma = @IdIdioma
    WHERE  IdUsuario = @IdUsuario
GO

/****** Objeto: StoredProcedure [dbo].[ObtenerTraduccionesPorIdioma] Fecha de script: 04/06/2026 11:09:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerTraduccionesPorIdioma]
    @IdIdioma INT
AS
BEGIN
    SELECT
        c.NombreControl,
        c.NombreFormulario,
        COALESCE(
            t_pedido.TextoTraducido,               -- 1º: traducción del idioma pedido
            '[' + t_español.TextoTraducido + ']',  -- 2º: texto en español entre corchetes
            '[' + c.NombreControl + ']'            -- 3º: nombre del control (último recurso)
        ) AS TextoTraducido
    FROM Control c
    LEFT JOIN Traduccion t_pedido
        ON  t_pedido.IdControl = c.IdControl
        AND t_pedido.IdIdioma  = @IdIdioma
    LEFT JOIN Traduccion t_español
        ON  t_español.IdControl = c.IdControl
        AND t_español.IdIdioma  = 1              -- español siempre como base
END
GO

USE [master]
GO
ALTER DATABASE [TpIngSoftware_2026] SET  READ_WRITE 
GO