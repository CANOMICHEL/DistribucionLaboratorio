
use BDOrganizacionLaboratoriosDAI
--======================================================================================
--================================== TDocente ===========================================
--======================================================================================
-- SPU Insertar Docente
if exists (select * from dbo.sysobjects where name = 'spuTDocente_Insertar')
	drop procedure spuTDocente_Insertar
go
create procedure spuTDocente_Insertar
	@CodDocente varchar (5),
	@Nombre varchar(100)
as
begin
	if (@CodDocente!= '' and not exists (select * from TDocente where CodDocente = @CodDocente))
	begin
		insert into TDocente values(@CodDocente,@Nombre)
		select CodError = 0, Mensaje = 'Registro insertado exitosamente'
	end
	else
		select CodError = 1, Mensaje = 'El código se encuentra en blanco o está duplicado'
end
go



--=======================================================================================
-- SPU Actualizar Docente
if exists (select * from dbo.sysobjects where name = 'spuTDocente_Actualizar')
	drop procedure spuTDocente_Actualizar
go
create procedure spuTDocente_Actualizar
	@CodDocente varchar (5),
	@Nombre varchar (100)
as
begin
	if (@CodDocente != '' and exists (select * from TDocente where CodDocente = @CodDocente))
	begin
		if (@Nombre != '')
		begin
			update TDocente set 
				Nombre = @Nombre
				where CodDocente = @CodDocente
			select CodError = 0, Mensaje = 'Registro actualizado exitosamente'
		end
	end
	else
		select CodError = 1, Mensaje = 'El código no existe en la base de datos'
end
go
--=======================================================================================
-- SPU Listar Docente
if exists (select * from dbo.sysobjects where name = 'spuTDocente_Listar')
	drop procedure spuTDocente_Listar
go
create procedure spuTDocente_Listar
as
begin
	select* from TDocente
end
go

--======================================================================================
--================================== TAsignatura ===========================================
--======================================================================================
if exists(select* from dbo.sysobjects where name='spuTAsignatura_Insertar')
	drop procedure spuTAsignatura_Insertar
go
create procedure spuTAsignatura_Insertar
	@CodAsignatura varchar(12),
	@NombreAsignatura varchar(40),
	@Creditos varchar(20),
	@Categoria varchar(20)
as
begin
if (@CodAsignatura != '' and exists (select * from TAsignatura where CodAsignatura = @CodAsignatura))
begin
	if(@NombreAsignatura!='')
	begin
		if(@Creditos!='')
		begin
			if(@Categoria!='')
			begin
				insert into TAsignatura values(@CodAsignatura,@NombreAsignatura,@Creditos,@Categoria)
				select CodError = 0, Mensaje = 'Registro insertado exitosamente'
			end
			else
				select CodError = 1, Mensaje = 'la categoria no debe estar vacia'
		end
		else
			select CodError = 1, Mensaje = 'Los creditos no debe estar vacio'
	end
	else
		select CodError = 1, Mensaje='El nombre de la asignatura no debe estar vacio'
end
else
	select CodError = 1, Mensaje='El codigo de la asignatura no debe estar vacio'
end
go

if exists(select* from dbo.sysobjects where name='spuTAsignatura_Actualizar')
	drop procedure spuTAsignatura_Actualizar
go
create procedure spuTAsignatura_Actualizar
	@CodAsignatura varchar(12),
	@NombreAsignatura varchar(40),
	@Creditos varchar(20),
	@Categoria varchar(20)
as
begin
if (@CodAsignatura != '' and exists (select * from TAsignatura where CodAsignatura = @CodAsignatura))
begin
	if(@NombreAsignatura!='')
	begin
		if(@Creditos!='')
		begin
			if(@Categoria!='')
			begin
				update TAsignatura set
				CodAsignatura = @CodAsignatura,
				NombreAsignatura = @NombreAsignatura,
				Creditos = @Creditos,
				Categoria = @Categoria
				where CodAsignatura=@CodAsignatura
				select CodError = 0, Mensaje = 'Registro actualizado exitosamente'
			end
			else
				select CodError = 1, Mensaje = 'la categoria no debe estar vacia'
		end
		else
			select CodError = 1, Mensaje = 'Los creditos no debe estar vacio'
	end
	else
		select CodError = 1, Mensaje='El nombre de la asignatura no debe estar vacio'
end
else
	select CodError = 1, Mensaje='El codigo de la asignatura no existe'
end
go

exec spuTDocente_Listar

