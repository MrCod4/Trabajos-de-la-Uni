if db_id('CursoPoo') is null
create database CursoPoo;

go

use CursoPoo;

go
create table Carreras(
id int primary key identity (1,1),
Nombre nvarchar(100) not null
);
go

create table Estudiantes(
Id int primary key identity (1,1),
Nombre nvarchar(100) not null,
Correo nvarchar(100) not null,
CarreraId int not null references Carreras(Id)
);
go

insert into Carreras(Nombre) 
values
('Ing Civil Informatica'),
('Ing Comercial'),
('Derecho');

insert into Estudiantes(Nombre, Correo, CarreraId)
values
('Ana Perez','ana@ejemplo.cl',1),
('Luiz soto','luiz@ejemplo.cl',2),
('Maria Diaz','maria@ejemplo.cl',3);
go

select c.Nombre, e.Nombre, Correo, CarreraId
from Carreras c, Estudiantes e
where c.Id = e.CarreraId;

