create table FUNCIONARIOS(
rutFuncionario varchar2(13) primary key not null,
apPatFunc varchar2(20),
apMatFunc varchar2(20),
nombresFunc varchar2(30),
fonoFunc number(9)
);

create table CURSOS(
codigoCurso number(4) primary key not null,
nombreCurso varchar2(50),
HorasCurso number(3)
);

create table REALIZADOS(
codRealizado number(4) primary key not null,
fechaInicio date,
fechaFin date,
costo number(7),
notaFinal number(2,1),
rutFunc varchar2(13) not null references FUNCIONARIOS,
codigoCurso number(4) not null references CURSOS
);

Insert into funcionarios values('22424737-9','Vera','Miranda','Carlos',996456789);
Insert into funcionarios values('21325011-9','Mena','Godoy','Mirta',987656651);
Insert into funcionarios values('21116906-4','Duarte','Vera','Sandra',976543678);
Insert into funcionarios values('22257368-4','Castro','Saavedra','Sergio',996576243);
Insert into funcionarios values('22265087-k','Barra','Vera','Gabriel',957654789);
Insert into funcionarios values('21790344-0','Zapata','Alarcón','Fernando',971423674);
Insert into funcionarios values('21590230-7','Silva','Mena','Leonardo',967132453);

Insert into cursos values(376,'Excel Avanzado',60);
Insert into cursos values(189,'Primeros Auxilios',80);
Insert into cursos values(290,'Contabilidad',70);
Insert into cursos values(478,'PowerPoint Medio',40);
Insert into cursos values(479,'Autocad',80);
Insert into cursos values(480,'Pastelería',70);

Insert into realizados values(3400,'11/3/2022','21/7/2022',80000,5.6,'21590230-7',376);
Insert into realizados values(3401,'12/2/2022','20/6/2022',90000,6.6,'22424737-9',290);
Insert into realizados values(3402,'9/3/2022','27/7/2022',90000,7,'22265087-k',480);
Insert into realizados values(3403,'26/4/2022','10/8/2022',70000,6.2,'21325011-9',478);
Insert into realizados values(3404,'3/2/2022','25/6/2022',100000,6.4,'21116906-4',376);
Insert into realizados values(3405,'7/8/2022','22/12/2022',850000,7,'21590230-7',290);
Insert into realizados values(3406,'22/7/2022','2/11/2022',120000,6.1,'22424737-9',376);
Insert into realizados values(3407,'9/8/2022','27/12/2022',80000,6.2,'22265087-k',290);
Insert into realizados values(3408,'4/7/2022','14/12/2022',90000,6.5,'21325011-9',290);
Insert into realizados values(3409,'15/7/2022','19/11/2022',90000,7,'21116906-4',480);
Insert into realizados values(3410,'11/3/2023','2/7/2023',100000,6.8,'21590230-7',478);
Insert into realizados values(3411,'4/4/2023','22/8/2023',950000,7,'22424737-9',480);
Insert into realizados values(3412,'12/3/2023','4/7/2023',120000,6.0,'22265087-k',376);
Insert into realizados values(3413,'19/4/2023','6/8/2023',100000,5.5,'21325011-9',480);
Insert into realizados values(3414,'26/2/2023','22/6/2023',70000,6.2,'21116906-4',290);

--clase 5

--1
select nombrecurso, fechainicio
from realizados r join cursos c
on r.codigocurso = c.codigocurso;

--2 
select nombresfunc, appatfunc, apmatfunc
from funcionarios join realizados r 
on  rutfuncionario = rutfunc join cursos c on r.codigocurso = c.codigocurso
and nombrecurso = 'Excel Avanzado';

--3
select fechainicio, fechafin
from cursos c join realizados r
on r.codigocurso = c.codigocurso and nombrecurso = 'PowerPoint Medio'; 

--4
select notafinal, costo
from funcionarios f join realizados r
on f.rutfuncionario = r.rutfunc and nombresfunc = 'Leonardo' and appatfunc = 'Silva';

--5
select rutfunc, c.codigocurso
from realizados r right join cursos c 
on r.codigocurso = c.codigocurso
order by c.codigocurso;

--6
select rutfuncionario, codigocurso
from  funcionarios f left join realizados r
on f.rutfuncionario = r.rutfunc
order by rutfuncionario;

--7
select numbrecurso, nombresfunc, appatfunc 
from funcionarios
cross join cursos;