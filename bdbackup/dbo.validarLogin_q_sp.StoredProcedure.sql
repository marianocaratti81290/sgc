USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[validarLogin_q_sp]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[validarLogin_q_sp]

@validarLogin varchar(200),
@existe int output
as

begin


set @existe =0
if exists (
select usuario from Login
where usuario = @validarLogin

) 
set @existe ='1'
else
set @existe ='0'
end




GO
