create table Camioneros(
RutCamionero varchar2(12) not null primary key,
NomCam varchar2(20),
ApPatCam varchar2(20),
ApMatCam varchar2(20),
FonoCam varchar2(10),
Sueldo number(9)
);

Create table Camiones(
Patente varchar2(6) not null primary key,
Marca varchar2(20),
Modelo varchar2(20),
Color varchar2(15),
Año number(4)
);

Create table ClienteDestino(
RutCliente varchar2(12) not null primary key,
NomCli varchar2(30),
ApPatCli varchar2(20),
ApMatCli varchar2(20),
FonoCli varchar2(10)
);



Create table Encomiendas(
CodEncomienda number(8) not null primary key,
PesoGr number(5),
Costo number(6),
Ciudad varchar2(30),
FechaEnvio date,
RutCli varchar2(12) not null references clientedestino,
RutCam varchar2(12) not null references camioneros,
Patente varchar2(6) not null references camiones
);

insert into camioneros values('10546789-4','Juan','Lara','Soto','64758999' ,340000);
insert into camioneros values('11328988-0','Mario','Donoso','Vera','53647800',350000);
insert into camioneros values('10324879-3','Luis','Díaz','Castro','43769034',340000);
insert into camioneros values('9678321-7', 'Mario','Donoso','Zapata','32879980',350000);

insert into camiones values('CTFT45','Ford','Cargo','Blanco',2010);
insert into camiones values('DFGR35','Mercedes Benz','Zetros','Negro',2011);
insert into camiones values('DRTQ87','Renault','Maxity','Blanco',2010);

insert into clienteDestino values('12867967-2','Carolina','Riquelme','Duarte','947528596');
insert into clienteDestino values('13437856-1','Eliana','Godoy','Urrutia','939881765');
insert into clienteDestino values('9768345-6','Carlos','Núñez','Torres','965639011');
insert into clienteDestino values('10769800-6','Paula','Millar','Salas','985619675');
insert into clienteDestino values('11341560-k','Marco','Vera','Carrillo','992039100');
insert into clienteDestino values('20900289-2','Lorena','Parra','Mora','945879826');

insert into encomiendas values(1,2380,52000,'Calama','13/10/2021','13437856-1','11328988-0','CTFT45');
insert into encomiendas values(2,1450,75000,'Arica','22/10/2021','12867967-2','10546789-4','DFGR35');
insert into encomiendas values(3,2130,23000,'Curicó','25/10/2021','9768345-6','9678321-7','CTFT45');
insert into encomiendas values(4,1569,30000,'Valdivia','25/10/2021','12867967-2','10324879-3','DRTQ87');
insert into encomiendas values(5,2176,25000,'Santiago','26/10/2021','13437856-1','11328988-0','DFGR35');
insert into encomiendas values(6,3343,28000,'Santiago','27/10/2021','11341560-k','10546789-4','DRTQ87');
insert into encomiendas values(7,2330,28000,'Curicó','3/11/2021','9768345-6','9678321-7','DRTQ87');
insert into encomiendas values(8,5890,56000,'Valdivia','5/11/2021','12867967-2','10324879-3','CTFT45');
insert into encomiendas values(9,8750,65000,'Arica','7/11/2021','12867967-2','11328988-0','DRTQ87');
insert into encomiendas values(10,8906,45000,'Santiago','11/11/2021','10769800-6','10546789-4','CTFT45');
insert into encomiendas values(11,8130,33000,'Curicó','12/11/2021','9768345-6','11328988-0','DRTQ87');
insert into encomiendas values(12,5680,62000,'Calama','13/11/2021','20900289-2','9678321-7','DFGR35');
insert into encomiendas values(13,4530,38000,'Curicó','15/11/2021','9768345-6', '11328988-0','DFGR35');
insert into encomiendas values(14,9890,66000,'Valdivia','17/11/2021','12867967-2','9678321-7','DRTQ87');
insert into encomiendas values(15,3976,45000,'Santiago','17/11/2021','13437856-1','10546789-4','DFGR35');
insert into encomiendas values(16,5460,65000,'Arica','20/11/2021','12867967-2','10546789-4','CTFT45');
insert into encomiendas values(17,5900,67000,'Calama','21/11/2021','20900289-2','9678321-7','CTFT45');
insert into encomiendas values(18,7866,58000,'Curicó','22/11/2021','9768345-6', '11328988-0','DFGR35');
insert into encomiendas values(19,7800,56000,'Valdivia','24/11/2021','12867967-2','9678321-7','CTFT45');
insert into encomiendas values(20,4890,35000,'Santiago','25/11/2021','13437856-1','10546789-4', 'DRTQ87');
insert into encomiendas values(21,7800,75000,'Arica','25/11/2021','12867967-2','9678321-7','CTFT45');
insert into encomiendas values(22,6080,68000,'Calama','26/11/2021','20900289-2','11328988-0','DRTQ87');
insert into encomiendas values(23,8945,64000,'Curicó','27/11/2021','9768345-6','10546789-4','DFGR35');
insert into encomiendas values(24,9800,43000,'Valdivia','28/11/2021','12867967-2','10324879-3','CTFT45');
insert into encomiendas values(25,6800,45000,'Santiago','29/11/2021','13437856-1','11328988-0', 'DRTQ87');

--Ejercicios
--1.	Nombres completos de clientes que han recibido encomiendas con el camión con patente DFGR35.
select nomcli, appatcli, apmatcli
from clientedestino c join encomiendas e
on c.rutcliente = e.rutcli 
join camiones ca
on  ca.patente = e.patente
and ca.patente = 'DFGR35';

--2.	Patentes que han llevado encomiendas a Calama con el camionero Mario Donoso Vera. 
select ca.patente
from clientedestino c join encomiendas e
on c.rutcliente = e.rutcli 
join camiones ca
on  ca.patente = e.patente
join camioneros cam
on e.rutcam = cam.rutcamionero
and ciudad = 'Calama'
and nomcam = 'Mario'
and appatcam = 'Donoso'
and apmatcam = 'Vera';

--3.	Sin repetir, ciudades a las que ha llevado encomiendas el camionero Juan Lara. 
select distinct ciudad
from encomiendas e 
join camioneros cam
on e.rutcam = cam.rutcamionero
and nomcam = 'Juan'
and appatcam = 'Lara';

--4.	Códigos de encomiendas transportadas por el camionero Mario Donoso Zapata con el camión Ford.
select e.codencomienda
from encomiendas e
join camioneros cam
on e.rutcam = cam.rutcamionero
join camiones ca
on ca.patente = e.patente
and nomcam = 'Mario'
and appatcam = 'Donoso'
and apmatcam = 'Zapata'
and marca = 'Ford';

--5.	Nombre completo del camionero que ha llevado encomiendas a Santiago con el camión Renault. 
select nomcam, appatcam, apmatcam
from camioneros cam join encomiendas e
on cam.rutcamionero = e.rutcam
join camiones ca
on  ca.patente = e.patente
and marca = 'Renault'
and ciudad = 'Santiago';

--6.	Nombre completo del camionero y marca del camión en que se transportó la encomienda 4. 
select nomcam, appatcam, apmatcam, marca
from camioneros cam join encomiendas e
on cam.rutcamionero = e.rutcam
join camiones ca
on  ca.patente = e.patente
and e.codencomienda = 4;

--7.	Fechas en que se ha enviado encomiendas a la cliente Eliana Godoy en el camión Mercedes Benz. 
select fechaenvio
from clientedestino c join encomiendas e
on c.rutcliente = e.rutcli 
join camiones ca
on  ca.patente = e.patente
and nomcli = 'Eliana'
and appatcli = 'Godoy'
and marca = 'Mercedes Benz';

--8.	Costos de envío en que el camionero Luis Díaz Castro usó el camión Renault Maxity. 
select costo
from camioneros cam join encomiendas e
on cam.rutcamionero = e.rutcam
join camiones ca
on  ca.patente = e.patente
and nomcam = 'Luis'
and appatcam = 'Díaz'
and apmatcam = 'Castro'
and marca = 'Renault'
and modelo = 'Maxity';

--9.	Los códigos de encomiendas y los pesos, que ha transportado el camionero Mario Donoso Vera a la cliente Eliana Godoy, ordenado por peso.
select e.codencomienda, pesogr
from camioneros cam join encomiendas e
on cam.rutcamionero = e.rutcam
join clientedestino c
on c.rutcliente = e.rutcli
and nomcam = 'Mario'
and appatcam = 'Donoso'
and apmatcam = 'Vera'
and nomcli = 'Eliana'
and appatcli = 'Godoy'
order by pesogr;

--10.	Máximo costo de una encomienda. 
select max(costo)
from encomiendas;

--11.	Suma de costos en envíos a Valdivia. 
select sum(costo)
from encomiendas
where ciudad = 'Valdivia';

--12.	La fecha más antigua en que se ha enviado una encomienda al cliente Carlos Núñez. 
select min(fechaenvio)
from encomiendas e
join clientedestino c
on e.rutcli = c.rutcliente
and nomcli = 'Carlos'
and appatcli = 'Núñez';

--13.	Nombre completo de los camioneros que han transportado encomiendas entre el 5/11/2021 al 17/11/2021, ordenados por apellido paterno. 
select nomcam, appatcam, apmatcam
from encomiendas e
join camioneros cam
on e.rutcam = cam.rutcamionero
and fechaenvio between '5/11/2021' and '17/11/2021'
order by appatcam;

--14.	Promedio de costos en envíos hechos por el camión Ford. 
select round(avg(costo))
from encomiendas e 
join camiones c
on c.patente = e.patente
and marca = 'Ford';

--15.	Suma de costos en encomiendas enviadas a Carolina Riquelme en el camión Renault. 
select sum(costo)
from encomiendas e join camiones ca
on ca.patente=e.patente join clientedestino cl
on cl.rutcliente=e.rutcli
and nomcli='Carolina'
and appatcli='Riquelme'
and marca='Renault'



