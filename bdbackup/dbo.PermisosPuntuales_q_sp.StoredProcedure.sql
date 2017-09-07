USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[PermisosPuntuales_q_sp]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PermisosPuntuales_q_sp]

@dni varchar(10),
@Formulario varchar(30),
@existe int output 

as

begin

set @existe =0

if exists (
select * from Permisos p, usuarios u, login l
where formulario=@formulario
and p.usuario = l.usrSinEncript
and l.id_usuario = u.id_usuario
and u.dni = @dni

) 
set @existe ='1'
else
set @existe ='0'

end
GO
