USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[modificarEstadoSucursal_u_sp]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[modificarEstadoSucursal_u_sp]
@id_sucursal int,
@estado varchar(20)

as

begin

update Sucursales
set
estado=@estado

where id_sucursal=@id_sucursal


end

GO
