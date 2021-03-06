USE [GestionClientes]
GO
/****** Object:  Table [dbo].[HistoricoSucursales]    Script Date: 23/6/2017 3:47:05 p. m. ******/
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
