USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[EliminarPermisosPuntuales_d_sp]    Script Date: 23/6/2017 3:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[EliminarPermisosPuntuales_d_sp]

@usr varchar(30),
@formulario varchar(30)

as
begin

delete from Permisos
where usuario = @usr and formulario = @formulario


end


GO
