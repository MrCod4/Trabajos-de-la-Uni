--Crear select con:
--2)	Usando 2 tablas con like (sin agrupar)
select nomCliEmpresa,fechaVenta
from system.Clientes cl join system.Ventas vn
on cl.rutCliEmpresa=vn.rutCliente 
where nomCliEmpresa like 'E%';
--5)	Usando 2 tablas con una función grupal (max, min, avg, sum o count)  (sin agrupar)
select avg(montoCompra)
from system.compras co join system.proveedores pr
on co.rutprov=pr.rutproveedor;

--Crear subconsultas con:
--8)	El nombre de cliente con mayor venta.
select nomcliempresa
from system.clientes
where rutcliempresa = (
select rutcliente
from system.ventas
where montoventa = (
select max(montoventa)
from system.ventas));

--9)	El fono del proveedor con menor compra.
select fonoproveedor
from system.proveedores
where rutproveedor = (
select rutprov
from system.compras
where montocompra = (
select min(montocompra)
from system.compras));

--10)	Nombres de clientes a quienes se ha vendido más de 2 veces.
select nomcliempresa
from system.clientes
where rutcliempresa in (
select rutcliente
from system.ventas
where (select count(montoventa) from system.ventas) > 2);

--11)	Email de proveedores a quienes se les ha comprado menos de 3 veces.
select emailproveedor
from system.proveedores
where rutproveedor in (
select rutprov
from system.compras
where (select count(montocompra) from system.compras) < 3);
