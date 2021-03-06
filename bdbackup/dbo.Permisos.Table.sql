USE [GestionClientes]
GO
/****** Object:  Table [dbo].[Permisos]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Permisos](
	[id_permiso] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](30) NOT NULL,
	[Formulario] [varchar](100) NOT NULL,
	[Estado] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Permisos] ON 

INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (85, N'admin', N'FrmPermisosUsuarios', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (100, N'maxi', N'FrmPermisosUsuarios', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (101, N'maxi', N'FrmModificarSucursal', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (86, N'admin', N'FrmModificarSucursal', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (87, N'admin                         ', N'FrmClientes', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (88, N'admin                         ', N'FrmGestionClientes', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (89, N'admin                         ', N'FrmReportes', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (90, N'admin                         ', N'FrmNuevoUsuario', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (91, N'admin                         ', N'FrmModificarUsuario', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (92, N'admin                         ', N'FrmEliminarUsuario', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (93, N'admin                         ', N'FrmConsultaUsuarios', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (124, N'matias', N'FrmPermisosUsuarios', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (95, N'admin                         ', N'FrmNuevaSucursal', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (96, N'admin                         ', N'FrmEliminarSucursal', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (97, N'admin                         ', N'FrmConsultaSucursales', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (98, N'admin                         ', N'FrmEstadoSucursales', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (99, N'admin                         ', N'FrmPermisosFuncionalidad', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (102, N'maxi', N'FrmClientes', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (103, N'maxi', N'FrmGestionClientes', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (104, N'maxi', N'FrmReportes', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (105, N'maxi', N'FrmNuevoUsuario', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (106, N'maxi', N'FrmModificarUsuario', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (107, N'maxi', N'FrmEliminarUsuario', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (108, N'maxi', N'FrmConsultaUsuarios', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (125, N'matias', N'FrmModificarSucursal', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (110, N'maxi', N'FrmNuevaSucursal', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (111, N'maxi', N'FrmEliminarSucursal', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (112, N'maxi', N'FrmConsultaSucursales', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (113, N'maxi', N'FrmEstadoSucursales', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (114, N'maxi', N'FrmPermisosFuncionalidad', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (116, N'admin                         ', N'FrmPermisosFuncionalidad', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (126, N'matias', N'FrmClientes', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (127, N'matias', N'FrmGestionClientes', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (128, N'matias', N'FrmReportes', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (129, N'matias', N'FrmNuevoUsuario', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (130, N'matias', N'FrmModificarUsuario', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (131, N'matias', N'FrmEliminarUsuario', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (132, N'matias', N'FrmConsultaUsuarios', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (133, N'matias', N'FrmNuevaSucursal', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (134, N'matias', N'FrmEliminarSucursal', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (135, N'matias', N'FrmConsultaSucursales', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (136, N'matias', N'FrmEstadoSucursales', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (137, N'matias', N'FrmPermisosFuncionalidad', 1)
INSERT [dbo].[Permisos] ([id_permiso], [usuario], [Formulario], [Estado]) VALUES (138, N'matias', N'FrmPermisosFuncionalidad', 1)
SET IDENTITY_INSERT [dbo].[Permisos] OFF
