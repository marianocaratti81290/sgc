USE [GestionClientes]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[clientes](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[apellido] [varchar](30) NOT NULL,
	[dni] [varchar](10) NOT NULL,
	[cuil] [varchar](12) NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[estado_civil] [varchar](10) NOT NULL,
	[sexo] [varchar](10) NOT NULL,
	[codAreaTel1] [varchar](5) NULL,
	[tel1] [varchar](10) NULL,
	[ref1] [nchar](30) NULL,
	[codAreaTel2] [varchar](5) NULL,
	[tel2] [nchar](10) NULL,
	[ref2] [nchar](30) NULL,
	[codAreaCel1] [varchar](5) NULL,
	[cel1] [varchar](10) NULL,
	[ref3] [nchar](30) NULL,
	[domicilio] [varchar](50) NOT NULL,
	[localidad] [varchar](30) NOT NULL,
	[provincia] [varchar](30) NOT NULL,
	[email] [varchar](50) NULL,
	[cp] [varchar](4) NULL,
 CONSTRAINT [PK__clientes__677F38F53766F341] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[clientes] ON 

INSERT [dbo].[clientes] ([id_cliente], [nombre], [apellido], [dni], [cuil], [fecha_nacimiento], [estado_civil], [sexo], [codAreaTel1], [tel1], [ref1], [codAreaTel2], [tel2], [ref2], [codAreaCel1], [cel1], [ref3], [domicilio], [localidad], [provincia], [email], [cp]) VALUES (1, N'Mariano', N'Caratti', N'35500117', NULL, CAST(0xAF3C0B00 AS Date), N'Soltero', N'Masculino', N'221', N'4259924', NULL, NULL, NULL, NULL, N'221', N'4124000', NULL, N'44 nro 329', N'La Plata', N'Buenos Aires', N'mcaratti@crednow.com.ar', N'1925')
INSERT [dbo].[clientes] ([id_cliente], [nombre], [apellido], [dni], [cuil], [fecha_nacimiento], [estado_civil], [sexo], [codAreaTel1], [tel1], [ref1], [codAreaTel2], [tel2], [ref2], [codAreaCel1], [cel1], [ref3], [domicilio], [localidad], [provincia], [email], [cp]) VALUES (2, N'Maximiliano', N'Giambelluca', N'36936190', NULL, CAST(0x68190B00 AS Date), N'Pareja', N'Masculino', N'221', N'4230736', NULL, NULL, NULL, NULL, N'221', N'5481305', NULL, N'20 y 531', N'La Plata', N'Buenos Aires', N'maxi.guiambelluca@crednow.com.ar', N'1900')
INSERT [dbo].[clientes] ([id_cliente], [nombre], [apellido], [dni], [cuil], [fecha_nacimiento], [estado_civil], [sexo], [codAreaTel1], [tel1], [ref1], [codAreaTel2], [tel2], [ref2], [codAreaCel1], [cel1], [ref3], [domicilio], [localidad], [provincia], [email], [cp]) VALUES (3, N'Maximiliano', N'Giambelluca', N'35699874', NULL, CAST(0x68190B00 AS Date), N'Pareja', N'Masculino', N'221', N'4230736', NULL, NULL, NULL, NULL, N'221', N'5481305', NULL, N'20 y 531', N'La Plata', N'Buenos Aires', N'maxi.guiambelluca@crednow.com.ar', N'1900')
INSERT [dbo].[clientes] ([id_cliente], [nombre], [apellido], [dni], [cuil], [fecha_nacimiento], [estado_civil], [sexo], [codAreaTel1], [tel1], [ref1], [codAreaTel2], [tel2], [ref2], [codAreaCel1], [cel1], [ref3], [domicilio], [localidad], [provincia], [email], [cp]) VALUES (4, N'Maximiliano', N'Giambelluca', N'587745', NULL, CAST(0x68190B00 AS Date), N'Pareja', N'Masculino', N'221', N'4230736', NULL, NULL, NULL, NULL, N'221', N'5481305', NULL, N'20 y 531', N'La Plata', N'Buenos Aires', N'maxi.guiambelluca@crednow.com.ar', N'1900')
INSERT [dbo].[clientes] ([id_cliente], [nombre], [apellido], [dni], [cuil], [fecha_nacimiento], [estado_civil], [sexo], [codAreaTel1], [tel1], [ref1], [codAreaTel2], [tel2], [ref2], [codAreaCel1], [cel1], [ref3], [domicilio], [localidad], [provincia], [email], [cp]) VALUES (5, N'matias', N'antonio', N'35417241', N'', CAST(0xB83C0B00 AS Date), N'Soltero', N'Masculino', N'', N'', N'                              ', N'', N'          ', N'                              ', N'', N'', N'                              ', N'', N'La Plata', N'Buenos Aires', N'', N'')
INSERT [dbo].[clientes] ([id_cliente], [nombre], [apellido], [dni], [cuil], [fecha_nacimiento], [estado_civil], [sexo], [codAreaTel1], [tel1], [ref1], [codAreaTel2], [tel2], [ref2], [codAreaCel1], [cel1], [ref3], [domicilio], [localidad], [provincia], [email], [cp]) VALUES (6, N'Isabel', N'Lopez', N'14417554', N'20144175542', CAST(0x18170B00 AS Date), N'Casado', N'Femenino', N'221', N'4259924', N'ninguna                       ', N'221', N'4124000   ', N'aca                           ', N'221', N'3145936', N'ella                          ', N'126 y 49', N'La Plata', N'Buenos Aires', N'isanel_61@yahoo.com.ar', N'1925')
INSERT [dbo].[clientes] ([id_cliente], [nombre], [apellido], [dni], [cuil], [fecha_nacimiento], [estado_civil], [sexo], [codAreaTel1], [tel1], [ref1], [codAreaTel2], [tel2], [ref2], [codAreaCel1], [cel1], [ref3], [domicilio], [localidad], [provincia], [email], [cp]) VALUES (7, N'Luis', N'Alberto', N'10254254', N'', CAST(0xB83C0B00 AS Date), N'', N'', N'', N'', N'                              ', N'', N'          ', N'                              ', N'', N'', N'                              ', N'', N'', N'', N'', N'')
INSERT [dbo].[clientes] ([id_cliente], [nombre], [apellido], [dni], [cuil], [fecha_nacimiento], [estado_civil], [sexo], [codAreaTel1], [tel1], [ref1], [codAreaTel2], [tel2], [ref2], [codAreaCel1], [cel1], [ref3], [domicilio], [localidad], [provincia], [email], [cp]) VALUES (8, N'Prueba', N'Alfonso', N'35852169', N'2022222222', CAST(0xE03C0B00 AS Date), N'Casado', N'Masculino', N'221', N'221', N'                              ', N'221', N'221       ', N'                              ', N'221', N'221', N'                              ', N'221', N'3 de febrero', N'Buenos Aires', N'2121', N'1222')
INSERT [dbo].[clientes] ([id_cliente], [nombre], [apellido], [dni], [cuil], [fecha_nacimiento], [estado_civil], [sexo], [codAreaTel1], [tel1], [ref1], [codAreaTel2], [tel2], [ref2], [codAreaCel1], [cel1], [ref3], [domicilio], [localidad], [provincia], [email], [cp]) VALUES (9, N'asd', N'asd', N'34444333', N'333333', CAST(0xE03C0B00 AS Date), N'Casado', N'Masculino', N'324', N'34', N'                              ', N'34', N'324       ', N'                              ', N'324', N'324', N'                              ', N'4324324', N'3 de febrero', N'Buenos Aires', N'324', N'213')
INSERT [dbo].[clientes] ([id_cliente], [nombre], [apellido], [dni], [cuil], [fecha_nacimiento], [estado_civil], [sexo], [codAreaTel1], [tel1], [ref1], [codAreaTel2], [tel2], [ref2], [codAreaCel1], [cel1], [ref3], [domicilio], [localidad], [provincia], [email], [cp]) VALUES (10, N'dsf', N'sdf', N'234', N'3232432', CAST(0xE03C0B00 AS Date), N'Soltero', N'Masculino', N'', N'', N'                              ', N'', N'          ', N'                              ', N'', N'', N'                              ', N'', N'3 de febrero', N'Buenos Aires', N'', N'5436')
INSERT [dbo].[clientes] ([id_cliente], [nombre], [apellido], [dni], [cuil], [fecha_nacimiento], [estado_civil], [sexo], [codAreaTel1], [tel1], [ref1], [codAreaTel2], [tel2], [ref2], [codAreaCel1], [cel1], [ref3], [domicilio], [localidad], [provincia], [email], [cp]) VALUES (11, N'Mariano', N'Caratti', N'35417258', N'20354172583', CAST(0x18170B00 AS Date), N'Soltero', N'Masculino', N'221', N'4259924', N'casa mama                     ', N'', N'          ', N'                              ', N'221', N'3144504', N'propio                        ', N'44 nro 329', N'La Plata', N'Buenos Aires', N'mcaratti@crednow.com.ar', N'1900')
INSERT [dbo].[clientes] ([id_cliente], [nombre], [apellido], [dni], [cuil], [fecha_nacimiento], [estado_civil], [sexo], [codAreaTel1], [tel1], [ref1], [codAreaTel2], [tel2], [ref2], [codAreaCel1], [cel1], [ref3], [domicilio], [localidad], [provincia], [email], [cp]) VALUES (12, N'Marcos', N'Swirch', N'32456654', N'20326544563', CAST(0x18170B00 AS Date), N'Soltero', N'Masculino', N'221', N'4259924', N'casa                          ', N'', N'          ', N'                              ', N'221', N'3144504', N' part                         ', N'44 nro 620', N'La Plata', N'Buenos Aires', N'mcaratti@crednow.com.ar', N'1925')
INSERT [dbo].[clientes] ([id_cliente], [nombre], [apellido], [dni], [cuil], [fecha_nacimiento], [estado_civil], [sexo], [codAreaTel1], [tel1], [ref1], [codAreaTel2], [tel2], [ref2], [codAreaCel1], [cel1], [ref3], [domicilio], [localidad], [provincia], [email], [cp]) VALUES (13, N'sdf', N'sdf456', N'456', N'5454645', CAST(0xF53C0B00 AS Date), N'Soltero', N'Masculino', N'546', N'546', N'                              ', N'546', N'456       ', N'                              ', N'546', N'456', N'                              ', N'546', N'Acassuso', N'Buenos Aires-GBA', N'', N'1900')
INSERT [dbo].[clientes] ([id_cliente], [nombre], [apellido], [dni], [cuil], [fecha_nacimiento], [estado_civil], [sexo], [codAreaTel1], [tel1], [ref1], [codAreaTel2], [tel2], [ref2], [codAreaCel1], [cel1], [ref3], [domicilio], [localidad], [provincia], [email], [cp]) VALUES (14, N'111', N'111', N'15321123', N'11111111', CAST(0xF63C0B00 AS Date), N'Soltero', N'Masculino', N'', N'', N'                              ', N'', N'          ', N'                              ', N'', N'', N'                              ', N'', N'La Plata', N'Buenos Aires', N'dsfdsf', N'1925')
SET IDENTITY_INSERT [dbo].[clientes] OFF
