USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[Logeo_buscarCliente_q_sp]    Script Date: 23/6/2017 3:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[Logeo_buscarCliente_q_sp]

@usuario varchar (200),
@password varchar (200),
@existe char output

as
begin

set @existe =0
if exists (
select * from Login
where usuario = @usuario
and password = @password
) 
set @existe ='1'
else
set @existe ='0'
end

/* Mariano Caratti 24/09/2015 */



GO
