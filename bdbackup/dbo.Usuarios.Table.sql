USE [GestionClientes]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[apellido] [varchar](30) NOT NULL,
	[dni] [varchar](8) NOT NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[fecha_modificacion] [date] NULL,
	[fecha_alta] [date] NOT NULL,
	[sexo] [nchar](10) NOT NULL,
	[cel] [varchar](20) NULL,
	[tel] [varchar](20) NULL,
	[localidad] [varchar](30) NULL,
	[provincia] [varchar](30) NULL,
	[domicilio] [varchar](50) NULL,
	[cp] [nchar](4) NULL,
	[email] [varchar](50) NULL,
	[observacion] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([id_usuario], [nombre], [apellido], [dni], [fecha_nacimiento], [fecha_modificacion], [fecha_alta], [sexo], [cel], [tel], [localidad], [provincia], [domicilio], [cp], [email], [observacion]) VALUES (1016, N'Mariano', N'Caratti', N'35500117', CAST(0xB83C0B00 AS Date), CAST(0xB83C0B00 AS Date), CAST(0xB83C0B00 AS Date), N'Masculino ', N'2213144504', N'2214259924', N'La Plata', N'Buenos Aires', N'124 e/ 44 y 45 nro 620', N'1925', N'mcaratti@crednow.com.ar', N'Administrador')
INSERT [dbo].[Usuarios] ([id_usuario], [nombre], [apellido], [dni], [fecha_nacimiento], [fecha_modificacion], [fecha_alta], [sexo], [cel], [tel], [localidad], [provincia], [domicilio], [cp], [email], [observacion]) VALUES (16, N'Maximiliano', N'Giambelluca', N'35500112', CAST(0xB33C0B00 AS Date), CAST(0xB33C0B00 AS Date), CAST(0xB33C0B00 AS Date), N'Masculino ', N'', N'', N'La Plata', N'Buenos Aires', N'', N'    ', N'', N'')
INSERT [dbo].[Usuarios] ([id_usuario], [nombre], [apellido], [dni], [fecha_nacimiento], [fecha_modificacion], [fecha_alta], [sexo], [cel], [tel], [localidad], [provincia], [domicilio], [cp], [email], [observacion]) VALUES (1017, N'Andres', N'Dri Gopar', N'29371117', CAST(0xD33C0B00 AS Date), CAST(0xD33C0B00 AS Date), CAST(0xD33C0B00 AS Date), N'Masculino ', N'2214956409', N'', N'La Plata', N'Buenos Aires', N'', N'1900', N'', N'')
INSERT [dbo].[Usuarios] ([id_usuario], [nombre], [apellido], [dni], [fecha_nacimiento], [fecha_modificacion], [fecha_alta], [sexo], [cel], [tel], [localidad], [provincia], [domicilio], [cp], [email], [observacion]) VALUES (1018, N'Matias', N'Antonio', N'35417241', CAST(0xE6150B00 AS Date), CAST(0xF63C0B00 AS Date), CAST(0xF63C0B00 AS Date), N'Masculino ', N'2213144777', N'2214723680', N'La Plata', N'Buenos Aires', N'44 nro 620', N'1925', N'up.zaf@hotmail.com', N'')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
