USE [master]
GO
/****** Object:  Database [PIN_GRUPO41]    Script Date: 19/10/2024 16:35:18 ******/
CREATE DATABASE [PIN_GRUPO41]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PIN_GRUPO41', FILENAME = N'G:\FerozoDatabases\sqlsrv\PIN_GRUPO41.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PIN_GRUPO41_log', FILENAME = N'G:\FerozoDatabases\sqlsrv\PIN_GRUPO41_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PIN_GRUPO41] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PIN_GRUPO41].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PIN_GRUPO41] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PIN_GRUPO41] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PIN_GRUPO41] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PIN_GRUPO41] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PIN_GRUPO41] SET ARITHABORT OFF 
GO
ALTER DATABASE [PIN_GRUPO41] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PIN_GRUPO41] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PIN_GRUPO41] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PIN_GRUPO41] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PIN_GRUPO41] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PIN_GRUPO41] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PIN_GRUPO41] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PIN_GRUPO41] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PIN_GRUPO41] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PIN_GRUPO41] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PIN_GRUPO41] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PIN_GRUPO41] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PIN_GRUPO41] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PIN_GRUPO41] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PIN_GRUPO41] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PIN_GRUPO41] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PIN_GRUPO41] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PIN_GRUPO41] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PIN_GRUPO41] SET  MULTI_USER 
GO
ALTER DATABASE [PIN_GRUPO41] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PIN_GRUPO41] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PIN_GRUPO41] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PIN_GRUPO41] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PIN_GRUPO41] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PIN_GRUPO41] SET QUERY_STORE = OFF
GO
USE [PIN_GRUPO41]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [PIN_GRUPO41]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 19/10/2024 16:35:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[Id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[Categoria] [varchar](50) NOT NULL,
	[Precio_hora] [numeric](18, 2) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias_Fallas]    Script Date: 19/10/2024 16:35:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias_Fallas](
	[Id_categoria_falla] [int] IDENTITY(1,1) NOT NULL,
	[Categoria] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_categoria_falla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 19/10/2024 16:35:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Telefono] [varchar](50) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
	[Cuit] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 19/10/2024 16:35:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[Id_empleado] [int] IDENTITY(1,1) NOT NULL,
	[Id_admin] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Telefono] [varchar](50) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Contraseña] [int] NOT NULL,
	[Ocupacion] [varchar](50) NOT NULL,
	[Id_caja] [int] NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[Id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equipos]    Script Date: 19/10/2024 16:35:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipos](
	[Id_Equipo] [int] IDENTITY(1,1) NOT NULL,
	[Id_Marca] [int] NOT NULL,
	[Id_Modelo] [int] NOT NULL,
	[Id_Cliente] [int] NOT NULL,
	[Fecha_Ingreso] [date] NOT NULL,
	[Id_falla] [int] NOT NULL,
 CONSTRAINT [PK_Equipos] PRIMARY KEY CLUSTERED 
(
	[Id_Equipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fallas]    Script Date: 19/10/2024 16:35:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fallas](
	[Id_falla] [int] IDENTITY(1,1) NOT NULL,
	[Falla] [varchar](255) NOT NULL,
	[Id_categoria_falla] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_falla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 19/10/2024 16:35:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[idMarca] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modelos]    Script Date: 19/10/2024 16:35:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modelos](
	[idModelo] [int] IDENTITY(1,1) NOT NULL,
	[Modelo] [varchar](50) NOT NULL,
	[idMarca] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 19/10/2024 16:35:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[ID_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Razon_Social] [varchar](50) NOT NULL,
	[Cuit] [varchar](50) NOT NULL,
	[Telefono] [varchar](15) NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[ID_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reparaciones]    Script Date: 19/10/2024 16:35:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reparaciones](
	[Id_Reparacion] [int] IDENTITY(1,1) NOT NULL,
	[Id_Cliente] [int] NULL,
	[Id_Equipo] [int] NULL,
	[Estado] [varchar](50) NULL,
	[Total] [decimal](18, 0) NULL,
	[Fecha_reparacion] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Repuestos]    Script Date: 19/10/2024 16:35:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Repuestos](
	[Id_repuesto] [int] IDENTITY(1,1) NOT NULL,
	[Repuesto] [varchar](50) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Stock] [int] NOT NULL,
	[Precio_unitario] [money] NOT NULL,
	[Id_Proveedor] [int] NOT NULL,
 CONSTRAINT [PK_Repuestos] PRIMARY KEY CLUSTERED 
(
	[Id_repuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 19/10/2024 16:35:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL,
	[Cargo] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categorias] ON 

INSERT [dbo].[Categorias] ([Id_categoria], [Categoria], [Precio_hora]) VALUES (1, N'A', CAST(3018.00 AS Numeric(18, 2)))
INSERT [dbo].[Categorias] ([Id_categoria], [Categoria], [Precio_hora]) VALUES (2, N'B', CAST(3480.00 AS Numeric(18, 2)))
INSERT [dbo].[Categorias] ([Id_categoria], [Categoria], [Precio_hora]) VALUES (3, N'C', CAST(3850.00 AS Numeric(18, 2)))
INSERT [dbo].[Categorias] ([Id_categoria], [Categoria], [Precio_hora]) VALUES (4, N'D', CAST(4146.00 AS Numeric(18, 2)))
SET IDENTITY_INSERT [dbo].[Categorias] OFF
GO
SET IDENTITY_INSERT [dbo].[Categorias_Fallas] ON 

INSERT [dbo].[Categorias_Fallas] ([Id_categoria_falla], [Categoria]) VALUES (1, N'Hardware')
INSERT [dbo].[Categorias_Fallas] ([Id_categoria_falla], [Categoria]) VALUES (2, N'Software')
INSERT [dbo].[Categorias_Fallas] ([Id_categoria_falla], [Categoria]) VALUES (3, N'Red')
INSERT [dbo].[Categorias_Fallas] ([Id_categoria_falla], [Categoria]) VALUES (4, N'Conectividad')
INSERT [dbo].[Categorias_Fallas] ([Id_categoria_falla], [Categoria]) VALUES (5, N'Seguridad')
INSERT [dbo].[Categorias_Fallas] ([Id_categoria_falla], [Categoria]) VALUES (12, N'Conectividad')
SET IDENTITY_INSERT [dbo].[Categorias_Fallas] OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Telefono], [Correo], [Cuit]) VALUES (6, N'luis', N'Lastra', N'3515905276', N'llastra_correo@gmail.com', N'3062489512')
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Telefono], [Correo], [Cuit]) VALUES (7, N'EDUARDO', N'CASTRO', N'543573500528', N'lcastro_correo@gmail.com', N'17184477235')
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Telefono], [Correo], [Cuit]) VALUES (8, N'sol', N'raja', N'645345565', N'sraja_correo@gmail.com', N'84466545131')
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Telefono], [Correo], [Cuit]) VALUES (9, N'Luis', N'Sosa', N'22336719', N'lsosa_correo@gmail.com', N'30695826175')
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Telefono], [Correo], [Cuit]) VALUES (10, N'carlos', N'comba', N'3515905276', N'ccomba_correo@gmail.com', N'20955051832')
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Telefono], [Correo], [Cuit]) VALUES (11, N'CARA', N'CLARA', N'543573599623', N'cclara_correo@gmail.com', N'25425131532')
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Telefono], [Correo], [Cuit]) VALUES (12, N'lucia', N'redondo', N'351621298', N'lredondo_correo@com', N'5958741262')
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Telefono], [Correo], [Cuit]) VALUES (13, N'FRANCO', N'CORTEZ', N'9822336719', N'fcortez_correo@gmail.com', N'1719447789')
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Telefono], [Correo], [Cuit]) VALUES (14, N'martin', N'perez', N'3573619852', N'mperez_correo@gmail.com', N'262589482')
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Telefono], [Correo], [Cuit]) VALUES (15, N'angel', N'paz', N'3573261948', N'apaz_correo@gmail.com', N'2032615481')
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Telefono], [Correo], [Cuit]) VALUES (16, N'franno', N'luciano', N'35756295896', N'fluciano_correo@gmail.com', N'20955051832')
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Telefono], [Correo], [Cuit]) VALUES (17, N'victor', N'jara', N'254695125', N'jvictor_correo@gmail.com', N'20955051832')
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Telefono], [Correo], [Cuit]) VALUES (18, N'andres', N'sosa', N'65675516513', N'asosa_correo@gmail.com', N'3512165423')
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Telefono], [Correo], [Cuit]) VALUES (19, N'Roman', N'Bossio', N'3532438680', N'bossio.roman2004@gmail.com', N'20450940802')
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Telefono], [Correo], [Cuit]) VALUES (20, N'Maria Luz', N'Bossio', N'3513458668', N'marialuzbossio@gmail.com', N'27450940815')
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Telefono], [Correo], [Cuit]) VALUES (24, N'CARLOS ', N'PORTELA', N'545435159052', N'cportela_85@gmail.com', N'20845123512')
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Telefono], [Correo], [Cuit]) VALUES (25, N'EMILIANO ', N'CARRERA', N'545435734006', N'emi-carrera16.hotmail.com', N'20811516502')
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Telefono], [Correo], [Cuit]) VALUES (26, N'MIGUEL', N'CARRIZO', N'545435334177', N'miguelon@gmail.com', N'20651305646')
INSERT [dbo].[Clientes] ([Id_cliente], [Nombre], [Apellido], [Telefono], [Correo], [Cuit]) VALUES (27, N'LAURA ', N'JUAREZ', N'543573500526', N'ljuarez_88@gmail.com', N'30605225420')
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Equipos] ON 

INSERT [dbo].[Equipos] ([Id_Equipo], [Id_Marca], [Id_Modelo], [Id_Cliente], [Fecha_Ingreso], [Id_falla]) VALUES (2, 7, 67, 8, CAST(N'2024-10-11' AS Date), 22)
INSERT [dbo].[Equipos] ([Id_Equipo], [Id_Marca], [Id_Modelo], [Id_Cliente], [Fecha_Ingreso], [Id_falla]) VALUES (3, 7, 64, 9, CAST(N'2024-10-11' AS Date), 11)
INSERT [dbo].[Equipos] ([Id_Equipo], [Id_Marca], [Id_Modelo], [Id_Cliente], [Fecha_Ingreso], [Id_falla]) VALUES (4, 26, 136, 26, CAST(N'2024-10-15' AS Date), 38)
INSERT [dbo].[Equipos] ([Id_Equipo], [Id_Marca], [Id_Modelo], [Id_Cliente], [Fecha_Ingreso], [Id_falla]) VALUES (5, 2, 16, 6, CAST(N'2024-10-15' AS Date), 48)
INSERT [dbo].[Equipos] ([Id_Equipo], [Id_Marca], [Id_Modelo], [Id_Cliente], [Fecha_Ingreso], [Id_falla]) VALUES (6, 5, 44, 10, CAST(N'2024-10-17' AS Date), 14)
INSERT [dbo].[Equipos] ([Id_Equipo], [Id_Marca], [Id_Modelo], [Id_Cliente], [Fecha_Ingreso], [Id_falla]) VALUES (7, 7, 66, 11, CAST(N'2024-10-18' AS Date), 8)
INSERT [dbo].[Equipos] ([Id_Equipo], [Id_Marca], [Id_Modelo], [Id_Cliente], [Fecha_Ingreso], [Id_falla]) VALUES (29, 5, 43, 7, CAST(N'2024-10-19' AS Date), 5)
INSERT [dbo].[Equipos] ([Id_Equipo], [Id_Marca], [Id_Modelo], [Id_Cliente], [Fecha_Ingreso], [Id_falla]) VALUES (30, 5, 44, 9, CAST(N'2024-10-19' AS Date), 5)
INSERT [dbo].[Equipos] ([Id_Equipo], [Id_Marca], [Id_Modelo], [Id_Cliente], [Fecha_Ingreso], [Id_falla]) VALUES (31, 2, 15, 8, CAST(N'2024-10-19' AS Date), 8)
SET IDENTITY_INSERT [dbo].[Equipos] OFF
GO
SET IDENTITY_INSERT [dbo].[Fallas] ON 

INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (1, N'La pantalla táctil no responde', 1)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (2, N'El celular no enciende', 1)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (3, N'La batería se descarga rápidamente', 1)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (4, N'El teléfono se sobrecalienta', 1)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (5, N'El puerto de carga no funciona', 1)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (6, N'El altavoz no emite sonido', 1)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (7, N'La cámara no enfoca correctamente', 1)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (8, N'El botón de encendido no funciona', 1)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (9, N'El botón de volumen está roto', 1)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (10, N'La pantalla tiene líneas o parpadeos', 1)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (11, N'El micrófono no funciona', 1)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (12, N'El teléfono no detecta la tarjeta SIM', 1)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (13, N'El celular no reconoce los auriculares', 1)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (14, N'El GPS no funciona correctamente', 1)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (15, N'El celular no tiene señal', 1)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (16, N'Problemas con el Wi-Fi, no se conecta', 2)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (17, N'Las aplicaciones se cierran solas', 2)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (18, N'El sistema operativo no arranca', 2)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (19, N'El celular se reinicia solo', 2)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (20, N'El Bluetooth no funciona', 2)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (21, N'Las actualizaciones de software fallan', 2)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (22, N'La cámara no abre', 2)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (23, N'Los archivos no se descargan', 2)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (24, N'No se puede instalar aplicaciones desde la Play Store', 2)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (25, N'El celular se bloquea en la pantalla de inicio', 2)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (26, N'La galería de fotos no carga', 2)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (27, N'Las notificaciones no aparecen', 2)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (28, N'Problemas de sincronización con la nube', 2)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (29, N'La pantalla se pone negra de repente', 2)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (30, N'Las llamadas se cortan constantemente', 3)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (31, N'El celular no recibe mensajes SMS', 3)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (32, N'El celular no envía mensajes SMS', 3)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (33, N'No se puede realizar llamadas', 3)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (34, N'La calidad del sonido durante las llamadas es mala', 3)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (35, N'El internet móvil es muy lento', 3)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (36, N'Problemas al cambiar entre redes 4G y 5G', 3)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (37, N'El almacenamiento interno está lleno', 1)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (38, N'Problemas al conectar el celular al PC', 4)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (39, N'No se puede transferir archivos vía USB', 4)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (40, N'El celular no reconoce la tarjeta SD', 1)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (41, N'El lector de huellas no funciona', 1)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (42, N'El reconocimiento facial no funciona', 1)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (43, N'El celular tiene aplicaciones no deseadas (adware)', 5)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (44, N'El teléfono muestra anuncios no solicitados', 5)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (45, N'El teléfono ha sido infectado por un virus o malware', 5)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (46, N'La pantalla tiene manchas o zonas muertas', 1)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (47, N'La vibración del teléfono no funciona', 1)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (48, N'Problemas con la conectividad NFC', 4)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (49, N'Los botones de navegación no responden', 1)
INSERT [dbo].[Fallas] ([Id_falla], [Falla], [Id_categoria_falla]) VALUES (50, N'El celular se queda congelado durante el uso', 2)
SET IDENTITY_INSERT [dbo].[Fallas] OFF
GO
SET IDENTITY_INSERT [dbo].[Marcas] ON 

INSERT [dbo].[Marcas] ([idMarca], [Marca]) VALUES (1, N'Apple')
INSERT [dbo].[Marcas] ([idMarca], [Marca]) VALUES (2, N'Samsung
')
INSERT [dbo].[Marcas] ([idMarca], [Marca]) VALUES (3, N'Huawei')
INSERT [dbo].[Marcas] ([idMarca], [Marca]) VALUES (4, N'Xiaomi')
INSERT [dbo].[Marcas] ([idMarca], [Marca]) VALUES (5, N'Oppo
')
INSERT [dbo].[Marcas] ([idMarca], [Marca]) VALUES (7, N'Vivo')
INSERT [dbo].[Marcas] ([idMarca], [Marca]) VALUES (8, N'OnePlus')
INSERT [dbo].[Marcas] ([idMarca], [Marca]) VALUES (10, N'Nokia')
INSERT [dbo].[Marcas] ([idMarca], [Marca]) VALUES (11, N'LG')
INSERT [dbo].[Marcas] ([idMarca], [Marca]) VALUES (12, N'Motorola')
INSERT [dbo].[Marcas] ([idMarca], [Marca]) VALUES (26, N'LENOVO')
INSERT [dbo].[Marcas] ([idMarca], [Marca]) VALUES (6, N'Google (Pixel)')
INSERT [dbo].[Marcas] ([idMarca], [Marca]) VALUES (9, N'Sony')
INSERT [dbo].[Marcas] ([idMarca], [Marca]) VALUES (27, N'HYUNDAY')
SET IDENTITY_INSERT [dbo].[Marcas] OFF
GO
SET IDENTITY_INSERT [dbo].[Modelos] ON 

INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (122, N'vivo ultra nuevo', 7)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (2, N'iPhone 13 Pro', 1)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (3, N'iPhone 13 Pro Max', 1)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (4, N'G32', 12)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (5, N'iPhone 12 Pro', 1)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (6, N'iPhone 12 Pro Max', 1)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (7, N'iPhone 11', 1)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (8, N'iPhone 11 Pro', 1)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (9, N'iPhone 11 Pro Max', 1)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (10, N'iPhone SE (2020)', 1)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (11, N'Galaxy S21', 2)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (12, N'Galaxy S21+', 2)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (13, N'Galaxy S21 Ultra', 2)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (14, N'Galaxy S20', 2)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (15, N'Galaxy S20+', 2)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (16, N'Galaxy S20 Ultra', 2)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (17, N'Galaxy Note 20', 2)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (18, N'Galaxy Note 20 Ultra', 2)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (19, N'Galaxy A52', 2)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (20, N'Galaxy A72', 2)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (21, N'P40', 3)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (22, N'P40 Pro', 3)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (23, N'Mate 40', 3)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (24, N'Mate 40 Pro', 3)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (25, N'Nova 7', 3)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (26, N'Nova 7i', 3)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (27, N'P30', 3)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (28, N'P30 Pro', 3)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (29, N'Y9a', 3)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (30, N'Y7a', 3)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (31, N'Mi 11', 4)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (32, N'Mi 11 Ultra', 4)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (33, N'Redmi Note 10', 4)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (34, N'Redmi Note 10 Pro', 4)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (35, N'Poco F3', 4)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (36, N'Poco X3 Pro', 4)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (37, N'Mi 10T', 4)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (38, N'Mi 10T Pro', 4)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (39, N'Redmi 9', 4)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (40, N'Redmi Note 9', 4)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (41, N'Find X3 Pro', 5)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (42, N'Reno 5', 5)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (43, N'A74', 5)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (44, N'Find X2 Pro', 5)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (45, N'Reno 4', 5)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (46, N'Reno 4 Pro', 5)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (47, N'A93', 5)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (48, N'A53', 5)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (49, N'F17 Pro', 5)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (50, N'F19 Pro', 5)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (51, N'X60 Pro', 6)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (52, N'V21', 6)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (53, N'Y20', 6)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (54, N'X50 Pro', 6)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (55, N'V20', 6)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (56, N'V20 SE', 6)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (57, N'Y51', 6)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (58, N'Y30', 6)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (59, N'S1 Pro', 6)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (60, N'Y12s', 6)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (61, N'OnePlus 9', 7)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (62, N'OnePlus 9 Pro', 7)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (63, N'OnePlus 8T', 7)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (64, N'OnePlus 8', 7)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (65, N'OnePlus 8 Pro', 7)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (66, N'OnePlus Nord', 7)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (67, N'OnePlus Nord N10 5G', 7)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (68, N'OnePlus Nord N100', 7)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (69, N'OnePlus 7T', 7)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (70, N'OnePlus 7T Pro', 7)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (71, N'Pixel 6', 8)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (72, N'Pixel 6 Pro', 8)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (73, N'Pixel 5', 8)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (74, N'Pixel 4a', 8)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (75, N'Pixel 4a 5G', 8)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (76, N'Pixel 4', 8)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (77, N'Pixel 4 XL', 8)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (78, N'Pixel 3a', 8)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (79, N'Pixel 3a XL', 8)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (80, N'Pixel 3', 8)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (81, N'Xperia 1 III', 9)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (82, N'Xperia 5 II', 9)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (83, N'Xperia 10 III', 9)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (84, N'Xperia 1 II', 9)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (85, N'Xperia 5', 9)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (86, N'Xperia 10 II', 9)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (87, N'Xperia L4', 9)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (88, N'Xperia 10', 9)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (89, N'Xperia 8', 9)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (90, N'Xperia Ace', 9)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (91, N'Nokia 8.3 5G', 10)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (92, N'Nokia 5.4', 10)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (93, N'Nokia 3.4', 10)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (94, N'Nokia 2.4', 10)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (95, N'Nokia 1.3', 10)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (96, N'Nokia 5.3', 10)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (97, N'Nokia 7.2', 10)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (98, N'Nokia 6.2', 10)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (99, N'Nokia 4.2', 10)
GO
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (100, N'Nokia 3.2', 10)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (101, N'LG Velvet', 11)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (102, N'LG Wing', 11)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (103, N'LG V60 ThinQ', 11)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (104, N'LG G8X ThinQ', 11)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (105, N'LG G7 ThinQ', 11)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (106, N'LG V50 ThinQ', 11)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (107, N'LG Q70', 11)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (108, N'LG K92 5G', 11)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (109, N'LG Stylo 6', 11)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (110, N'LG W41', 11)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (111, N'Moto G100', 12)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (112, N'Moto G Power', 12)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (113, N'Moto E7', 12)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (114, N'Moto G9 Power', 12)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (115, N'Moto G9 Play', 12)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (116, N'Moto G9 Plus', 12)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (117, N'Moto G8 Power', 12)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (118, N'Moto G8 Play', 12)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (119, N'Moto G7 Power', 12)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (123, N'Cat I', 15)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (128, N'iPhone 7 Plus', 1)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (129, N'Cat I', 19)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (130, N'Spa X', 21)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (132, N'x45', 23)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (134, N'Max3', 25)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (136, N'XX45', 26)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (137, N'MX32', 27)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (1135, N'T45', 27)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (1136, N'465', 27)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (124, N'Cat II', 15)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (125, N'Serie L', 16)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (126, N'Serie S', 16)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (127, N'Geo 10', 17)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (131, N'Wolf 45', 22)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (133, N'Lx7', 24)
INSERT [dbo].[Modelos] ([idModelo], [Modelo], [idMarca]) VALUES (135, N'XX7', 26)
SET IDENTITY_INSERT [dbo].[Modelos] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedores] ON 

INSERT [dbo].[Proveedores] ([ID_Proveedor], [Razon_Social], [Cuit], [Telefono], [Direccion]) VALUES (1, N'Todo iPhone', N'20450839703', N'3573438680', N'Corrientes 26')
INSERT [dbo].[Proveedores] ([ID_Proveedor], [Razon_Social], [Cuit], [Telefono], [Direccion]) VALUES (3, N'RepCel', N'200200200', N'32517689', N'San Juan 123')
INSERT [dbo].[Proveedores] ([ID_Proveedor], [Razon_Social], [Cuit], [Telefono], [Direccion]) VALUES (7, N'TodoAR', N'20450459703', N'3573438656', N'Salta 26')
INSERT [dbo].[Proveedores] ([ID_Proveedor], [Razon_Social], [Cuit], [Telefono], [Direccion]) VALUES (8, N'MERCADO LIBRE', N'2020202020', N'3573414234', N'CORRIENTES 23')
SET IDENTITY_INSERT [dbo].[Proveedores] OFF
GO
SET IDENTITY_INSERT [dbo].[Reparaciones] ON 

INSERT [dbo].[Reparaciones] ([Id_Reparacion], [Id_Cliente], [Id_Equipo], [Estado], [Total], [Fecha_reparacion]) VALUES (1, NULL, 29, N'En espera', NULL, NULL)
INSERT [dbo].[Reparaciones] ([Id_Reparacion], [Id_Cliente], [Id_Equipo], [Estado], [Total], [Fecha_reparacion]) VALUES (2, NULL, 30, N'En espera', NULL, NULL)
INSERT [dbo].[Reparaciones] ([Id_Reparacion], [Id_Cliente], [Id_Equipo], [Estado], [Total], [Fecha_reparacion]) VALUES (3, NULL, 31, N'En espera', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Reparaciones] OFF
GO
SET IDENTITY_INSERT [dbo].[Repuestos] ON 

INSERT [dbo].[Repuestos] ([Id_repuesto], [Repuesto], [Descripcion], [Stock], [Precio_unitario], [Id_Proveedor]) VALUES (3, N'Modulo A20', N'Modulo A20 Media', 2, 20000.0000, 8)
INSERT [dbo].[Repuestos] ([Id_repuesto], [Repuesto], [Descripcion], [Stock], [Precio_unitario], [Id_Proveedor]) VALUES (4, N'Pin de Carga iPhone 7', N'Pin de Carga iPhone 7 Origianal ', 2, 20000.0000, 8)
INSERT [dbo].[Repuestos] ([Id_repuesto], [Repuesto], [Descripcion], [Stock], [Precio_unitario], [Id_Proveedor]) VALUES (7, N'Modulo A50', N'Modulo A20 Media', 2, 20000.0000, 3)
SET IDENTITY_INSERT [dbo].[Repuestos] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([Id_Usuario], [Usuario], [Contraseña], [Cargo]) VALUES (1, N'Admin', N'admin123', N'Administrador')
INSERT [dbo].[Usuarios] ([Id_Usuario], [Usuario], [Contraseña], [Cargo]) VALUES (2, N'Alexis', N'alexis123', N'Tecnico')
INSERT [dbo].[Usuarios] ([Id_Usuario], [Usuario], [Contraseña], [Cargo]) VALUES (4, N'luis', N'luis', N'Administrador')
INSERT [dbo].[Usuarios] ([Id_Usuario], [Usuario], [Contraseña], [Cargo]) VALUES (5, N'Roman', N'roman123', N'Administrador')
INSERT [dbo].[Usuarios] ([Id_Usuario], [Usuario], [Contraseña], [Cargo]) VALUES (6, N'Franco', N'franco123', N'Recepcionista')
INSERT [dbo].[Usuarios] ([Id_Usuario], [Usuario], [Contraseña], [Cargo]) VALUES (7, N'juan', N'juan', N'Tecnico')
INSERT [dbo].[Usuarios] ([Id_Usuario], [Usuario], [Contraseña], [Cargo]) VALUES (8, N'Carlos', N'carlos123', N'Recepcionista')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[Fallas]  WITH CHECK ADD FOREIGN KEY([Id_categoria_falla])
REFERENCES [dbo].[Categorias_Fallas] ([Id_categoria_falla])
GO
/****** Object:  StoredProcedure [dbo].[agregar_repuesto]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[agregar_repuesto]
@repuesto varchar(50),
@stock int,
@precio money,
@descripcion varchar(50),
@proveedor int
as
insert into Repuestos
values (@repuesto, @descripcion, @stock, @precio, @proveedor)
GO
/****** Object:  StoredProcedure [dbo].[agregar_usuario]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[agregar_usuario]
@usuario varchar (50),
@contraseña varchar (50),
@cargo varchar (50)
as
insert into Usuarios
values (@usuario,  @contraseña, @cargo)
GO
/****** Object:  StoredProcedure [dbo].[buscar_repuesto]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[buscar_repuesto]
@nombre varchar (50)
as 
select Id_repuesto, Repuesto, Descripcion, Stock, Precio_unitario, Razon_Social
from Repuestos r
join Proveedores p
on r.Id_Proveedor = p.ID_Proveedor
where Repuesto=@nombre
GO
/****** Object:  StoredProcedure [dbo].[buscar_usuario]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[buscar_usuario]
@usuario varchar(50)
as
select Id_Usuario as 'Codigo', Usuario, Contraseña, Cargo
from Usuarios
where Usuario = @usuario
GO
/****** Object:  StoredProcedure [dbo].[carga_grilla_equipo]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[carga_grilla_equipo]
as
select idmodelo as 'Código de Modelo', upper(Modelo) as 'Modelo', upper(Marca) as 'Marca'
from Modelos m
join Marcas ma
on m.idMarca= ma.idMarca
GO
/****** Object:  StoredProcedure [dbo].[carga_grilla_proveedor]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[carga_grilla_proveedor]
as
select ID_Proveedor 'Codigo de Proveedor', upper(Razon_Social) 'Razon Social', Cuit, Telefono, upper(Direccion) as 'Direccion'
from Proveedores
GO
/****** Object:  StoredProcedure [dbo].[cargar_combo_marca]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[cargar_combo_marca]
as
select idMarca,  upper(Marca)
from Marcas
GO
/****** Object:  StoredProcedure [dbo].[cargar_combo_modelo]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[cargar_combo_modelo]
as
select idModelo, upper(Modelo), idMarca
from Modelos
GO
/****** Object:  StoredProcedure [dbo].[cargar_equipo]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[cargar_equipo]
@Modelo varchar(50),
@idMarca int
as
insert into Modelos
values (upper(@Modelo), upper(@idMarca))
GO
/****** Object:  StoredProcedure [dbo].[cargar_equipos]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[cargar_equipos]
@idmarcas int,
@idmodelos int,
@idcliente int,
@fecha_ingreso date,
@problema_reportado varchar(50)
as
insert into Equipos
values (@idmarcas, @idmodelos, @idcliente, @fecha_ingreso, @problema_reportado)
GO
/****** Object:  StoredProcedure [dbo].[cargar_grilla_repuestos]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[cargar_grilla_repuestos]
as
select Id_repuesto as 'Codigo', Repuesto, Descripcion, Stock, Precio_unitario, Razon_Social as 'Proveedor' 
from Repuestos R
join Proveedores P 
on R.Id_Proveedor = P.ID_Proveedor
GO
/****** Object:  StoredProcedure [dbo].[cargar_grilla_usuarios]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[cargar_grilla_usuarios]
as
select Id_Usuario as 'Codigo', Usuario, Contraseña, Cargo
from Usuarios
GO
/****** Object:  StoredProcedure [dbo].[cargar_proveedor]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[cargar_proveedor]
@Razon_Social varchar (50),
@Cuit varchar (50),
@Telefono varchar (15),
@Direccion varchar (50)
as
insert into Proveedores
values (upper(@Razon_Social), @Cuit, @Telefono,upper( @Direccion))
GO
/****** Object:  StoredProcedure [dbo].[combo_marca]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[combo_marca]
as
select idMarca as 'Código de Marca',upper( Marca) as 'Marca'
from Marcas
GO
/****** Object:  StoredProcedure [dbo].[combo_modelo_x_marca]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[combo_modelo_x_marca]
@idmarca int
as
select mo.idModelo, upper(mo.Modelo) as Modelo
from Modelos mo
where mo.idMarca = @idmarca
GO
/****** Object:  StoredProcedure [dbo].[combo_proveedor]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[combo_proveedor]
as 
select *
from Proveedores
GO
/****** Object:  StoredProcedure [dbo].[consulta_x_nom]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consulta_x_nom]
@nombre varchar(59)
as 
select Id_cliente as 'Código del Cliente', upper(Nombre) as 'Nombre',upper( Apellido) as 'Apellido', Telefono as 'Teléfono', Correo ,Cuit as 'Cuil'
from Clientes
where (Nombre= @nombre or Apellido = @nombre) or ((Nombre) + ' '+ (apellido)) = @nombre
--(rtrim(Nombre) + ' '+ rtrim(apellido)) = @nombre
GO
/****** Object:  StoredProcedure [dbo].[Consultar_Razon_Social]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Consultar_Razon_Social]
@Razon_Social varchar (50)
as
select ID_Proveedor 'Codigo de Proveedor',upper( Razon_Social) 'Razon Social', Cuit, Telefono, upper(Direccion)
from Proveedores
where Razon_Social = @Razon_Social
GO
/****** Object:  StoredProcedure [dbo].[elimina_marca]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[elimina_marca]
@marca varchar(50)
as
delete
from Marcas
where Marca=@marca
GO
/****** Object:  StoredProcedure [dbo].[eliminar_equipo]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[eliminar_equipo]
@idmodelo int
as 
delete 
from [dbo].[Modelos]
where [idModelo] = @idmodelo
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_Proveedor]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Eliminar_Proveedor]
@ID_Proveedor int
as
delete
from Proveedores
where ID_Proveedor = @ID_Proveedor
GO
/****** Object:  StoredProcedure [dbo].[eliminar_repuestos]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[eliminar_repuestos]
@id int
as 
delete 
from Repuestos
where Id_repuesto = @id
GO
/****** Object:  StoredProcedure [dbo].[eliminar_usuario]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[eliminar_usuario]
@id int
as
delete 
from Usuarios
where Id_Usuario = @id
GO
/****** Object:  StoredProcedure [dbo].[Equipos_combo_fallas]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Equipos_combo_fallas]
as
select *
from Fallas
GO
/****** Object:  StoredProcedure [dbo].[equipos_sala_espera]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[equipos_sala_espera]
as
select upper(c.Nombre) as 'Nombre', upper(c.Apellido) as 'Apellido', m.Marca, o.Modelo, Falla as 'Problema Reportado', Fecha_Ingreso
from Equipos e
join Clientes c
on e.Id_Cliente = c.Id_Cliente
join Marcas m
on e.Id_Marca = m.idMarca
join Modelos o
on o.idModelo = e.Id_Modelo
join Fallas f
on f.Id_falla = e.Id_falla
order by Fecha_Ingreso asc
GO
/****** Object:  StoredProcedure [dbo].[Estadisticas_carga_cahrt]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Estadisticas_carga_cahrt]
as
select m.Marca, count(*) as 'Cant.'
from Marcas m
join Equipos e
on m.idMarca = e.Id_Marca
group by m.Marca
GO
/****** Object:  StoredProcedure [dbo].[Fallas_carga_grilla]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Fallas_carga_grilla]
as
select f.Id_falla as 'Código de falla', f.Falla as 'Falla del equipo', c.Categoria as 'Categoría del fallo'
from Fallas f
join Categorias_Fallas c
on f.Id_categoria_falla= c.Id_categoria_falla
GO
/****** Object:  StoredProcedure [dbo].[Fallas_categoria_fallas]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Fallas_categoria_fallas]
as
select Id_categoria_falla as 'Código de fallo', Categoria as 'Categoría'
from Categorias_Fallas
GO
/****** Object:  StoredProcedure [dbo].[Fallas_combo_categorias]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Fallas_combo_categorias]
as 
select Id_categoria_falla as 'Código del problema', Categoria as 'Categoría'
from Categorias_Fallas
GO
/****** Object:  StoredProcedure [dbo].[Fallas_eiminar_fallo]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Fallas_eiminar_fallo]
@id_cat int
as 
delete
from Fallas
where Id_falla=@id_cat
GO
/****** Object:  StoredProcedure [dbo].[Fallas_elimina_cat]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Fallas_elimina_cat]
@id_cat int
as
delete 
from Categorias_Fallas
where Id_categoria_falla= @id_cat
GO
/****** Object:  StoredProcedure [dbo].[Fallas_gaurda_categoria]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Fallas_gaurda_categoria]
@categoria varchar(100)
as
insert Categorias_Fallas
values (@categoria)
GO
/****** Object:  StoredProcedure [dbo].[Fallas_guargas_falla]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Fallas_guargas_falla]
@fallo varchar(100),
@id_cat int
as 
insert Fallas
values (@fallo, @id_cat)
GO
/****** Object:  StoredProcedure [dbo].[Fallas_modifica_categoria]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Fallas_modifica_categoria]
@id_cat int,
@categoria varchar(100)
as
update Categorias_Fallas
set Categoria= @categoria
where Id_categoria_falla=@id_cat
GO
/****** Object:  StoredProcedure [dbo].[Fallas_modifica_falla]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Fallas_modifica_falla]
@id_fallo int,
@fallo varchar(100),
@id_cat int
as
update Fallas
set Falla= @fallo, Id_categoria_falla=@id_cat
where Id_falla=@id_fallo
GO
/****** Object:  StoredProcedure [dbo].[grilla_taller]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[grilla_taller]
AS
BEGIN
    SELECT 
		r.Estado,
        UPPER(c.Nombre) AS 'Nombre', 
        UPPER(c.Apellido) AS 'Apellido', 
        m.Marca, 
        o.Modelo, 
        f.Falla AS 'Problema Reportado', 
        e.Fecha_Ingreso
    FROM 
        Equipos e
    JOIN 
        Clientes c ON e.Id_Cliente = c.Id_Cliente
    JOIN 
        Marcas m ON e.Id_Marca = m.idMarca
    JOIN 
        Modelos o ON e.Id_Modelo = o.idModelo
    JOIN 
        Reparaciones r ON e.Id_Equipo = r.Id_Equipo
	join 
		Fallas f on f.Id_falla = e.Id_falla
    WHERE 
        r.Estado = 'En espera'
    ORDER BY 
        e.Fecha_Ingreso ASC;
END;
GO
/****** Object:  StoredProcedure [dbo].[ini_sesion_viejo]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ini_sesion_viejo]
@usuario VARCHAR(50),
@contraseña VARCHAR(50)
AS
BEGIN
    SELECT COUNT(1) 
    FROM usuarios 
    WHERE usuario = @usuario AND contraseña = @contraseña
END
GO
/****** Object:  StoredProcedure [dbo].[inicio_sesion]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[inicio_sesion]
@usuario VARCHAR(50),
@contraseña VARCHAR(50)
AS
BEGIN
    SELECT Cargo
    FROM usuarios 
    WHERE Usuario = @usuario AND Contraseña = @contraseña
END
GO
/****** Object:  StoredProcedure [dbo].[Marcas_sala_espera]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Marcas_sala_espera]
as	
select count(Id_Marca)
from Equipos
GO
/****** Object:  StoredProcedure [dbo].[modifica_cliente]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[modifica_cliente]
@idcliente int,
@nombre varchar(50),
@apellido varchar(50),
@telefono varchar(50),
@correo varchar(50),
@cuil varchar(50)
as	
update Clientes
set Nombre=upper(@nombre), Apellido=upper(@apellido), Telefono=@telefono, Correo=@correo, Cuit=@cuil
where Id_cliente= @idcliente
GO
/****** Object:  StoredProcedure [dbo].[modifica_equipo]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[modifica_equipo]
@idmodelo int,
@modelo varchar(50),
@idmarca int
as 
update Modelos
set Modelo=upper(@modelo), idMarca=@idmarca
where idModelo=@idmodelo
GO
/****** Object:  StoredProcedure [dbo].[modificar_proveedor]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[modificar_proveedor]
@ID_Proveedor int,
@Razon_Social varchar (50),
@Cuit varchar (50),
@Telefono varchar (15),
@Direccion varchar (50)
as 
update Proveedores
set Razon_Social = upper(@Razon_Social), Cuit = @Cuit, Telefono = @Telefono, Direccion = upper(@Direccion)
where ID_Proveedor = @ID_Proveedor
GO
/****** Object:  StoredProcedure [dbo].[modificar_repuesto]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[modificar_repuesto]
@id int,
@repuesto varchar (50),
@stock int,
@precio money,
@descripcion varchar (50),
@proveedor int
as
update Repuestos
set Repuesto = @repuesto, Descripcion = @descripcion, Stock = @stock, Precio_unitario = @precio, Id_Proveedor = @proveedor
where Id_repuesto = @id
GO
/****** Object:  StoredProcedure [dbo].[modificar_usuario]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[modificar_usuario]
@id int,
@usuario varchar(50),
@contraseña varchar(50),
@cargo varchar(50)
as 
update Usuarios
set Usuario = @usuario, Contraseña = @contraseña, Cargo = @cargo
where Id_Usuario = @id
GO
/****** Object:  StoredProcedure [dbo].[nueva_marca]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[nueva_marca]
@marca varchar(50)
as
insert into Marcas
values (upper(@marca))
GO
/****** Object:  StoredProcedure [dbo].[nuevo_cliente]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[nuevo_cliente]
@nombre varchar(50),
@apellido varchar(50),
@telefono varchar(50),
@correo varchar(50),
@cuil varchar(50)
as
insert into Clientes
values (upper(@nombre),upper(@apellido),@telefono,@correo,@cuil)
GO
/****** Object:  StoredProcedure [dbo].[Taller_combo_categorias]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Taller_combo_categorias]
AS
BEGIN
    SELECT Id_categoria, Categoria, Precio_hora
    FROM Categorias
END
GO
/****** Object:  StoredProcedure [dbo].[Taller_combo_repuesos]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Taller_combo_repuesos]
AS
BEGIN
    SELECT Id_repuesto, Repuesto, Precio_unitario, Stock, Descripcion
    FROM Repuestos
END
GO
/****** Object:  StoredProcedure [dbo].[todos_campos]    Script Date: 19/10/2024 16:35:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  procedure [dbo].[todos_campos]
as 
select Id_cliente as 'Código del Cliente', upper(Nombre) as 'Nombre', upper(Apellido) as 'Apellido', Telefono as 'Teléfono', Correo, Cuit as 'Cuil'
from Clientes
GO
USE [master]
GO
ALTER DATABASE [PIN_GRUPO41] SET  READ_WRITE 
GO
