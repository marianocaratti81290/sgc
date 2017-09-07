USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[obtenerCliente_q_sp]    Script Date: 23/6/2017 3:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[obtenerCliente_q_sp]

as

begin

select nombre, apellido, dni, fecha_nacimiento, codAreaTel1 + ' ' + tel1 as telefono, codAreaCel1 + ' ' + cel1 as celular, domicilio, provincia, localidad, email, cp , id_cliente from clientes 

end
GO
