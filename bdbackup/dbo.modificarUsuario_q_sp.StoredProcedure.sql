USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[modificarUsuario_q_sp]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[modificarUsuario_q_sp]
(
@id_usuario int,
@nombre varchar(30),
@apellido varchar(30),
@dni varchar (8),
@sexo varchar(10),
@nacimiento date,
@direccion varchar(50),
@provincia varchar(30),
@localidad varchar(30),
@cel varchar (20),
@tel_fijo varchar(20),
@email varchar(50),
@cp varchar(4) ,
@observaciones varchar(50))

as
begin

update usuarios
set

nombre = @nombre,
apellido = @apellido,
dni = @dni,
fecha_nacimiento = @nacimiento,
fecha_modificacion = getdate(),
sexo = @sexo,
cel= @cel,
tel= @tel_fijo,
localidad= @localidad,
provincia = @provincia,
domicilio = @direccion,
cp=@cp,
email= @email,
observacion= @observaciones

where id_usuario=@id_usuario

end

GO
