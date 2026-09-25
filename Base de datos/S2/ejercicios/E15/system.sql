create table Clientes(
rutCliEmpresa varchar2(10) not null primary key,
nomCliempresa varchar2(25),
fonoCliEmpresa number(9),
emailCliEmpresa varchar2(30)
);
create table Productos(
codprod number(3) not null primary key, 
nomProd varchar2(25),
precioProd number(7),
fechFabrProd date,
stockProd number(3)
);
create table Proveedores(
rutProveedor varchar2(10) not null primary key,
nomProveedor varchar2(25),
fonoProveedor number(9),
emailProveedor varchar2(30)
);
create table Ventas(
numVenta number(4)not null primary key,
fechaVenta date,
montoVenta number(7),
codProducto number(3)not null references Productos(codprod),
rutCliente  varchar2(10)not null references Clientes(rutCliEmpresa)
);
create table Compras(
numCompra number(4)not null primary key,
fechaCompra date,
montoCompra number(7),
codprod  number(3)not null references Productos(codprod),
rutProv varchar2(10)not null references Proveedores(rutProveedor) 
);

--Creacion de roles y usuarios
--Rol y usuario de Compras
create user usuario_compras identified by "123";
create role ROL_COMPRAS;
grant select, insert, update, delete on compras to ROL_COMPRAS;
grant select, insert, update, delete on proveedores to ROL_COMPRAS;
grant select, insert, update, delete on productos to ROL_COMPRAS;
grant select on ventas to ROL_COMPRAS;
grant connect to usuario_compras;
grant ROL_COMPRAS to usuario_compras;
--Rol y usuario de Ventas
create user usuario_ventas identified by "123";
create role ROL_VENTAS;
grant select, insert, update, delete on ventas to ROL_VENTAS;
grant select, insert, update, delete on clientes to ROL_VENTAS;
grant select on productos to ROL_VENTAS;
grant connect to usuario_ventas;
grant ROL_VENTAS to usuario_ventas;

--Rol y usuario de Finanzas
create user usuario_finanzas identified by "123";
create role ROL_FINANZAS;
grant select on compras to ROL_FINANZAS;
grant select on ventas to ROL_FINANZAS;
grant select on clientes to ROL_FINANZAS;
grant select on proveedores to ROL_FINANZAS;
grant connect to usuario_finanzas;
grant ROL_FINANZAS to usuario_finanzas;




