USE [GestionClientes]
GO
/****** Object:  StoredProcedure [dbo].[InsertarPermisosPuntuales_i_sp]    Script Date: 23/6/2017 3:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertarPermisosPuntuales_i_sp]

@usr varchar(30),
@formulario varchar(30)

as
begin

insert into Permisos
values (@usr, @formulario,1)


end
GO
