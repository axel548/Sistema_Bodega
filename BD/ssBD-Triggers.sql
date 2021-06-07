use master
go
use bodega
go
--//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*----------------------------------------------------TRIGGERS---------------------------------------------------------------*/
go
/*inventario-Ac*/
go
CREATE trigger TR_EstadoInsertadoAc on estado_invAc for insert
as
set nocount on 
declare @id_estado int 
select @id_estado = id_esti from inserted
update inventarioAc set id_est= @id_estado where RIGHT(codigo,4) = @id_estado	/*Ya*/
go
CREATE trigger TR_PrecioInsertadoAc on Pre_invAc for insert
as
set nocount on
declare @id_precio int 
select @id_precio = id_PI from inserted
update inventarioAc set id_pi= @id_precio where RIGHT(codigo,4) = @id_precio  /*Ya*/
go
/*inventario-Re*/
go
CREATE trigger TR_EstadoInsertadoRe on estado_invRe for insert
as
set nocount on 
declare @id_estado int 
select @id_estado = id_esti from inserted
update inventarioRe set id_est= @id_estado where RIGHT(codigo,4) = @id_estado	/*Ya*/
go
CREATE trigger TR_PrecioInsertadoRe on Pre_invRe for insert
as
set nocount on
declare @id_precio int 
select @id_precio = id_PI from inserted
update inventarioRe set id_pi= @id_precio where RIGHT(codigo,4) = @id_precio  /*Ya*/
go
/*inventario-ME*/
go
CREATE trigger TR_EstadoInsertadoME on estado_invME for insert
as
set nocount on 
declare @id_estado int 
select @id_estado = id_esti from inserted
update inventarioME set id_est= @id_estado where RIGHT(codigo,4) = @id_estado	/*Ya*/
go
CREATE trigger TR_PrecioInsertadoME on Pre_invME for insert
as
set nocount on
declare @id_precio int 
select @id_precio = id_PI from inserted
update inventarioME set id_pi= @id_precio where RIGHT(codigo,4) = @id_precio  /*Ya*/
go
/*prestamo*/
create trigger TR_EstPrestEstInsertado on est_pres_est for insert
as
set nocount on 
declare @id_estado int 
select @id_estado = id_EsPre from inserted
update Prestamo_Estudiante set id_esPr= @id_estado where RIGHT(no_prest, 4) = @id_estado	 /*Ya*/
go
CREATE trigger TR_EstPrestProInsertado on est_pres_pro for insert
as
set nocount on 
declare @id_estado int 
select @id_estado = id_EsPre from inserted
update Prestamo_Profesor set id_esPr= @id_estado where RIGHT(no_prest,4)= @id_estado	 /*Ya*/
go
/*Resta de Inventario*/
create trigger TR_RestCantidadEst on Prestamo_estudiante for insert
as
set nocount on 
declare @cant int
select @cant = cantidad from inserted 
declare @codigo varchar(6)
select @codigo = right(codigo,4) from inserted
declare @estado varchar(20)
select @estado = estado_cod from inserted
if @estado = 'Activo'
begin
update Pre_invAc set Pre_invAc.cant = Pre_invAc.cant - @cant from inserted where Pre_invAc.id_PI = @codigo
end
else if @estado = 'Reserva'
begin
update Pre_invRe set Pre_invRe.cant = Pre_invRe.cant - @cant from inserted where Pre_invRe.id_PI =@codigo
end
go
create trigger TR_RestCantidadPro on Prestamo_Profesor for insert
as
set nocount on 
declare @cant int
select @cant = cantidad from inserted
declare @codigo varchar(6)
select @codigo = right(codigo,4) from inserted 
declare @estado varchar(20)
select @estado = estado_cod from inserted
if @estado = 'Activo'
begin
update Pre_invAc set Pre_invAc.cant =  Pre_invAc.cant - @cant from inserted where Pre_invAc.id_Pi=@codigo
end
else if @estado = 'Reserva'
begin
update Pre_invRe set Pre_invRe.cant =  Pre_invRe.cant - @cant from inserted where Pre_invRe.id_Pi=@codigo 
end
go
/*Historial-Prestamos*/
create trigger TR_HistorialEst on Prestamo_Estudiante for insert
as
set nocount on
declare @noprest varchar(15)
select @noprest = no_prest from inserted
declare @cantidad int
select @cantidad = cantidad from inserted
declare @carne varchar(15)
select @carne = carne from inserted
declare @codigo varchar(6)
select @codigo = codigo from inserted

insert into Historial_Prestamos(no_prest,codigo,cantidad,CodigoPersona,fechInser) 
values(@noprest,@codigo,@cantidad,@carne,GETDATE())
go
create trigger TR_HistorialPro on Prestamo_Profesor for insert
as
set nocount on
declare @noprest varchar(15)
select @noprest = no_prest from inserted
declare @cantidad int
select @cantidad = cantidad from inserted
declare @dpi varchar(15)
select @dpi = dpi from inserted
declare @codigo varchar(6)
select @codigo = codigo from inserted

insert into Historial_Prestamos(no_prest,codigo,cantidad,CodigoPersona,fechInser) 
values(@noprest,@codigo,@cantidad,@dpi,GETDATE())
go

