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
Nombre varchar(40)not null,
PRIMARY KEY(CodDocente)
)
go
CREATE TABLE TAsignatura(
CodAsignatura TCodAsignatura not null,
NombreAsignatura varchar(100)not null,
Creditos varchar(2),
Categoria varchar(3),
CodDocente TCodDocente not null,
PRIMARY KEY(CodAsignatura),
FOREIGN KEY(CodDocente) references TDocente(CodDocente)
)
go
CREATE TABLE THorario(
CodHorario TCodHorario not null,
Horario varchar(20)not null,
PRIMARY KEY(CodHorario)
)
go
CREATE TABLE TDia(
CodDia TCodDia not null,
Dia varchar(10)not null,
PRIMARY KEY(CodDia)
)
go


CREATE TABLE TPrincipal(
Numero_Laboratorio varchar(3),
CodDia TCodDia not null,
CodHorario TCodHorario not null,
CodAsignatura TCodAsignatura not null,
FOREIGN KEY(CodDia) references TDia(CodDia),
FOREIGN KEY(CodHorario) references THorario(CodHorario),
FOREIGN KEY(CodAsignatura) references TAsignatura(CodAsignatura)
)
go

insert into TUsuario values ('1234','MICHEL','CANO','LOAIZA','75684458','ACTIVO')

insert into TUsuario values ('1254','Manuel','Apaza','Garrido','56883423','DESACTIVO')
insert into TDocente values('Doc1','Carbafeik lucho silva')
insert into TDocente values('Doc2','Rambo Michel Lucho')

insert into TAsignatura values('IF412AIN','ALGORITMICA','4','OE','Doc1')
insert into TAsignatura values('IF416AIN','COMPUTACIÓN GRÁFICA','4','OE','Doc2')

--insert into THorario values('H1','7:00-9:00')
--insert into THorario values('H2','9:00-11:00')
--insert into TDia values('D1','Lunes')
--insert into TDia values('D2','Martes')
--insert into TDia values('D3','Miercoles')
--insert into TDia values('D4','Jueves')
--insert into TDia values('D5','Viernes')
--insert into TPrincipal values('301','D1','H1','IF412AIN','Doc1')
--insert into TPrincipal values('304','D5','H2','IF416AIN','Doc2')
--select* from TUsuario
--select* from TDocente
--select* from TDia
--select* from THorario
--select* from TPrincipal
