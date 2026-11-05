--1
create table turistas(
rutturista varchar2(10)not null primary key,
nomturista varchar2(15),
appatturista varchar2(15),
apmatturista varchar2(15),
emailturista varchar2(15)
);
create table packturisticos(
codpack number(9)not null primary key,
cantdias number(2),
paisdestino varchar2(15)
);
create table viajes(
codviaje number(10)not null primary key,
fechaviaje date,
costoviaje number(8),
rutturista varchar2(10)not null references turistas,
codigopack number(9)not null references packturisticos
);

--Inserts
insert into turistas values('1111111-9','Julián','Rebolledo','Toloza','JRT@gmail.cl');
insert into turistas values('2222222-9','Danitza','Contreras','Aguilera','DCA@gmail.cl');

insert into packturisticos values(123,20,'Francia');
insert into packturisticos values(124,35,'España');

--1
create sequence sec_codviaje
start with 1;

--2
insert into viajes values(sec_codviaje.nextval,'15/01/2026',25000,'1111111-9',123);
insert into viajes values(sec_codviaje.nextval,'20/06/2026',53000,'2222222-9',123);
insert into viajes values(sec_codviaje.nextval,'17/09/2026',80000,'1111111-9',124);
insert into viajes values(sec_codviaje.nextval,'21/04/2026',10000,'2222222-9',124);
insert into viajes values(sec_codviaje.nextval,'07/05/2026',67000,'1111111-9',123);
insert into viajes values(sec_codviaje.nextval,'23/01/2026',100000,'2222222-9',124);
insert into viajes values(sec_codviaje.nextval,'25/10/2026',250000,'1111111-9',123);
insert into viajes values(sec_codviaje.nextval,'06/07/2026',5000,'2222222-9',124);
insert into viajes values(sec_codviaje.nextval,'01/10/2026',43000,'1111111-9',124);
insert into viajes values(sec_codviaje.nextval,'30/04/2026',49000,'1111111-9',123);

--3
create index indice_fecha on
viajes(fechaviaje);

--4
create view vista_rut_fecha as 
select t.rutturista,v.fechaviaje
from turistas t,viajes v
where t.rutturista=v.rutturista
and v.fechaviaje between '21/04/2026' and '06/07/2026';

--5
select * from vista_rut_fecha;

--6
create synonym vistafechaentre for turistas;

--7
select * from vistafechaentre;

--8
select codviaje,nvl(fechaviaje,'01/01/1111')
from viajes;

--9
select fechaviaje,costoviaje,
case 
when costoviaje<500000 then 'Costo bajo'
when costoviaje>=500000 and costoviaje<=800000 then 'Costo medio'
else 'Costo alto'
end Clasificacion
from viajes;

--10
select 'El turista '||upper(nomturista)||' '||upper(appatturista)||' pago $'||costoviaje||' por el viaje '||codviaje Turista_Viaje
from viajes v
join turistas t
on v.rutturista = t.rutturista
where costoviaje > 50000;

--11
select 'El pack '||codpack||' de '||cantdias|| ' dias, se contrato para el dia '||substr(fechaviaje,1,2)||' de octubre' Fecha_Pack
from viajes v
join packturisticos p
on p.codpack = v.codigopack
where substr(fechaviaje,4,2) = '10';
 
--12
select 'El costo diario del pack a '||paisdestino||' es de $'||round((costoviaje/cantdias),1)||' para el turista con rut '||rutturista Costo_Pack
from viajes v
join packturisticos p
on p.codpack = v.codigopack;

--13
select 'Han pasado '||trunc(sysdate - fechaviaje)||' dias, desde que el turista '||nomturista||' '||appatturista||' '||apmatturista||' viajo a '||paisdestino Dias_Transcurridos
from viajes v
join turistas t
on v.rutturista = t.rutturista
join packturisticos p
on p.codpack = v.codigopack;

--14
select 'El viaje '||codviaje||' fue un dia '||to_char(fechaviaje,'day') Fecha_de_Viaje
from viajes
where substr(fechaviaje,4,2) = '10';

--15
select 'Para el pack '||codigopack||' se tiene un costo total de $'||sum(costoviaje) Total_Pack
from viajes
having sum(costoviaje) > 100000
group by codigopack;

--16
select 'A '||paisdestino||' el dia '||fechaviaje||' viajo el turista '||nomturista||' '||appatturista||' '||apmatturista Fecha_viaje_de_turista
from viajes v
join turistas t
on v.rutturista = t.rutturista
join packturisticos p
on p.codpack = v.codigopack
where costoviaje < 60000;

--17
select 'El turista '||nomturista||' '||appatturista||' viajo al menor costo' Menor_Costo
from viajes v
join turistas t
on v.rutturista = t.rutturista
where costoviaje = (
select min(costoviaje)
from viajes
);
 
