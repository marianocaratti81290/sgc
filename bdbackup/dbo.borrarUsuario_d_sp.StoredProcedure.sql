USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[borrarUsuario_d_sp]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[borrarUsuario_d_sp]

@id_usuario varchar(10)

as
begin

delete from usuarios where id_usuario = @id_usuario
delete from login where id_usuario = @id_usuario

end


GO
