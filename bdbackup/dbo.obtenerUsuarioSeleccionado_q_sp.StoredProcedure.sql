USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[obtenerUsuarioSeleccionado_q_sp]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[obtenerUsuarioSeleccionado_q_sp]
@id_usuario int
as

begin

select nombre,apellido,dni,sexo,FORMAT(GETDATE(),'dd/MM/yyyy'),   fecha_alta,sexo,cel,tel,localidad, provincia,domicilio,cp,email,observacion, usuario, password, case when estado=1 then 'Activo' else 'Inactivo' end as estado, l.usrSinEncript,l.passSinEncript, u.id_usuario
from usuarios u, login l
where u.id_usuario = l.id_usuario
and u.id_usuario = @id_usuario

end




GO
