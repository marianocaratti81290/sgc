USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[obtenerUsuarioFiltrado2_q_sp]    Script Date: 23/6/2017 3:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[obtenerUsuarioFiltrado2_q_sp]

@filtro varchar(20),
@buscar varchar(30)

as

begin

if (@filtro = 'Dni')
select *   from usuarios
where dni like '%' + @buscar + '%'


else
if (@filtro = 'Apellido')
select *   from usuarios
where apellido like '%' + @buscar + '%'


else
if (@filtro = 'Nombre')
select *   from usuarios 
where nombre like '%' + @buscar + '%'


end

GO
