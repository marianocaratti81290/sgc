USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[obtenerSucursalFiltrada_q_sp]    Script Date: 26/6/2017 9:50:10 p. m. ******/
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
