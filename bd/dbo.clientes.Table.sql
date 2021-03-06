USE [GestionClientes]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 23/6/2017 3:47:05 p. m. ******/
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
