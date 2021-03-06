USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[nuevaSucursal_i_sp]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[nuevaSucursal_i_sp]

@nombre varchar(30),
@direccion varchar (50),
@telefono varchar(10),
@estado varchar(10),
@tpoContrato varchar(10),
@fechaContrato varchar(30),
@observacion varchar(50)

as

begin

if (@tpoContrato = 'Propio')
insert into Sucursales
values
(

@nombre,
@direccion,
CONVERT(VARCHAR(30), GETDATE(), 109),
CONVERT(VARCHAR(30), GETDATE(), 109),
@telefono,
@estado,
@tpoContrato,
'No',
@observacion
)
else

insert into Sucursales
values
(

@nombre,
@direccion,
CONVERT(VARCHAR(30), GETDATE(), 109),
CONVERT(VARCHAR(30), GETDATE(), 109),
@telefono,
@estado,
@tpoContrato,
@fechaContrato,
@observacion
)

end


GO
