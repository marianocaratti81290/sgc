USE [GestionClientes]
GO
/****** Object:  Table [dbo].[trabajo]    Script Date: 23/6/2017 3:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[trabajo](
	[id_trabajo] [int] IDENTITY(1,1) NOT NULL,
	[situacionLaboral] [int] NULL,
	[lugarTrabajo] [varchar](50) NULL,
	[rubro] [varchar](50) NULL,
	[titulo] [varchar](50) NULL,
	[observacion] [varchar](50) NULL,
	[codAreaTel1Laboral] [varchar](5) NULL,
	[tel1Laboral] [varchar](10) NULL,
	[int1] [nchar](10) NULL,
	[codAreaTel2Laboral] [varchar](5) NULL,
	[tel2Laboral] [varchar](10) NULL,
	[int2] [nchar](10) NULL,
	[codAreaCel1Laboral] [varchar](5) NULL,
	[cel1Laboral] [varchar](10) NULL,
	[codAreaCel2Laboral] [varchar](10) NULL,
	[cel2Laboral] [nchar](10) NULL,
	[id_cliente] [int] NOT NULL,
 CONSTRAINT [PK__trabajo__428E603D262489A4] PRIMARY KEY CLUSTERED 
(
	[id_trabajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
