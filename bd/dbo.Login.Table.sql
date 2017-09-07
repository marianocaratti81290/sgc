USE [GestionClientes]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 23/6/2017 3:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[id_login] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [nvarchar](200) NOT NULL,
	[password] [nvarchar](200) NOT NULL,
	[estado] [int] NOT NULL,
	[id_usuario] [int] NULL,
	[usrSinEncript] [nchar](30) NULL,
	[passSinEncript] [nchar](30) NULL
) ON [PRIMARY]

GO
