USE [GestionClientes]
GO
/****** Object:  Table [dbo].[HistoricoUsuarios]    Script Date: 23/6/2017 3:47:05 p. m. ******/
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
