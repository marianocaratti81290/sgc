USE [GestionClientes]
GO
/****** Object:  Table [dbo].[Sucursales]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sucursales](
	[id_sucursal] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[direccion] [varchar](50) NULL,
	[fecha_alta] [date] NOT NULL,
	[fecha_modificacion] [date] NULL,
	[telefono] [varchar](10) NULL,
	[estado] [varchar](10) NOT NULL,
	[tpoContrato] [nchar](10) NOT NULL,
	[fechaContrato] [varchar](30) NOT NULL,
	[observacion] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Sucursales] ON 

INSERT [dbo].[Sucursales] ([id_sucursal], [nombre], [direccion], [fecha_alta], [fecha_modificacion], [telefono], [estado], [tpoContrato], [fechaContrato], [observacion]) VALUES (1, N'Casa Central', N'44 Nro 329', CAST(0xD33C0B00 AS Date), CAST(0xD33C0B00 AS Date), N'4124000', N'Activo', N'Propio    ', N'No', N'')
SET IDENTITY_INSERT [dbo].[Sucursales] OFF
