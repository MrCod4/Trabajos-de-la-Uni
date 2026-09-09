create table administrador(
  rutAdm     varchar2(10) not null primary key,
  nombresAdm varchar2(25),
  apPatAdm   varchar2(15),
  apMatAdm   varchar2(15),
  fonoAdm    number(9)
);
 
create table empleados(
  rutEmp     varchar2(10) not null primary key,
  nombresEmp varchar2(25),
  apPatEmp   varchar2(15),
  apMatEmp   varchar2(15),
  fonoEmp    number(9),
  funcionEmp varchar2(30),
  rutAdm     varchar2(10) not null,
  constraint fk_emp_adm foreign key (rutAdm) references administrador(rutAdm)
);
 
create table clientes(
  rutCli     varchar2(10) not null primary key,
  nombresCli varchar2(25),
  apPatCli   varchar2(15),
  apMatCli   varchar2(15),
  fonoCli    number(9)
);
 
create table productos(
  codProd       varchar2(10)  not null primary key,
  nombreProd    varchar2(50),
  fechaCreaProd date,
  fechaVencProd date,
  stockProd     number(5),
  precioProd    number(10,2)
);
 
create table proveedores(
  rutProv    varchar2(10) not null primary key,
  nombreProv varchar2(50),
  fonoProv   number(9),
  emailProv  varchar2(50)
);
 
create table ventas(
  idVen    number(10)   not null primary key,
  fechaVen date,
  horaVen  varchar2(8),
  cantVen  number(5),
  totalVen number(10,2),
  rutEmp   varchar2(10) not null,
  codProd  varchar2(10) not null,
  constraint fk_ven_emp  foreign key (rutEmp)  references empleados(rutEmp),
  constraint fk_ven_prod foreign key (codProd) references productos(codProd)
);
 
create table compras(
  idCom        number(10)   not null primary key,
  metodoPagoCom varchar2(20),
  cantCom      number(5),
  costoCom     number(10,2),
  rutCli       varchar2(10) not null,
  codProd      varchar2(10) not null,
  constraint fk_com_cli  foreign key (rutCli)  references clientes(rutCli),
  constraint fk_com_prod foreign key (codProd) references productos(codProd)
);
 
create table compra_suministros(
  idSum    number(10)   not null primary key,
  rutProv  varchar2(10) not null,
  codProd  varchar2(10) not null,
  precioSum number(10,2),
  fechaSum  date,
  diasSum   number(3),
  constraint fk_sum_prov foreign key (rutProv) references proveedores(rutProv),
  constraint fk_sum_prod foreign key (codProd) references productos(codProd)
);


--inserts
insert into administrador values ('12345678-9','Ricardo','Fuentes','Mora',41234567);
insert into administrador values ('98765432-1','Patricia','Muñoz','Rojas',41298765);
insert into administrador values ('11223344-5','Jorge','Sepúlveda','Castro',41211223);
insert into administrador values ('44556677-8','Claudia','Rojas','Vega',41244556);
insert into administrador values ('77889900-2','Andrés','Valdés','Pino',41277889);
insert into administrador values ('33221100-K','Marcela','Contreras','Silva',41233221);

insert into empleados values ('15111222-3','Carlos','Pérez','Soto',41211122,'Cajero','12345678-9');
insert into empleados values ('16222333-4','Sofía','López','Díaz',41222233,'Repositora','12345678-9');
insert into empleados values ('17333444-5','Benjamín','Ramos','Araya',41233344,'Bodeguero','98765432-1');
insert into empleados values ('18444555-6','Valentina','Castro','Mora',41244455,'Cajera','98765432-1');
insert into empleados values ('19555666-7','Felipe','Morales','Vega',41255566,'Repositor','11223344-5');
insert into empleados values ('20666777-8','Gabriela','Herrera','Leal',41266677,'Cajera','44556677-8');

insert into clientes values ('10100200-1','Ana','González','Pérez',911223344);
insert into clientes values ('20200300-2','Luis','Martínez','Soto',922334455);
insert into clientes values ('30300400-3','Carmen','Díaz','Rojas',933445566);
insert into clientes values ('40400500-4','Pedro','Soto','Mora',944556677);
insert into clientes values ('50500600-5','Mónica','Vargas','Leal',955667788);
insert into clientes values ('60600700-6','Roberto','Flores','Vega',966778899);

insert into productos values ('PROD001','Arroz 1kg','10/01/2024','31/12/2026',50,1290);
insert into productos values ('PROD002','Aceite 1lt','15/02/2024','30/06/2026',30,2490);
insert into productos values ('PROD003','Leche 1lt','01/05/2025','15/06/2025',24,990);
insert into productos values ('PROD004','Fideos 500g', '20/03/2024','20/03/2027',40,890);
insert into productos values ('PROD005','Coca-Cola 1.5lt','10/04/2025','10/10/2025',36,1590);
insert into productos values ('PROD006','Pan molde 700g', '10/05/2025','17/05/2025',15,1190);
insert into productos values ('PROD007','Atún 170g', '01/06/2024','01/06/2028',60,1390);
insert into productos values ('PROD008','Detergente 1kg', '15/07/2024', '15/07/2025',20,3290);

insert into proveedores values ('76100200-3','Distribuidora Sur S.A.', 41310020,'ventas@distsur.cl');
insert into proveedores values ('76200300-4','Alimentos del Valle Ltda.',41320030,'contacto@alvalle.cl');
insert into proveedores values ('76300400-5','Bebidas Chile S.A.',       41330040,'pedidos@bebcl.cl');
insert into proveedores values ('76400500-6','Granos y Cereales Ltda.',  41340050,'info@granoscl.cl');
insert into proveedores values ('76500600-7','Limpieza Total SpA',       41350060,'ventas@limptotal.cl');
insert into proveedores values ('76600700-8','Lácteos del Bio-Bio S.A.',41360070,'pedidos@lacteosbio.cl');

insert into ventas values (1,'01/05/2025','09:15',3,3870, '15111222-3','PROD001');
insert into ventas values (2,'02/05/2025','10:30',2,4980, '15111222-3','PROD002');
insert into ventas values (3,'03/05/2025','11:00',5,4950, '18444555-6','PROD003');
insert into ventas values (4,'04/05/2025','14:20',4,3560, '18444555-6','PROD004');
insert into ventas values (5,'05/05/2025','16:45',6,9540, '20666777-8','PROD005');
insert into ventas values (6,'06/05/2025','08:50',2,2380, '15111222-3','PROD006');
insert into ventas values (7,'07/05/2025','13:10',3,4170, '20666777-8','PROD007');
insert into ventas values (8,'08/05/2025','17:30',1,3290, '18444555-6','PROD008');

insert into compras values (1,'efectivo',2,2580,'10100200-1','PROD001');
insert into compras values (2,'débito',1,2490,'20200300-2','PROD002');
insert into compras values (3,'crédito', 3,2970,'30300400-3','PROD003');
insert into compras values (4,'efectivo',4,3560,'40400500-4','PROD004');
insert into compras values (5,'transferencia',2,3180,'50500600-5','PROD005');
insert into compras values (6,'débito',1,1190,'60600700-6','PROD006');
insert into compras values (7,'efectivo',2,2780,'10100200-1','PROD007');
insert into compras values (8,'débito', 1,3290,'20200300-2','PROD008');

insert into compra_suministros values (1,'76100200-3','PROD001', 850, '20/04/2025',3);
insert into compra_suministros values (2,'76400500-6','PROD001', 820, '25/04/2025',2);
insert into compra_suministros values (3,'76200300-4','PROD002',1600, '18/04/2025',4);
insert into compra_suministros values (4,'76600700-8','PROD003', 650, '30/04/2025',1);
insert into compra_suministros values (5,'76100200-3','PROD004', 580, '22/04/2025',3);
insert into compra_suministros values (6,'76300400-5','PROD005', 980, '15/04/2025',2);
insert into compra_suministros values (7,'76200300-4','PROD006', 720, '05/05/2025',1);
insert into compra_suministros values (8,'76500600-7','PROD008',2100, '28/04/2025',5);

--alteraciones de tablas
alter table clientes add (direccionCli varchar2(100));
alter table empleados modify (funcionEmp varchar2(50));
alter table productos add (marcaProd varchar2(30));

delete from ventas where idVen = 8;
delete from compra_suministros where precioSum > 2000;

update empleados
set fonoEmp = 977889900
where rutEmp = '15111222-3';

--selects con group by (sin y con join)
select nombresCli, sum(costoCom)
from clientes c, compras co
where c.rutcli = co.rutcli
and nombrescli like 'C%'
group by nombresCli;

select  nombreProd, round(avg(cantCom), 2)
from productos p
join compras co
on p.codProd = co.codProd
where cantcom > 3
group by nombreProd;

--selects con having (con y sin join)
select nombresCli, sum(costoCom)
from clientes c, compras co
where c.rutcli = co.rutcli
having sum(costocom) < 20000
group by nombresCli;

select  nombreProd, round(avg(cantCom), 2)
from productos p
join compras co
on p.codProd = co.codProd
having avg(cantcom) < 3
group by nombreProd;




