USE [GestionClientes]
GO
/****** Object:  User [mariano]    Script Date: 26/6/2017 9:50:09 p. m. ******/
CREATE USER [mariano] FOR LOGIN [mariano] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [mariano]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [mariano]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [mariano]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [mariano]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [mariano]
GO
ALTER ROLE [db_datareader] ADD MEMBER [mariano]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [mariano]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [mariano]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [mariano]
GO
