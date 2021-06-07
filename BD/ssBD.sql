  use master
go
use bodega
go

/*USUARIOS*/				/*YA*/
create table usuarios(
	id_usr int identity(1,1) primary key,
	nombre varchar(50) not null,
	apellido varchar(50) not null,
	email varchar(100) not null,
	usr varchar(50) unique not null /*collate Latin1_General_100_CS_AS_SC*/, 
	passw varchar(50) not null /*collate Latin1_General_100_CS_AS_SC*/,
	tip_usr varchar(50) not null,
)
go
/*Verificación por login*/
begin
declare  @usr varchar(50)
declare	 @pass varchar(50)
end
go
insert into usuarios values('xael','lopez','axel.aatl@gmail.com','xael','zjen@kayss','Administrador');
insert into usuarios values('Janice','Quevedo','quevedojanice@gmail.com','Janice','janice@123$','Estándar');
go


/*INVENTARIO-Ac*/				/*YA*/
create table Pre_invAc(
	id_PI int identity(1,1) primary key,
	cant int,
	prec_unit decimal(18,2),
	total decimal(18,2)
)
go
create table estado_invAc(
	id_esti int identity(1,1) primary key,
	estado varchar(20),
	sub_est varchar(20),
	obser varchar(100),
	categoría varchar(30),
	sub_cat varchar(30)
)
go
create table inventarioAc(
	codigo varchar(6) primary key,
	nombre varchar(50),
	imagen varbinary(max),
	id_pi int,
	id_est int,
	foreign key(id_pi) references Pre_invAc(id_PI),
	foreign key(id_est) references estado_invAc(id_esti)
)
go
/*INVENTARIO-Re*/				
create table Pre_invRe(
	id_PI int identity(1,1) primary key,
	cant int,
	prec_unit decimal(18,2),
	total decimal(18,2)
)
go
create table estado_invRe(
	id_esti int identity(1,1) primary key,
	estado varchar(20),
	sub_est varchar(20),
	obser varchar(100),
	categoría varchar(30),
	sub_cat varchar(30)
)
go
create table inventarioRe(
	codigo varchar(6) primary key,
	nombre varchar(50),
	imagen varbinary(max),
	id_pi int,
	id_est int,
	foreign key(id_pi) references Pre_invRe(id_PI),
	foreign key(id_est) references estado_invRe(id_esti)
)
go
/*INVENTARIO-ME*/				/*YA*/
create table Pre_invME(
	id_PI int identity(1,1) primary key,
	cant int,
	prec_unit decimal(18,2),
	total decimal(18,2)
)
go
create table estado_invME(
	id_esti int identity(1,1) primary key,
	estado varchar(20),
	sub_est varchar(20),
	obser varchar(100),
	categoría varchar(30),
	sub_cat varchar(30),
	reporte int /*if reporte=0: without report, elseif reporte=1:with report*/
)
go
create table inventarioME(
	codigo varchar(6) primary key,
	nombre varchar(50),
	imagen varbinary(max),
	id_pi int,
	id_est int,
	foreign key(id_pi) references Pre_invME(id_PI) on delete cascade,
	foreign key(id_est) references estado_invME(id_esti) on delete cascade 
)
go

/*PROFESOR*/				/*YA*/				
create table profesor(
	dpi varchar(15) primary  key,
	nombre varchar(50),
	apellido varchar(50),
	especialdiad varchar(30)
)
go

/*ESTUDIANTE*/				/*YA*/
create table estudiante(
	carne varchar(15) primary key,
	nombre varchar(50),
	apellido varchar(50),
	especialidad varchar(50),
	grado varchar(10),
	seccion varchar(5)
)
go

/*PRESTAMO PARA ESTUDIANTES*/				/*YA*/
create table est_pres_est(
	id_EsPre int identity(1,1) primary key,
	estado_pres varchar(20),
	Fec_prest date,
	Fec_dev date,
	obser_pr varchar(100)
)
go
create table Prestamo_Estudiante(
	no_prest  varchar(15) primary key,
	codigo varchar(6),
	articulo varchar(50),
	Carne varchar(15),
	nombre varchar(50),
	profeautoriza varchar(20),
	id_esPr int,
	cantidad int,
	estado_cod varchar(20),
	foreign key(id_esPr) references est_pres_est(id_EsPre) on delete cascade
)				/*YA*/
go

/*PRESTAMO PARA PROFESORES*/
create table est_pres_pro(
	id_EsPre int identity(1,1) primary key,
	estado_pres varchar(20),
	Fec_prest date,
	Fec_dev date,
	obser_pr varchar(100)
)				/*YA*/
go
create table Prestamo_Profesor(
	no_prest  varchar(15) primary key,
	codigo varchar(6),
	articulo varchar(50),
	dpi varchar(15),
	nombre varchar(50),
	id_esPr int,
	cantidad int,
	estado_cod varchar(20),
	foreign key(id_esPr) references est_pres_pro(id_EsPre)on delete cascade
)				/*YA*/
go
/*PRESTAMOS EXPIRADOS*/
create table PRESTAMOEXPIRADO(
	no_prest  varchar(15) primary key,
	codigo varchar(6),
	articulo varchar(50),
	dpi varchar(15),
	cantidad int,
	estado_cod varchar(20),
	estado_pres varchar(20),
	Fec_prest date,
	Fec_dev date,
	obser_pr varchar(100)
)				/*YA*/
go
/*PRESTAMO ANUAL*/
create table estadoAnual(
	id_EA int identity(1,1) primary key,
	estado_pres varchar(20),
	Fec_prest date,
	Fec_dev date,
	obser_pr varchar(100)
)
go
create table PrestamoAnual(
	no_prest  varchar(15) not null,
	codigo varchar(6),
	articulo varchar(50),
	dpi varchar(15),
	id_EA int,
	cantidad int,
	estado_cod varchar(20),
	foreign key(id_EA) references estadoAnual(id_EA) on delete cascade
)				/*YA*/
go

/*PERDIDA Y REPARACIÓN*/
create table lose_fix(
	no_LF varchar(15) primary key,
	no_prest varchar(15),
	codigo varchar(6),
	articulo varchar(50),
	codigoPersona varchar(15),
	nombre varchar(50),
	cobro_lf decimal(18,2),
	cantidad int,
	total decimal(18,2),
	estado varchar(20),
	tipo varchar(10),
	categoría varchar(10)
)				/*YA*/
go

/*Correo Eletronico*/
create table CorreoElectronico(
	id int identity(1,1) primary key,
	email varchar(50) not null,
	passw varchar(30) not null
)
go
insert into CorreoElectronico values('xaello57@gmail.com','Em123axel')
go
/*Historial-Prestamos*/
create table Historial_Prestamos(
no_prest varchar(15),
codigo varchar(6),
cantidad int,
CodigoPersona varchar(15),
fechInser datetime,
fechdevo datetime
)
go
/*Historial-Inventario*/
create table Historial_Inven(
codigo varchar(6),
nombre varchar(50),
precio decimal(18,2),
categoria varchar(30),
subcat varchar(30),
estado varchar(20),
fechInser datetime,
fechElim datetime
)
go

/*
truncate table Historial_Prestamos
dream on-aerosmith
zombie - cramberries
metallica - unforgiven
led zepellin - stairway to heaven
gun's - estranged
*/


