USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[EliminarPermisosPuntuales_d_sp]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[EliminarPermisosPuntuales_d_sp]

@dni varchar(30),
@formulario varchar(30)


as
begin

delete from Permisos
where usuario in
(select top 1 l.usrSinEncript from usuarios u, login l
where l.id_usuario = u.id_usuario
and u.dni = @dni) and

formulario = @formulario

end

GO
