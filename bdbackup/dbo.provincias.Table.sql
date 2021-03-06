USE [GestionClientes]
GO
/****** Object:  Table [dbo].[provincias]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[provincias](
	[id] [int] NOT NULL,
	[provincia] [varchar](255) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[provincias] ([id], [provincia]) VALUES (1, N'Buenos Aires')
INSERT [dbo].[provincias] ([id], [provincia]) VALUES (2, N'Buenos Aires-GBA')
INSERT [dbo].[provincias] ([id], [provincia]) VALUES (3, N'Capital Federal')
INSERT [dbo].[provincias] ([id], [provincia]) VALUES (4, N'Catamarca')
INSERT [dbo].[provincias] ([id], [provincia]) VALUES (5, N'Chaco')
INSERT [dbo].[provincias] ([id], [provincia]) VALUES (6, N'Chubut')
INSERT [dbo].[provincias] ([id], [provincia]) VALUES (7, N'Córdoba')
INSERT [dbo].[provincias] ([id], [provincia]) VALUES (8, N'Corrientes')
INSERT [dbo].[provincias] ([id], [provincia]) VALUES (9, N'Entre Ríos')
INSERT [dbo].[provincias] ([id], [provincia]) VALUES (10, N'Formosa')
INSERT [dbo].[provincias] ([id], [provincia]) VALUES (11, N'Jujuy')
INSERT [dbo].[provincias] ([id], [provincia]) VALUES (12, N'La Pampa')
INSERT [dbo].[provincias] ([id], [provincia]) VALUES (13, N'La Rioja')
INSERT [dbo].[provincias] ([id], [provincia]) VALUES (14, N'Mendoza')
INSERT [dbo].[provincias] ([id], [provincia]) VALUES (15, N'Misiones')
INSERT [dbo].[provincias] ([id], [provincia]) VALUES (16, N'Neuquén')
INSERT [dbo].[provincias] ([id], [provincia]) VALUES (17, N'Río Negro')
INSERT [dbo].[provincias] ([id], [provincia]) VALUES (18, N'Salta')
INSERT [dbo].[provincias] ([id], [provincia]) VALUES (19, N'San Juan')
INSERT [dbo].[provincias] ([id], [provincia]) VALUES (20, N'San Luis')
INSERT [dbo].[provincias] ([id], [provincia]) VALUES (21, N'Santa Cruz')
INSERT [dbo].[provincias] ([id], [provincia]) VALUES (22, N'Santa Fe')
INSERT [dbo].[provincias] ([id], [provincia]) VALUES (23, N'Santiago del Estero')
INSERT [dbo].[provincias] ([id], [provincia]) VALUES (24, N'Tierra del Fuego')
INSERT [dbo].[provincias] ([id], [provincia]) VALUES (25, N'Tucumán')
