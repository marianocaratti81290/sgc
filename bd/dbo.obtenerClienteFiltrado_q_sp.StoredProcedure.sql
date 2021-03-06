USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[obtenerClienteFiltrado_q_sp]    Script Date: 23/6/2017 3:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[obtenerClienteFiltrado_q_sp]

@filtro varchar(20),
@buscar varchar(30)

as

begin

if (@filtro = 'Dni')
select nombre, apellido, dni, fecha_nacimiento, codAreaTel1 + ' ' + tel1 as telefono, codAreaCel1 + ' ' + cel1 as celular, domicilio, provincia, localidad, email, cp , id_cliente from clientes 
where dni like '%' + @buscar + '%'
order by dni desc

else
if (@filtro = 'Apellido')
select nombre, apellido, dni, fecha_nacimiento, codAreaTel1 + ' ' + tel1 as telefono, codAreaCel1 + ' ' + cel1 as celular, domicilio, provincia, localidad, email, cp , id_cliente from clientes 
where apellido like '%' + @buscar + '%'
order by apellido desc

else
if (@filtro = 'Nombre')
select nombre, apellido, dni, fecha_nacimiento, codAreaTel1 + ' ' + tel1 as telefono, codAreaCel1 + ' ' + cel1 as celular, domicilio, provincia, localidad, email, cp , id_cliente from clientes 
where nombre like '%' + @buscar + '%'
order by nombre desc

end

GO
