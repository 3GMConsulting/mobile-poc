USE [MobilePOC]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 10/4/2020 02:22:35 ******/
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
/****** Object:  Table [dbo].[UsuarioPerfil]    Script Date: 10/4/2020 02:22:35 ******/
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
/****** Object:  Table [dbo].[UsuarioSeguridad]    Script Date: 10/4/2020 02:22:35 ******/
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
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([IdUsuario], [Usuario], [Contrasena], [NombreCompleto], [Mail], [FechaNacimiento], [IdUsuarioPerfil], [IdUsuarioSeguridad]) VALUES (3, N'Madiox', N'1111', N'Matias Gaudio', N'matiasgaudio@gmail.com', CAST(N'1996-01-01' AS Date), 1, 1)
INSERT [dbo].[Usuario] ([IdUsuario], [Usuario], [Contrasena], [NombreCompleto], [Mail], [FechaNacimiento], [IdUsuarioPerfil], [IdUsuarioSeguridad]) VALUES (4, N'Krapsus', N'2222', N'Fernando Martinez', N'fernandomartinez@gmail.com', CAST(N'1997-01-01' AS Date), 2, 2)
INSERT [dbo].[Usuario] ([IdUsuario], [Usuario], [Contrasena], [NombreCompleto], [Mail], [FechaNacimiento], [IdUsuarioPerfil], [IdUsuarioSeguridad]) VALUES (5, N'SituationUK', N'3333', N'Bruno Garza', N'brunogarza.dm@gmail.com', CAST(N'1993-01-01' AS Date), 3, 3)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
SET IDENTITY_INSERT [dbo].[UsuarioPerfil] ON 

INSERT [dbo].[UsuarioPerfil] ([IdUsuarioPerfil], [FotoPerfil], [EstadoPerfil], [ScoreJugador], [ScoreObservador], [ScoreGlobal]) VALUES (1, NULL, N'TEST', 0, 0, 0)
INSERT [dbo].[UsuarioPerfil] ([IdUsuarioPerfil], [FotoPerfil], [EstadoPerfil], [ScoreJugador], [ScoreObservador], [ScoreGlobal]) VALUES (2, NULL, N'TEST2', 0, 0, 0)
INSERT [dbo].[UsuarioPerfil] ([IdUsuarioPerfil], [FotoPerfil], [EstadoPerfil], [ScoreJugador], [ScoreObservador], [ScoreGlobal]) VALUES (3, NULL, N'TEST3', 0, 0, 0)
SET IDENTITY_INSERT [dbo].[UsuarioPerfil] OFF
SET IDENTITY_INSERT [dbo].[UsuarioSeguridad] ON 

INSERT [dbo].[UsuarioSeguridad] ([IdUsuarioSeguridad], [PreguntaSecreta], [RespuestaSecreta]) VALUES (1, N'FutbolistaFavorito', N'LeoPonzio')
INSERT [dbo].[UsuarioSeguridad] ([IdUsuarioSeguridad], [PreguntaSecreta], [RespuestaSecreta]) VALUES (2, N'LibroFavorito', N'1984')
INSERT [dbo].[UsuarioSeguridad] ([IdUsuarioSeguridad], [PreguntaSecreta], [RespuestaSecreta]) VALUES (3, N'FutbolistaFavorito', N'DavidBeckham')
SET IDENTITY_INSERT [dbo].[UsuarioSeguridad] OFF
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD FOREIGN KEY([IdUsuarioPerfil])
REFERENCES [dbo].[UsuarioPerfil] ([IdUsuarioPerfil])
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD FOREIGN KEY([IdUsuarioSeguridad])
REFERENCES [dbo].[UsuarioSeguridad] ([IdUsuarioSeguridad])
GO
