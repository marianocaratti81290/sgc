USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[guardarHistoricoSucursal_i_sp]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[guardarHistoricoSucursal_i_sp]

@id_sucursal int,
@observacion varchar(50)

as

begin

insert into HistoricoSucursales 

select id_sucursal, nombre, direccion, fecha_alta, fecha_modificacion, telefono, estado, tpoContrato, fechaContrato, @observacion
from Sucursales
where id_sucursal = @id_sucursal



end

GO
