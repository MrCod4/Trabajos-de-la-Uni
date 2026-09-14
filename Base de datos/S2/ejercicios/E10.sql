create table participantes( 

codigopart varchar2(10) not null primary key, 

nombrepart varchar2(25), 

emailpart varchar2(30) 

); 

create table etapas( 

numetapa number(10) not null primary key, 

niveletapa number(10), 

bonosetapa number(2) 

); 

create table jugadas( 

codjug varchar2(15) not null primary key, 

fechajug date, 

puntajejug number(3), 

codparticipante varchar2(10) not null references participantes, 

numetapa number(10) not null references etapas 

)

insert into participantes values ('p001','ana torres','anat@gmail.com'); 

insert into participantes values ('p002','carlos rojas','carlosr@gmail.com'); 

insert into participantes values ('p003','andrea soto','andreas@gmail.com'); 

insert into participantes values ('p004','luis perez','luisp@gmail.com'); 

insert into participantes values ('p005','alejandra mora','alejandram@gmail.com'); 

insert into participantes values ('p006','pablo silva','pablos@gmail.com'); 

insert into etapas values (1,1,10); 

insert into etapas values (2,2,15); 

insert into etapas values (3,3,20); 

insert into etapas values (4,4,25); 

insert into etapas values (5,5,30); 

insert into etapas values (6,6,40); 

insert into jugadas values ('j001','10/03/2026',850,'p001',1); 

insert into jugadas values ('j002','18/03/2026',920,'p002',2); 

insert into jugadas values ('j003','25/03/2026',780,'p003',3); 

insert into jugadas values ('j004','05/04/2026',950,'p004',4); 

insert into jugadas values ('j005','12/04/2026',890,'p005',5); 

insert into jugadas values ('j006','20/04/2026',990,'p006',6); 

insert into jugadas values ('j007','25/04/2026',870,'p001',2); 

insert into jugadas values ('j008','30/04/2026',940,'p002',3); 

insert into jugadas values ('j009','05/05/2026',760,'p003',4); 

insert into jugadas values ('j010','10/05/2026',980,'p004',5); 

insert into jugadas values ('j011','15/05/2026',820,'p005',6); 

insert into jugadas values ('j012','20/05/2026',910,'p006',1); 

insert into jugadas values ('j013','25/05/2026',795,'p001',3); 

insert into jugadas values ('j014','30/05/2026',965,'p002',4); 

insert into jugadas values ('j015','05/06/2026',885,'p003',5); 

insert into jugadas values ('j016','10/06/2026',930,'p004',6); 

insert into jugadas values ('j017','15/06/2026',745,'p005',1); 

insert into jugadas values ('j018','20/06/2026',990,'p006',2); 

insert into jugadas values ('j019','25/06/2026',860,'p001',4); 

insert into jugadas values ('j020','30/06/2026',905,'p002',5); 

insert into jugadas values ('j021','05/07/2026',775,'p003',6); 

insert into jugadas values ('j022','10/07/2026',955,'p004',1); 

insert into jugadas values ('j023','15/07/2026',840,'p005',2); 

insert into jugadas values ('j024','20/07/2026',925,'p006',3); 

insert into jugadas values ('j025','25/07/2026',810,'p001',5); 

insert into jugadas values ('j026','30/07/2026',970,'p002',6); 

insert into jugadas values ('j027','04/08/2026',835,'p003',1); 

insert into jugadas values ('j028','08/08/2026',915,'p004',2); 

insert into jugadas values ('j029','12/08/2026',725,'p005',3); 

insert into jugadas values ('j030','16/08/2026',945,'p006',4); 

insert into jugadas values ('j031','20/08/2026',880,'p001',6); 

insert into jugadas values ('j032','24/08/2026',995,'p002',1); 

insert into jugadas values ('j033','28/08/2026',805,'p003',2); 

insert into jugadas values ('j034','01/09/2026',935,'p004',3); 

insert into jugadas values ('j035','05/09/2026',755,'p005',4); 

insert into jugadas values ('j036','09/09/2026',975,'p006',5); 

insert into jugadas values ('j037','13/09/2026',865,'p001',1); 

insert into jugadas values ('j038','17/09/2026',900,'p002',2); 

insert into jugadas values ('j039','21/09/2026',790,'p003',3); 

insert into jugadas values ('j040','25/09/2026',960,'p004',4); 

insert into jugadas values ('j041','29/09/2026',825,'p005',5); 

insert into jugadas values ('j042','03/10/2026',985,'p006',6); 

insert into jugadas values ('j043','07/10/2026',875,'p001',3); 

insert into jugadas values ('j044','11/10/2026',925,'p002',4); 

insert into jugadas values ('j045','15/10/2026',815,'p003',5); 

insert into jugadas values ('j046','19/10/2026',955,'p004',6); 

--1
select nombrepart, puntajejug
from participantes p, jugadas j
where p.codigopart = j.codparticipante
and nombrepart like 'a%';

--2
select nombrepart, fechajug
from participantes p, jugadas j
where p.codigopart = j.codparticipante
and fechajug between '03/10/2026' and '19/10/2026' ;

--3
select nombrepart, sum(puntajejug)
from participantes p, jugadas j
where p.codigopart = j.codparticipante
and nombrepart like 'a%'
group by nombrepart;

--4
select distinct nombrepart
from participantes p, jugadas j, etapas e
where p.codigopart = j.codparticipante
and e.numetapa = j.numetapa
and puntajejug > 100;

--5
select nombrepart
from participantes p, jugadas j, etapas e
where p.codigopart = j.codparticipante
and e.numetapa = j.numetapa
and puntajejug > 900;

--6
select distinct nombrepart, round(avg(puntajejug))
from participantes p, jugadas j, etapas e
where p.codigopart = j.codparticipante
and e.numetapa = j.numetapa
group by nombrepart;

--7
select nombrepart, round(avg(puntajejug))
from participantes p, jugadas j
where p.codigopart = j.codparticipante
and nombrepart like 'a%'
group by nombrepart;

--8
select nombrepart, sum(puntajejug)
from participantes p, jugadas j
where p.codigopart = j.codparticipante
having sum(puntajejug) > 6000
group by nombrepart;

--9
select nombrepart, sum(puntajejug)
from participantes p, jugadas j
where p.codigopart = j.codparticipante
and nombrepart like 'a%'
having sum(puntajejug) > 6000
group by nombrepart;

--10
select niveletapa,  sum(puntajejug)
from participantes p, jugadas j, etapas e
where p.codigopart = j.codparticipante
and e.numetapa = j.numetapa
and nombrepart like 'a%'
group by niveletapa;

--11
select nombrepart, round(avg(puntajejug))
from participantes p, jugadas j, etapas e
where p.codigopart = j.codparticipante
and e.numetapa = j.numetapa
having avg(puntajejug) > 900
group by nombrepart;

--12
select niveletapa, sum(puntajejug)
from participantes p, jugadas j, etapas e
where p.codigopart = j.codparticipante
and e.numetapa = j.numetapa
and nombrepart like 'a%'
having sum(puntajejug) > 4000
group by niveletapa;
