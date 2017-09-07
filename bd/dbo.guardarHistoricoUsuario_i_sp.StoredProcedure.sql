USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[guardarHistoricoUsuario_i_sp]    Script Date: 23/6/2017 3:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[guardarHistoricoUsuario_i_sp]

@id_usuario varchar(10),
@observacion varchar(200)

as
begin

insert into HistoricoUsuarios 

select id_usuario, nombre,apellido,dni,fecha_nacimiento,fecha_modificacion,fecha_alta,sexo,cel,tel,localidad,provincia,domicilio,cp,email,@observacion from usuarios where id_usuario = @id_usuario  

end



GO
