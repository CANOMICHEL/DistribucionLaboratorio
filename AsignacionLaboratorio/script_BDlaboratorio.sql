--crear la base de datos--
use master
go
if exists (select * from sysdatabases where name = 'BDOrganizacionLaboratoriosDAI')
	drop database BDOrganizacionLaboratoriosDAI
go

CREATE DATABASE BDOrganizacionLaboratoriosDAI -- Create DataBase
go
use BDOrganizacionLaboratoriosDAI
go
/*Crear lo tipos*/
CREATE TYPE TCodDocente FROM varchar(5) not null;
go
CREATE TYPE TCodAsignatura FROM varchar(12) not null;
go 
CREATE TYPE TCodHorario FROM varchar(12) not null;
go 
CREATE TYPE TCodDia FROM varchar(12) not null;
go 
CREATE TYPE TCodLaboratorio FROM varchar(12) not null;
go  
CREATE TYPE TCodPerfil FROM varchar(12) not null;
go 
CREATE TYPE TIdUsuario from varchar(12) not null;
go
/*Crear las tablas*/
CREATE TABLE TUsuario(
IdUsuario TIdUsuario not null,
Usuario varchar(50) not null,
Contraseña varchar(100)not null,
Nombre varchar (20) not null,
Apellido_Paterno varchar(20) not null,
Apellido_Materno varchar (20) not null,
Dni varchar(10) not null,
Primary key(IdUsuario)
)
go

CREATE TABLE TUsuario1(
Usuario varchar(50) not null,
Contraseña varchar(100)not null
Primary key(Usuario)
)
go

CREATE TABLE TDocente(
CodDocente TCodDocente not null,
Nombre varchar(100)not null,
PRIMARY KEY(CodDocente)
)
go
CREATE TABLE TAsignatura(
CodAsignatura TCodAsignatura not null,
NombreAsignatura varchar(40)not null,
Creditos varchar(20),
Categoria varchar(20),
PRIMARY KEY(CodAsignatura)
)
go
CREATE TABLE THorario(
CodHorario TCodHorario not null,
Horario varchar(40)not null,
PRIMARY KEY(CodHorario)
)
go
CREATE TABLE TDia(
CodDia TCodDia not null,
Dia varchar(40)not null,
PRIMARY KEY(CodDia)
)
go
CREATE TABLE TLaboratorio(
CodLaboratorio TCodLaboratorio not null,
NroLaboratorio varchar(20)not null,
PRIMARY KEY(CodLaboratorio)
)
go
CREATE TABLE TDocente_Asignatura(
CodDocente_Asignatura varchar(12) not null,
CodDocente TCodDocente not null,
CodAsignatura TCodAsignatura not null,
PRIMARY KEY(CodDocente_Asignatura),
FOREIGN KEY(CodDocente) references TDocente(CodDocente),
FOREIGN KEY(CodAsignatura) references TAsignatura(CodAsignatura)
)
go
CREATE TABLE TPrincipal(
CodDocente_Asignatura varchar(12) not null,
CodLaboratorio TCodLaboratorio not null,
CodDia TCodDia not null,
CodHorario TCodHorario not null,
FOREIGN KEY(CodDocente_Asignatura) references TDocente_Asignatura(CodDocente_Asignatura),
FOREIGN KEY(CodLaboratorio) references TLaboratorio(CodLaboratorio),
FOREIGN KEY(CodDia) references TDia(CodDia),
FOREIGN KEY(CodHorario) references THorario(CodHorario)
)
go
CREATE TABLE TPerfil(
CodPerfil TCodPerfil not null,
Perfil varchar (20) not null,
PRIMARY KEY(CodPerfil)
)
go
CREATE TABLE TPerfil_Usuario(
CodPerfil TCodPerfil not null,
CodUsuario TIdUsuario not null,
Foreign key(CodPerfil) references TPerfil(CodPerfil),
Foreign key(CodUsuario) references TUsuario(IdUsuario)
)
go


insert into TUsuario1 values('U001','1234')
insert into TUsuario1 values('U002','1234')

insert into THorario values('H001','7-9')
insert into THorario values('H002','7-9')
insert into THorario values('H003','7-9')
insert into THorario values('H004','7-9')

select* from THorario
select* from TUsuario1