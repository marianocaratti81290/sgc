USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[validarDni_q_sp]    Script Date: 23/6/2017 3:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[validarDni_q_sp]

@validarDni varchar(10),
@existe int output
as

begin


set @existe =0
if exists (
select dni from Usuarios
where dni = @validarDni

) 
set @existe ='1'
else
set @existe ='0'
end




GO
