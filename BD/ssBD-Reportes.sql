use master
go
use bodega
go
--/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*--------------------------------------------------------Reportes----------------------------------------------------------*/
go
/*Reporte Prestamo Estudiante*/
create PROC REPORTPresEstudiante/*ya*/
	@carne varchar(15),
	@fechprest date
	as
	begin
	/*Prestamo Estudiante*/
	SELECT * FROM View_PrestamoEStud WHERE Carne = @carne and Fec_prest =@fechprest
	end	
go
/*Reporte Prestamo Profesor*/
create PROC REPORTPresProfesor
	@dpi varchar(15),
	@fechprest date 
	as
	begin
	/*Prestamo Profesor*/
	SELECT * FROM View_PrestamoPRo WHERE dpi = @dpi and Fec_prest= @fechprest
	end
go
/*Reporte Inventario*/
create PROC REPORTInventario
	@categoria varchar(20),
	@subcat varchar(20),
	@tipo varchar(12)
	as
	if @tipo = 'Activo'
	begin	
		SELECT * FROM View_InerAc where categoría = @categoria or sub_cat = @subcat
	end
	else if @tipo = 'Reserva'
	begin
		SELECT * FROM View_InerRe where categoría = @categoria or sub_cat = @subcat
	end
	else if @tipo = 'Mal Estado'
	begin 
		SELECT * FROM View_InerME where categoría = @categoria or sub_cat = @subcat
	end
go
/*Reporte AnualInstructor*/
create proc REPORTAnualInstructor/*si funciona*/
	@no_prest varchar(15),
	@dpi varchar(15),
	@fechprest date 
	as
	begin
	/*Prestamo Profesor*/
	SELECT * FROM View_PrestamoAnual WHERE dpi = @dpi and no_prest = @fechprest
	end
go
/*Reportes de Historiales */
create Proc REPORTHistorial_Inventario/*ya*/
	@fecha_inicial as date,
	@fecha_final as date
	as 
	begin
	select * from Historial_Inven where fechInser >= @fecha_inicial and fechInser <= @fecha_final
	end
go
create Proc REPORTHistorial_Prestamos/*ya*/
	@fecha_inicial as date,
	@fecha_final as date
	as 
	begin
	select * from Historial_Prestamos where fechInser >= @fecha_inicial and fechInser <= @fecha_final
	end
go
/*Reportes de Solvencias */
create Proc REPORTESolvenciaEstudiante/*ya*/
	@carne varchar(15)
	as 
	begin
	select * from View_Solven_Estudiante where carne = @carne
	end
	
go
create Proc REPORTESolvenciaProfesor/*ya*/
	@dpi varchar(15)
	as 
	begin
	select * from View_Solven_Profesor where dpi = @dpi
	end



go
create Proc REPORTELoseFix/*ya*/
	@noLF varchar(15)
	as 
	begin
	select * from lose_fix where no_LF = @noLF
	end
go
create Proc REPORTEPrestamoExpirado/*ya*/
	@expirado varchar(15)
	as 
	begin
	select * from PRESTAMOEXPIRADO where no_prest = @expirado	
	end
go
create Proc REPORTEInvenMalEstado/*ya*/
	@codigo varchar(15)
	as 
	begin
	select * from View_InerME where codigo = @codigo	
	end
go
