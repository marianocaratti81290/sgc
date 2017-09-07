USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[obtenerConsultaUsuario_q_sp]    Script Date: 23/6/2017 3:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[obtenerConsultaUsuario_q_sp]

as

begin

select top (2) nombre, apellido, dni, cel, l.fecha_ingreso   from usuarios u, logeo_usuario l where u.id_usuario = l.id_usuario order by fecha_ingreso desc

end

select * from logeo_usuario

GO
