use CursoPoo;

go

create table Personaje(
Id int primary key identity (1,1),
Nombre nvarchar(100) not null,
Tipo nvarchar(100) not null,
Nivel int not null
);

go

insert Personaje(Nombre, Tipo, Nivel)
values
('Aragorn', 'Guerrero', 8),
('Gandlf', 'Mago', 12),
('Legolas', 'Arquero', 5);

go

select*
from Personaje
where Nivel>=5;

update Personaje
set Nivel = 10
where Id = 1;
