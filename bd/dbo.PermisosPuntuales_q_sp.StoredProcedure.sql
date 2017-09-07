USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[PermisosPuntuales_q_sp]    Script Date: 23/6/2017 3:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[PermisosPuntuales_q_sp]

@usr varchar(30),
@Formulario varchar(30),
@existe int output 

as

begin

set @existe =0

if exists (
select * from Permisos
where usuario=@usr and formulario=@formulario

) 
set @existe ='1'
else
set @existe ='0'

end
GO
