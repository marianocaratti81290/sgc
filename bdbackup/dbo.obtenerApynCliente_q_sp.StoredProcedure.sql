USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[obtenerApynCliente_q_sp]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtenerApynCliente_q_sp]

@dni varchar(20)

as

begin

select apellido + ', ' + nombre as apyn from clientes where dni = @dni


end
GO
