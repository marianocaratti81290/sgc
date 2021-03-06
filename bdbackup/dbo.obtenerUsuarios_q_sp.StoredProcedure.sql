USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[obtenerUsuarios_q_sp]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtenerUsuarios_q_sp] 

as

begin

select nombre as NOMBRE ,apellido as APELLIDO, dni as DNI, fecha_nacimiento as FECHA_NACIMIENTO,fecha_alta as FECHA_ALTA,sexo as SEXO,cel as CELULAR,tel as TELEFONO,localidad as LOCALIDAD, provincia as PROVINCIA,domicilio as DOMICILIO,cp as CP,email as EMAIL,observacion as OBSERVACION, usuario as USUARIO, password as PASSWORD, case when estado=1 then 'Activo' else 'Inactivo' end as ESTADO, l.usrSinEncript,l.passSinEncript, u.id_usuario 
from usuarios u, login l
where u.id_usuario = l.id_usuario

end



GO
