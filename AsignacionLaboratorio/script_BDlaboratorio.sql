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
CREATE TYPE TCodDocente FROM varchar(8) not null;
go
CREATE TYPE TCodAsignatura FROM varchar(10) not null;
go 
CREATE TYPE TCodHorario FROM varchar(2) not null;
go 
CREATE TYPE TCodDia FROM varchar(2) not null;
go  
CREATE TYPE TCodPerfil FROM varchar(8) not null;
go 

/*Crear las tablas*/
CREATE TABLE TUsuario(

Contraseña varchar(10)not null,
Nombre varchar (50) not null,
Apellido_Paterno varchar(50) not null,
Apellido_Materno varchar (50) not null,
Dni_Usuario varchar(8) not null,
Estado Varchar(10),
Primary key(DNI_Usuario)
)
go


CREATE TABLE TDocente(
CodDocente TCodDocente not null,
Nombre varchar(10)not null,
PRIMARY KEY(CodDocente)
)
go
CREATE TABLE TAsignatura(
CodAsignatura TCodAsignatura not null,
NombreAsignatura varchar(100)not null,
Creditos varchar(2),
Categoria varchar(3),
PRIMARY KEY(CodAsignatura)
)
go
CREATE TABLE THorario(
CodHorario TCodHorario not null,
Horario varchar(2)not null,
PRIMARY KEY(CodHorario)
)
go
CREATE TABLE TDia(
CodDia TCodDia not null,
Dia varchar(10)not null,
PRIMARY KEY(CodDia)
)
go

CREATE TABLE TDocente_Asignatura(
CodDocente_Asignatura varchar(5) not null,
CodDocente TCodDocente not null,
CodAsignatura TCodAsignatura not null,
PRIMARY KEY(CodDocente_Asignatura),
FOREIGN KEY(CodDocente) references TDocente(CodDocente),
FOREIGN KEY(CodAsignatura) references TAsignatura(CodAsignatura)
)
go
CREATE TABLE TPrincipal(
CodDocente_Asignatura varchar(5) not null,
CodLaboratorio varchar(3),
CodDia TCodDia not null,
CodHorario TCodHorario not null,
FOREIGN KEY(CodDocente_Asignatura) references TDocente_Asignatura(CodDocente_Asignatura),
FOREIGN KEY(CodDia) references TDia(CodDia),
FOREIGN KEY(CodHorario) references THorario(CodHorario)
)
go

insert into TUsuario values ('1234','MICHEL','CANO','LOAIZA','75684458','ACTIVO')

insert into TUsuario values ('1254','Manuel','Apaza','Garrido','56883423','DESACTIVO')

insert into TAsignatura values('IF412AIN','ALGORITMICA','4','OE')
insert into TAsignatura values('IF416AIN','COMPUTACIÓN GRÁFICA','4','OE')

select* from TUsuario