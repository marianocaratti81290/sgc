USE [GestionClientes]
GO
/****** Object:  Table [dbo].[operacionesCliente]    Script Date: 26/6/2017 9:50:10 p. m. ******/
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
SET IDENTITY_INSERT [dbo].[operacionesCliente] ON 

INSERT [dbo].[operacionesCliente] ([id_operacion], [dni], [apyn], [operacion], [tipoPrestamo], [origen], [cbRelacOrigen], [importe], [plazo], [cbplazo], [estado], [fecha]) VALUES (1, N'35500117', N'Caratti, Mariano', N'Nuevo Prestamo', N'S', N'CallCenter', N'Entrantes-Ventas', 10000, N'30', NULL, N'Pendiente', NULL)
INSERT [dbo].[operacionesCliente] ([id_operacion], [dni], [apyn], [operacion], [tipoPrestamo], [origen], [cbRelacOrigen], [importe], [plazo], [cbplazo], [estado], [fecha]) VALUES (2, N'35500117', N'Caratti, Mariano', N'Renovacion', N'S', N'Ventas', N'Suc Ensenada', 9555, N'30', NULL, N'Rechazado', NULL)
INSERT [dbo].[operacionesCliente] ([id_operacion], [dni], [apyn], [operacion], [tipoPrestamo], [origen], [cbRelacOrigen], [importe], [plazo], [cbplazo], [estado], [fecha]) VALUES (3, N'35417258', N'Caratti, Mariano', N'Consulta', N'S', N'Ventas', N'Suc Calle44', 10000, N'30', NULL, N'Pendiente', NULL)
INSERT [dbo].[operacionesCliente] ([id_operacion], [dni], [apyn], [operacion], [tipoPrestamo], [origen], [cbRelacOrigen], [importe], [plazo], [cbplazo], [estado], [fecha]) VALUES (4, N'32456654', N'Swirch, Marcos', N'Consulta', N'S', N'CallCenter', N'Entrantes-Ventas', 10000, N'30', NULL, N'Pendiente', NULL)
INSERT [dbo].[operacionesCliente] ([id_operacion], [dni], [apyn], [operacion], [tipoPrestamo], [origen], [cbRelacOrigen], [importe], [plazo], [cbplazo], [estado], [fecha]) VALUES (5, N'456', N'sdf456, sdf', N'Paralelo', N'S', N'Multimedia', N'Carta', 1000, N'10', N'dia', N'Pendiente', NULL)
INSERT [dbo].[operacionesCliente] ([id_operacion], [dni], [apyn], [operacion], [tipoPrestamo], [origen], [cbRelacOrigen], [importe], [plazo], [cbplazo], [estado], [fecha]) VALUES (6, N'35500117', N'Caratti, Mariano', N'Paralelo', N'S', N'Digital', N'Facebook', 1000, N'30', N'dia', N'Concretado', CAST(0xF63C0B00 AS Date))
INSERT [dbo].[operacionesCliente] ([id_operacion], [dni], [apyn], [operacion], [tipoPrestamo], [origen], [cbRelacOrigen], [importe], [plazo], [cbplazo], [estado], [fecha]) VALUES (7, N'35500117', N'Caratti, Mariano', N'Renovacion', N'S', N'Referidos', N'Promotor', 1000, N'30', N'dia', N'Pendiente', CAST(0xF63C0B00 AS Date))
INSERT [dbo].[operacionesCliente] ([id_operacion], [dni], [apyn], [operacion], [tipoPrestamo], [origen], [cbRelacOrigen], [importe], [plazo], [cbplazo], [estado], [fecha]) VALUES (8, N'35500117', N'Caratti, Mariano', N'Nuevo Prestamo', N'S', N'Ventas', N'Suc Ensenada', 50000, N'30', N'dia', N'Rechazado', CAST(0xF63C0B00 AS Date))
INSERT [dbo].[operacionesCliente] ([id_operacion], [dni], [apyn], [operacion], [tipoPrestamo], [origen], [cbRelacOrigen], [importe], [plazo], [cbplazo], [estado], [fecha]) VALUES (9, N'35500117', N'Caratti, Mariano', N'Consulta', N'S', N'Multimedia', N'Radio', 250000, N'30', N'dia', N'Concretado', CAST(0xF63C0B00 AS Date))
INSERT [dbo].[operacionesCliente] ([id_operacion], [dni], [apyn], [operacion], [tipoPrestamo], [origen], [cbRelacOrigen], [importe], [plazo], [cbplazo], [estado], [fecha]) VALUES (10, N'15321123', N'111, 111', N'Consulta', N'S', N'Ventas', N'Suc Berisso', 1000, N'30', N'dia', N'Pendiente', CAST(0xF63C0B00 AS Date))
SET IDENTITY_INSERT [dbo].[operacionesCliente] OFF
