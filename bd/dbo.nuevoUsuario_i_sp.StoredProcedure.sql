USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[nuevoUsuario_i_sp]    Script Date: 23/6/2017 3:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[nuevoUsuario_i_sp]


@Nombre varchar(30),
@Apellido varchar(30),
@DNI varchar(8),
@fecha_nacimiento date,
@sexo nchar(10),
@cel varchar(20),
@tel varchar(20),
@localidad varchar(30),
@provincia varchar(30),
@domicilio varchar(50),
@cp nchar(4),
@email varchar(50),
@observacion varchar(50),
@usr varchar(200),
@pass varchar(200),
@estado int,
@usrSinEncript varchar(30),
@passSinEncript varchar(30)

as

begin

--SET IDENTITY_INSERT Usuarios on


insert into Usuarios
values (

@Nombre,
@Apellido,
@DNI,
@fecha_nacimiento,
CONVERT(VARCHAR(50), GETDATE(), 109),
CONVERT(VARCHAR(50), GETDATE(), 109),
@sexo,
@cel,
@tel,
@localidad,
@provincia,
@domicilio,
@cp,
@email,
@observacion
)


--SET IDENTITY_INSERT Usuarios off

--SET IDENTITY_INSERT Login on

insert into Login
values (

@usr,
@pass,
@estado,
IDENT_CURRENT ('usuarios'), 
@usrSinEncript,
@passSinEncript

)

--SET IDENTITY_INSERT Login off


end




GO
