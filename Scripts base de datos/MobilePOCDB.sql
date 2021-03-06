USE [MobilePOC]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 10/4/2020 00:22:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [nvarchar](max) NULL,
	[Contrasena] [nvarchar](max) NULL,
	[NombreCompleto] [nvarchar](max) NULL,
	[Mail] [nvarchar](max) NULL,
	[FechaNacimiento] [date] NULL,
	[IdUsuarioPerfil] [int] NULL,
	[IdUsuarioSeguridad] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioPerfil]    Script Date: 10/4/2020 00:22:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioPerfil](
	[IdUsuarioPerfil] [int] IDENTITY(1,1) NOT NULL,
	[FotoPerfil] [varbinary](max) NULL,
	[EstadoPerfil] [nvarchar](max) NULL,
	[ScoreJugador] [int] NULL,
	[ScoreObservador] [int] NULL,
	[ScoreGlobal] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuarioPerfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioSeguridad]    Script Date: 10/4/2020 00:22:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioSeguridad](
	[IdUsuarioSeguridad] [int] IDENTITY(1,1) NOT NULL,
	[PreguntaSecreta] [nvarchar](max) NULL,
	[RespuestaSecreta] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuarioSeguridad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD FOREIGN KEY([IdUsuarioPerfil])
REFERENCES [dbo].[UsuarioPerfil] ([IdUsuarioPerfil])
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD FOREIGN KEY([IdUsuarioSeguridad])
REFERENCES [dbo].[UsuarioSeguridad] ([IdUsuarioSeguridad])
GO
