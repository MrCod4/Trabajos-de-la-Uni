-- 3. INSERTAR 4 CLIENTES
INSERT INTO system.Clientes VALUES ('12345678-5', 'Empresa ABC Ltda', 912345679, 'abc@gmail.com');
INSERT INTO system.Clientes VALUES ('13456789-6', 'Empresa XYZ Ltda', 923456780, 'xyz@gmail.com');
INSERT INTO system.Clientes VALUES ('14567890-7', 'Comercial Norte', 934567891, 'norte@gmail.com');
INSERT INTO system.Clientes VALUES ('15678901-8', 'Comercial Sur', 945678902, 'sur@gmail.com');

-- 5. INSERTAR 10 VENTAS
INSERT INTO system.Ventas VALUES (2001, '15-03-2026', 25000, 101, '12345678-5');
INSERT INTO system.Ventas VALUES (2002, '16-03-2026', 30000, 102, '13456789-6');
INSERT INTO system.Ventas VALUES (2003, '17-03-2026', 180000, 103, '14567890-7');
INSERT INTO system.Ventas VALUES (2004, '18-03-2026', 550000, 104, '15678901-8');
INSERT INTO system.Ventas VALUES (2005, '19-03-2026', 120000, 105, '12345678-5');
INSERT INTO system.Ventas VALUES (2006, '20-03-2026', 45000, 106, '13456789-6');
INSERT INTO system.Ventas VALUES (2007, '21-03-2026', 60000, 107, '14567890-7');
INSERT INTO system.Ventas VALUES (2008, '22-03-2026', 75000, 108, '15678901-8');

commit;

--3)	Usando 3 tablas con between (sin agrupar)
select nomCliEmpresa, nomProd
from system.Clientes cl join system.Ventas vn
on cl.rutCliEmpresa=vn.rutCliente
join system.productos pr 
on vn.codproducto=pr.codprod
where vn.fechaventa between '17-03-2026' and '21-03-2026';

--4)	Usando 3 tablas con operadores relacionales (>,>=,<,<=,<>,=) (sin agrupar)
select nomCliEmpresa, nomProd
from system.Clientes cl join system.Ventas vn
on cl.rutCliEmpresa=vn.rutCliente
join system.productos pr 
on vn.codproducto=pr.codprod
where vn.montoventa >= 60000;

