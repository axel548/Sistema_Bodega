use master
go
use bodega
go
--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*-------------------------------------------PROCEDIMIENTOS DE ALMACENAMIENTO------------------------------------------------*/
go
/*Inventario-Ac*/
create proc ADDInvAc
	@codigo varchar(6),
	@nombre varchar(20),
	@imagen varbinary(max),

	@estado varchar(20),
	@subestado varchar(20),
	@obser varchar(100),
	@categoria varchar(30),
	@sub_cat varchar(30),

	@cant int,
	@precuni decimal(18,2),
	@total decimal(18,2)
	as
	begin
	insert into inventarioAc(codigo,nombre, imagen) values(@codigo,@nombre, @imagen)
	insert into estado_invAc values(@estado, @subestado,@obser, @categoria, @sub_cat)
	insert into Pre_invAc values(@cant, @precuni, @total)
	insert into Historial_Inven(codigo,nombre,precio,categoria,subcat,estado,fechInser) values(@codigo,@nombre,@precuni, @categoria,@sub_cat,@estado,GETDATE())
	end
go
create proc UPDATEInvAc
	@codigo varchar(6),
	@nombre varchar(20),
	@imagen varbinary(max),
	@estado varchar(20),
	@subestado varchar(20),
	@obser varchar(100),
	@categoria varchar(30),
	@sub_cat varchar(30),
	@cant int,
	@precuni decimal(18,2),
	@total decimal(18,2)
	as
	begin	
	update inventarioAc set nombre = @nombre, imagen = @imagen where codigo = @codigo
	update Pre_invAc set cant = @cant, prec_unit = @precuni, total = @total where id_PI = RIGHT(@codigo,4)
	update estado_invAc set estado = @estado, sub_est = @subestado ,obser = @obser, categoría = @categoria, sub_cat = @sub_cat where id_esti = RIGHT(@codigo,4)
	end		  /*Ya*/
go
/*Inventario_Re*/
create proc ADDInvRe
	@codigo varchar(6),
	@nombre varchar(20),
	@imagen varbinary(max),

	@estado varchar(20),
	@subestado varchar(20),
	@obser varchar(100),
	@categoria varchar(30),
	@sub_cat varchar(30),

	@cant int,
	@precuni decimal(18,2),
	@total decimal(18,2)
	as
	begin
	insert into inventarioRe(codigo,nombre, imagen) values(@codigo,@nombre, @imagen)
	insert into estado_invRe values(@estado, @subestado,@obser, @categoria, @sub_cat)
	insert into Pre_invRe values(@cant, @precuni, @total)
	insert into Historial_Inven(codigo,nombre,precio,categoria,subcat,estado,fechInser) values(@codigo,@nombre,@precuni, @categoria,@sub_cat,@estado,GETDATE())
	end
go
create proc UPDATEInvRe 
	@codigo varchar(6),
	@nombre varchar(20),
	@imagen varbinary(max),
	@estado varchar(20),
	@subestado varchar(20),
	@obser varchar(100),
	@categoria varchar(30),
	@sub_cat varchar(30),
	@cant int,
	@precuni decimal(18,2),
	@total decimal(18,2)
	as
	begin	
	update inventarioRe set nombre = @nombre, imagen = @imagen where codigo = @codigo
	update Pre_invRe set cant = @cant, prec_unit = @precuni, total = @total where id_PI = RIGHT(@codigo,4)
	update estado_invRe set estado = @estado, sub_est = @subestado ,obser = @obser, categoría = @categoria, sub_cat = @sub_cat where id_esti = RIGHT(@codigo,4)
	end		  /*Ya*/
go
/*Inventario-ME*/
create proc ADDInvME
	@codigo varchar(6),
	@nombre varchar(20),
	@imagen varbinary(max),

	@estado varchar(20),
	@subestado varchar(20),
	@obser varchar(100),
	@categoria varchar(30),
	@sub_cat varchar(30),

	@cant int,
	@precuni decimal(18,2),
	@total decimal(18,2)
	as
	begin
	insert into inventarioME(codigo,nombre, imagen) values(@codigo,@nombre, @imagen)
	insert into estado_invME(estado,sub_est,obser,categoría,sub_cat) values(@estado, @subestado,@obser, @categoria, @sub_cat)
	insert into Pre_invME values(@cant, @precuni, @total)
	insert into Historial_Inven(codigo,nombre,precio,categoria,subcat,estado,fechInser) values(@codigo,@nombre,@precuni, @categoria,@sub_cat,@estado,GETDATE())
	end
go
create proc UPDATEInvME 
	@codigo varchar(6)
	as
	begin	
	delete from Pre_invME where id_PI = RIGHT(@codigo,4)
	delete from estado_invME where id_esti = RIGHT(@codigo,4)
	end		  /*Ya*/
go
/*Estudiante*/
create proc ADDEstudiante
	@carne varchar(15),
	@nombre varchar(50),
	@apellido varchar(50),
	@especialidad varchar(50),
	@grado varchar(10),
	@seccion varchar(5)
	as
	if not exists(select carne from estudiante where carne = @carne)
	begin
		insert into estudiante values(@carne,@nombre,@apellido,@especialidad,@grado,@seccion)
	end
	else if exists(select carne from estudiante where carne = @carne)
	begin
		print 'ya existe'
	end
go
create proc UPDATEEstudiante
	@carne varchar(15),
	@nombre varchar(50),
	@apellido varchar(50),
	@especialidad varchar(50),
	@grado varchar(10),
	@seccion varchar(5)
	as
	begin
		update estudiante set nombre =@nombre , apellido =@apellido ,especialidad= @especialidad, grado =@grado, seccion = @seccion where carne = @carne
	end
go
/*Profesor*/
create proc ADDProfesor
	@dpi varchar(15),
	@nombre varchar(50),
	@apellido varchar(50),
	@especialidad varchar(50)
	as
	if not exists(select dpi from profesor where dpi = @dpi)
	begin
		insert into profesor values(@dpi,@nombre,@apellido,@especialidad)
	end
		else if exists(select dpi from profesor where dpi = @dpi)
	begin
		print 'ya existe'
	end
go
create proc UPDATEProfesor
	@dpi varchar(15),
	@nombre varchar(50),
	@apellido varchar(50),
	@especialidad varchar(50)
	as
	begin
		update profesor set nombre = @nombre, apellido = @apellido, especialdiad = @especialidad where dpi = @dpi
	end

go
/*Prestamos Estudiante*/
create proc ADDPrestamoEstudiante
	@noprest varchar(15),
	@codigo varchar(6),
	@articculo varchar(50),
	@nombre varchar(50),
	@carne varchar(15),
	@profeautoriza varchar(20),
	@cantidad int,
	@estado_cod varchar(20),

	@estado_pres varchar(20),
	@fec_prest date,
	@fec_dev date,
	@obser_pr varchar(100)
	as	
	declare @cant int
	select @cant = cant from Pre_invAc where id_PI = RIGHT(@codigo,4)
	declare @cant2 int 
	select @cant2 = cant from Pre_invRe where id_PI = RIGHT(@codigo,4)

	if @cantidad <= @cant or @cantidad <= @cant2
	begin
		if @estado_cod = 'Activo'
		begin
			if	exists(select codigo from inventarioAc where codigo = @codigo)
			begin
				if exists(select carne from estudiante where carne=@carne)	
				begin
					insert into Prestamo_Estudiante(no_prest, codigo, articulo, Carne, nombre,profeautoriza,cantidad,estado_cod) values(@noprest, @codigo, @articculo, @carne, @nombre, @profeautoriza, @cantidad,@estado_cod)
					insert into est_pres_est values(@estado_pres, @fec_prest, @fec_dev, @obser_pr)
				end
			end
		end
		else if @estado_cod = 'Reserva'
		begin 
			if	exists(select codigo from inventarioRe where codigo = @codigo)
			begin
				if exists(select carne from estudiante where carne=@carne)	
				begin
					insert into Prestamo_Estudiante(no_prest, codigo, articulo, Carne, nombre,profeautoriza,cantidad,estado_cod) values(@noprest, @codigo, @articculo, @carne, @nombre,@profeautoriza,@cantidad,@estado_cod)
					insert into est_pres_est values(@estado_pres, @fec_prest, @fec_dev,@obser_pr)
				end
			end
		end
	end
go
/*Prestamo Profesor*/
create proc ADDPrestamoProfesor
	@noprest varchar(15),
	@codigo varchar(6),
	@articulo varchar(50),
	@dpi varchar(15),
	@nombre varchar(50),
	@cantidad int,
	@estado_cod varchar(20),

	@estado_pres varchar(20),
	@fec_prest date,
	@fec_dev date,
	@obser_pr varchar(100)
	as
	declare @cant int
	select @cant = cant from Pre_invAc where id_PI = RIGHT(@codigo,4)
	declare @cant2 int
	select @cant2 = cant from Pre_invRe where id_PI = RIGHT(@codigo,4)

	if @cantidad <= @cant or @cantidad <= @cant2
	begin
		if @estado_cod = 'Activo'
		begin
			if	exists(select codigo from inventarioAc where codigo = @codigo)
			begin
				if exists(select dpi from profesor where dpi=@dpi)	
				begin
					insert into Prestamo_Profesor(no_prest,codigo, articulo, dpi, nombre, cantidad,estado_cod) values(@noprest, @codigo, @articulo, @dpi,@nombre,@cantidad,@estado_cod)
					insert into est_pres_pro values(@estado_pres, @fec_prest, @fec_dev,@obser_pr)
				end
			end
		end
		else if @estado_cod ='Reserva'
		begin
			if	exists(select codigo from inventarioRe where codigo = @codigo)
			begin
				if exists(select dpi from profesor where dpi=@dpi)	
				begin
					insert into Prestamo_Profesor(no_prest,codigo, articulo, dpi, nombre, cantidad,estado_cod) values(@noprest, @codigo, @articulo, @dpi,@nombre,@cantidad,@estado_cod)
					insert into est_pres_pro values(@estado_pres, @fec_prest, @fec_dev,@obser_pr)
				end
			end
		end
	end 
go
/*Prestamo Actualización Pro-Est*/
create proc UpdateDevolucionEstudiante
	@noprest varchar(15),
	@estado_pres varchar(20),
	@codigo varchar(6),
	@fec_dev date,
	@persona varchar(10),
	@tipo varchar(8)
	as
	declare @cantdev int
	select @cantdev = cantidad from Historial_Prestamos where no_prest = @noprest

	if @estado_pres = 'Devolución' 
	begin
		if @tipo = 'Activo'
		begin
			if @persona = 'Estudiante'
			begin
				update Pre_invAc set cant += @cantdev where id_PI = RIGHT(@codigo,4)
				update Historial_Prestamos set fechdevo = @fec_dev where no_prest = @noprest
				delete from est_pres_est where id_EsPre = RIGHT(@noprest,4)
			end
			else if @persona = 'Profesor'
			begin
				update Pre_invAc set cant += @cantdev where id_PI = RIGHT(@codigo,4)
				update Historial_Prestamos set fechdevo = @fec_dev where no_prest = @noprest
				delete from est_pres_pro where id_EsPre = RIGHT(@noprest,4)
			end
		end
		if @tipo = 'Reserva'
		begin
			if @persona = 'Estudiante'
			begin
				update Pre_invRe set cant += @cantdev where id_PI = RIGHT(@codigo,4)
				update Historial_Prestamos set fechdevo = @fec_dev where no_prest = @noprest
				delete from est_pres_est where id_EsPre = RIGHT(@noprest,4)
			end
			else if @persona = 'Profesor'
			begin
				update Pre_invRe set cant += @cantdev where id_PI = RIGHT(@codigo,4)
				update Historial_Prestamos set fechdevo = @fec_dev where no_prest = @noprest
				delete from est_pres_pro where id_EsPre = RIGHT(@noprest,4)
			end
		end
	end
go
create proc UpdateReparacionEstudiante
	@noprest varchar(15),
	@no_LF varchar(15),
	@estado_pres varchar(20),
	@codigo varchar(6),
	@articulo varchar(50),
	@fec_dev date,
	@cantFL int,
	@cantDev int,
	@carne varchar(15),
	@nombre varchar(50),
	@total decimal(18,2),
	@persona varchar(10),
	@tipo varchar(8)
	as
	declare @cobro_lfAc decimal(18,2)
	select @cobro_lfAc = prec_unit from Pre_invAc where(id_PI = RIGHT(@codigo,4))
	declare @cobro_lfRe decimal(18,2)
	select @cobro_lfRe = prec_unit from Pre_invRe where(id_PI = RIGHT(@codigo,4))


	if @persona ='Estudiante'
	begin
		if @estado_pres = 'Reparación' 
	begin
		if @tipo = 'Activo'
		begin
			update Pre_invAc set cant += @cantDev where id_PI = RIGHT(@codigo,4)
			insert into lose_fix values(@no_LF, @noprest, @codigo,@articulo,@carne,@nombre,@cobro_lfAc, @cantFL, @total,'Activo', 'Reparación', @persona)
			delete from est_pres_est where id_EsPre = RIGHT(@noprest,4)
		end
		if @tipo = 'Reserva'
		begin
			update Pre_invRe set cant += @cantDev where id_PI = RIGHT(@codigo,4)
			insert into lose_fix values(@no_LF, @noprest, @codigo,@articulo,@carne,@nombre,@cobro_lfRe, @cantFL, @total,'Reserva', 'Reparación', @persona)
			delete from est_pres_est where id_EsPre = RIGHT(@noprest,4)
		end
	end
	else if @estado_pres = 'Perdida' 
	begin
		if @tipo = 'Activo'
		begin
			update Pre_invAc set cant += @cantDev where id_PI = RIGHT(@codigo,4)
			insert into lose_fix values(@no_LF, @noprest, @codigo,@articulo,@carne,@nombre,@cobro_lfAc, @cantFL, @total,'Activo', 'Perdida', @persona)
			delete from est_pres_est where id_EsPre = RIGHT(@noprest,4)
		end
		if @tipo = 'Reserva'
		begin
			update Pre_invRe set cant += @cantDev where id_PI = RIGHT(@codigo,4)
			insert into lose_fix values(@no_LF, @noprest, @codigo,@articulo,@carne,@nombre,@cobro_lfRe, @cantFL, @total,'Reserva', 'Perdida', @persona)
			delete from est_pres_est where id_EsPre = RIGHT(@noprest,4)
		end
	end
	end
	else if @persona = 'Profesor'
	begin
		if @estado_pres = 'Reparación' 
	begin
		if @tipo = 'Activo'
		begin
			update Pre_invAc set cant += @cantDev where id_PI = RIGHT(@codigo,4)
			insert into lose_fix values(@no_LF, @noprest, @codigo,@articulo,@carne,@nombre,@cobro_lfAc, @cantFL, @total,'Activo', 'Reparación', @persona)
			delete from est_pres_pro where id_EsPre = RIGHT(@noprest,4)
		end
		if @tipo = 'Reserva'
		begin
			update Pre_invRe set cant += @cantDev where id_PI = RIGHT(@codigo,4)
			insert into lose_fix values(@no_LF, @noprest, @codigo,@articulo,@carne,@nombre,@cobro_lfRe, @cantFL, @total,'Reserva', 'Reparación', @persona)
			delete from est_pres_pro where id_EsPre = RIGHT(@noprest,4)
		end
	end
	else if @estado_pres = 'Perdida' 
	begin
		if @tipo = 'Activo'
		begin
			update Pre_invAc set cant += @cantDev where id_PI = RIGHT(@codigo,4)
			insert into lose_fix values(@no_LF, @noprest, @codigo,@articulo,@carne,@nombre,@cobro_lfAc, @cantFL, @total,'Activo', 'Perdida', @persona)
			delete from est_pres_pro where id_EsPre = RIGHT(@noprest,4)
		end
		if @tipo = 'Reserva'
		begin
			update Pre_invRe set cant += @cantDev where id_PI = RIGHT(@codigo,4)
			insert into lose_fix values(@no_LF, @noprest, @codigo,@articulo,@carne,@nombre,@cobro_lfRe, @cantFL, @total,'Reserva', 'Perdida', @persona)
			delete from est_pres_pro where id_EsPre = RIGHT(@noprest,4)
		end
	end
	end
go
/*Correo Electrónico*/
create proc UPDATEce
	@id	int,
	@email varchar(50),
	@passw varchar(30)
	as 
	begin
		update CorreoElectronico set email = @email , passw = @passw where id = @id
	end
go

create proc SolvePro
as 
declare @dpi varchar(15)
select @dpi = dpi from profesor
declare @conteo int
select @conteo =dpi from Prestamo_Profesor where (dpi = @dpi)
begin
select dpi, nombre, apellido, conteo=@conteo from profesor 
end
go

create proc SolveEst
as 
declare @carne varchar(15)
select @carne = carne from estudiante
declare @conteo int
select @conteo =carne from Prestamo_Estudiante where (Carne = @carne)
begin
select carne, nombre, apellido, especialidad, grado, seccion, conteo=@conteo from estudiante 
end
go

create proc UPDATEReportME
@codigo varchar(6),
@report int
as
update estado_invME set reporte = @report where id_esti = RIGHT(@codigo, 4)
