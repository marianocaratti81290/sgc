USE [GestionClientes]
GO
/****** Object:  Table [dbo].[origenRelacMarketing]    Script Date: 23/6/2017 3:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[origenRelacMarketing](
	[id_Relac] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[id_origen] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
