create table losclientes(
rutCliente varchar2(10) not null primary key,
apPatCliente varchar2(20),
apMatCliente varchar2(20),
nombresCliente varchar2(30),
telefonoCliente varchar2(9)
);

create table mascotas(
codigoMascota varchar2(5) not null primary key,
nombreMascota varchar2(20),
especie varchar2(20),
raza varchar2(30),
fechaNacimiento date,
rutCliente varchar2(10) not null references losclientes
);

create table veterinarios(
rutVeterinario varchar2(10) not null primary key,
apPatVeterinario varchar2(20),
apMatVeterinario varchar2(20),
nombresVeterinario varchar2(30),
especialidad varchar2(30)
);

create table medicamentos(
codigoMedicamento varchar2(5) not null primary key,
nombreMedicamento varchar2(40),
laboratorio varchar2(30),
precio number(8),
stock number(5)
);


create table lasatenciones(
codigoAtencion varchar2(5) not null primary key,
fecha date,
costo number(8),
diagnostico varchar2(100),
codigoMascota varchar2(5) not null references mascotas,
rutVeterinario varchar2(10) not null references veterinarios
);

create table recetas(
codigoReceta varchar2(5) not null primary key,
dosis varchar2(30),
cantidad number(4),
codigoAtencion varchar2(5) not null references lasatenciones,
codigoMedicamento varchar2(5) not null references medicamentos
);


insert into losclientes values('11111111-1','Gonzalez','Perez','Carlos','912345678');
insert into losclientes values('12222222-2','Martinez','Rojas','Andrea','923456789');
insert into losclientes values('13333333-3','Soto','Muñoz','Felipe','934567890');
insert into losclientes values('14444444-4','Ramirez','Silva','Camila','945678901');
insert into losclientes values('15555555-5','Torres','Castro','Daniela','956789012');

insert into mascotas values('M001','Toby','Perro','Labrador','15/3/2020','11111111-1');
insert into mascotas values('M002','Luna','Gato','Siames','20/7/2021','12222222-2');
insert into mascotas values('M003','Rocky','Perro','Pastor Aleman','10/1/2019','13333333-3');
insert into mascotas values('M004','Mia','Gato','Persa','5/9/2022','14444444-4');
insert into mascotas values('M005','Max','Perro','Beagle','12/11/2020','15555555-5');

insert into veterinarios values('16666666-6','Fernandez','Diaz','Marcelo','Cirugia');
insert into veterinarios values('17777777-7','Contreras','Vega','Paula','Dermatologia');
insert into veterinarios values('18888888-8','Morales','Reyes','Javier','Medicina General');
insert into veterinarios values('19999999-9','Sepulveda','Rojas','Carolina','Traumatologia');
insert into veterinarios values('20000000-0','Navarro','Fuentes','Rodrigo','Cardiologia');

insert into medicamentos values('MED01','Amoxicilina','VetPharma',8500,30);
insert into medicamentos values('MED02','Meloxicam','AnimalMed',6200,45);
insert into medicamentos values('MED03','Cefalexina','VetChile',9900,25);
insert into medicamentos values('MED04','Prednisona','PetLab',7500,50);
insert into medicamentos values('MED05','Enrofloxacino','BioVet',11500,20);

insert into lasatenciones values('A001','10/4/2026',25000,'Infeccion respiratoria','M001','16666666-6');
insert into lasatenciones values('A002','15/4/2026',18000,'Dermatitis alergica','M002','17777777-7');
insert into lasatenciones values('A003','22/4/2026',22000,'Control general','M003','18888888-8');
insert into lasatenciones values('A004','5/5/2026',35000,'Lesion en pata trasera','M004','19999999-9');
insert into lasatenciones values('A005','12/5/2026',30000,'Control cardiaco','M005','20000000-0');

insert into recetas values('R001','1 cada 12 horas',10,'A001','MED01');
insert into recetas values('R002','1 cada 24 horas',5,'A002','MED04');
insert into recetas values('R003','1 cada 12 horas',8,'A003','MED03');
insert into recetas values('R004','1 cada 24 horas',7,'A004','MED02');
insert into recetas values('R005','1 cada 12 horas',10,'A005','MED05');

--Ejercicios

--1.	Mostrar el nombre de cada mascota junto con los nombres y apellido paterno de su dueño. 
select nombremascota, nombrescliente, appatcliente
from losclientes c, mascotas m
where c.rutcliente = m.rutcliente;

--2.	Mostrar el código de atención, fecha, diagnóstico y nombre de la mascota que recibió la atención.
select codigoatencion, fecha, diagnostico, nombremascota
from lasatenciones a, mascotas m
where a.codigomascota = m.codigomascota;

--3.	Mostrar el código de receta, dosis, cantidad y nombre del medicamento recetado. 
select codigoreceta, dosis, cantidad, nombremedicamento
from recetas r, medicamentos m
where r.codigomedicamento = m.codigomedicamento;

--4.	Mostrar el nombre de la mascota, el nombre de su dueño y la fecha de cada atención recibida.
select nombremascota, nombrescliente, fecha
from lasatenciones a, mascotas m, losclientes c
where c.rutcliente = m.rutcliente and m.codigomascota = a.codigomascota;

--5.	Mostrar el nombre de la mascota, el diagnóstico de la atención y el nombre del veterinario que la atendió.
select nombremascota, diagnostico, nombresveterinario
from mascotas m, lasatenciones a, veterinarios v
where m.codigomascota = a.codigomascota and a.rutveterinario = v.rutveterinario;

--6.	Mostrar el código de atención, el diagnóstico, el nombre del medicamento recetado y la dosis indicada.
select a.codigoatencion, diagnostico, nombremedicamento, dosis
from lasatenciones a, recetas r, medicamentos m
where a.codigoatencion = r.codigoatencion and r.codigomedicamento = m.codigomedicamento;

--7.	Mostrar el nombre del cliente, el nombre de su mascota, la fecha de atención y el nombre del veterinario que realizó la atención. 
select nombrescliente, nombremascota, fecha, nombresveterinario
from lasatenciones a, mascotas m, losclientes c, veterinarios v
where  c.rutcliente = m.rutcliente and m.codigomascota = a.codigomascota and  a.rutveterinario = v.rutveterinario;

--8.	Mostrar el nombre de la mascota, su especie, el diagnóstico, el medicamento recetado y la dosis.
select nombremascota, especie, dosis, cantidad, diagnostico
from lasatenciones a, mascotas m, recetas r, medicamentos med 
where m.codigomascota = a.codigomascota and  r.codigoatencion = a.codigoatencion and r.codigomedicamento = med.codigomedicamento;
