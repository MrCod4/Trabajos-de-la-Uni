create table libros(
codlibro varchar2(5) not null primary key,
titulo varchar2(30),
precio number(8),
stock number(3)
);
create table ventalibros(
numventa number(8) not null primary key,
fecha date,
cantidad number(3),
codigolibro varchar2(5) not null references libros
);
create sequence sec_ventalibros;

insert into libros values('1001','El Principito',12000,25);
insert into libros values('1002','Don Quijote',18000,15);
insert into libros values('1003','La Odisea',15000,20);
insert into libros values('1004','Cien años de soledad',22000,12);
insert into ventalibros values(sec_ventalibros.nextval,'5/3/2026',3,'1001');
insert into ventalibros values(sec_ventalibros.nextval,'8/3/2026',2,'1002');
insert into ventalibros values(sec_ventalibros.nextval,'12/3/2026',5,'1003');
insert into ventalibros values(sec_ventalibros.nextval,'15/3/2026',1,'1004');
insert into ventalibros values(sec_ventalibros.nextval,'20/3/2026',4,'1001');
insert into ventalibros values(sec_ventalibros.nextval,'25/3/2026',2,'1003');

select*from ventalibros;
--1
create or replace procedure cambiaprecio1(valor number)
as
begin
    update libros set precio=precio*(1+(valor/100)); 
end;

--2
exec cambiaprecio1(5);
exec cambiaprecio1(-8);

--3
create or replace procedure cambiaprecio2(cambio number,cod varchar2)
as
begin
    update libros set precio=precio*(1+(cambio/100))
    where codlibro=cod; 
end;

--4
exec cambiaprecio2(10,'1002');
exec cambiaprecio2(-7,'1004');

--5
create or replace procedure cambiocantidad(valor number, numv number)
as
begin
update ventalibros set cantidad = valor
where numventa = numv;
end;

exec cambiocantidad(5,1);

--6
 set serveroutput on
 
 --7
 create or replace function totventas(cod varchar2)
 return number
 is suma number;
 
 begin
 select sum(cantidad) into suma
 from ventalibros
 where codigolibro = cod;
 return suma;
 end;
 
 select totventas('1001') from dual;
 
 --8
 create or replace function consultafecha(numero number)
return varchar2
is resultado varchar2(20);
begin
if numero = 1 then
select to_char(min(fecha),'dd/mm/yy') into resultado
from ventalibros;
else
if numero = 2 then
select to_char(max(fecha),'dd/mm/yy') into resultado
from ventalibros;
else
resultado := '11/11/11';
end if;
end if;

return resultado;
end;

select consultafecha(2) from dual;
