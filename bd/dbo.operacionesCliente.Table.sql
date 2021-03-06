USE [GestionClientes]
GO
/****** Object:  Table [dbo].[operacionesCliente]    Script Date: 23/6/2017 3:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[operacionesCliente](
	[id_operacion] [int] IDENTITY(1,1) NOT NULL,
	[dni] [varchar](10) NULL,
	[apyn] [varchar](50) NULL,
	[operacion] [varchar](50) NULL,
	[tipoPrestamo] [varchar](20) NULL,
	[origen] [varchar](30) NULL,
	[cbRelacOrigen] [varchar](30) NULL,
	[importe] [int] NULL,
	[plazo] [varchar](5) NULL,
	[cbplazo] [varchar](20) NULL,
	[estado] [varchar](30) NULL,
	[fecha] [date] NULL,
 CONSTRAINT [PK__operacio__AC60F426EE3467A6] PRIMARY KEY CLUSTERED 
(
	[id_operacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
