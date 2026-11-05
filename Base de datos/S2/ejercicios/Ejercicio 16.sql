Create table Comprador(
codigo number(6) not null primary key,
email varchar2(20),
deuda number(8),
fono varchar2(12),
categoria number(2),
fechaNac date
);

--los datos nulos pueden ser con '' (cremillas vacías) o con la palabra null
insert into Comprador values(12,'correo1@otro.cl',560000,'+56998897887',3,'');
insert into Comprador values(13,null,null,'+56976596200',3,null);
insert into Comprador values(14,'correo2@otro.cl',700000,'','','12/7/1999');
insert into Comprador values(15,'','','','','2/3/1998');
insert into Comprador values(16,'',null,'+56967652001',1,null);
insert into Comprador values(17,'correo3@otro.cl',290000,'+56987564380',4,null);
insert into Comprador values(18,null,null,null,null,null);
insert into Comprador values(19,'','','','','');

--1
select * from comprador;

--2
select codigo,nvl(email,'-Sin email-') email,deuda,fono,categoria,fechanac
from comprador;

--3
select codigo,nvl(email,0) email,nvl(fono,0) fono,categoria,fechanac
from comprador;

select codigo,email,nvl(fechanac,'1/1/11') fechanacim
from comprador;

--4
select 'El cliente '||codigo||' con correo '
||nvl(email,'pendiente')||' tiene categoría ' ||nvl(categoria,0) cat
from comprador
where categoria>2;

select 'El cliente '||codigo||' con fono ' 
||nvl(fono,0)||' tiene fecha de nac. ' 
||nvl(fechanac,'11/11/1111') fechas_de_nac
from comprador
where fechanac>'11/11/1111';

--5
select 'El cliente '||codigo||' con categoria '||nvl(categoria,0)||' tiene deuda '||nvl(deuda, 0)
from comprador
where categoria between 3 and 4;

--6
select coalesce(email,fono,'-Sin contacto-') Contacto
from comprador;

--7
select 'El cliente '||codigo||' tiene prioridad '||coalesce(categoria, deuda, 0)||' para credito'
from comprador
where coalesce(categoria, deuda, 0) between 1 and 3;

--8








