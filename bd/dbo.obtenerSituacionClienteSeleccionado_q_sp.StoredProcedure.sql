USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[obtenerSituacionClienteSeleccionado_q_sp]    Script Date: 23/6/2017 3:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtenerSituacionClienteSeleccionado_q_sp]

@dni varchar(20)

as

begin

select   apyn as ApellidoNombre,
		 dni as DNI,
		 operacion,
		 case tipoPrestamo  when 'S' then  'Otorgado en Sucursal' else 'Otorgado en Comercio' end as TipoPrestamo,
		 origen,
		 cbRelacOrigen as Tipo,
		 estado,
		 importe,
		 plazo,
		 id_operacion
	   

from operacionesCliente 
where dni= @dni



end
GO
