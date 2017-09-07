USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[nuevaGestionCliente_i_sp]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[nuevaGestionCliente_i_sp]

@dni varchar(10),
@apyn varchar (50),
@operacion varchar(50),
@tipoPrestamo varchar (20),
@origen varchar (30),
@relacOrigen varchar (30),
@importe int,
@plazo varchar (5),
@cbplazo varchar(20),
@estado varchar(30)

as

begin

insert into operacionesCliente values
(
@dni,
@apyn,
@operacion,
@tipoPrestamo,
@origen,
@relacOrigen,
@importe,
@plazo,
@cbplazo,
@estado,
getdate()
)


end

GO
