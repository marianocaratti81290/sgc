USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[delegarPermisosPorFuncionalidad_i_sp]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[delegarPermisosPorFuncionalidad_i_sp]

@origen varchar(30),
@destino varchar(30)
as

begin

delete from Permisos
where usuario= @destino


insert into permisos -- ( usuario, formulario, estado)

select @destino,formulario,1 from permisos
where usuario = @origen



end


GO
