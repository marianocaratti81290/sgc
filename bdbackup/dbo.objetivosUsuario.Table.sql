USE [GestionClientes]
GO
/****** Object:  Table [dbo].[objetivosUsuario]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[objetivosUsuario](
	[id_objUsr] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](30) NOT NULL,
	[importe] [real] NOT NULL,
	[fecha_desde] [date] NOT NULL,
	[fecha_hasta] [date] NOT NULL,
	[estado] [varchar](10) NOT NULL,
	[observacion] [varchar](50) NOT NULL,
	[id_suc] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_objUsr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
