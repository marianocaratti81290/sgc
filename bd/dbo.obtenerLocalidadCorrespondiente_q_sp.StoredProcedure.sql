USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[obtenerLocalidadCorrespondiente_q_sp]    Script Date: 23/6/2017 3:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[obtenerLocalidadCorrespondiente_q_sp]
@valor varchar(20)

as
begin

select localidad from localidades l
where id_privincia = @valor


end

GO
