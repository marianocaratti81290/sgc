USE [GestionClientes]
GO
/****** Object:  Table [dbo].[HistoricoUsuarios]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HistoricoUsuarios](
	[id_usuario] [int] NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[apellido] [varchar](30) NOT NULL,
	[dni] [varchar](8) NOT NULL,
	[fecha_nacimiento] [varchar](10) NOT NULL,
	[fecha_modificacion] [varchar](30) NULL,
	[fecha_alta] [nchar](30) NOT NULL,
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
INSERT [dbo].[HistoricoUsuarios] ([id_usuario], [nombre], [apellido], [dni], [fecha_nacimiento], [fecha_modificacion], [fecha_alta], [sexo], [cel], [tel], [localidad], [provincia], [domicilio], [cp], [email], [observacion]) VALUES (8, N'Matias', N'Antonio', N'35417241', N'15/02/1990', N'Mar 22 2017 11:03:08:997AM', N'Mar 22 2017 11:03:08:997AM    ', N'Masculino ', N'2213144777', N'2214259924', N'La Plata', N'Buenos Aires', N'44 nro 620', N'1925', N'up.zaf@hotmail.com', N'No quiero que tenga acceso al sistema')
INSERT [dbo].[HistoricoUsuarios] ([id_usuario], [nombre], [apellido], [dni], [fecha_nacimiento], [fecha_modificacion], [fecha_alta], [sexo], [cel], [tel], [localidad], [provincia], [domicilio], [cp], [email], [observacion]) VALUES (9, N'Maximiliano', N'Giambelluca', N'36936190', N'22/07/1992', N'Mar 22 2017  2:33:06:800PM', N'Mar 22 2017  2:33:06:800PM    ', N'Masculino ', N'2215481305', N'2214230736', N'La Plata', N'Buenos Aires', N'20 esq 531', N'1925', N'maxigiambelluca@crednow.com.ar', N'Ninguno')
INSERT [dbo].[HistoricoUsuarios] ([id_usuario], [nombre], [apellido], [dni], [fecha_nacimiento], [fecha_modificacion], [fecha_alta], [sexo], [cel], [tel], [localidad], [provincia], [domicilio], [cp], [email], [observacion]) VALUES (10, N'Maximiliano', N'Giabelluca', N'35621457', N'08/06/1992', N'Mar 22 2017  2:42:59:183PM', N'Mar 22 2017  2:42:59:183PM    ', N'Masculino ', N'2213145874', N'2213458745', N'La Plata', N'Buenos Aires', N'asfd', N'1925', N'marisanfsd', N'Ninguno por ahora')
INSERT [dbo].[HistoricoUsuarios] ([id_usuario], [nombre], [apellido], [dni], [fecha_nacimiento], [fecha_modificacion], [fecha_alta], [sexo], [cel], [tel], [localidad], [provincia], [domicilio], [cp], [email], [observacion]) VALUES (11, N'Luis', N'Moncho', N'10554714', N'08/12/1990', N'Mar 30 2017  4:37:02:797PM', N'Mar 30 2017  4:37:02:797PM    ', N'Masculino ', N'2213144504', N'2214259924', N'Ensenada', N'Buenos Aires', N'49 nro 596', N'1925', N'ninguno', N'Prueba')
INSERT [dbo].[HistoricoUsuarios] ([id_usuario], [nombre], [apellido], [dni], [fecha_nacimiento], [fecha_modificacion], [fecha_alta], [sexo], [cel], [tel], [localidad], [provincia], [domicilio], [cp], [email], [observacion]) VALUES (14, N'juan', N'blaz', N'36547745', N'2017-04-05', N'2017-04-05', N'2017-04-05                    ', N'Masculino ', N'', N'', N'', N'', N'', N'    ', N'', N'Prueba')
INSERT [dbo].[HistoricoUsuarios] ([id_usuario], [nombre], [apellido], [dni], [fecha_nacimiento], [fecha_modificacion], [fecha_alta], [sexo], [cel], [tel], [localidad], [provincia], [domicilio], [cp], [email], [observacion]) VALUES (13, N'Matias', N'Antonio', N'35417241', N'2017-04-04', N'2017-04-04', N'2017-04-04                    ', N'Masculino ', N'2213144777', N'2214259924', N'La Plata', N'Buenos Aires', N'44 nro 620', N'1925', N'up.zaf@hotmail.com', N'Prueba')
INSERT [dbo].[HistoricoUsuarios] ([id_usuario], [nombre], [apellido], [dni], [fecha_nacimiento], [fecha_modificacion], [fecha_alta], [sexo], [cel], [tel], [localidad], [provincia], [domicilio], [cp], [email], [observacion]) VALUES (8, N'Luis', N'Alberto', N'10554117', N'2017-04-01', N'2017-04-03', N'2017-04-01                    ', N'Masculino ', N'2213144504', N'2214259924', N'A. Alsina', N'Buenos Aires', N'01', N'1900', N'asasas.com', N'Prueba')
INSERT [dbo].[HistoricoUsuarios] ([id_usuario], [nombre], [apellido], [dni], [fecha_nacimiento], [fecha_modificacion], [fecha_alta], [sexo], [cel], [tel], [localidad], [provincia], [domicilio], [cp], [email], [observacion]) VALUES (7, N'Mariano', N'Caratti', N'35500117', N'2017-03-21', N'2017-04-08', N'2017-03-21                    ', N'Masculino ', N'2213144504', N'2214259924', N'La Plata', N'Buenos Aires', N'44 nro 620', N'1925', N'mcaratti@crednow.com.ar', N'PRUEBA')
INSERT [dbo].[HistoricoUsuarios] ([id_usuario], [nombre], [apellido], [dni], [fecha_nacimiento], [fecha_modificacion], [fecha_alta], [sexo], [cel], [tel], [localidad], [provincia], [domicilio], [cp], [email], [observacion]) VALUES (17, N'mariano', N'caratti', N'35500117', N'2017-04-17', N'2017-04-17', N'2017-04-17                    ', N'Masculino ', N'', N'', N'', N'', N'', N'    ', N'', N'Prueba validacion dni
')
INSERT [dbo].[HistoricoUsuarios] ([id_usuario], [nombre], [apellido], [dni], [fecha_nacimiento], [fecha_modificacion], [fecha_alta], [sexo], [cel], [tel], [localidad], [provincia], [domicilio], [cp], [email], [observacion]) VALUES (19, N'123', N'123', N'123', N'2017-04-21', N'2017-04-21', N'2017-04-21                    ', N'Masculino ', N'', N'', N'', N'', N'', N'    ', N'', N'Prueba')
INSERT [dbo].[HistoricoUsuarios] ([id_usuario], [nombre], [apellido], [dni], [fecha_nacimiento], [fecha_modificacion], [fecha_alta], [sexo], [cel], [tel], [localidad], [provincia], [domicilio], [cp], [email], [observacion]) VALUES (18, N'Luis', N'Moncho', N'20070029', N'2017-04-21', N'2017-04-21', N'2017-04-21                    ', N'Masculino ', N'2213144504', N'2214124000', N'La Plata', N'Buenos Aires', N'44 nro 329', N'1900', N'luism@crednow.com.ar', N'Prueba')
INSERT [dbo].[HistoricoUsuarios] ([id_usuario], [nombre], [apellido], [dni], [fecha_nacimiento], [fecha_modificacion], [fecha_alta], [sexo], [cel], [tel], [localidad], [provincia], [domicilio], [cp], [email], [observacion]) VALUES (15, N'Matias', N'Antonio', N'35500117', N'2017-04-05', N'2017-04-21', N'2017-04-05                    ', N'Femenino  ', N'2213144777', N'2214259924', N'La Plata', N'Buenos Aires', N'44 nro 620', N'1925', N'up.zaf@hotmail.com', N'error')
