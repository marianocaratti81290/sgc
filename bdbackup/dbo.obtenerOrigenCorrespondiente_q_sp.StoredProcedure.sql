USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[obtenerOrigenCorrespondiente_q_sp]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[obtenerOrigenCorrespondiente_q_sp]
@valor varchar(50)

as
begin

select descripcion from origenRelacMarketing
where id_origen = @valor


end

GO
