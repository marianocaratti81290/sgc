USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[obtenerSucursales_q_sp]    Script Date: 23/6/2017 3:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[obtenerSucursales_q_sp]

as

begin

select * from Sucursales

end

GO
