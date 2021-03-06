USE [GestionClientes]
GO
/****** Object:  Table [dbo].[HistoricoSucursales]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HistoricoSucursales](
	[id_sucursal] [int] NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[direccion] [varchar](50) NULL,
	[fecha_alta] [varchar](30) NOT NULL,
	[fecha_modificacion] [varchar](30) NULL,
	[telefono] [varchar](10) NULL,
	[estado] [varchar](10) NOT NULL,
	[tpoContrato] [nchar](10) NOT NULL,
	[fechaContrato] [varchar](30) NOT NULL,
	[observacion] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[HistoricoSucursales] ([id_sucursal], [nombre], [direccion], [fecha_alta], [fecha_modificacion], [telefono], [estado], [tpoContrato], [fechaContrato], [observacion]) VALUES (7, N'City', N'Ninguna', N'Mar 23 2017  3:39:57:933PM', N'Mar 23 2017  3:39:57:933PM', N'2214124587', N'Activo', N'Propio    ', N'No', N'No existe mas')
INSERT [dbo].[HistoricoSucursales] ([id_sucursal], [nombre], [direccion], [fecha_alta], [fecha_modificacion], [telefono], [estado], [tpoContrato], [fechaContrato], [observacion]) VALUES (7, N'City', N'Ninguna', N'Mar 23 2017  3:39:57:933PM', N'Mar 23 2017  3:39:57:933PM', N'2214124587', N'Activo', N'Propio    ', N'No', N'No existe mas')
INSERT [dbo].[HistoricoSucursales] ([id_sucursal], [nombre], [direccion], [fecha_alta], [fecha_modificacion], [telefono], [estado], [tpoContrato], [fechaContrato], [observacion]) VALUES (2, N'Ensenada', N'La Merced', N'2017-04-01', N'2017-04-01', N'2214124000', N'Activo', N'Propio    ', N'No', N'Prueba')
INSERT [dbo].[HistoricoSucursales] ([id_sucursal], [nombre], [direccion], [fecha_alta], [fecha_modificacion], [telefono], [estado], [tpoContrato], [fechaContrato], [observacion]) VALUES (1, N'Ensenada', N'La Merced', N'2017-04-01', N'2017-04-01', N'2214124000', N'Activo', N'Propio    ', N'No', N'Prueba')
INSERT [dbo].[HistoricoSucursales] ([id_sucursal], [nombre], [direccion], [fecha_alta], [fecha_modificacion], [telefono], [estado], [tpoContrato], [fechaContrato], [observacion]) VALUES (3, N'La Plata', N'44 nro 320', N'2017-04-01', N'2017-04-01', N'2213144504', N'Activo', N'          ', N'sábado, 1 de abril de 2017', N'apRUEBA')
INSERT [dbo].[HistoricoSucursales] ([id_sucursal], [nombre], [direccion], [fecha_alta], [fecha_modificacion], [telefono], [estado], [tpoContrato], [fechaContrato], [observacion]) VALUES (4, N'Enseanda', N'La Merced', N'2017-04-01', N'2017-04-01', N'2214124000', N'Activo', N'          ', N'sábado, 1 de abril de 2017', N'Prueba')
INSERT [dbo].[HistoricoSucursales] ([id_sucursal], [nombre], [direccion], [fecha_alta], [fecha_modificacion], [telefono], [estado], [tpoContrato], [fechaContrato], [observacion]) VALUES (5, N'Ensenada', N'La Merced', N'2017-04-01', N'2017-04-01', N'2214124000', N'Activo', N'Alquiler  ', N'sábado, 1 de abril de 2017', N'Ninguno')
INSERT [dbo].[HistoricoSucursales] ([id_sucursal], [nombre], [direccion], [fecha_alta], [fecha_modificacion], [telefono], [estado], [tpoContrato], [fechaContrato], [observacion]) VALUES (6, N'Ensenada', N'La Merced', N'2017-04-01', N'2017-04-02', N'2214124000', N'Activo', N'Alquiler  ', N'Apr  2 2017 10:54AM', N'Prueba de grilla vacia')
INSERT [dbo].[HistoricoSucursales] ([id_sucursal], [nombre], [direccion], [fecha_alta], [fecha_modificacion], [telefono], [estado], [tpoContrato], [fechaContrato], [observacion]) VALUES (7, N'Ensenada1', N'124', N'2017-04-01', N'2017-04-01', N'5676', N'Inactivo', N'Propio    ', N'Apr 12 2017 11:35AM', N'prueba del sistema')
INSERT [dbo].[HistoricoSucursales] ([id_sucursal], [nombre], [direccion], [fecha_alta], [fecha_modificacion], [telefono], [estado], [tpoContrato], [fechaContrato], [observacion]) VALUES (8, N'Ensenada', N'la merced', N'2017-04-05', N'2017-04-05', N'2214124000', N'Inactivo', N'Alquiler  ', N'miércoles, 5 de abril de 2017', N'Prueba')
INSERT [dbo].[HistoricoSucursales] ([id_sucursal], [nombre], [direccion], [fecha_alta], [fecha_modificacion], [telefono], [estado], [tpoContrato], [fechaContrato], [observacion]) VALUES (1009, N'CitiBell', N'Cantilo 960', N'2017-04-22', N'2017-04-22', N'2214124000', N'Activo', N'Propio    ', N'Mar 17 2018 12:00AM', N'no funko')
INSERT [dbo].[HistoricoSucursales] ([id_sucursal], [nombre], [direccion], [fecha_alta], [fecha_modificacion], [telefono], [estado], [tpoContrato], [fechaContrato], [observacion]) VALUES (9, N'Ensenada', N'La Merced 665', N'2017-04-17', N'2017-04-17', N'2214124000', N'Activo', N'Propio    ', N'Apr 17 2017  2:22PM', N'mimguno')
