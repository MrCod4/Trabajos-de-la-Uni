create table equipos(
codigoEquipo varchar2(5) primary key not null,
descripEquipo varchar2(30),
marcaEquipo varchar2(20),
modeloEquipo varchar2(14),
stock number(3)
);
create table clientes(
rutCliente varchar2(13) primary key not null,
nomCli varchar2(20),
apPatCli varchar2(15),
apMatCli varchar2(15),
categoria number(2),
fonoCli varchar2(14)
);
create table arriendos(
codArriendo number(4) primary key not null,
sucursal varchar2(30),
fechaArriendo date,
costoArriendo number(6),
tipoDePago varchar2(10),
codEquipo varchar2(5) not null references equipos,
rutCliente varchar2(13) not null references clientes
);





insert into equipos values('RTY67','Taladro','Makita','BD700',12);
insert into equipos values('DRF54','Motosierra','Stihl','ST67',15);
insert into equipos values('DRF56','Esmeril angular','ByD','BD56',8);
insert into equipos values('FG567','Mezcladora','Makita','MT56',18);
insert into equipos values('RTY54','Grupo generador','Stihl','ST56',21);

insert into clientes values('10534876-5','David','Parra','Lara',1,'945219992');
insert into clientes values('14340300-k','Marta','Soto','Vera',2,'979050234');
insert into clientes values('12500320-8','Daniel','Mena','Duarte',1,'994568001');
insert into clientes values('8768320-1','Carla','Villa','Jara',2,'');
insert into clientes values('9435678-9','Manuel','Castro','Godoy',3,'');
insert into clientes values('14567980-k','Francisco','Barra','Méndez',3,'987658908');

insert into arriendos values(2334,'Talcahuano','15/1/2023',23000,'Contado','RTY67','10534876-5');
insert into arriendos values(2335,'Concepción','23/1/2023',87000,'Crédito','DRF54','10534876-5');
insert into arriendos values(2336,'Penco','11/2/2023',59000,'Contado','RTY67','14340300-k');
insert into arriendos values(2337,'Concepción','13/2/2023',45000,'Contado','DRF54','14567980-k');
insert into arriendos values(2338,'Talcahuano','25/2/2023',59000,'Crédito','RTY54','9435678-9');
insert into arriendos values(2339,'Talcahuano','2/3/2023',28900,'Crédito','FG567','8768320-1');
insert into arriendos values(2340,'Penco','12/3/2023',60500,'Crédito','RTY54','9435678-9');
insert into arriendos values(2341,'Concepción','14/3/2023',47000,'Contado','FG567','14567980-k');
insert into arriendos values(2342,'Concepción','15/3/2023',29000,'Contado','RTY54','10534876-5');
insert into arriendos values(2343,'Concepción','23/3/2023',86000,'Crédito','DRF54','9435678-9');
insert into arriendos values(2344,'Concepción','5/4/2023',76000,'Crédito','DRF56','12500320-8');
insert into arriendos values(2345,'Penco','9/4/2023',108000,'Crédito','FG567','8768320-1');
insert into arriendos values(2346,'Talcahuano','16/4/2023',94000,'Contado','DRF54','14340300-k');
insert into arriendos values(2347,'Talcahuano','4/5/2023',87000,'Crédito','RTY67','10534876-5');
insert into arriendos values(2348,'Concepción','17/5/2023',83000,'Crédito','DRF54','14340300-k');
insert into arriendos values(2349,'Concepción','18/5/2023',45000,'Crédito','DRF56','12500320-8');
insert into arriendos values(2350,'Talcahuano','28/5/2023',74000,'Crédito','FG567','8768320-1');
insert into arriendos values(2351,'Penco','1/6/2023',105000,'Crédito','RTY54','9435678-9');
insert into arriendos values(2352,'Concepción','8/6/2023',55000,'Crédito','RTY67','14567980-k');
insert into arriendos values(2353,'Talcahuano','15/6/2023',77000,'Crédito','DRF54','10534876-5');
insert into arriendos values(2354,'Penco','19/6/2023',82000,'Crédito','DRF56','14340300-k');
insert into arriendos values(2355,'Penco','24/6/2023',56000,'Crédito','FG567','12500320-8');
insert into arriendos values(2356,'Concepción','27/6/2023',92000,'Crédito','RTY54','8768320-1');
insert into arriendos values(2357,'Concepción','5/7/2023',64000,'Crédito','FG567','12500320-8');
insert into arriendos values(2358,'Concepción','12/7/2023',91000,'Crédito','DRF54','9435678-9');
insert into arriendos values(2359,'Talcahuano','19/7/2023',107000,'Crédito','RTY54','12500320-8');
insert into arriendos values(2360,'Concepción','24/7/2023',94000,'Crédito','DRF54','8768320-1');
insert into arriendos values(2361,'Concepción','25/7/2023',47000,'Contado','RTY54','9435678-9');
insert into arriendos values(2362,'Concepción','28/7/2023',97000,'Crédito','DRF54','12500320-8');

--1)	Nombre completo del cliente, la descripción del equipo, y el costo del arriendo de los arriendos realizados
--Sin join:

select nomcli, appatcli, apmatcli, descripequipo, costoarriendo
from equipos e, arriendos a, clientes c
where codigoequipo = codequipo and a.rutcliente = c.rutcliente;

--Con join:
select nomcli, appatcli, apmatcli, descripequipo, costoarriendo
from equipos e join arriendos a on codigoequipo = codequipo join clientes c on a.rutcliente = c.rutcliente; 

--2)	Nombre del cliente, el equipo arrendado y la fecha del arriendo para quienes han arrendado un equipo en la sucursal 'Concepción'.
--Sin join:
select nomcli, descripequiepo, fechaarriendo
from equipos e, arriendos a, clientes c
where codigoequipo = codequipo and a.rutcliente = c.rutcliente and sucursal = 'Concepción';

--Con join:
select nomcli, e.codigoequipo, fechaarriendo
from equipos e join arriendos a on codigoequipo = codequipo join clientes c on a.rutcliente = c.rutcliente and sucursal = 'Concepción';

--3)	El apellido paterno del cliente y el tipo de pago utilizado en cada arriendo, ordenado por el apellido paterno del cliente.
--Sin join:
select appatcli, tipodepago
from arriendos a, clientes c
where  a.rutcliente = c.rutcliente 
order by appatcli;

--Con join:
select appatcli, tipodepago
from arriendos a join clientes c on a.rutcliente = c.rutcliente
order by appatcli;

--4)	Descripción del equipo y la fecha del arriendo arrendados por el cliente con rut 10534876-5 
--Sin join:
select descripequipo, fechaarriendo
from equipos e, arriendos a, clientes c
where codigoequipo = codequipo and a.rutcliente = c.rutcliente and c.rutcliente = '10534876-5';

--Con join:
select descripequipo, fechaarriendo
from equipos e join arriendos a on codigoequipo = codequipo join clientes c on a.rutcliente = c.rutcliente and  c.rutcliente = '10534876-5';

--5)	Descripción del equipo y el nombre completo del cliente para los arriendos realizados en la sucursal Talcahuano.
--Sin join:
select descripequipo, nomcli, appatcli, apmatcli
from equipos e, arriendos a, clientes c
where codigoequipo = codequipo and a.rutcliente = c.rutcliente and sucursal = 'Talcahuano';

--Con join:
select descripequipo, nomcli, appatcli, apmatcli
from equipos e join arriendos a on codigoequipo = codequipo join clientes c on a.rutcliente = c.rutcliente and sucursal = 'Talcahuano';

--6)	Los nombres de los clientes y los modelos de los equipos que se han arrendado, ordenando el resultado por el modelo del equipo
--Sin join:
select nomcli, modeloequipo
from equipos e, arriendos a, clientes c
where codigoequipo = codequipo and a.rutcliente = c.rutcliente
order by modeloequipo;

--Con join:
select nomcli, modeloequipo
from equipos e join arriendos a on codigoequipo = codequipo join clientes c on a.rutcliente = c.rutcliente
order by modeloequipo;

--7)	Nombre completo del cliente y la fecha del arriendo en que han arrendado el equipo con código DRF54.
--Sin join:
select nomcli, appatcli, apmatcli, fechaarriendo
from equipos e, arriendos a, clientes c
where codigoequipo = codequipo and a.rutcliente = c.rutcliente and codequipo = 'DRF54';

--Con join:
select nomcli, appatcli, apmatcli, fechaarriendo
from equipos e join arriendos a on codigoequipo = codequipo join clientes c on a.rutcliente = c.rutcliente and codequipo = 'DRF54';

--Nueva clase 1
--E1
select sum(costoarriendo) 
from arriendos a, clientes c
where a.rutcliente = c.rutcliente
and nomcli = 'David'
and appatcli = 'Parra';

--E2
select sum(costoarriendo) 
from arriendos a 
join clientes c 
on a.rutcliente = c.rutcliente
and nomcli = 'David'
and appatcli = 'Parra';

--E3
select count(marcaequipo)
from equipos e, arriendos a
where e.codigoequipo = a.codequipo
and descripequipo = 'Taladro';

--E4
select count(marcaequipo)
from equipos e join arriendos a
on e.codigoequipo = a.codequipo
and descripequipo = 'Taladro';

--E5
select max(costoarriendo)
from arriendos a, clientes c
where a.rutcliente = c.rutcliente
and nomcli = 'Marta'
and appatcli = 'Soto';

--E6
select max(costoarriendo)
from arriendos a join clientes c
on a.rutcliente = c.rutcliente
and nomcli = 'Marta'
and appatcli = 'Soto';

--E7
select min(fechaarriendo)
from equipos e, arriendos a
where e.codigoequipo = a.codequipo
and descripequipo = 'Motosierra';

--E8
select min(fechaarriendo)
from equipos e join arriendos a
on e.codigoequipo = a.codequipo
and descripequipo = 'Motosierra';

--E9
select avg(costoarriendo)
from arriendos a, clientes c
where a.rutcliente = c.rutcliente
and nomcli = 'Manuel'
and appatcli = 'Castro'
and fechaarriendo > '20/03/23';

--E10
select avg(costoarriendo)
from arriendos a join clientes c
on a.rutcliente = c.rutcliente
and nomcli = 'Manuel'
and appatcli = 'Castro'
and fechaarriendo > '20/03/23';

--E11
select count(fechaarriendo), sum(costoarriendo)
from arriendos a join clientes c
on a.rutcliente = c.rutcliente 
join equipos e
on e.codigoequipo = a.codequipo
and nomcli = 'Carla'
and appatcli = 'Villa'
and descripequipo = 'Mezcladora';

--E12
select max(fechaarriendo)
from arriendos a,equipos e
where e.codigoequipo=a.codequipo
and descripEquipo='Esmeril angular';

--E13
select max(fechaarriendo)
from arriendos a join equipos e
on e.codigoequipo=a.codequipo
and descripEquipo='Esmeril angular';

--Clase nueva, Group by
--E14
select sucursal, sum(costoarriendo) SUMADEARRIENDOS
from arriendos a
group by sucursal;

--E15
select codequipo, round(avg(costoarriendo), 2)
from arriendos
where codequipo like 'RT%'
group by codequipo;

--E16
select sucursal, fechaarriendo, round(avg(costoarriendo), 2)
from arriendos
having sum(costoarriendo) >= 95000
group by sucursal, fechaarriendo;


--E17
select tipodepago, round(avg(costoarriendo),2)
from arriendos a
join clientes c
on c.rutcliente = a.rutcliente
where categoria = 1
group by tipodepago;

--E18
select sucursal, tipodepago, count(marcaequipo)
from arriendos a
join equipos e
on e.codigoequipo = a.codequipo
where descripequipo like 'M%'
group by sucursal, tipodepago;

--E19
select nomcli, appatcli, apmatcli
from arriendos a
join equipos e
on e.codigoequipo = a.codequipo
join clientes c
on a.rutcliente = c.rutcliente
where marcaequipo like 'S%'
group by nomcli, appatcli;

--E20
select tipodepago, round(avg(costoarriendo),2)
from arriendos a
join clientes c
on a.rutcliente = c.rutcliente
where categoria = 1
having avg(costoarriendo) > 20000
group by tipodepago;

--E21
select nomcli, appatcli, sum(costoarriendo)
from arriendos a
join equipos e
on codigoequipo = codequipo
join clientes c
on a.rutcliente = c.rutcliente
where marcaequipo like 'S%'
having sum(costoarriendo) > 200000
group by nomcli, appatcli;







