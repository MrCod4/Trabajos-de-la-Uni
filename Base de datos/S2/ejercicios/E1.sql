Create table ESTUDIANTES(
RutEst varchar2(13) not null primary key,
apPatEst varchar2(20),
apMatEst varchar2(20),
nombresEst varchar2(30),
fechaNac date
);
Create table CARRERAS(
codigoCarrera varchar2(10) not null primary key,
nombreCarrera varchar2(50),
totalHorasCarr number(4),
totalSemestres number(2)
);
Create table MATRICULAS(
numMatricula number(8) not null primary key,
costo number(7),
fecha date,
codigoCarrera varchar2(10) not null references carreras,
rutEst varchar2(13) not null references estudiantes 
);
Create table PROFESORES(
rutProfesor varchar2(13) not null primary key,
apPatProfesor varchar2(20),
apMatProfesor varchar2(20),
nombresProfesor varchar2(30),
tituloProfesor varchar2(40)
);
Create table CURSOS (
codigoCurso varchar2(10) not null primary key,
nombreCurso varchar2(30) null,
totalHorasCurso number(3),
tipoCurso varchar2(10)
);
Create table INSCRIPCIONES(
codInscripcion varchar(10) not null primary key,
semestre number(2),
a�o number(4),
rutEst varchar2(13) not null references estudiantes,
codigoCurso varchar2(10) not null references cursos
);


Create table PAGOSAPROFESORES(
codigoPago varchar2(10) not null primary key,
mes number(2),
a�o number(4),
monto number(7),
rutProfesor varchar2(13) not null references profesores,
codigoCurso varchar2(10) not null references cursos
);



Insert into estudiantes values ('10424736-9','Soto','Miranda','V�ctor','23/7/1976');
Insert into estudiantes values('9325010-9','Ferrer','Godoy','Isabel','12/5/1978');
Insert into estudiantes values('21116906-4','Donoso','Vera','Daniela',null);
Insert into estudiantes values('9425736-4','Castro','Saavedra','Mart�n',null);

Insert into carreras values('cr1','Refrigeraci�n',1859,4);
Insert into carreras values('b50','Automatizaci�n',2279,5);
Insert into carreras values('t60','Ingenier�a inform�tica',3454,8);
Insert into carreras values('i34','Topograf�a',4408,10);
Insert into carreras values('r30','Educaci�n de p�rvulos',6008,12);

Insert into matriculas values(2500,110000,'20/2/2023','b50','9325010-9');
Insert into matriculas values(2501,130000,'21/2/2023','i34','10424736-9');
Insert into matriculas values(2502,142000,'21/2/2023','t60','21116906-4');
Insert into matriculas values(2503,120000,'22/2/2023','t60','9425736-4');


Insert into matriculas values(2600,120000,'11/7/2023','b50','9325010-9');
Insert into matriculas values(2601,140000,'12/7/2023','i34','10424736-9');
Insert into matriculas values(2602,152000,'12/7/2023','t60','21116906-4');
Insert into matriculas values(2603,130000,'13/7/2023','t60','9425736-4');


Insert into profesores values ('8657483-1','Hern�ndez','Jara','Horacio','Pedagogo en matem�ticas');
Insert into profesores values ('10545676-1','Mart�nez','N��ez','Teresa','Pedagogo en matem�ticas');
Insert into profesores values ('7789000-2','Aguayo','Soto','Gabriel','Periodista');
Insert into profesores values ('11324657-0','Alarc�n','Meneses','Victoria','Periodista');
Insert into profesores values ('8799800-4','Gallardo','Vargas','Miguel','Traductor en ingl�s');
Insert into profesores values ('10435768-9','Ulloa','Carrasco','Laura','Traductor en ingl�s');
Insert into profesores values ('9540998-2','Ramos','Lara','Mar�a','Ingeniero en inform�tica');
Insert into profesores values ('9439878-8','Pereira','Bustos','Eliana','Ingeniero en refrigeraci�n');

Insert into cursos values('as1000','Matem�ticas I',70,'lectiva');
Insert into cursos values('as2000','Ingl�s I',70,'lectiva');
Insert into cursos values('as3000','T�cnicas de comunicaci�n',70,'lectiva');
Insert into cursos values('as4000','Base de datos',88,'pr�ctica');
Insert into cursos values('as5000','Refrigeraci�n I',90,'pr�ctica');


Insert into inscripciones values('in500',1,2023,'9325010-9','as1000');
Insert into inscripciones values('in510',1,2023,'9325010-9','as5000');
Insert into inscripciones values('in530',1,2023,'10424736-9','as1000');
Insert into inscripciones values('in540',1,2023,'10424736-9','as2000');
Insert into inscripciones values('in520',1,2023,'21116906-4','as4000');
Insert into inscripciones values('in550',1,2023,'21116906-4','as2000');
Insert into inscripciones values('in560',1,2023,'9425736-4','as1000');
Insert into inscripciones values('in545',1,2023,'9425736-4','as3000');

Insert into inscripciones values('in600',2,2023,'9325010-9','as2000');
Insert into inscripciones values('in610',2,2023,'9325010-9','as5000');
Insert into inscripciones values('in630',2,2023,'10424736-9','as1000');
Insert into inscripciones values('in640',2,2023,'10424736-9','as3000');
Insert into inscripciones values('in620',2,2023,'21116906-4','as1000');
Insert into inscripciones values('in650',2,2023,'21116906-4','as3000');
Insert into inscripciones values('in660',2,2023,'9425736-4','as2000');
Insert into inscripciones values('in645',2,2023,'9425736-4','as4000');


Insert into pagosaprofesores values('mar2023657',3,2023,60000,'11324657-0','as3000');
Insert into pagosaprofesores values('abr2023657',4,2023,80000,'11324657-0','as3000');
Insert into pagosaprofesores values('may2023657',5,2023,80000,'11324657-0','as3000');
Insert into pagosaprofesores values('jun2023657',6,2023,80000,'11324657-0','as3000');
Insert into pagosaprofesores values('jul2023657',7,2023,80000,'11324657-0','as3000');

Insert into pagosaprofesores values('mar2023658',3,2023,70000,'7789000-2','as3000');
Insert into pagosaprofesores values('abr2023658',4,2023,90000,'7789000-2','as3000');
Insert into pagosaprofesores values('may2023658',5,2023,90000,'7789000-2','as3000');
Insert into pagosaprofesores values('jun2023658',6,2023,97000,'7789000-2','as3000');
Insert into pagosaprofesores values('jul2023658',7,2023,99000,'7789000-2','as3000');

Insert into pagosaprofesores values('mar2023800',3,2023,90000,'8799800-4','as2000');
Insert into pagosaprofesores values('abr2023800',4,2023,70000,'8799800-4','as2000');
Insert into pagosaprofesores values('may2023800',5,2023,90000,'8799800-4','as2000');
Insert into pagosaprofesores values('jun2023800',6,2023,90000,'8799800-4','as2000');
Insert into pagosaprofesores values('jul2023800',7,2023,90000,'8799800-4','as2000');

Insert into pagosaprofesores values('mar2023808',3,2023,70000,'10435768-9','as2000');
Insert into pagosaprofesores values('abr2023808',4,2023,88000,'10435768-9','as2000');
Insert into pagosaprofesores values('may2023808',5,2023,92000,'10435768-9','as2000');
Insert into pagosaprofesores values('jun2023808',6,2023,96000,'10435768-9','as2000');
Insert into pagosaprofesores values('jul2023808',7,2023,87000,'10435768-9','as2000');

Insert into pagosaprofesores values('mar2023900',3,2023,80000,'8799800-4','as4000');
Insert into pagosaprofesores values('abr2023900',4,2023,60000,'9439878-8','as4000');
Insert into pagosaprofesores values('may2023900',5,2023,80000,'9439878-8','as4000');
Insert into pagosaprofesores values('jun2023900',6,2023,80000,'9439878-8','as4000');
Insert into pagosaprofesores values('jul2023900',7,2023,80000,'9439878-8','as4000');

Insert into pagosaprofesores values('mar2023998',3,2023,75000,'10545676-1','as1000');
Insert into pagosaprofesores values('abr2023998',4,2023,50000,'10545676-1','as1000');
Insert into pagosaprofesores values('may2023998',5,2023,75000,'10545676-1','as1000');
Insert into pagosaprofesores values('jun2023998',6,2023,75000,'10545676-1','as1000');
Insert into pagosaprofesores values('jul2023998',7,2023,75000,'10545676-1','as1000');

Insert into pagosaprofesores values('mar2023558',3,2023,80000,'9439878-8','as5000');
Insert into pagosaprofesores values('abr2023558',4,2023,60000,'9439878-8','as5000');
Insert into pagosaprofesores values('may2023558',5,2023,80000,'9439878-8','as5000');
Insert into pagosaprofesores values('jun2023558',6,2023,80000,'9439878-8','as5000');
Insert into pagosaprofesores values('jul2023558',7,2023,80000,'9439878-8','as5000');

Insert into pagosaprofesores values('ago2023657',8,2023,60000,'11324657-0','as3000');
Insert into pagosaprofesores values('sep2023657',9,2023,80000,'11324657-0','as3000');
Insert into pagosaprofesores values('oct2023657',10,2023,80000,'11324657-0','as3000');
Insert into pagosaprofesores values('nov2023657',11,2023,80000,'11324657-0','as3000');
Insert into pagosaprofesores values('dic2023657',12,2023,80000,'11324657-0','as3000');

Insert into pagosaprofesores values('ago2023658',8,2023,70000,'7789000-2','as3000');
Insert into pagosaprofesores values('sep2023658',9,2023,90000,'7789000-2','as3000');
Insert into pagosaprofesores values('oct2023658',10,2023,90000,'7789000-2','as3000');
Insert into pagosaprofesores values('nov2023658',11,2023,97000,'7789000-2','as3000');
Insert into pagosaprofesores values('dic2023658',12,2023,99000,'7789000-2','as3000');

Insert into pagosaprofesores values('ago2023800',8,2023,90000,'8799800-4','as2000');
Insert into pagosaprofesores values('sep2023800',9,2023,70000,'8799800-4','as2000');
Insert into pagosaprofesores values('oct2023800',10,2023,90000,'8799800-4','as2000');
Insert into pagosaprofesores values('nov2023800',11,2023,90000,'8799800-4','as2000');
Insert into pagosaprofesores values('dic2023800',12,2023,90000,'8799800-4','as2000');

Insert into pagosaprofesores values('ago2023808',8,2023,70000,'10435768-9','as2000');
Insert into pagosaprofesores values('sep2023808',9,2023,88000,'10435768-9','as2000');
Insert into pagosaprofesores values('oct2023808',10,2023,92000,'10435768-9','as2000');
Insert into pagosaprofesores values('nov2023808',11,2023,96000,'10435768-9','as2000');
Insert into pagosaprofesores values('dic2023808',12,2023,87000,'10435768-9','as2000');


Insert into pagosaprofesores values('ago2023900',8,2023,80000,'8799800-4','as4000');
Insert into pagosaprofesores values('sep2023900',9,2023,60000,'9439878-8','as4000');
Insert into pagosaprofesores values('oct2023900',10,2023,80000,'9439878-8','as4000');
Insert into pagosaprofesores values('nov2023900',11,2023,80000,'9439878-8','as4000');
Insert into pagosaprofesores values('dic2023900',12,2023,80000,'9439878-8','as4000');

Insert into pagosaprofesores values('ago2023998',8,2023,75000,'10545676-1','as1000');
Insert into pagosaprofesores values('sep2023998',9,2023,50000,'10545676-1','as1000');
Insert into pagosaprofesores values('oct2023998',10,2023,75000,'10545676-1','as1000');
Insert into pagosaprofesores values('nov2023998',11,2023,75000,'10545676-1','as1000');
Insert into pagosaprofesores values('dic2023998',12,2023,75000,'10545676-1','as1000');

Insert into pagosaprofesores values('ago2023558',8,2023,80000,'9439878-8','as5000');
Insert into pagosaprofesores values('sep2023558',9,2023,60000,'9439878-8','as5000');
Insert into pagosaprofesores values('oct2023558',10,2023,80000,'9439878-8','as5000');
Insert into pagosaprofesores values('nov2023558',11,2023,80000,'9439878-8','as5000');
Insert into pagosaprofesores values('dic2023558',12,2023,80000,'9439878-8','as5000');

select distinct nombresest, appatest, apmatest from estudiantes e , matriculas m where e.rutest = m.rutest;
select distinct nombresest, appatest, apmatest from estudiantes e, inscripciones i where e.rutest = i.rutest;
select nombrecarrera, fecha from carreras c, matriculas m where c.codigocarrera = m.codigocarrera and costo between 100000 and 130000; 
--Ejercicios, Clase 1
--1
select fecha 
from carreras c, matriculas m 
where c.codigocarrera = m.codigocarrera and nombrecarrera = 'Ingenier�a inform�tica';
--2
select nombrecarrera 
from carreras c, matriculas m 
where c.codigocarrera = m.codigocarrera and nummatricula = 2502; 
--3
select sum(costo) costo_total 
from estudiantes e, matriculas m 
where e.rutest = m.rutest and nombresest = 'Isabel' and appatest = 'Ferrer';
--4
select codigocurso 
from inscripciones i, estudiantes e 
where i.rutest = e.rutest and nombresest = 'Daniela' and appatest = 'Donoso';

--Ejercicios, Clase 2
--1
select nombresest, appatest, apmatest, nombrecarrera, fecha 
from estudiantes e, matriculas m, carreras c 
where e.rutest = m.rutest and c.codigocarrera = m.codigocarrera and  e.rutest ='21116906-4' 
order by fecha ;
---2
select nombresest, appatest, apmatest, a�o, semestre
from estudiantes e, inscripciones i, cursos  c
where e.rutest = i.rutest and c.codigocurso = i.codigocurso and nombrecurso = 'Matem�ticas I';
--3
select nombrecurso, semestre, a�o
from estudiantes e, inscripciones i, cursos c
where i.codigocurso=c.codigocurso and nombresest = 'Victor' and appatest = 'Soto' and apmatest= 'Miranda';

--Ejercicios Clase 3
--1
select distinct rutest 
from inscripciones i, cursos c, pagosaprofesores pp, profesores p
where i.codigocurso = c.codigocurso and c.codigocurso = pp.codigocurso and pp.rutprofesor = p.rutprofesor and nombresprofesor = 'Gabriel' and appatprofesor = 'Aguayo';

--2
select distinct nombrecurso
from carreras c, matriculas m, estudiantes e, inscripciones i, cursos cu
where c.codigocarrera = m.codigocarrera and e.rutest = i.rutest and e.rutest = m.rutest and i.codigocurso = cu.codigocurso and nombrecarrera = 'Ingeniería informática'
order by nombrecurso;

--3
select distinct nombrecarrera
from carreras c, matriculas m, estudiantes e, inscripciones i, cursos cu, pagosaprofesores pp
where c.codigocarrera = m.codigocarrera and e.rutest = i.rutest and e.rutest = m.rutest and i.codigocurso = cu.codigocurso and pp.codigocurso = cu.codigocurso and rutprofesor = '7789000-2'
order by nombrecarrera;

--4
select distinct nombresprofesor, appatprofesor, apmatprofesor
from carreras c, matriculas m, estudiantes e, inscripciones i, cursos cu, pagosaprofesores pp, profesores p
where c.codigocarrera = m.codigocarrera and e.rutest = i.rutest and e.rutest = m.rutest and i.codigocurso = cu.codigocurso and pp.codigocurso = cu.codigocurso and pp.rutprofesor = p.rutprofesor and nombrecarrera = 'Automatización'
order by appatprofesor, apmatprofesor;

