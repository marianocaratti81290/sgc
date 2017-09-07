USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[obtenerUsuarioParaPermisos_q_sp]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[obtenerUsuarioParaPermisos_q_sp]

@dni varchar(10)

as

begin

select  l.usrSinEncript from usuarios u, login l
where l.id_usuario = u.id_usuario
and u.dni = @dni



end


GO
