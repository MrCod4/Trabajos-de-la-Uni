create table libro(
codlibro varchar2(6) not null primary key,
precio number(10),
titulo varchar2(50),
autor varchar2(50),
añoo number(4),
editorial varchar2(40)
);

create table clienteempresa(
rutcliente varchar2(10) not null primary key,
nombrecli varchar2(40),
girocli varchar2(50),
ciudadcli varchar2(30),
fonocli varchar2(15)
);

create table venta(
codventa varchar2(6) not null primary key,
codlibro varchar2(6) not null references libro,
rutcli varchar2(10) not null references clienteempresa,
fecha date,
montoventa number(10)
);

insert into libro values ('l001',15990,'cien años de soledad','gabriel garcía márquez',1967,'sudamericana');
insert into libro values ('l002',12990,'el principito','antoine de saint-exupéry',1943,'salamandra');
insert into libro values ('l003',18990,'1984','george orwell',1949,'debolsillo');
insert into libro values ('l004',14990,'don quijote','miguel de cervantes',1605,'planeta');
insert into libro values ('l005',16990,'la metamorfosis','franz kafka',1915,'austral');
insert into libro values ('l006',21990,'el señor de los anillos','j.r.r. tolkien',1954,'minotauro');
insert into libro values ('l007',13990,'fahrenheit 451','ray bradbury',1953,'minotauro');
insert into libro values ('l008',17990,'crónica de una muerte anunciada','gabriel garcía márquez',1981,'debolsillo');
insert into libro values ('l009',19990,'orgullo y prejuicio','jane austen',1813,'alianza');
insert into libro values ('l010',11990,'el viejo y el mar','ernest hemingway',1952,'debolsillo');

insert into clienteempresa values ('11111111-1','librería central','venta de libros','concepción','987654321');
insert into clienteempresa values ('12222222-2','comercial andes','comercio','chillán','976543210');
insert into clienteempresa values ('13333333-3','distribuidora sur','distribución','los ángeles','965432109');
insert into clienteempresa values ('14444444-4','librería del valle','venta de libros','concepción','954321098');
insert into clienteempresa values ('15555555-5','comercial pacífico','comercio','talcahuano','943210987');

insert into venta values ('v001','l001','11111111-1','5/1/2026',15990);
insert into venta values ('v002','l003','12222222-2','12/1/2026',18990);
insert into venta values ('v003','l005','13333333-3','20/1/2026',16990);
insert into venta values ('v004','l002','11111111-1','3/2/2026',12990);
insert into venta values ('v005','l006','14444444-4','15/2/2026',21990);

insert into venta values ('v006','l004','15555555-5','22/2/2026',14990);
insert into venta values ('v007','l007','12222222-2','8/3/2026',13990);
insert into venta values ('v008','l008','13333333-3','17/3/2026',17990);
insert into venta values ('v009','l010','11111111-1','25/3/2026',11990);
insert into venta values ('v010','l009','14444444-4','4/4/2026',19990);

insert into venta values ('v011','l001','15555555-5','14/4/2026',15990);
insert into venta values ('v012','l006','13333333-3','27/4/2026',21990);
insert into venta values ('v013','l003','11111111-1','6/5/2026',18990);
insert into venta values ('v014','l008','12222222-2','19/5/2026',17990);
insert into venta values ('v015','l005','14444444-4','30/5/2026',16990);

--A
select titulo 
from libro i, venta v
where i.codlibro = v.codlibro and montoventa > 15000;

--b
select fecha
from libro i, venta v
where i.codlibro = v.codlibro and titulo like('e%');

--c
select distinct nombrecli 
from clienteempresa c, venta v
where c.rutcliente = v.rutcli and montoventa between 14000 and 18000;

--d
select montoventa
from clienteempresa c, venta v
where c.rutcliente= v.rutcli and ciudadcli = 'concepción';

--e
select precio
from clienteempresa c, libro l, venta v
where c.rutcliente = v.rutcli and l.codlibro = v.codlibro and nombrecli = 'comercial andes';

--f
select nombrecli
from clienteempresa c, libro l, venta v
where c.rutcliente = v.rutcli and l.codlibro = v.codlibro and titulo = 'cien años de soledad';

