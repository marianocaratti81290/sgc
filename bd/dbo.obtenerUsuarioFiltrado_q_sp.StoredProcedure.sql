USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[obtenerUsuarioFiltrado_q_sp]    Script Date: 23/6/2017 3:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[obtenerUsuarioFiltrado_q_sp]

@filtro varchar(20),
@buscar varchar(30)

as

begin

if (@filtro = 'Dni')
select top (2) nombre, apellido, dni, cel, l.fecha_ingreso   from usuarios u, logeo_usuario l 
where dni like '%' + @buscar + '%'
order by fecha_ingreso desc

else
if (@filtro = 'Apellido')
select top (2) nombre, apellido, dni, cel, l.fecha_ingreso   from usuarios u, logeo_usuario l
where apellido like '%' + @buscar + '%'
order by fecha_ingreso desc

else
if (@filtro = 'Nombre')
select top (2) nombre, apellido, dni, cel, l.fecha_ingreso   from usuarios u, logeo_usuario l
where nombre like '%' + @buscar + '%'
order by fecha_ingreso desc

end

GO
