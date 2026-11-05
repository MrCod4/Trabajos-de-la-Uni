Create table Funciones(
codigoF varchar2(3) not null primary key, 
bono number(6),
descto number(6)
);
Create table Personal(
codigoP number(6) not null primary key,
rango number(2),
sueldobase number(7),
codfuncion varchar2(3) references funciones
);
insert into funciones values('a1',50000,10000);
insert into funciones values('a2',45000,9000);
insert into funciones values('b1',40000,8000);
insert into funciones values('b2',35000,7000);
insert into funciones values('b3',30000,6000);
insert into personal values(2356,5,700000,'a2');
insert into personal values(2278,1,900000,'a1');
insert into personal values(2480,2,850000,'a2');
insert into personal values(2384,4,750000,'b3');
insert into personal values(2158,3,800000,'b2');
insert into personal values(2340,5,720000,'b3');
insert into personal values(2867,1,950000,'a2');
insert into personal values(2242,3,850000,'a1');
insert into personal values(2193,2,920000,'b1');
insert into personal values(2396,4,720000,'b2');

--1
select decode(1000,1000,'iguales','no iguales') elegir 
from dual;

--2
select decode(1000,5000,'iguales','no iguales') elegir 
from dual;

--3
SELECT codigof,bono,decode(bono,
         40000,'coincide a 40000',
        'no coincide'
        ) Resultado
FROM funciones;

--4
SELECT codigop,rango,sueldobase,decode(rango,
            	1,sueldobase*1.09,
      	2,sueldobase*1.08,
 	3,sueldobase*1.07,
            	4,sueldobase*1.06,
            	5,sueldobase*1.05,
            	sueldobase) sueldoBaseNuevo
FROM personal;

--5
select codigof, descto, decode(
codigof, 'a1', descto*0.98,
'a2', descto*0.94,
'b1', descto*0.9,
'b2', descto*0.86,
'b3', descto*0.82
) Descuento
from funciones 

--6
select codigop,rango,
      case  
           when rango>=2 and rango<=4 then '-rango menor'
           when rango>4 then '-rango MAYOR'
      end Calificación
from personal ;

--7
select codigof, bono, descto,
case
when (bono - descto) < 30000 then ' baja diferencia'
when (bono - descto) < 40000 then ' diferencia normal'
else ' diferencia exesiva'
end diferencia
from funciones;



