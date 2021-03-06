USE [GestionClientes]
GO
/****** Object:  Table [dbo].[trabajo]    Script Date: 26/6/2017 9:50:10 p. m. ******/
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
SET IDENTITY_INSERT [dbo].[trabajo] ON 

INSERT [dbo].[trabajo] ([id_trabajo], [situacionLaboral], [lugarTrabajo], [rubro], [titulo], [observacion], [codAreaTel1Laboral], [tel1Laboral], [int1], [codAreaTel2Laboral], [tel2Laboral], [int2], [codAreaCel1Laboral], [cel1Laboral], [codAreaCel2Laboral], [cel2Laboral], [id_cliente]) VALUES (1, 1, N'Finvert S.R.L', N'Financiera', N'Sistemas', N'Ninguna', N'221', N'4124000', NULL, N'', N'', NULL, N'', N'', N'', NULL, 1)
INSERT [dbo].[trabajo] ([id_trabajo], [situacionLaboral], [lugarTrabajo], [rubro], [titulo], [observacion], [codAreaTel1Laboral], [tel1Laboral], [int1], [codAreaTel2Laboral], [tel2Laboral], [int2], [codAreaCel1Laboral], [cel1Laboral], [codAreaCel2Laboral], [cel2Laboral], [id_cliente]) VALUES (2, 1, N'Finvert', N'Financiera', N'Licenciado en Marketing', N'Full time', N'221', N'4124000', NULL, N'221', N'4124000', NULL, N'', N'', N'', NULL, 2)
INSERT [dbo].[trabajo] ([id_trabajo], [situacionLaboral], [lugarTrabajo], [rubro], [titulo], [observacion], [codAreaTel1Laboral], [tel1Laboral], [int1], [codAreaTel2Laboral], [tel2Laboral], [int2], [codAreaCel1Laboral], [cel1Laboral], [codAreaCel2Laboral], [cel2Laboral], [id_cliente]) VALUES (3, 1, N'Finvert', N'Financiera', N'Licenciado en Marketing', N'Full time', N'221', N'4124000', NULL, N'221', N'4124000', NULL, N'', N'', N'', NULL, 3)
INSERT [dbo].[trabajo] ([id_trabajo], [situacionLaboral], [lugarTrabajo], [rubro], [titulo], [observacion], [codAreaTel1Laboral], [tel1Laboral], [int1], [codAreaTel2Laboral], [tel2Laboral], [int2], [codAreaCel1Laboral], [cel1Laboral], [codAreaCel2Laboral], [cel2Laboral], [id_cliente]) VALUES (4, 1, N'', N'', N'', N'', N'', N'', NULL, N'', N'', NULL, N'', N'', N'', NULL, 4)
INSERT [dbo].[trabajo] ([id_trabajo], [situacionLaboral], [lugarTrabajo], [rubro], [titulo], [observacion], [codAreaTel1Laboral], [tel1Laboral], [int1], [codAreaTel2Laboral], [tel2Laboral], [int2], [codAreaCel1Laboral], [cel1Laboral], [codAreaCel2Laboral], [cel2Laboral], [id_cliente]) VALUES (5, 1, N'', N'', N'', N'', N'', N'', N'          ', N'', N'', N'          ', N'', N'', N'', N'          ', 5)
INSERT [dbo].[trabajo] ([id_trabajo], [situacionLaboral], [lugarTrabajo], [rubro], [titulo], [observacion], [codAreaTel1Laboral], [tel1Laboral], [int1], [codAreaTel2Laboral], [tel2Laboral], [int2], [codAreaCel1Laboral], [cel1Laboral], [codAreaCel2Laboral], [cel2Laboral], [id_cliente]) VALUES (6, 1, N'educacion', N'docente', N'maestra', N'ninguna', N'221', N'4259987', N'colegio   ', N'', N'', N'          ', N'', N'', N'', N'          ', 6)
INSERT [dbo].[trabajo] ([id_trabajo], [situacionLaboral], [lugarTrabajo], [rubro], [titulo], [observacion], [codAreaTel1Laboral], [tel1Laboral], [int1], [codAreaTel2Laboral], [tel2Laboral], [int2], [codAreaCel1Laboral], [cel1Laboral], [codAreaCel2Laboral], [cel2Laboral], [id_cliente]) VALUES (7, 1, N'', N'', N'', N'', N'', N'', N'          ', N'', N'', N'          ', N'', N'', N'', N'          ', 7)
INSERT [dbo].[trabajo] ([id_trabajo], [situacionLaboral], [lugarTrabajo], [rubro], [titulo], [observacion], [codAreaTel1Laboral], [tel1Laboral], [int1], [codAreaTel2Laboral], [tel2Laboral], [int2], [codAreaCel1Laboral], [cel1Laboral], [codAreaCel2Laboral], [cel2Laboral], [id_cliente]) VALUES (8, 1, N'aca', N'ninguno', N'ninguno', N'nada', N'221', N'221', N'          ', N'221', N'221', N'          ', N'221', N'221', N'221', N'221       ', 8)
INSERT [dbo].[trabajo] ([id_trabajo], [situacionLaboral], [lugarTrabajo], [rubro], [titulo], [observacion], [codAreaTel1Laboral], [tel1Laboral], [int1], [codAreaTel2Laboral], [tel2Laboral], [int2], [codAreaCel1Laboral], [cel1Laboral], [codAreaCel2Laboral], [cel2Laboral], [id_cliente]) VALUES (9, 1, N'sdfsdf', N'sdf', N'df', N'sfda', N'22', N'22', N'          ', N'22', N'22', N'          ', N'22', N'22', N'22', N'22        ', 9)
INSERT [dbo].[trabajo] ([id_trabajo], [situacionLaboral], [lugarTrabajo], [rubro], [titulo], [observacion], [codAreaTel1Laboral], [tel1Laboral], [int1], [codAreaTel2Laboral], [tel2Laboral], [int2], [codAreaCel1Laboral], [cel1Laboral], [codAreaCel2Laboral], [cel2Laboral], [id_cliente]) VALUES (10, 1, N'sdf', N'dsf', N'dsf', N'dsf', N'', N'', N'          ', N'', N'', N'          ', N'', N'', N'', N'          ', 10)
INSERT [dbo].[trabajo] ([id_trabajo], [situacionLaboral], [lugarTrabajo], [rubro], [titulo], [observacion], [codAreaTel1Laboral], [tel1Laboral], [int1], [codAreaTel2Laboral], [tel2Laboral], [int2], [codAreaCel1Laboral], [cel1Laboral], [codAreaCel2Laboral], [cel2Laboral], [id_cliente]) VALUES (11, 1, N'finvert srl', N'sistemas', N'responsable sistemas', N'', N'221', N'4124000', N'4012      ', N'', N'', N'          ', N'221', N'3144504', N'', N'          ', 11)
INSERT [dbo].[trabajo] ([id_trabajo], [situacionLaboral], [lugarTrabajo], [rubro], [titulo], [observacion], [codAreaTel1Laboral], [tel1Laboral], [int1], [codAreaTel2Laboral], [tel2Laboral], [int2], [codAreaCel1Laboral], [cel1Laboral], [codAreaCel2Laboral], [cel2Laboral], [id_cliente]) VALUES (12, 0, N'No posee', N'No posee', N'No posee', N'No posee', N'0', N'0', N'0         ', N'0', N'0', N'0         ', N'0', N'0', N'0', N'0         ', 12)
INSERT [dbo].[trabajo] ([id_trabajo], [situacionLaboral], [lugarTrabajo], [rubro], [titulo], [observacion], [codAreaTel1Laboral], [tel1Laboral], [int1], [codAreaTel2Laboral], [tel2Laboral], [int2], [codAreaCel1Laboral], [cel1Laboral], [codAreaCel2Laboral], [cel2Laboral], [id_cliente]) VALUES (13, 1, N'dfgdfg', N'dfg', N'fdg', N'fdg', N'435', N'435', N'          ', N'435', N'45', N'          ', N'435', N'435', N'435', N'435       ', 13)
INSERT [dbo].[trabajo] ([id_trabajo], [situacionLaboral], [lugarTrabajo], [rubro], [titulo], [observacion], [codAreaTel1Laboral], [tel1Laboral], [int1], [codAreaTel2Laboral], [tel2Laboral], [int2], [codAreaCel1Laboral], [cel1Laboral], [codAreaCel2Laboral], [cel2Laboral], [id_cliente]) VALUES (14, 1, N'dsf', N'dsf', N'dsf', N'sdf', N'222', N'22', N'          ', N'', N'', N'          ', N'', N'', N'', N'          ', 14)
SET IDENTITY_INSERT [dbo].[trabajo] OFF
