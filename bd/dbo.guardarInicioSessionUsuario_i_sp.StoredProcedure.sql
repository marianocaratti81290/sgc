USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[guardarInicioSessionUsuario_i_sp]    Script Date: 23/6/2017 3:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[guardarInicioSessionUsuario_i_sp]

@usuario varchar (200)

as

begin


insert into logeo_usuario (id_usuario,fecha_ingreso)

select id_usuario, CONVERT(VARCHAR(50), GETDATE(), 121)

 from login where usuario = @usuario

end



GO
