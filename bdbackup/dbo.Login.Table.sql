USE [GestionClientes]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 26/6/2017 9:50:10 p. m. ******/
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
SET IDENTITY_INSERT [dbo].[Login] ON 

INSERT [dbo].[Login] ([id_login], [usuario], [password], [estado], [id_usuario], [usrSinEncript], [passSinEncript]) VALUES (20, N'1q9hEbEgs7bQ7a19HT/Gkg==', N'1q9hEbEgs7bQ7a19HT/Gkg==', 1, 16, N'maxi                          ', N'maxi                          ')
INSERT [dbo].[Login] ([id_login], [usuario], [password], [estado], [id_usuario], [usrSinEncript], [passSinEncript]) VALUES (1020, N'ISMvKXpXpadDiUoOSoAfww==', N'OYT01orN68LH99fML11lWQ==', 1, 1016, N'admin                         ', N'1520hgW4                      ')
INSERT [dbo].[Login] ([id_login], [usuario], [password], [estado], [id_usuario], [usrSinEncript], [passSinEncript]) VALUES (1021, N'enc5z6omnPJnbXJJ3qHZVg==', N'KgtDbo76hM8c3jrRFd3ALw==', 1, 1017, N'Andresdg                      ', N'andresdg                      ')
INSERT [dbo].[Login] ([id_login], [usuario], [password], [estado], [id_usuario], [usrSinEncript], [passSinEncript]) VALUES (1022, N'CQw247s5N3RoNjGXr7PpGw==', N'4QrcOUm6Wau+VuBX8g+IPg==', 1, 1018, N'matias                        ', N'123456                        ')
SET IDENTITY_INSERT [dbo].[Login] OFF
