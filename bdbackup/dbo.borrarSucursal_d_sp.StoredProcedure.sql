USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[borrarSucursal_d_sp]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[borrarSucursal_d_sp]
@id_sucursal int

as

begin

delete from Sucursales where id_sucursal= @id_sucursal

end

GO
