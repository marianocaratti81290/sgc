USE [GestionClientes]
GO
/****** Object:  Table [dbo].[origenRelacMarketing]    Script Date: 26/6/2017 9:50:10 p. m. ******/
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
SET IDENTITY_INSERT [dbo].[origenRelacMarketing] ON 

INSERT [dbo].[origenRelacMarketing] ([id_Relac], [descripcion], [id_origen]) VALUES (1, N'Radio', 1)
INSERT [dbo].[origenRelacMarketing] ([id_Relac], [descripcion], [id_origen]) VALUES (2, N'Diario', 1)
INSERT [dbo].[origenRelacMarketing] ([id_Relac], [descripcion], [id_origen]) VALUES (3, N'Carta', 1)
INSERT [dbo].[origenRelacMarketing] ([id_Relac], [descripcion], [id_origen]) VALUES (4, N'Revista', 1)
INSERT [dbo].[origenRelacMarketing] ([id_Relac], [descripcion], [id_origen]) VALUES (5, N'Tarjeta Nexo', 1)
INSERT [dbo].[origenRelacMarketing] ([id_Relac], [descripcion], [id_origen]) VALUES (6, N'Otros', 1)
INSERT [dbo].[origenRelacMarketing] ([id_Relac], [descripcion], [id_origen]) VALUES (7, N'Entrantes-SMS', 2)
INSERT [dbo].[origenRelacMarketing] ([id_Relac], [descripcion], [id_origen]) VALUES (8, N'Entrantes-Ventas', 2)
INSERT [dbo].[origenRelacMarketing] ([id_Relac], [descripcion], [id_origen]) VALUES (9, N'Entrantes-Otros', 2)
INSERT [dbo].[origenRelacMarketing] ([id_Relac], [descripcion], [id_origen]) VALUES (10, N'Salientes-Ventas', 2)
INSERT [dbo].[origenRelacMarketing] ([id_Relac], [descripcion], [id_origen]) VALUES (11, N'Salientes-Cobranza', 2)
INSERT [dbo].[origenRelacMarketing] ([id_Relac], [descripcion], [id_origen]) VALUES (12, N'Suc Calle44', 3)
INSERT [dbo].[origenRelacMarketing] ([id_Relac], [descripcion], [id_origen]) VALUES (13, N'Suc Calle12', 3)
INSERT [dbo].[origenRelacMarketing] ([id_Relac], [descripcion], [id_origen]) VALUES (14, N'Suc Ensenada', 3)
INSERT [dbo].[origenRelacMarketing] ([id_Relac], [descripcion], [id_origen]) VALUES (15, N'Suc Berisso', 3)
INSERT [dbo].[origenRelacMarketing] ([id_Relac], [descripcion], [id_origen]) VALUES (16, N'Suc Quilmes', 3)
INSERT [dbo].[origenRelacMarketing] ([id_Relac], [descripcion], [id_origen]) VALUES (17, N'Suc Los Hornos', 3)
INSERT [dbo].[origenRelacMarketing] ([id_Relac], [descripcion], [id_origen]) VALUES (18, N'Cliente', 4)
INSERT [dbo].[origenRelacMarketing] ([id_Relac], [descripcion], [id_origen]) VALUES (19, N'Promotor', 4)
INSERT [dbo].[origenRelacMarketing] ([id_Relac], [descripcion], [id_origen]) VALUES (20, N'Presidencia', 4)
INSERT [dbo].[origenRelacMarketing] ([id_Relac], [descripcion], [id_origen]) VALUES (21, N'Facebook', 5)
INSERT [dbo].[origenRelacMarketing] ([id_Relac], [descripcion], [id_origen]) VALUES (22, N'Facebook', 5)
INSERT [dbo].[origenRelacMarketing] ([id_Relac], [descripcion], [id_origen]) VALUES (23, N'Whatsapp', 5)
INSERT [dbo].[origenRelacMarketing] ([id_Relac], [descripcion], [id_origen]) VALUES (24, N'Pagina Web', 5)
INSERT [dbo].[origenRelacMarketing] ([id_Relac], [descripcion], [id_origen]) VALUES (25, N'Email', 5)
SET IDENTITY_INSERT [dbo].[origenRelacMarketing] OFF
