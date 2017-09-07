USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[validarDniCliente_q_sp]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[validarDniCliente_q_sp]

@validarDni varchar(10),
@existe int output
as

begin


set @existe =0
if exists (
select dni from clientes
where dni = @validarDni

) 
set @existe ='1'
else
set @existe ='0'
end




GO
