USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[obtenerPermisosUsuario]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create procedure [dbo].[obtenerPermisosUsuario]

@usuario varchar(30)

as
begin

select formulario from permisos where usuario = @usuario 

end                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
GO
