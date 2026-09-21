--1.	Select a la tabla ventas con ambos usuarios.
select * 
from system.ventas; 

--2.	Select a la tabla Productos con ambos usuarios
select*
from system.productos;

--3.	Select a la tabla Vendedores con ambos usuarios.
select*
from system.vendedores;

--4.	Insert a la tabla ventas con ambos usuarios.
insert into system.ventas values(95,1540300,'5/11/2021','dte2600', '21FD');

--5.	Insert a la tabla Productos con ambos usuarios.
insert into system.productos values ('ytd6767','Válvula zenner','17/5/2021',26000,30000,0.72);

--6.	Insert a la tabla Vendedores con ambos usuarios.
insert into system.Vendedores values('34Rh','Romina', 'Zapata', 'Aburto','19/8/1989',430431);

--7.	Update a la tabla ventas con ambos usuarios.
update system.ventas
set fecha = '5/11/2021'
where numventa = 95;

--8.	Update a la tabla Productos con ambos usuarios.
update system.productos
set fechafabr = '18/5/2021'
where codp= 'ytd6767';

--9.	Update a la tabla Vendedores con ambos usuarios.
update system.vendedores
set appat  = 'zambrano'
where codv = '34Rh';