USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[InsertarPermisosPuntuales_i_sp]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertarPermisosPuntuales_i_sp]

@dni varchar(30),
@formulario varchar(30)

as
begin

insert into Permisos

select l.usrSinEncript, @formulario,1 from usuarios u, login l
where l.id_usuario = u.id_usuario
and u.dni = @dni

end
GO
