USE [GestionClientes]
GO
/****** Object:  Table [dbo].[localidades]    Script Date: 23/6/2017 3:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[localidades](
	[id] [int] NOT NULL,
	[id_privincia] [int] NOT NULL,
	[localidad] [varchar](255) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
