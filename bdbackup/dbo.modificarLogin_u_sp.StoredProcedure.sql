USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[modificarLogin_u_sp]    Script Date: 26/6/2017 9:50:10 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[modificarLogin_u_sp](
@id_usuario int,

@password varchar(200),
@estado int,
@usrSinEncript varchar(30),
@passSinEncript varchar(30))


as

begin

update Login
set

password= @password,
estado= @estado,
usrSinEncript = @usrSinEncript,
passSinEncript = @passSinEncript


where id_usuario=@id_usuario



end

GO
