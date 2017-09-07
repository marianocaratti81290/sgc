USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[buscarUsuarioFiltrado_q_sp]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[buscarUsuarioFiltrado_q_sp]
@buscar varchar(30)

as

begin
if (@buscar <> '')

select u.nombre, u.apellido, u.dni, u.fecha_nacimiento, u.sexo, u.cel, u.tel from usuarios u, login l
where l.usrSinEncript like '%' + @buscar + '%' and
u.id_usuario = l.id_usuario
order by usuario desc

else

select u.nombre, u.apellido, u.dni, u.fecha_nacimiento, u.sexo, u.cel, u.tel from usuarios u, login l
where u.id_usuario = l.id_usuario
order by usuario desc


end


GO
