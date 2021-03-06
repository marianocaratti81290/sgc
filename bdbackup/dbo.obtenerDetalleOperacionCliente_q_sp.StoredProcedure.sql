USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[obtenerDetalleOperacionCliente_q_sp]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[obtenerDetalleOperacionCliente_q_sp]

@dni varchar(10),
@id_operacion int

as

begin

select nombre,
		apellido,
		c.dni,
		cuil,
		fecha_nacimiento,
		estado_civil,
		sexo,
		codAreaTel1 + ' ' + tel1 as tel1,
		ref1,
		codAreaTel2 + ' ' + tel2 as tel2,
		codAreaCel1 + ' ' + cel1 as cel1,
		ref3,
		domicilio,
		localidad,
		provincia,	
		email,
		cp,
		operacion,
		case tipoPrestamo when 'S' then 'Prestamo en Sucursal' else 'Prestamo en Comercio' end as TipoPrestamo,
		origen,
		cbRelacOrigen as tipoOrigen,
		importe,
		plazo,
		estado
from operacionesCliente oc, clientes c 

where oc.dni = c.dni
and oc.dni= @dni

end
GO
