
-- 1. INSERTAR 6 PROVEEDORES
INSERT INTO system.Proveedores VALUES ('76234567-8', 'Distribuidora Alfa', 912345678, 'alfa@gmail.com');
INSERT INTO system.Proveedores VALUES ('77345678-9', 'Comercial Beta', 923456789, 'beta@gmail.com');
INSERT INTO system.Proveedores VALUES ('78456789-0', 'Importadora Gamma', 934567890, 'gamma@gmail.com');
INSERT INTO system.Proveedores VALUES ('79567890-1', 'Proveedora Delta', 945678901, 'delta@gmail.com');
INSERT INTO system.Proveedores VALUES ('80678901-2', 'Comercial Epsilon', 956789012, 'epsilon@gmail.com');
INSERT INTO system.Proveedores VALUES ('81789012-3', 'Distribuciones Zeta', 967890123, 'zeta@gmail.com');

-- 2. INSERTAR 10 PRODUCTOS
INSERT INTO system.Productos VALUES (101, 'Teclado Logitech', 25000, '10-01-2026', 50);
INSERT INTO system.Productos VALUES (102, 'Mouse Logitech', 15000, '15-01-2026', 70);
INSERT INTO system.Productos VALUES (103, 'Monitor Samsung', 180000, '20-01-2026', 20);
INSERT INTO system.Productos VALUES (104, 'Notebook Lenovo', 550000, '25-01-2026', 15);
INSERT INTO system.Productos VALUES (105, 'Impresora HP', 120000, '05-02-2026', 25);
INSERT INTO system.Productos VALUES (106, 'Audifonos Sony', 45000, '10-02-2026', 40);
INSERT INTO system.Productos VALUES (107, 'Webcam Logitech', 60000,'15-02-2026', 30);
INSERT INTO system.Productos VALUES (108, 'Disco SSD Kingston', 75000, '20-02-2026', 35);
INSERT INTO system.Productos VALUES (109, 'Memoria RAM Kingston', 50000, '25-02-2026', 45);
INSERT INTO system.Productos VALUES (110, 'Parlante JBL', 85000, '01-03-2026', 25);

--4. INSERTAR 10 COMPRAS
INSERT INTO system.Compras VALUES (1001, '05-03-2026', 500000, 101, '76234567-8');
INSERT INTO system.Compras VALUES (1002, '06-03-2026', 300000, 102, '77345678-9');
INSERT INTO system.Compras VALUES (1003, '07-03-2026', 1800000, 103, '78456789-0');
INSERT INTO system.Compras VALUES (1004,'08-03-2026', 5500000, 104, '79567890-1');
INSERT INTO system.Compras VALUES (1005,'09-03-2026', 1200000, 105, '80678901-2');
INSERT INTO system.Compras VALUES (1006, '10-03-2026', 450000, 106, '81789012-3');
INSERT INTO system.Compras VALUES (1007, '11-03-2026', 600000, 107, '76234567-8');
INSERT INTO system.Compras VALUES (1008, '12-03-2026', 750000, 108, '77345678-9');
INSERT INTO system.Compras VALUES (1009, '13-03-2026', 500000, 109, '78456789-0');
INSERT INTO system.Compras VALUES (1010, '14-03-2026', 850000, 110, '79567890-1');

commit;

--6)	Con agrupamiento, usando una función grupal, entre dos tablas (condicionar con where y having).
select numVenta,min(precioProd)
from system.Ventas vn join SYSTEM.productos pr
on vn.codproducto=pr.codprod
where vn.fechaventa='17-03-2026'
having min(precioProd)>10000
group by numVenta;

--7)	Con agrupamiento, usando una función grupal, entre tres tablas (condicionar con having).
select nomProveedor,avg(montoCompra)
from system.productos pr join system.compras co
on pr.codprod=co.codprod
join system.proveedores pr 
on co.rutprov=pr.rutproveedor
having avg(montoCompra)>10000
group by nomProveedor


