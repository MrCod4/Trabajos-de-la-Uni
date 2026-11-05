create table huespedes (
codhuesped number(6) not null primary key,
nombreshuesped varchar2(20),
appathuesped varchar2(20),
apmathuesped varchar2(20),
emailhuesped varchar2(80)
);
create table habitaciones (
codhabitacion number(5) not null primary key,
tipohabitacion varchar2(20),
numpiso number(2),
tarifanoche number(8)
);
create table reservas (
codreserva number(4) not null primary key,
fecha date,
cantnoches number(3),
monto number(8),
codhuesped number(6) not null  references huespedes,
codhabitacion number(5) not null references habitaciones
);

insert into huespedes values (1,'Fernando Ignacio','Pérez','Reyes','FIPR@gmail.com');
insert into huespedes values (2,'Victoria Isabel','Gallardo','Duarte','VIGD@gmail.com');
insert into huespedes values (3,'Catalina Andrea','Fuentes','Soto','CAFS@gmail.com');
insert into habitaciones values (101,'individual',1,45000);
insert into habitaciones values (202,'doble',2,65000);
insert into habitaciones values (301,'suite',3,120000);
insert into habitaciones values (204,'familiar',2,95000);

--1) insertar 10 reservas, utilizando valores lo más distintos posibles y dejando, por lo menos, 3 fechas de reserva nulas.

INSERT INTO reservas VALUES (1001,'10/01/2026', 2 ,  50000,  1, 101);
INSERT INTO reservas VALUES (1002, '', 5, 120000, 2, 202);
INSERT INTO reservas VALUES (1003, '15/02/2026', 1 ,  25000,  3, 301);
INSERT INTO reservas VALUES (1004, '', 7 , 250000, 1, 204);
INSERT INTO reservas VALUES (1005, '20/03/2026', 3 ,  85000,  2, 101);
INSERT INTO reservas VALUES (1006, '', 4 , 175000, 3, 202);
INSERT INTO reservas VALUES (1007, '05/04/2026', 10 , 400000, 1, 301);
INSERT INTO reservas VALUES (1008, '12/05/2026', 6 , 210000, 2, 204);
INSERT INTO reservas VALUES (1009, '', 8 , 320000, 3, 101);
INSERT INTO reservas VALUES (1010, '25/06/2026', 2 ,  65000, 1, 301);

--2) El huésped <nombreshuesped en mayúsculas> <appathuesped en mayúsculas>  realizó una reserva por $<monto> en una habitación de tipo <tipohabitacion>.

select 'El huesped '||upper(nombreshuesped)||' '||upper(appathuesped)||' realizo una reserva por $'||monto||' en una habitacion de tipo '||tipohabitacion huespedes
from huespedes h
join reservas r
on h.codhuesped = r.codhuesped
join habitaciones ha
on r.codhabitacion = ha.codhabitacion;

--3) La habitación <codhabitacion> fue reservada el día <mostrar número del día de fecha> de <nombre del mes>.
select 'La habitacion '||codhabitacion||' fue reservada el dia '||substr(fecha,1,2)||' de enero' fechahabitacion
from reservas
where fecha between '01/1/26' and '31/1/26';

--4) El monto final de la reserva <codreserva> es de $<suma entre monto y el 10% del monto, redondeada a 1 decimal> para el huésped con correo <emailhuesped>.
select 'El monto final de la reserva '||codreserva||' es de $'||round((monto*1.1),1)||' para el huesped con correo '||emailhuesped reservas
from reservas r
join huespedes h
on r.codhuesped = h.codhuesped;

--5) Han pasado <resta entre sysdate y fecha, aplicando trunc> días desde que el huésped <nombreshuesped> <appathuesped> reservó una habitación de tipo <tipohabitacion>.
select 'Han pasado '||trunc(sysdate - fecha)||' dias desde que el huesped '||nombreshuesped||' '||appathuesped||' reservo una habitacion de tipo '||tipohabitacion tiempotranscurrido
from huespedes h
join reservas r
on h.codhuesped = r.codhuesped
join habitaciones ha
on r.codhabitacion = ha.codhabitacion;

--6) La reserva <codreserva> fue realizada un día <nombre del día, utilizando to_char sobre fechareserva>.
select 'La reserva '||codreserva||' fue realizada un dia '||to_char(fecha,'day')
from reservas
where fecha<'01/04/2026';

--7) El huésped <nombrehuesped> <appathuesped>  con correo <emailhuesped> realizó su reserva el <fecha>.
select 'El huesped ' ||nombreshuesped|| ' ' ||appathuesped||' con correo '||emailhuesped|| 'realizo su reserva el ' ||nvl(fecha,'1/1/11')
from reservas r join huespedes h
on r.codhuesped=h.codhuesped;

--8) La reserva <codreserva> con un monto de $<monto> se considera de categoría <aplicar case para que entregue 'premium' si el monto supera un valor indicado por usted; en caso contrario, 'estándar'>.
select 'La reserva ' ||codreserva|| ' con un monto de $'||monto||' se considera de categoría ' ||case  
           when monto>200000 then 'Premium'
           else 'estándar' 
           end
from reservas;

--9) Para el huésped con código <codhuesped> se tiene un monto total de reservas de $<suma de montoreserva>.
--(utilizar select múltiple, agrupar por codhuesped y condicionar que la suma de montoreserva sea menor a un valor indicado por usted).
select 'Para el huésped con código '||h.codhuesped||' se tiene un monto total de reservas de $' ||sum(monto) as montototal
from huespedes h join reservas r
on h.codhuesped=r.codhuesped
having sum(monto)<500000
group by h.codhuesped;

--10) En la habitación de tipo <tipohabitacion>, el día <fecha>, realizó una reserva el huésped <nombrehuesped> <appathuesped>  <apmathuesped> .
--(utilizar select múltiple y condicionar que la fecha de reserva sea mayor a una fecha indicada por usted).
select 'En la habitcacion '||tipohabitacion||', el dia '||fecha||', realizó una reserva el huésped '||nombreshuesped||' '||appathuesped||' '|| appathuesped
from huespedes h join reservas r
on h.codhuesped=r.codhuesped join habitaciones ha
on r.codhabitacion = ha.codhabitacion
where r.fecha>'20/03/2026';

--11) El huésped <nombrehuesped> <appathuesped>  <apmathuesped>  realizó la reserva de mayor monto.
--(utilizar una subconsulta para mostrar el nombre del huésped asociado a la reserva con el mayor monto).
select 'El huésped '||nombreshuesped||' '||appathuesped||' '|| appathuesped||' realizó la reserva de mayor monto'
from huespedes h
join reservas r
on h.codhuesped=r.codhuesped
where r.monto=(select max(monto)from reservas);




