create table Vehiculos(
patente varchar2(6) not null primary key,
marca varchar2(20),
modelo varchar2(30),
año number(4)
);
create table Maestros(
rutMaestro varchar2(10) not null primary key,
nombres varchar2(30),
apPat varchar2(20),
apMat varchar2(20),
fono varchar2(15)
);
create table Reparaciones(
codReparacion number(6) not null primary key,
fecha date,
costo number(10),
patente varchar2(6) not null references Vehiculos,
rutMaestro varchar2(10) not null references Maestros
);
insert into Vehiculos values('VBRT34','Toyota','Yaris',2024);
insert into Vehiculos values('CDWS78','Hyundai','Accent',2019);
insert into Vehiculos values('FFJK12','Chevrolet','Sail',2021);
insert into Vehiculos values('GHBN56','Kia','Rio',2018);
insert into Vehiculos values('JKSD90','Nissan','Versa',2022);
insert into Maestros values('11111111-1','Carlos','Muñoz','Rojas','987654321');
insert into Maestros values('12222222-2','Pedro','Silva','Pérez','976543210');

insert into Maestros values('13333333-3','Andrés','Torres','Soto','965432109');
insert into Maestros values('14444444-4','Miguel','Vega','López','954321098');
insert into Maestros values('15555555-5','Felipe','Castro','Díaz','943210987');
insert into Reparaciones values(1001,'05/03/2026',45000,'VBRT34','11111111-1');
insert into Reparaciones values(1002,'07/03/2026',65000,'CDWS78','12222222-2');
insert into Reparaciones values(1003,'10/03/2026',38000,'FFJK12','13333333-3');
insert into Reparaciones values(1004,'12/03/2026',72000,'GHBN56','14444444-4');
insert into Reparaciones values(1005,'15/03/2026',55000,'JKSD90','15555555-5');
insert into Reparaciones values(1006,'18/03/2026',85000,'VBRT34','12222222-2');
insert into Reparaciones values(1007,'20/03/2026',42000,'CDWS78','13333333-3');
insert into Reparaciones values(1008,'22/03/2026',96000,'FFJK12','14444444-4');
insert into Reparaciones values(1009,'25/03/2026',68000,'GHBN56','15555555-5');
insert into Reparaciones values(1010,'28/03/2026',51000,'JKSD90','11111111-1');
insert into Reparaciones values(1011,'02/04/2026',76000,'VBRT34','13333333-3');
insert into Reparaciones values(1012,'05/04/2026',49000,'CDWS78','14444444-4');
insert into Reparaciones values(1013,'08/04/2026',105000,'FFJK12','15555555-5');
insert into Reparaciones values(1014,'11/04/2026',58000,'GHBN56','11111111-1');
insert into Reparaciones values(1015,'14/04/2026',62000,'JKSD90','12222222-2');
insert into Reparaciones values(1016,'17/04/2026',88000,'VBRT34','14444444-4');
insert into Reparaciones values(1017,'20/04/2026',47000,'CDWS78','15555555-5');
insert into Reparaciones values(1018,'23/04/2026',93000,'FFJK12','11111111-1');
insert into Reparaciones values(1019,'26/04/2026',71000,'GHBN56','12222222-2');
insert into Reparaciones values(1020,'29/04/2026',54000,'JKSD90','13333333-3');

--1)	Mostrar la patente y marca de los vehículos que hayan tenido una reparación cuyo costo sea mayor que todos los costos de las reparaciones realizadas al vehículo de patente 'CDWS78'.
select patente, marca
from vehiculos
where patente in (
select patente
from reparaciones 
where costo > all (
select costo
from reparaciones
where patente = 'CDWS78'));

--2)	Mostrar la patente y modelo de los vehículos que hayan tenido una reparación con un costo mayor que al menos uno de los costos de las reparaciones realizadas al vehículo de patente 'VBRT34'.
select patente, marca
from vehiculos
where patente in (
select patente
from reparaciones 
where costo > any (
select costo
from reparaciones
where patente = 'VBRT34'));

--3)	Mostrar los nombres y apellidos paternos de los maestros cuyo nombre comience con la letra 'C' y que hayan realizado alguna reparación con un costo mayor que el promedio de costos de todas las reparaciones.
select nombres, appat, apmat
from maestros
where nombres like 'C%'
and rutmaestro in (
select rutmaestro
from reparaciones
where costo > any(
select avg(costo)
from reparaciones));

--4)	Mostrar la patente y marca de los vehículos que hayan tenido reparaciones con un costo entre $50.000 y $80.000, y cuyo costo sea mayor que el promedio de todas las reparaciones.

select patente, marca
from  vehiculos
where patente in (
select patente
from reparaciones 
where costo between 50000 and 80000
and costo > all(
select avg(costo)
from reparaciones);

--5)	Mostrar los nombres de los maestros que hayan realizado una reparación cuyo costo sea mayor que todos los costos de las reparaciones realizadas durante marzo de 2026.

select nombres
from maestros
where rutmaestro in (
select rutmaestro
from reparaciones
where costo > all (
select costo
from reparaciones
where fecha between '1/03/2026' and '31/03/2026'));

--6)	Mostrar la patente y modelo de los vehículos que hayan tenido una reparación cuyo costo sea menor que al menos uno de los costos de las reparaciones realizadas al vehículo 'JKSD90'.

select patente, modelo
from vehiculos
where patente in (
select patente
from reparaciones
where costo < any (
select costo
from reparaciones
where patente = 'JKSD90'));

--7)	Mostrar los nombres y apellidos paternos de los maestros que hayan realizado una reparación cuyo costo sea menor que todos los costos de las reparaciones realizadas por el maestro con rut '12222222-2'.

select nombres, appat, apmat
from maestros
where rutmaestro in (
select rutmaestro
from reparaciones
where costo > all (
select costo
from reparaciones
where rutmaestro = '12222222-2'));

--8)	Mostrar la patente y marca de los vehículos que hayan sido reparados por maestros y cuyo costo de reparación sea mayor que todos los costos de las reparaciones realizadas por maestros cuyo nombre comience con la letra 'C'.

select patente, marca
from vehiculos
where patente in (
select patente
from reparaciones
where costo > all (
select costo
from reparaciones
where rutmaestro in (
select rutmaestro
from maestros
where nombres like 'C%')));

