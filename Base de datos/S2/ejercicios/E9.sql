create table deptos(
coddepartamento varchar2(5) not null primary key,
nombredepartamento varchar2(30),
fonodepartamento varchar2(15)
);

create table turnos(
codturno varchar2(5) not null primary key,
nombreturno varchar2(20),
horainicio varchar2(5),
horatermino varchar2(5)
);

create table ejecutivos(
rutejecutivo varchar2(10) not null primary key,
nombresejecutivo varchar2(30),
appatejecutivo varchar2(20),
apmatejecutivo varchar2(20),
fonoejecutivo varchar2(15),
calle varchar2(20),
numero number(4),
ciudad varchar2(30),
coddepartamento varchar2(5) not null references deptos,
codturno varchar2(5) not null  references turnos
);


create table maquinarias(
numserie varchar2(10) not null primary key,
descripcion varchar2(40),
antiguedad number(2),
valordiario number(8),
coddepartamento varchar2(5) not null references deptos
);

create table clientela(
rutcliente varchar2(10) not null primary key,
fonocliente varchar2(15)
);

create table arriendos(
codarriendo varchar2(6) not null primary key,
fechaarriendo date,
cantidaddias number(3),
rutcliente varchar2(10) not null references clientela,
numserie varchar2(10) not null references maquinarias,
rutejecutivo varchar2(10) not null references ejecutivos
);

insert into deptos values ('d01','construcción','412234501');
insert into deptos values ('d02','jardinería','412234502');
insert into deptos values ('d03','electricidad','412234503');
insert into deptos values ('d04','excavación','412234504');
insert into deptos values ('d05','transporte','412234505');
insert into deptos values ('d06','herramientas','412234506');

insert into turnos values ('t01','mañana','08:00','14:00');
insert into turnos values ('t02','tarde','14:00','20:00');
insert into turnos values ('t03','completo','08:00','17:00');
insert into turnos values ('t04','mañana 2','09:00','15:00');
insert into turnos values ('t05','tarde 2','15:00','21:00');
insert into turnos values ('t06','especial','10:00','18:00');

insert into ejecutivos values ('11111111-1','Carlos','Rojas','Díaz','987654321','Los Carrera',120,'Concepción','d01','t01');
insert into ejecutivos values ('12222222-2','Andrea','Muñoz','Soto','987654322','Cochrane',250,'Tomé','d02','t02');
insert into ejecutivos values ('13333333-3','Luis','Pérez','Vega','987654323','Freire',430,'Talcahuano','d03','t03');
insert into ejecutivos values ('14444444-4','Marcela','Torres','Silva','987654324','Maipu',510,'Concepción','d04','t01');
insert into ejecutivos values ('15555555-5','Jorge','Salinas','Castro','987654325','Orompello',620,'Talcahuano','d05','t02');
insert into ejecutivos values ('16666666-6','Paula','Mora','Reyes','987654326','Rengo',730,'Cocepción','d06','t03');

insert into maquinarias values ('m001','betonera 150 litros',3,35000,'d01');
insert into maquinarias values ('m002','cortadora de pasto',2,22000,'d02');
insert into maquinarias values ('m003','generador eléctrico',4,45000,'d03');
insert into maquinarias values ('m004','miniexcavadora',5,95000,'d04');
insert into maquinarias values ('m005','carretilla motorizada',2,55000,'d05');
insert into maquinarias values ('m006','taladro industrial',1,18000,'d06');
insert into maquinarias values ('m007','andamio modular',4,30000,'d01');
insert into maquinarias values ('m008','desbrozadora',3,24000,'d02');
insert into maquinarias values ('m009','compresor eléctrico',2,38000,'d03');
insert into maquinarias values ('m010','retroexcavadora',6,120000,'d04');

insert into clientela values ('17777777-7','912345671');
insert into clientela values ('18888888-8','912345672');
insert into clientela values ('19999999-9','912345673');
insert into clientela values ('20111111-1','912345674');
insert into clientela values ('20222222-2','912345675');
insert into clientela values ('20333333-3','912345676');

insert into arriendos values ('a001','05/03/2026',3,'17777777-7','m001','11111111-1');
insert into arriendos values ('a002','08/03/2026',2,'18888888-8','m002','12222222-2');
insert into arriendos values ('a003','12/03/2026',5,'19999999-9','m003','13333333-3');
insert into arriendos values ('a004','18/03/2026',4,'20111111-1','m004','14444444-4');
insert into arriendos values ('a005','22/03/2026',2,'20222222-2','m005','15555555-5');
insert into arriendos values ('a006','27/03/2026',6,'20333333-3','m006','16666666-6');
insert into arriendos values ('a007','02/04/2026',3,'17777777-7','m007','11111111-1');
insert into arriendos values ('a008','10/04/2026',4,'18888888-8','m008','12222222-2');
insert into arriendos values ('a009','15/04/2026',2,'19999999-9','m009','13333333-3');
insert into arriendos values ('a010','23/04/2026',5,'20111111-1','m010','14444444-4');
insert into arriendos values ('a011','28/04/2026',2,'17777777-7','m003','13333333-3');
insert into arriendos values ('a012','02/05/2026',4,'18888888-8','m005','15555555-5');
insert into arriendos values ('a013','06/05/2026',3,'19999999-9','m001','11111111-1');
insert into arriendos values ('a014','10/05/2026',7,'20111111-1','m002','12222222-2');
insert into arriendos values ('a015','14/05/2026',5,'20222222-2','m004','14444444-4');
insert into arriendos values ('a016','18/05/2026',2,'20333333-3','m006','16666666-6');
insert into arriendos values ('a017','22/05/2026',6,'17777777-7','m008','12222222-2');
insert into arriendos values ('a018','26/05/2026',3,'18888888-8','m010','14444444-4');
insert into arriendos values ('a019','30/05/2026',4,'19999999-9','m007','11111111-1');
insert into arriendos values ('a020','03/06/2026',8,'20111111-1','m009','13333333-3');
insert into arriendos values ('a021','07/06/2026',2,'20222222-2','m001','11111111-1');
insert into arriendos values ('a022','11/06/2026',5,'20333333-3','m003','13333333-3');
insert into arriendos values ('a023','15/06/2026',3,'17777777-7','m005','15555555-5');
insert into arriendos values ('a024','19/06/2026',6,'18888888-8','m006','16666666-6');
insert into arriendos values ('a025','23/06/2026',4,'19999999-9','m002','12222222-2');
insert into arriendos values ('a026','27/06/2026',7,'20111111-1','m008','12222222-2');
insert into arriendos values ('a027','01/07/2026',3,'20222222-2','m010','14444444-4');
insert into arriendos values ('a028','05/07/2026',5,'20333333-3','m007','11111111-1');
insert into arriendos values ('a029','09/07/2026',2,'17777777-7','m009','13333333-3');
insert into arriendos values ('a030','13/07/2026',6,'18888888-8','m004','14444444-4');
insert into arriendos values ('a031','17/07/2026',4,'19999999-9','m005','15555555-5');
insert into arriendos values ('a032','21/07/2026',3,'20111111-1','m003','13333333-3');
insert into arriendos values ('a033','25/07/2026',6,'20222222-2','m007','11111111-1');
insert into arriendos values ('a034','29/07/2026',2,'20333333-3','m002','12222222-2');
insert into arriendos values ('a035','02/08/2026',5,'17777777-7','m010','14444444-4');
insert into arriendos values ('a036','06/08/2026',3,'18888888-8','m009','13333333-3');
insert into arriendos values ('a037','10/08/2026',7,'19999999-9','m006','16666666-6');
insert into arriendos values ('a038','14/08/2026',4,'20111111-1','m001','11111111-1');
insert into arriendos values ('a039','18/08/2026',2,'20222222-2','m008','12222222-2');
insert into arriendos values ('a040','22/08/2026',6,'20333333-3','m004','14444444-4');
insert into arriendos values ('a041','26/08/2026',3,'17777777-7','m006','16666666-6');
insert into arriendos values ('a042','30/08/2026',5,'18888888-8','m007','11111111-1');
insert into arriendos values ('a043','03/09/2026',4,'19999999-9','m010','14444444-4');
insert into arriendos values ('a044','07/09/2026',2,'20111111-1','m005','15555555-5');
insert into arriendos values ('a045','11/09/2026',8,'20222222-2','m003','13333333-3');
insert into arriendos values ('a046','15/09/2026',3,'20333333-3','m008','12222222-2');
insert into arriendos values ('a047','19/09/2026',6,'17777777-7','m004','14444444-4');
insert into arriendos values ('a048','23/09/2026',4,'18888888-8','m001','11111111-1');
insert into arriendos values ('a049','27/09/2026',5,'19999999-9','m002','12222222-2');
insert into arriendos values ('a050','01/10/2026',7,'20111111-1','m009','13333333-3');

--Evaluacion informativa
--1
select nombresejecutivo, fechaarriendo
from ejecutivos e, arriendos a
where e.rutejecutivo = a.rutejecutivo
and nombresejecutivo like 'C%';

--2
select nombresejecutivo, fechaarriendo
from ejecutivos e, arriendos a
where e.rutejecutivo = a.rutejecutivo
and fechaarriendo between '10/4/2026' and '10/05/2026' ;

--3
select sum(valordiario)
from maquinarias m, arriendos a
where m.numserie = a.numserie
and fechaarriendo between '10/4/2026' and '10/05/2026';

--4
select distinct nombresejecutivo, descripcion
from ejecutivos e, arriendos a, maquinarias m
where m.numserie = a.numserie
and  e.rutejecutivo = a.rutejecutivo
and fechaarriendo between '22/8/2026' and '1/10/2026';

--5
select nombresejecutivo, valordiario
from ejecutivos e, arriendos a, maquinarias m
where m.numserie = a.numserie
and  e.rutejecutivo = a.rutejecutivo
and valordiario > 50000;

--6
select  avg(valordiario)
from ejecutivos e, arriendos a, maquinarias m
where m.numserie = a.numserie
and  e.rutejecutivo = a.rutejecutivo;

--7
select d.coddepartamento
from deptos d
join ejecutivos e
on d.coddepartamento = e.coddepartamento
where nombresejecutivo = 'Jorge';

--8
select descripcion, sum(valordiario)
from  arriendos a, maquinarias m
where m.numserie = a.numserie
having sum(valordiario) > 100000
group by descripcion;

--9
select descripcion, sum(valordiario)
from  arriendos a, maquinarias m
where m.numserie = a.numserie
having sum(valordiario) < 200000
group by descripcion;

--10
select nombresejecutivo, valordiario
from ejecutivos e, arriendos a, maquinarias m
where m.numserie = a.numserie
and  e.rutejecutivo = a.rutejecutivo
and valordiario > 70000;

--11
select nombresejecutivo, min(valordiario)
from arriendos a, maquinarias m, ejecutivos e
where m.numserie = a.numserie
and  e.rutejecutivo = a.rutejecutivo
having min(valordiario) between 20000 and 120000
group by nombresejecutivo;

--12
select nombresejecutivo, min(valordiario)
from arriendos a, maquinarias m, ejecutivos e
where m.numserie = a.numserie
and  e.rutejecutivo = a.rutejecutivo
and valordiario > 30000
having min(valordiario) between 20000 and 120000
group by nombresejecutivo;

--13
select distinct fonocliente
from clientela c
join arriendos a
on c.rutcliente = a.rutcliente
join ejecutivos e
on  e.rutejecutivo = a.rutejecutivo
join deptos d
on d.coddepartamento = e.coddepartamento
where cantidaddias < 10;

--14
select nombredepartamento, sum(valordiario)
from clientela c
join arriendos a
on c.rutcliente = a.rutcliente
join maquinarias m
on  m.numserie = a.numserie
join deptos d
on d.coddepartamento = m.coddepartamento
having sum(valordiario) > 100000
group by nombredepartamento;

--15
select nombredepartamento, sum(valordiario)
from clientela c
join arriendos a
on c.rutcliente = a.rutcliente
join maquinarias m
on  m.numserie = a.numserie
join deptos d
on d.coddepartamento = m.coddepartamento
where nombredepartamento like 'e%'
having sum(valordiario) > 100000
group by nombredepartamento;