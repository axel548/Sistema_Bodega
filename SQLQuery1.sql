use master
go
use Bodega
go
declare @noprest varchar(15)
select @noprest = no_prest from Prestamo_Estudiante
declare @id_es int
select @id_es = id_esPr from Prestamo_Estudiante where id_esPr = RIGHT(@noprest,4)

declare @fecprest date
select @fecprest = Fec_prest from est_pres_est where id_EsPre = @id_es
declare @fecdev date 
select @fecdev = Fec_dev from est_pres_est where id_EsPre = @id_es

declare @codigo varchar(6)
select @codigo = codigo from Prestamo_Estudiante where no_prest = @noprest
declare @nombre varchar(15)
select @nombre = nombre from Prestamo_Estudiante where no_prest = @noprest
declare @carne varchar(15)
select @carne = Carne from Prestamo_Estudiante where no_prest = @noprest
declare @cant int
select @cant = cantidad from Prestamo_Estudiante where no_prest = @noprest
declare @estado_cod varchar(20) 
select @estado_cod = estado_cod from Prestamo_Estudiante where no_prest = @noprest

if (select datediff(day, @fecprest, getdate())) >=7
begin
	
end
else if (select datediff(day, @fecprest, getdate())) < 7
begin

end

