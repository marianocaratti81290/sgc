USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[nuevoCliente_i_sp]    Script Date: 23/6/2017 3:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[nuevoCliente_i_sp]

@nombre varchar(30),
@apellido varchar(30),
@dni varchar(10),
@cuil varchar(12),
@fecha_nacimiento date,
@estado_civil varchar(10),
@sexo varchar(10),
@codAreaTel1 varchar(5),
@tel1 varchar(10),
@ref1 varchar(30),
@codAreaTel2 varchar(5),
@tel2 varchar(10),
@ref2 varchar(30),
@codAreaCel1 varchar(5),
@cel1 varchar(10),
@ref3 varchar(10),
@domicilio varchar(50),
@localidad varchar(30),
@provincia varchar(30),
@email varchar(50),
@cp varchar(4),
@situacionLaboral int,
@lugarTrabajo varchar(50),
@rubro varchar(50),
@titulo varchar(50),
@observacion varchar(50),
@codAreaTel1Laboral varchar(5),
@tel1Laboral varchar(10),
@int1 varchar(10),
@codAreaTel2Laboral varchar(5),
@tel2Laboral varchar(10),
@int2 varchar(10),
@codAreaCel1Laboral varchar(5),
@cel1Laboral varchar(10),
@codAreaCel2Laboral varchar(10),
@cel2Laboral varchar(10)

as
begin

insert into clientes
values (
@nombre,
@apellido,
@dni,
@cuil,
@fecha_nacimiento,
@estado_civil,
@sexo,
@codAreaTel1,
@tel1,
@ref1,
@codAreaTel2,
@tel2,
@ref2,
@codAreaCel1,
@cel1,
@ref3,
@domicilio,
@localidad,
@provincia,
@email,
@cp
)

insert into trabajo
values (

@situacionLaboral,
@lugarTrabajo,
@rubro,
@titulo,
@observacion,
@codAreaTel1Laboral,
@tel1Laboral,
@int1,
@codAreaTel2Laboral,
@tel2Laboral,
@int2,
@codAreaCel1Laboral,
@cel1Laboral,
@codAreaCel2Laboral,
@cel2Laboral,
IDENT_CURRENT ('clientes')
)
end

GO
