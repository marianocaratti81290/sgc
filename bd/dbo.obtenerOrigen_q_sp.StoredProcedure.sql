USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[obtenerOrigen_q_sp]    Script Date: 23/6/2017 3:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[obtenerOrigen_q_sp]
as

begin
select * from origenMarketing
end

GO
