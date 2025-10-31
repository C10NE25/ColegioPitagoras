USE ColegioPitagoras3;
GO

--------------------------------------------------------------
--------------	Procedimientos Almacenados	------------------
--------------------------------------------------------------
sp_help apoderado
----------------------------------------------
--------------	Apodereado	------------------
----------------------------------------------

--Listar
go
create or alter procedure spListarApoderado
as
	select idApoderado, dniApo, nombreApo, apellidosApo, numCelularApo, direccionApo, estadoApot
	from Apoderado
	where estadoApot='1'

exec spListarApoderado

--Insertar
go
create or alter procedure spInsertarApoderado(
@dniApo varchar(8),
@nombreApo varchar(40),
@apellidosApo varchar (40),
@numCelularApo varchar(9),
@direccionApo varchar(100),
@estadoApot bit
)
as
begin
	insert into Apoderado(dniApo, nombreApo, apellidosApo, numCelularApo, direccionApo, estadoApot)
	values (@dniApo, @nombreApo, @apellidosApo, @numCelularApo, @direccionApo, @estadoApot)
end


EXEC spInsertarApoderado 
    @dniApo = '87654321',
    @nombreApo = 'Luis',
    @apellidosApo = 'Ramírez Torres',
    @numCelularApo = '987654321',
    @direccionApo = 'Av. Los Olivos 125',
    @estadoApot = 1;

select * from Apoderado

--Editar
go
create or alter procedure spEditarApoderado 
(
    @idApoderado int,
    @dniApo varchar(8),
    @nombreApo varchar(40),
    @apellidosApo varchar(40),
    @numCelularApo varchar(9),
    @direccionApo varchar(100),
    @estadoApot bit
)
as
begin 
    update Apoderado
    set 
        dniApo = @dniApo,
        nombreApo = @nombreApo,
        apellidosApo = @apellidosApo,
        numCelularApo = @numCelularApo,
        direccionApo = @direccionApo,
        estadoApot = @estadoApot
    where idApoderado = @idApoderado;
end

select * from Apoderado
EXEC spEditarApoderado 
    @idApoderado = 2,
    @dniApo = '12345678',
    @nombreApo = 'Carlos',
    @apellidosApo = 'Torres Díaz',
    @numCelularApo = '987654321',
    @direccionApo = 'Av. Grau 456',
    @estadoApot = 1;

--Deshabilitar apoderado
go
create or alter procedure spDeshabilitarApoderado
(
    @idApoderado int
)
as
begin 
    update Apoderado
    set estadoApot = 0
    where idApoderado = @idApoderado;
end

EXEC spDeshabilitarApoderado @idApoderado = 2;

select * from Apoderado

----------------------------------------------
--------------	Estudiante	------------------
----------------------------------------------

--Listar
go
create or alter procedure spListarEstudiante
as
	select 
		idEstudiante, 
		dniEst, 
		nombreEst, 
		apellidosEst, 
		fechaNacEst, 
		direccionEst, 
		idApoderado, 
		estadoEst
	from Estudiante
	where estadoEst = 1

exec spListarEstudiante


--Insertar
go
create or alter procedure spInsertarEstudiante
(
	@dniEst varchar(8),
	@nombreEst varchar(40),
	@apellidosEst varchar(40),
	@fechaNacEst date,
	@direccionEst varchar(100),
	@idApoderado int,
	@estadoEst bit
)
as
begin
	insert into Estudiante(dniEst, nombreEst, apellidosEst, fechaNacEst, direccionEst, idApoderado, estadoEst)
	values (@dniEst, @nombreEst, @apellidosEst, @fechaNacEst, @direccionEst, @idApoderado, @estadoEst)
end


EXEC spInsertarEstudiante 
	@dniEst = '78945612',
	@nombreEst = 'Ana',
	@apellidosEst = 'Gómez Paredes',
	@fechaNacEst = '2008-05-15',
	@direccionEst = 'Jr. Los Sauces 345',
	@idApoderado = 1,
	@estadoEst = 1;

select * from Estudiante


--Editar
go
create or alter procedure spEditarEstudiante 
(
	@idEstudiante int,
	@dniEst varchar(8),
	@nombreEst varchar(40),
	@apellidosEst varchar(40),
	@fechaNacEst date,
	@direccionEst varchar(100),
	@idApoderado int,
	@estadoEst bit
)
as
begin 
	update Estudiante
	set 
		dniEst = @dniEst,
		nombreEst = @nombreEst,
		apellidosEst = @apellidosEst,
		fechaNacEst = @fechaNacEst,
		direccionEst = @direccionEst,
		idApoderado = @idApoderado,
		estadoEst = @estadoEst
	where idEstudiante = @idEstudiante;
end


select * from Estudiante

EXEC spEditarEstudiante 
	@idEstudiante = 1,
	@dniEst = '65498732',
	@nombreEst = 'María',
	@apellidosEst = 'Fernández Soto',
	@fechaNacEst = '2009-03-10',
	@direccionEst = 'Av. Primavera 789',
	@idApoderado = 2,
	@estadoEst = 1;


--Deshabilitar estudiante
go
create or alter procedure spDeshabilitarEstudiante
(
	@idEstudiante int
)
as
begin 
	update Estudiante
	set estadoEst = 0
	where idEstudiante = @idEstudiante;
end

EXEC spDeshabilitarEstudiante @idEstudiante = 1;

select * from Estudiante

----------------------------------------------
--------------	Docente	----------------------
----------------------------------------------

--Listar
go
create or alter procedure spListarDocente
as
	select 
		idDocente, 
		dniDoc, 
		nombreDoc, 
		apellidosDoc, 
		numCelularDoc, 
		direccionDoc, 
		estadoDoc
	from Docente
	where estadoDoc = 1

exec spListarDocente


--Insertar
go
create or alter procedure spInsertarDocente
(
	@dniDoc varchar(8),
	@nombreDoc varchar(40),
	@apellidosDoc varchar(40),
	@numCelularDoc varchar(9),
	@direccionDoc varchar(100),
	@estadoDoc bit
)
as
begin
	insert into Docente(dniDoc, nombreDoc, apellidosDoc, numCelularDoc, direccionDoc, estadoDoc)
	values (@dniDoc, @nombreDoc, @apellidosDoc, @numCelularDoc, @direccionDoc, @estadoDoc)
end


EXEC spInsertarDocente 
	@dniDoc = '45678912',
	@nombreDoc = 'José',
	@apellidosDoc = 'Ramos Flores',
	@numCelularDoc = '987321654',
	@direccionDoc = 'Av. La Cultura 321',
	@estadoDoc = 1;

select * from Docente


--Editar
go
create or alter procedure spEditarDocente 
(
	@idDocente int,
	@dniDoc varchar(8),
	@nombreDoc varchar(40),
	@apellidosDoc varchar(40),
	@numCelularDoc varchar(9),
	@direccionDoc varchar(100),
	@estadoDoc bit
)
as
begin 
	update Docente
	set 
		dniDoc = @dniDoc,
		nombreDoc = @nombreDoc,
		apellidosDoc = @apellidosDoc,
		numCelularDoc = @numCelularDoc,
		direccionDoc = @direccionDoc,
		estadoDoc = @estadoDoc
	where idDocente = @idDocente;
end


select * from Docente

EXEC spEditarDocente 
	@idDocente = 1,
	@dniDoc = '12345678',
	@nombreDoc = 'Carlos',
	@apellidosDoc = 'Salazar Núñez',
	@numCelularDoc = '999888777',
	@direccionDoc = 'Jr. Los Álamos 987',
	@estadoDoc = 1;


--Deshabilitar docente
go
create or alter procedure spDeshabilitarDocente
(
	@idDocente int
)
as
begin 
	update Docente
	set estadoDoc = 0
	where idDocente = @idDocente;
end

EXEC spDeshabilitarDocente @idDocente = 1;

select * from Docente

----------------------------------------------
-------------- Nivel Academico	--------------
----------------------------------------------

--Listar
go
create or alter procedure spListarNivelAcademico
as
	select  idNivel, nombreNivel, estadoNivel
	from NivelAcademico
	where estadoNivel=1

exec spListarNivelAcademico

sp_help nivelacademico

--Insertar
go
create or alter procedure spInsertarNivelAcademico
(
	@nombreNivel varchar(40),
	@estadoNivel bit
)
as
begin
	insert into NivelAcademico(nombreNivel, estadoNivel)
	values (@nombreNivel, @estadoNivel)
end

exec spInsertarNivelAcademico
	@nombreNivel = 'Inicial',
	@estadoNivel = 1

select * from NivelAcademico

--Editar
go
create or alter procedure spEditarNivelAcademico 
(
	@idNivel int,
	@nombreNivel varchar(40),
	@estadoNivel bit
)
as
begin 
	update NivelAcademico
	set 
		nombreNivel = @nombreNivel,
		estadoNivel = @estadoNivel
	where idNivel = @idNivel;
end

select * from NivelAcademico
exec spEditarNivelAcademico
	@idNivel=3,
	@nombreNivel='Educacion Especial',
	@estadoNivel=1 

--Deshabilitar nivelAcademico
go
create or alter procedure spDeshabilitarNivelAcademico
(
	@idNivel int
)
as
begin 
	update NivelAcademico
	set estadoNivel = 0
	where idNivel = @idNivel;
end

exec spDeshabilitarNivelAcademico
	@idNivel=3

select * from NivelAcademico

----------------------------------------------
-------------- Grado Academico	--------------
----------------------------------------------

sp_help gradoacademico
--Listar
go
create or alter procedure spListarGradoAcademico
as
	select idGrado, nombreGrado, idNivel, estadoGrado 
	from GradoAcademico
	where estadoGrado=1

exec spListarGradoAcademico

--Insertar
go
create or alter procedure spInsertarGradoAcademico
(
	@nombreGrado varchar(40),
	@idNivel int,
	@estadoGrado bit
)
as
begin
	insert into GradoAcademico(nombreGrado, idNivel, estadoGrado)
	values (@nombreGrado, @idNivel, @estadoGrado)
end

exec spInsertarGradoAcademico
	@nombreGrado='Tercero',
	@idNivel=2,
	@estadoGrado=1

 --Editar
go
create or alter procedure spEditarGradoAcademico 
(
	@idGrado int,
	@nombreGrado varchar(40),
	@idNivel int,
	@estadoGrado bit
)
as
begin 
	update GradoAcademico
	set 
		nombreGrado = @nombreGrado,
		idNivel = @idNivel,
		estadoGrado = @estadoGrado 
	where idGrado = @idGrado
end

--Deshabilitar
go
create or alter procedure spDeshabilitarGradoAcademico
(
	@idGrado int
)
as
begin 
	update GradoAcademico
	set estadoGrado = 0
	where idGrado = @idGrado;
end

----------------------------------------------
--------------      Cursos		--------------
----------------------------------------------
sp_help curso
--Listar
go
create or alter procedure spListarCursos
as
	select idCurso, nombreCurso, idDocente, idGrado, estadoCurso 
	from Curso
	where estadoCurso=1

exec spListarCursos

--Insertar
go
create or alter procedure spInsertarCurso
(
	@nombreCurso varchar(30),
	@idDocente int,
	@idGrado int,
	@estadoCurso bit
)
as
begin
	insert into Curso(nombreCurso, idDocente, idGrado, estadoCurso)
	values (@nombreCurso, @idDocente, @idGrado, @estadoCurso)
end

select * from Docente

sp_help curso
--Editar
go 
create or alter procedure spEditarCurso
(
	@idCurso int,
	@nombreCurso varchar(30),
	@idDocente int,
	@idGrado int,
	@estadoCurso bit
)
as
begin 
	update Curso
	set 
		nombreCurso = @nombreCurso,
		idDocente = @idDocente,
		idGrado = @idGrado,
		estadoCurso = @estadoCurso
	where idCurso = @idCurso
end

--Deshabilitar
go
create or alter procedure spDeshabilitarCurso
(
	@idCurso int
)
as
begin 
	update Curso
	set estadoCurso = 0
	where idCurso = @idCurso;
end

exec spDeshabilitarCurso @idCurso=3
select * from curso