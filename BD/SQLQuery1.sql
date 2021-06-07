Create Database Bodega_0
on
(Name= Bodeaga_Data,
Filename = 'F:\IES 6.5\Bodeaga_Data.mdf',
Size=15MB,
Maxsize =200MB,
Filegrowth=20%
),
(Name= Bodega_Sec,
Filename = 'F:\IES 6.5\Bodega_Sec.ndf',
Size= 10MB,
Maxsize = 80MB,
Filegrowth= 2MB
)
log on
(Name= Bodega_Log,
Filename = 'F:\IES 6.5\Bodega_Log.ldf',
Size= 10MB,
Maxsize = 70MB,
Filegrowth= 5MB
)
go
/*CREACIÓN DE LA BD BODEGA*/
use master
if exists(select * from sysdatabases where name='Bodega')
	begin
	drop database Bodega 
	create database Bodega
	end
else
	begin 
	create database Bodega
	end
go

use bodega

select CONVERT(varchar(10), GETDATE() + 1,120)