create table Gamers(
nombreGamer varchar2(30) not null primary key,
email varchar2(50),
fono varchar2(15)
);
create table Torneos(
codTorneo number(5) not null primary key,
nombreTorneo varchar2(40),
categoria varchar2(30)
);
create table Juegos(
codJuego number(6) not null primary key,
fecha date,
puntaje number(6),
nombreGamer varchar2(30) not null references Gamers,
codTorneo number(5) not null references Torneos
);
insert into Gamers values('ShadowX','shadowx@gmail.com','912345678');
insert into Gamers values('DragonPro','dragonpro@gmail.com','923456789');
insert into Gamers values('FireStorm','firestorm@gmail.com','934567890');
insert into Gamers values('DarkWolf','darkwolf@gmail.com','945678901');
insert into Gamers values('TitanX','titanx@gmail.com','956789012');
insert into Torneos values(101,'Copa Nacional','Accion');
insert into Torneos values(102,'Liga Gamer Chile','Estrategia');
insert into Torneos values(103,'Masters Gaming','Deportes');
insert into Torneos values(104,'Copa Titan','Aventura');
insert into Torneos values(105,'Desafio Nacional','Combate');
insert into Juegos values(1001,'05/03/2026',850,'ShadowX',101);
insert into Juegos values(1002,'06/03/2026',920,'DragonPro',101);
insert into Juegos values(1003,'07/03/2026',780,'FireStorm',101);
insert into Juegos values(1004,'08/03/2026',1050,'DarkWolf',101);
insert into Juegos values(1005,'10/03/2026',1100,'ShadowX',102);
insert into Juegos values(1006,'11/03/2026',950,'TitanX',102);
insert into Juegos values(1007,'12/03/2026',1020,'FireStorm',102);
insert into Juegos values(1008,'15/03/2026',1250,'DragonPro',103);
insert into Juegos values(1009,'16/03/2026',870,'DarkWolf',103);
insert into Juegos values(1010,'17/03/2026',990,'TitanX',103);
insert into Juegos values(1011,'20/03/2026',1150,'ShadowX',104);
insert into Juegos values(1012,'21/03/2026',1080,'DragonPro',104);
insert into Juegos values(1013,'22/03/2026',930,'FireStorm',104);
insert into Juegos values(1014,'25/03/2026',1350,'DarkWolf',105);
insert into Juegos values(1015,'26/03/2026',1180,'TitanX',105);
insert into Juegos values(1016,'02/04/2026',1420,'ShadowX',105);
insert into Juegos values(1017,'05/04/2026',1280,'DragonPro',102);
insert into Juegos values(1018,'08/04/2026',1160,'FireStorm',103);
insert into Juegos values(1019,'12/04/2026',1500,'DarkWolf',102);
insert into Juegos values(1020,'15/04/2026',1320,'TitanX',104);

--create table Gamers(
nombreGamer varchar2(30) not null primary key,
email varchar2(50),
fono varchar2(15)
);
create table Torneos(
codTorneo number(5) not null primary key,
nombreTorneo varchar2(40),
categoria varchar2(30)
);
create table Juegos(
codJuego number(6) not null primary key,
fecha date,
puntaje number(6),
nombreGamer varchar2(30) not null references Gamers,
codTorneo number(5) not null references Torneos
);
insert into Gamers values('ShadowX','shadowx@gmail.com','912345678');
insert into Gamers values('DragonPro','dragonpro@gmail.com','923456789');
insert into Gamers values('FireStorm','firestorm@gmail.com','934567890');
insert into Gamers values('DarkWolf','darkwolf@gmail.com','945678901');
insert into Gamers values('TitanX','titanx@gmail.com','956789012');
insert into Torneos values(101,'Copa Nacional','Accion');
insert into Torneos values(102,'Liga Gamer Chile','Estrategia');
insert into Torneos values(103,'Masters Gaming','Deportes');
insert into Torneos values(104,'Copa Titan','Aventura');
insert into Torneos values(105,'Desafio Nacional','Combate');
insert into Juegos values(1001,'05/03/2026',850,'ShadowX',101);
insert into Juegos values(1002,'06/03/2026',920,'DragonPro',101);
insert into Juegos values(1003,'07/03/2026',780,'FireStorm',101);
insert into Juegos values(1004,'08/03/2026',1050,'DarkWolf',101);
insert into Juegos values(1005,'10/03/2026',1100,'ShadowX',102);
insert into Juegos values(1006,'11/03/2026',950,'TitanX',102);
insert into Juegos values(1007,'12/03/2026',1020,'FireStorm',102);
insert into Juegos values(1008,'15/03/2026',1250,'DragonPro',103);
insert into Juegos values(1009,'16/03/2026',870,'DarkWolf',103);
insert into Juegos values(1010,'17/03/2026',990,'TitanX',103);
insert into Juegos values(1011,'20/03/2026',1150,'ShadowX',104);
insert into Juegos values(1012,'21/03/2026',1080,'DragonPro',104);
insert into Juegos values(1013,'22/03/2026',930,'FireStorm',104);
insert into Juegos values(1014,'25/03/2026',1350,'DarkWolf',105);
insert into Juegos values(1015,'26/03/2026',1180,'TitanX',105);
insert into Juegos values(1016,'02/04/2026',1420,'ShadowX',105);
insert into Juegos values(1017,'05/04/2026',1280,'DragonPro',102);
insert into Juegos values(1018,'08/04/2026',1160,'FireStorm',103);
insert into Juegos values(1019,'12/04/2026',1500,'DarkWolf',102);
insert into Juegos values(1020,'15/04/2026',1320,'TitanX',104);

--1.	Mostrar el email y fono del gamer que realizó el juego código 1001

select email, fono
from gamers
where nombregamer =
(select nombregamer
from juegos
where codjuego = 1001);

--2.	Mostrar el nombre y categoría del torneo correspondiente al juego código 1010. 

select nombretorneo, categoria
from torneos
where codtorneo =
(select codtorneo
from juegos 
where codjuego = 1010);

--3.	Mostrar el nombre del gamer con menor puntaje obtenido.

select nombregamer
from gamers
where nombregamer = 
(select nombregamer
from juegos
where puntaje = (
select min(puntaje)
from juegos));

--4.	Mostrar el torneo en el que se obtuvo el mayor puntaje.

select nombretorneo
from torneos
where codtorneo = 
(select codtorneo
from juegos
where puntaje =
(select max(puntaje)
from juegos));

--5.	Crear una subconsulta ideada por Uds.

select nombretorneo
from torneos
where codtorneo = 
(select codtorneo
from juegos
where puntaje =
(select min(puntaje)
from juegos));
