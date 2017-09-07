USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[obtenerSucursalSeleccionada_q_sp]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtenerSucursalSeleccionada_q_sp]

@id_sucursal int

as

begin

select nombre,direccion,fecha_alta,telefono,estado,tpoContrato,fechaContrato,observacion from sucursales where id_sucursal = @id_sucursal


end

GO
