USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[obtenerClientes_q_sp]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[obtenerClientes_q_sp]

as

begin

select  nombre,
		apellido,
		dni,
		fecha_nacimiento,
		email,
		id_cliente

from clientes


end
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
GO
