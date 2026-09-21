create table Productos(
codP varchar2(7) not null primary key,
nomP varchar2(20),
fechaFabr date,
precioProveedor number(10,2),
precioVenta number(10,2),
peso number(6,2)  -- en kg
);
Create table Vendedores(
codV varchar2(6) not null primary key,
nombres varchar2(15),
apPat varchar2(10),
apMat varchar2(10),
fechaNac date,
sueldoBase number(7)
);
Create table Ventas(
numVenta number(8) not null primary key,
monto number(12,2),
fecha date,
codProd varchar2(7) not null references Productos,
codVend varchar2(6) not null references Vendedores
);
insert into Productos values('bbr2325','Motor tipo A','12/5/2021',250000,270000,93.56);
insert into Productos values('bbr2346','Motor tipo B','26/6/2021',280000,310000,113.49);
insert into Productos values('bbr2357','Motor tipo C','12/5/2021',220000,250000,87.23);
insert into Productos values('dte4387','Inyector central','24/3/2021',90000,95000,2.56);
insert into Productos values('dte2600','Inyector secuencial','25/5/2021',134000,140000,3.79);
insert into Productos values('ytd2380','Válvula de flujo','8/4/2021',19000,23000,0.28);
insert into Productos values('ytd4578','Válvula zenner','17/5/2021',26000,30000,0.72);

insert into Vendedores values('34RT','Romina', 'Zapata', 'Aburto','19/8/1989',430431);
insert into Vendedores values('28DS','Franco', 'Munita', 'Vera','2/12/1988',416389);
insert into Vendedores values('21FD','Carla', 'Millar', 'Gatica','26/10/1996',383897);
insert into Vendedores values('54DE','Renato', 'Donoso','Santis','16/8/1994',425675);

insert into Ventas values(78,1200560,'15/7/2021','dte4387', '21FD');
insert into Ventas values(79,906790,'16/7/2021','ytd2380', '28DS');
insert into Ventas values(80,1890500,'19/7/2021','bbr2346', '34RT');
insert into Ventas values(81,980450,'20/7/2021','ytd4578', '54DE');
insert into Ventas values(82,1105020,'24/7/2021','dte2600', '28DS');
insert into Ventas values(83,2450600,'25/7/2021','bbr2325', '34RT');
insert into Ventas values(84,1670400,'2/8/2021','ytd4578', '21FD');
insert into Ventas values(85,1540710,'5/8/2021','dte4387', '54DE');
insert into Ventas values(86,987600,'9/8/2021','bbr2357', '34RT');
insert into Ventas values(87,1346900,'12/8/2021','dte2600', '21FD');
insert into Ventas values(88,1200780,'21/8/2021','ytd2380', '28DS');
insert into Ventas values(89,1790430,'27/8/2021','ytd4578', '54DE');
insert into Ventas values(90,2800910,'1/9/2021','bbr2346', '21FD');
insert into Ventas values(91,995500,'16/9/2021','ytd2380', '34RT');
insert into Ventas values(92,1250400,'20/9/2021','dte4387', '28DS');
insert into Ventas values(93,1320650,'1/10/2021','bbr2357', '54DE');
insert into Ventas values(94,1540300,'5/10/2021','dte2600', '21FD');

--Ejercicios
--1.	Crear un rol llamado ROL_VENTAS que permita consultar e insertar registros en la tabla Ventas, consultar las tablas Productos, además de poder eliminar en la tabla Vendedores.
create role ROL_VENTAS;
grant select, insert on ventas to ROL_VENTAS;
grant select on productos to ROL_VENTAS;
grant delete on vendedores to ROL_VENTAS;

--2.	Crear un rol llamado ROL_PRODUCTOS que permita consultar, insertar y modificar registros de la tabla Productos, pero que no permita eliminar registros
create role ROL_PRODUCTOS;
grant select, insert, update on productos to ROL_PRODUCTOS;

--3.	Crear los usuarios usuario_ventas y usuario_productos, asignándoles una contraseña y otorgándoles el privilegio necesario para iniciar sesión en Oracle. 
create user usuario_ventas identified by "123";
create user usuario_productos identified by "123";

grant connect to usuario_ventas;
grant connect to usuario_productos;

--4.	Asignar ROL_VENTAS al usuario usuario_ventas. 
grant ROL_VENTAS to usuario_ventas;

--5.	Asignar ROL_PRODUCTOS al usuario usuario_productos. 
grant ROL_PRODUCTOS to usuario_productos;





