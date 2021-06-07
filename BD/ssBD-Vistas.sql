use master
go
use bodega
go
--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*------------------------------------------------------VISTAS---------------------------------------------------------------*/
go
/*inventario-Ac*/
create view View_InerAc
as
select inventarioAc.codigo, inventarioAc.nombre, inventarioAc.imagen, estado_invAc.estado, estado_invAc.sub_est,
estado_invAc.obser, estado_invAc.categoría, estado_invAc.sub_cat, 
Pre_invAc.cant, Pre_invAc.prec_unit, Pre_invAc.total  
from ((inventarioAc
inner join estado_invAc on inventarioAc.id_est = estado_invAc.id_esti) 
inner join Pre_invAc on inventarioAc.id_pi = Pre_invAc.id_PI);
go
/*inventario-Re*/
create view View_InerRe
as
select inventarioRe.codigo, inventarioRe.nombre, inventarioRe.imagen, estado_invRe.estado, estado_invRe.sub_est,
estado_invRe.obser, estado_invRe.categoría, estado_invRe.sub_cat, 
Pre_invRe.cant, Pre_invRe.prec_unit, Pre_invRe.total  
from ((inventarioRe
inner join estado_invRe on inventarioRe.id_est = estado_invRe.id_esti) 
inner join Pre_invRe on inventarioRe.id_pi = Pre_invRe.id_PI);
go
/*inventario-ME*/
create view View_InerME
as
select inventarioME.codigo, inventarioME.nombre, inventarioME.imagen, estado_invME.estado, estado_invME.sub_est,
estado_invME.obser, estado_invME.categoría, estado_invME.sub_cat, 
Pre_invME.cant, Pre_invME.prec_unit, Pre_invME.total  
from ((inventarioME
inner join estado_invME on inventarioME.id_est = estado_invME.id_esti) 
inner join Pre_invME on inventarioME.id_pi = Pre_invME.id_PI);
go
/*Prestamos*/
create view View_PrestamoEStud
as
select Prestamo_Estudiante.no_prest,
		Prestamo_Estudiante.cantidad,
		Prestamo_Estudiante.codigo,
		Prestamo_Estudiante.id_esPr,
		Prestamo_Estudiante.Carne,
		Prestamo_Estudiante.articulo,
		Prestamo_Estudiante.profeautoriza,

	   estudiante.nombre, estudiante.apellido,
	   estudiante.especialidad, estudiante.grado, estudiante.seccion,

	   est_pres_est.estado_pres, est_pres_est.Fec_prest,
	   est_pres_est.Fec_dev, est_pres_est.obser_pr
from 
	(((Prestamo_Estudiante left join inventarioAc on Prestamo_Estudiante.codigo = inventarioAc.codigo)
		left join estudiante on Prestamo_Estudiante.carne = estudiante.carne)
		left join est_pres_est on Prestamo_Estudiante.id_esPr = est_pres_est.id_EsPre);
go
create view View_PrestamoPRo
as
select Prestamo_Profesor.no_prest,
		Prestamo_Profesor.cantidad,
		Prestamo_Profesor.codigo,
		Prestamo_Profesor.id_esPr,
		Prestamo_Profesor.dpi,
		Prestamo_Profesor.articulo,

	   profesor.nombre, profesor.apellido,

	   est_pres_pro.estado_pres, est_pres_pro.Fec_prest,
	   est_pres_pro.Fec_dev, est_pres_pro.obser_pr
from 
	(((Prestamo_Profesor left join inventarioAc on Prestamo_Profesor.codigo = inventarioAc.codigo)
		left join profesor on Prestamo_Profesor.dpi = profesor.dpi)
		left join est_pres_pro on Prestamo_Profesor.id_esPr = est_pres_pro.id_EsPre);
go
/*Solvencias*/
go
create view View_Solven_Profesor
as	
select profesor.dpi, profesor.nombre, profesor.apellido, (select count(*) from Prestamo_Profesor where dpi = profesor.dpi) as conteo
from profesor
go
create view View_Solven_Estudiante
as	
select estudiante.carne, estudiante.nombre, estudiante.apellido, 
		estudiante.especialidad, estudiante.grado, estudiante.seccion,
(select count(*) from Prestamo_Estudiante where Carne = estudiante.carne) as conteo
from estudiante
go
/*Prestamos Anuales*/
create view View_PrestamoAnual
as
select PrestamoAnual.no_prest,
		PrestamoAnual.cantidad,
		PrestamoAnual.codigo,
		PrestamoAnual.id_EA,
		PrestamoAnual.dpi,
		PrestamoAnual.articulo,

	   profesor.nombre, profesor.apellido,

	   estadoAnual.estado_pres, estadoAnual.Fec_prest,
	   estadoAnual.Fec_dev, estadoAnual.obser_pr
from 
	(((PrestamoAnual left join inventarioAc on PrestamoAnual.codigo = inventarioAc.codigo)
		left join profesor on PrestamoAnual.dpi = profesor.dpi)
		left join estadoAnual on PrestamoAnual.id_EA = estadoAnual.id_EA);
go







