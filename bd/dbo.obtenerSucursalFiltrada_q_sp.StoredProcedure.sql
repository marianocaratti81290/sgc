USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[obtenerSucursalFiltrada_q_sp]    Script Date: 23/6/2017 3:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[obtenerSucursalFiltrada_q_sp] 

@buscar varchar(30)

as

begin

select * from sucursales where nombre = @buscar


end

GO
