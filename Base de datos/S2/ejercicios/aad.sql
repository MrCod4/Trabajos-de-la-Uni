create table clubes( 

codclub varchar2(6) not null primary key, 

nombreclub varchar2(40), 

ciudadclub varchar2(30), 

aniofundclub number(4) 

); 

create table deportistas( 

rutdep varchar2(10) not null primary key, 

nombresdep varchar2(30), 

appatdep varchar2(20), 

apmatdep varchar2(20), 

fonodep varchar2(15) 

); 

create table contrataciones( 

numcontrato varchar2(6) not null primary key, 

codclub varchar2(6) not null references clubes, 

rutdeportista varchar2(10) not null references deportistas, 

fecha date, 

costo number(12) 

); 

 

insert into clubes values ('c001','Colo-colo','Santiago',1925); 

insert into clubes values ('c002','Universidad de chile','Santiago',1927); 

insert into clubes values ('c003','Universidad catolica','Santiago',1937); 

insert into clubes values ('c004','Huachipato','Talcahuano',1947); 

insert into clubes values ('c005','Everton','Viña del mar',1909); 

insert into deportistas values ('11111111-1','Matías','González','Rojas','987654321'); 

insert into deportistas values ('12222222-2','Cristóbal','Muñoz','Soto','976543210'); 

insert into deportistas values ('13333333-3','Felipe','Ramírez','Vega','965432109'); 

insert into deportistas values ('14444444-4','Sebastián','Torres','Silva','954321098'); 

insert into deportistas values ('15555555-5','Nicolás','Contreras','Pérez','943210987'); 

insert into contrataciones values ('ct001','c001','11111111-1','10/1/2024',85000000); 

insert into contrataciones values ('ct002','c002','12222222-2','15/2/2024',72000000); 

insert into contrataciones values ('ct003','c003','13333333-3','20/3/2024',68000000); 

insert into contrataciones values ('ct004','c004','14444444-4','5/4/2024',45000000); 

insert into contrataciones values ('ct005','c005','15555555-5','18/5/2024',52000000); 

insert into contrataciones values ('ct006','c002','11111111-1','12/1/2025',90000000); 

insert into contrataciones values ('ct007','c003','15555555-5','25/2/2025',75000000); 

insert into contrataciones values ('ct008','c001','13333333-3','14/4/2025',82000000); 

insert into contrataciones values ('ct009','c004','12222222-2','8/6/2025',55000000); 

insert into contrataciones values ('ct010','c005','14444444-4','20/7/2025',60000000);

--Ejercicios

--1
select nombreclub 
from clubes c, contrataciones ct
where c.codclub = ct.codclub and costo > 70000000;

--2
select fecha 
from clubes c, contrataciones ct, deportistas d
where  c.codclub = ct.codclub and rutdep = rutdeportista and nombreclub like('C%');

--3
select distinct nombresdep 
from deportistas d, contrataciones ct
where rutdep = rutdeportista and fecha between '1/3/2025' and '30/6/2025';

--4
select fecha
from deportistas d, contrataciones ct
where rutdep = rutdeportista and nombresdep = 'Felipe' and appatdep = 'Ramírez'  and apmatdep = 'Vega';

--5
select  nombreclub
from clubes c, contrataciones ct, deportistas d
where  c.codclub = ct.codclub and rutdep = rutdeportista and nombresdep = 'Felipe' and appatdep = 'Ramírez'  and apmatdep = 'Vega';

--6
select  fonodep
from clubes c, contrataciones ct, deportistas d
where  c.codclub = ct.codclub and rutdep = rutdeportista and nombreclub = 'Huachipato';