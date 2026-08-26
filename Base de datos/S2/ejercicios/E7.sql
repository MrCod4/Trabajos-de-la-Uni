create table restaurantes( 

rutRest varchar2(12) not null primary key, 

nombreRest varchar2(20), 

direccRest varchar2(100), 

fonoRest number(15) 

); 

create table colaboradores( 

rutCol varchar2(12) not null primary key, 

nombresCol varchar2(20), 

apPatCol varchar2(20), 

apMatCol varchar2(20), 

fonoCol number(9) 

); 

create table consumos( 

numCons number(8) not null primary key, 

fechaCons date, 

CostoCons number(12), 

rutRest varchar2(12) not null references restaurantes, 

rutColaborador varchar2(12) not null references colaboradores 

); 

 

insert into restaurantes values('6345789-3','Sabores','Colón 742',63758592); 

insert into restaurantes values('7237798-8','Miramar','Maipú 636',83740275); 

 

insert into colaboradores values('14034034-4','Roberto','Lara','Carrasco',29384520); 

insert into colaboradores values('18000313-2','Lorena','Vera','Coloma',85031809); 

 

insert into consumos values (88845,'13/10/2022',30100,'6345789-3','14034034-4'); 

insert into consumos values (88878,'15/10/2022',50000,'6345789-3','18000313-2'); 

insert into consumos values (88909,'11/11/2022',20000,'7237798-8','18000313-2'); 

insert into consumos values (88922,'22/11/2022',21000,'7237798-8','14034034-4'); 

insert into consumos values (89100,'3/12/2022',35000,'7237798-8','14034034-4'); 

insert into consumos values (89120,'15/12/2022',76000,'6345789-3','18000313-2');

--Evaluacion 2
--1
--restaurantes:
insert into restaurantes values('6345789-7','Dolores','Colón 745',63758592);

--colaboradores:
insert into colaboradores values('14034034-7','Roberto','Lara','Sepulveda',29384520); 
insert into colaboradores values('14034034-9','Roberto','Sanchez','Carrasco',29384520); 

--consumos:
insert into consumos values (89121,'16/12/2022',26000,'6345789-3','18000313-2');
insert into consumos values (89103,'7/12/2022',75000,'7237798-8','14034034-4'); 
insert into consumos values (88927,'21/11/2022',41000,'7237798-8','14034034-4'); 
insert into consumos values (88879,'17/10/2022',50000,'6345789-3','18000313-2'); 
insert into consumos values (88924,'29/11/2022',11000,'7237798-8','14034034-4'); 

--2
select distinct nombrescol, appatcol, apmatcol
from colaboradores c 
join consumos co
on co.rutcolaborador = c.rutcol
and costocons between 30000 and 50000;

--3
select distinct nombrerest
from restaurantes r
join consumos co
on r.rutrest = co.rutrest
and fechacons > '20/11/2022';

--4
select fechacons
from consumos co
join colaboradores c
on c.rutcol = co.rutcolaborador
and nombrescol = 'Lorena'
and appatcol = 'Vera';

--5
select costocons
from consumos co, restaurantes r
where r.rutrest = co.rutrest
and nombrerest = 'Sabores';

--6
select distinct nombrerest
from restaurantes r, colaboradores c, consumos co
where r.rutrest = co.rutrest
and c.rutcol = co.rutcolaborador
and nombrescol = 'Lorena'
and appatcol = 'Vera';

--7
select distinct fonocol
from  restaurantes r, colaboradores c, consumos co
where r.rutrest = co.rutrest
and c.rutcol = co.rutcolaborador
and nombrerest = 'Sabores';

--8
select min(fechacons)
from consumos co;

--9
select min(costocons)
from consumos co, colaboradores c
where c.rutcol = co.rutcolaborador
and nombrescol = 'Lorena'
and appatcol = 'Vera';

--10
select max(fechacons)
from consumos co, restaurantes r
where r.rutrest = co.rutrest
and nombrerest = 'Sabores';

--11
select sum(costocons)
from consumos co, restaurantes r, colaboradores c
where r.rutrest = co.rutrest
and c.rutcol = co.rutcolaborador
and nombrerest = 'Sabores'
and nombrescol = 'Lorena'
and appatcol = 'Vera';

--12
select avg(costocons)
from consumos co, colaboradores c, restaurantes r
where r.rutrest = co.rutrest
and c.rutcol = co.rutcolaborador
and nombrescol = 'Roberto'
and appatcol = 'Lara'
and nombrerest = 'Miramar';
