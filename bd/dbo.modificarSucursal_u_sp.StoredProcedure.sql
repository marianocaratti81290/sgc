USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[modificarSucursal_u_sp]    Script Date: 23/6/2017 3:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[modificarSucursal_u_sp]

@id_sucursal int,
@nombre varchar(30),
@direccion varchar(50),
@fecha_alta varchar(20),
@telefono varchar(20),
@estado varchar(10),
@tpoContrato varchar(10),
@fechaContrato varchar(30),
@observacion varchar(50)

as

begin

update Sucursales
set
nombre = @nombre,
direccion = @direccion,
fecha_modificacion = @fecha_alta,
telefono = @telefono,
estado = @estado,
tpoContrato = @tpoContrato,
fechaContrato = @fechaContrato,
observacion = @observacion

where id_sucursal = @id_sucursal



end

GO
