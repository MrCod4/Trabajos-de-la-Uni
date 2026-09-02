create table participantes ( 
codigopart varchar2(6) not null primary key,
nombrepart varchar2(40), 
emailpart varchar2(50) 
); 
create table etapas ( 
numetapa number(3) not null primary key, 
niveletapa varchar2(20), 
bonosetapa number(6) 
); 
create table jugadas ( 
codjug varchar2(6) not null primary key, 
fechajug date,
 puntajejug number(6), 
codparticipante varchar2(6) not null references participantes, 
numetapa number(3) not null references etapas
);

insert into participantes values ('p001','ana torres','ana@gmail.com');
insert into participantes values ('p002','carlos rojas','carlos@gmail.com');
insert into participantes values ('p003','maría soto','maria@gmail.com');
insert into participantes values ('p004','luis pérez','luis@gmail.com');
insert into etapas values (1,'fácil',100);
insert into etapas values (2,'fácil',150);
insert into etapas values (3,'medio',200);
insert into etapas values (4,'medio',250);
insert into etapas values (5,'difícil',300);
insert into etapas values (6,'difícil',400);
insert into jugadas values ('j001','10/03/2026',850,'p001',1); 
insert into jugadas values ('j002','12/03/2026',920,'p002',2); 
insert into jugadas values ('j003','15/03/2026',780,'p003',1); 
insert into jugadas values ('j004','20/03/2026',1100,'p004',3); 
insert into jugadas values ('j005','25/03/2026',1250,'p001',4); 
insert into jugadas values ('j006','02/04/2026',980,'p002',3); 
insert into jugadas values ('j007','08/04/2026',1350,'p003',5); 
insert into jugadas values ('j008','15/04/2026',1420,'p004',6); 
insert into jugadas values ('j009','20/04/2026',1180,'p001',5); 
insert into jugadas values ('j010','25/04/2026',1500,'p002',6); 


--E1
--Número de etapa y suma de puntajes agrupado por Código de participante, con fecha menores a una indicada por Ud.

select e.numetapa, sum(puntajejug)
from jugadas j
join etapas e
on j.numetapa = e.numetapa
where fechajug < '25/04/2026'
group by codparticipante, e.numetapa;

--E2
--Código de participante y promedio de puntajes agrupado por Código de participante, con los promedios mayores a uno indicado por Ud.

select codigopart, round(avg(puntajejug))
from jugadas j
join participantes p
on codigopart = codparticipante
having avg(puntajejug) > 850
group by codparticipante;

--E3
--Nombre de cada participante y la cantidad de jugadas que ha realizado, considerando solo participantes cuyo nombre comience con la letra 'A', agrupando por nombre del participante.

select nombrepart, count(fechajug)
from participantes p
join jugadas j
on codigopart = codparticipante
where nombrepart like 'a%'
group by nombrepart;

--E4
--Nombre de cada participante y el puntaje total obtenido en todas sus jugadas, considerando solamente jugadas con puntajes mayores a 900 puntos, agrupando por nombre del participante y mostrando solamente aquellos cuyo suma de puntajes sea superior a 2000 puntos.

select nombrepart, sum(puntajejug)
from participantes p
join jugadas j
on codigopart = codparticipante
where puntajejug > 900
having sum(puntajejug) > 2000
group by nombrepart;

--E5
--Nombre de cada participante y el promedio de puntaje obtenido en sus jugadas, considerando solamente jugadas con puntajes entre 800 y 1300 puntos, agrupando por nombre del participante.

select nombrepart, round(avg(puntajejug))
from participantes p
join jugadas j
on codigopart = codparticipante
where puntajejug between 800 and 1300
group by nombrepart;


--E6
--Nivel de cada etapa y la cantidad de jugadas realizadas en ese nivel, considerando solamente etapas cuyo nivel comience con la letra 'D', agrupando por nivel de etapa.

select niveletapa, count(fechajug)
from jugadas j
join etapas e
on j.numetapa = e.numetapa
where niveletapa like 'd%'
group by niveletapa;

--E7
--Número de cada etapa y el puntaje máximo obtenido en ella, considerando solamente jugadas realizadas entre el '15/03/2026' y el '15/04/2026', agrupando por número de etapa.

select j.numetapa , max(puntajejug)
from jugadas j
join etapas e
on j.numetapa = e.numetapa
where fechajug between '15/03/2026' and '15/04/2026'
group by j.numetapa;

--E8
--Nombre de cada participante y la cantidad de etapas distintas en las que ha jugado, considerando solamente participantes cuyo nombre termine con la letra 's', agrupando por nombre del participante.

select nombrepart, count(niveletapa)
from jugadas j
join etapas e
on j.numetapa = e.numetapa
join participantes p
on codigopart = codparticipante
where nombrepart like '%s'
group by nombrepart;

--E9
--Nombre de cada participante, el nivel de la etapa y el promedio de puntaje obtenido, considerando solamente jugadas con puntaje mayor a 1000 puntos, agrupando por nombre del participante y nivel de etapa y mostrando solamente los grupos cuyo promedio de puntaje sea superior a 1200 puntos.

select nombrepart, niveletapa, round(avg(puntajejug))
from jugadas j
join etapas e
on j.numetapa = e.numetapa
join participantes p
on codigopart = codparticipante
where puntajejug > 1000
having avg(puntajejug) >1200
group by nombrepart, niveletapa;

--E10
--Nivel de etapa y la cantidad de participantes distintos que han jugado en él, considerando solamente etapas con bonos menores a 350 puntos, agrupando por nivel de etapa.
select distinct niveletapa, count(nombrepart)
from jugadas j
join etapas e
on j.numetapa = e.numetapa
join participantes p
on codigopart = codparticipante
where bonosetapa < 350
group by niveletapa;

--E11
--Nombre de cada participante, el nivel de etapa y el puntaje total obtenido, considerando solamente jugadas realizadas entre el '01/04/2026' y el '30/04/2026', agrupando por nombre del participante y nivel de etapa.

select nombrepart, niveletapa, sum(puntajejug)
from jugadas j
join etapas e
on j.numetapa = e.numetapa
join participantes p
on codigopart = codparticipante
where fechajug between '01/04/2026' and '30/04/2026'
group by nombrepart, niveletapa;



