USE [GestionClientes]
GO
/****** Object:  Table [dbo].[origenMarketing]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[origenMarketing](
	[id_origen] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[origenMarketing] ([id_origen], [descripcion]) VALUES (1, N'Multimedia')
INSERT [dbo].[origenMarketing] ([id_origen], [descripcion]) VALUES (2, N'CallCenter')
INSERT [dbo].[origenMarketing] ([id_origen], [descripcion]) VALUES (3, N'Ventas')
INSERT [dbo].[origenMarketing] ([id_origen], [descripcion]) VALUES (4, N'Referidos')
INSERT [dbo].[origenMarketing] ([id_origen], [descripcion]) VALUES (5, N'Digital')
