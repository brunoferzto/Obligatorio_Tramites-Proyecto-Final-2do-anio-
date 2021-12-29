Use master
go

If exists(Select * From SysDataBases Where name='Tramites')
Begin
	Drop Database Tramites
End
go
---HICE CAMBIOS PARA QUE ANDE NO SOBRESCRIBIR 

Create Database Tramites
On(
	Name='Tramites',
	Filename='C:\Tramites.mdf'
)
go

Use Tramites	
go

create table Usuario
(
cedula int not null primary key Check (cedula > 9999999 and cedula < 100000000),
contraseña varchar(6) not null check(contraseña like '[a-zA-Z][a-zA-Z][a-zA-Z][0-9][0-9][^a-Z0-9]'),
nombre varchar(50) not null,
)
go



create table Solicitante 
(
cedula int not null primary key foreign key references Usuario (cedula),
telefono varchar (9) not null check (telefono like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') 
)
go

create table Empleado
(
cedula int not null primary key foreign key references Usuario (cedula),
horainicio time not null, 
horafin time not null 
)
go

create table Documentacion
(
doccodigo int primary key,
nombre varchar(30) not null,
lugarobtencion varchar(30) not null,
baja bit not null default(1),
)
go

create table TiposDeTramite
(
codigo varchar(9)  primary key check(codigo like '[2][0][0-9][0-9][a-zA-Z][a-zA-Z][a-zA-Z][a-zA-Z][a-zA-Z]'),
nombre varchar(30) not null,
descripcion varchar(100) not null,
precio int not null check(precio > 0),
baja bit not null default(1),
)
go

create table Contiene
(
codigo varchar(9) not null foreign key references TiposDeTramite(codigo),
doccodigo int not null foreign key references Documentacion(doccodigo),
primary key (codigo,doccodigo)
)
go



create table Solicitud
(
numero int not null identity primary key,
estado varchar(9) not null check(estado = 'Alta' or estado = 'Ejecutada' or estado = 'Anulada') default('Alta'),
fechayhora datetime not null,
cedula int not null foreign key references Solicitante (cedula),
codigo varchar(9) not null foreign key references TiposDeTramite(codigo),
)
go

create table HorasExtra
(
fecha datetime not null default(GETDATE()),
cedula int not null foreign key references Empleado (cedula),
minutos varchar(2) not null check(minutos like '[0-9][0-9]')
primary key(cedula,fecha),
)
go

USE master
GO

CREATE LOGIN [IIS APPPOOL\DefaultAppPool] FROM WINDOWS WITH DEFAULT_DATABASE = master
GO

USE Tramites
GO

CREATE USER [IIS APPPOOL\DefaultAppPool] FOR LOGIN [IIS APPPOOL\DefaultAppPool]
GO

Create proc LogueoEmpleado @ced varchar(10), @con varchar(30)
As
Begin
Select *
From Usuario inner join Empleado
on Usuario.cedula = Empleado.cedula
Where Empleado.cedula=@ced and contraseña=@con
End
go

Create proc BuscarEmpleado @ced int
As
Begin
Select *
From Empleado inner Join Usuario on Empleado.cedula = Usuario.cedula
where Empleado.cedula = @ced 
End
go

Create proc AgregarEmpleado @ced int, @con varchar(6), @nom varchar(50), @ini varchar(5), @fin varchar(5)
As
Begin
If exists (select * from Empleado where cedula = @ced)
	return -1
Else
	Begin Tran
	declare @error int
	Insert Usuario values (@ced, @con, @nom)
	set @error = @@ERROR
	Insert Empleado values (@ced, @ini, @fin)
	set @error = @@ERROR + @error
	declare @VarSentencia varchar(200) 
	set @VarSentencia='CREATE LOGIN [' +  cast(@ced as varchar(8)) + '] WITH PASSWORD = ' + QUOTENAME(@con, '''')
	exec(@VarSentencia)
	set @error = @@ERROR + @error
	set @VarSentencia='Create User [' +  cast(@ced as varchar(8)) + '] From Login [' + cast(@ced as varchar(8)) + ']'
	exec(@VarSentencia)
	set @error = @@ERROR + @error 
	If (@error = 0)
		Begin
		Commit Tran
		exec sp_addsrvrolemember @ced, 'SecurityAdmin'
		exec sp_addrolemember @rolename = rol_Empleado, @membername = @ced
		exec sp_addrolemember @rolename = db_owner, @membername = @ced
		exec sp_addrolemember @rolename = db_accessadmin, @membername = @ced
		return 1
		End
	Else
		Begin
		Rollback Tran
		return -2
		End
	End

go 


CREATE  proc ModificarEmpleado @ced int, @con varchar(6), @nom varchar(50), @ini varchar(5), @fin varchar(5)
As
Begin
If not exists (select * from Empleado where cedula = @ced)
	return -1
	Begin Transaction
	update Usuario set Usuario.nombre = @nom, Usuario.contraseña = @con where Usuario.cedula = @ced -- tenia insert
	if @@ERROR <> 0	
		begin
		rollback tran 
		return -2
		end
	Update Empleado set Empleado.horafin = @fin, Empleado.horainicio = @ini where Empleado.cedula = @ced  -- tmb
	if @@ERROR <> 0	
		begin
		rollback tran
		return -2		
		end
	commit tran
	return 1
	end 
go

Create proc EliminarEmpleado @ced int
As
Begin
If not exists (select * from Empleado where cedula = @ced)
	return -1

Begin Transaction 

Delete HorasExtra where HorasExtra.cedula =  @ced
	if (@@ERROR <> 0)
	begin
		rollback tran
		return -2
		end

Delete Empleado where empleado.cedula = @ced 
	if (@@ERROR <> 0)
	begin
		rollback tran
		return -2
		end

Delete Usuario where Usuario.cedula = @ced 
	if (@@ERROR <> 0)
	begin
		rollback tran
		return -2
		end

	Declare @VarSentenciaI varchar(200)
	Set @VarSentenciaI = 'Drop User  [' +  cast(@ced as varchar(8)) + ']'
	Exec (@VarSentenciaI)
	Delete Usuario where Usuario.cedula = @ced 
	if (@@ERROR <> 0)
	begin
		rollback tran
		return -2
		end

	Declare @VarSentencia varchar (200)
	Set @VarSentencia = 'Drop Login [' +  cast(@ced as varchar(8)) + ']'
	Exec (@VarSentencia)
	if (@@ERROR <> 0)
	begin
		rollback tran
		return -2
		end

commit tran
	return 1
	end 
go

		



Create Proc BuscarDocumentacionActiva @cod int
As
Begin
Select *
From Documentacion
Where @cod = doccodigo and baja = 1 
End
go

Create Proc BuscarDocumentacion @cod int
As
Begin
Select *
From Documentacion
Where @cod = doccodigo
End

go

Create Proc BuscarContiene @cod varchar(9)
As
Begin
Select Contiene.doccodigo
From Contiene
Where Contiene.codigo = @cod
End
go

Create Proc AgregarDocumentacion @cod int, @nom varchar(30), @lug varchar(30)
As
Begin
If exists (select * from Documentacion where @cod=doccodigo and baja = 1)
	return -1
Else if exists (select * from Documentacion where @cod=doccodigo and baja = 0)
	Begin
	Update Documentacion set doccodigo = @cod, nombre = @nom, lugarobtencion = @lug, baja = 1 where doccodigo = @cod
	return 1
	End
Else
	declare @error int
	declare @baja bit = 1
	Insert Documentacion values (@cod, @nom, @lug, @baja)
	set @error = @@ERROR
	if (@error = 0)
		return 1
	else
		return -2
End
go

Create Proc ModificarDocumentacion @cod int, @nom varchar(30), @lug varchar(30)
As
Begin
If not exists (select * from Documentacion where @cod=doccodigo and baja = 1)
	return -1
Else
	declare @error int
	Update Documentacion set nombre = @nom, lugarobtencion = @lug, baja = 1 WHERE Documentacion.doccodigo = @cod -- no tenia where cambia todo
	set @error = @@ERROR
	if (@error = 0)
		return 1
	else
		return -2
End
go

Create Proc EliminarDocumentacion @cod int
As
Begin
If not exists (select * from Documentacion where @cod=doccodigo and baja = 1)
	return -1
Else if exists (select * from Contiene where @cod=doccodigo)
	Begin
	Update Documentacion set baja=0 where @cod=doccodigo
	return 1
	End
Else
	declare @error int
	Delete Documentacion where doccodigo = @cod
	set @error = @@ERROR
	if (@error = 0)
		return 1
	else
		return -2
End
go

Create Proc BuscarTipoDeTramiteActivo @cod varchar(9)
As
Begin
Select *
From TiposDeTramite
Where @cod = codigo and baja = 1
End
go

Create Proc AgregarTipoDeTramite @cod varchar(9), @nom varchar(30), @des varchar(100), @pre int
As
Begin
If exists (select * from TiposDeTramite where codigo = @cod and baja = 1)
	return - 1
If exists (select * from TiposDeTramite where codigo = @cod and baja = 0)
	Begin
	Update TiposDeTramite set codigo = @cod, nombre = @nom, descripcion = @des, precio = @pre, baja = 1 where codigo = @cod
	return 1
	End
Else
	declare @error int
	declare @baja bit =1
	Insert TiposDeTramite values (@cod, @nom, @des, @pre, @baja)
	set @error = @@ERROR
	if (@error = 0)
		return 1
	else
		return -2
End
go

Create Proc ModificarTipoDeTramite @cod varchar(9), @nom varchar(30), @des varchar(100), @pre int
As
Begin
If not exists (select * from TiposDeTramite where codigo = @cod and baja = 1)
	return - 1
Else
	declare @error int
	Update TiposDeTramite set codigo = @cod, nombre = @nom, descripcion = @des, precio = @pre, baja = 1 where codigo = @cod
	set @error = @@ERROR
	if (@error = 0)
		return 1
	else
		return -2
End
go


go
Create Proc EliminarTipoDeTramite @cod varchar(9)
As
Begin
If not exists (select * from TiposDeTramite where codigo = @cod and baja = 1)
	return -1
Else if exists (select * from Contiene where codigo = @cod)
	Begin -- Se cambio TiposDeTramite x Documentacion. <-- daba error de conversion ahí. 
	Update TiposDeTramite set baja=0 where  TiposDeTramite.codigo=@cod  
	return 1
	End
Else
	declare @error int
	Delete TiposDeTramite where codigo = @cod
	set @error = @@ERROR
	if (@error = 0)
		return 1
	else
		return -2
End
go


Create Proc AltaContiene @cod varchar(9), @doccod int
As
Begin
If not exists (select * from TiposDeTramite where TiposDeTramite.codigo = @cod and baja = 1)
	return -1
if not exists (select * from Documentacion where Documentacion.doccodigo = @doccod and baja = 1)
	return -2
if exists (select * from Contiene where Contiene.codigo = @cod and Contiene.doccodigo = @doccod)
	return -3

	declare @error int
	Insert Contiene values (@cod, @doccod)
	set @error = @@ERROR
	if (@error = 0)
	begin
		return 1
		end
	else
		return -4
End
go


Create Proc BajaContiene @cod varchar(9)
As
Begin
Delete From Contiene where codigo=@cod
If @@ERROR = 0
	return 1
else
	return -1
End
go

Create Proc ListarSolicitudes
As
Begin
Select *
From Solicitud
End
go

Create Proc ListarSolicitudesAlta
As
Begin
Select *
From Solicitud
Where estado = 'Alta'
End
go

Create Proc CambiarEstadoSolicitud @num int, @est varchar(9)
As
Begin
If not exists (select * from Solicitud where @num = numero)
	return -1
Else if (@est != 'Alta' and @est != 'Ejecutada' and @est != 'Anulada')
	return -2
declare @error int
Update Solicitud set estado = @est where numero = @num
set @error = @@ERROR
if (@error = 0)
	return 1
else
	return -3
End
go

Create Proc ListarDocumentacion
As
Begin
Select *
From Documentacion
End
go

Create Proc ListarTiposDeTramites
As
Begin
Select *
From TiposDeTramite -- estaba en plural :P
Where baja = 1
End
go

Create Proc BuscarTipoDeTramite @cod varchar(9)
As
Begin
Select *
From TiposDeTramite
Where @cod = codigo
End
go

Create proc BuscarSolicitante @ced int
As
Begin
Select *
From Solicitante inner join Usuario on Solicitante.cedula = Usuario.cedula
Where Solicitante.cedula = @ced
End
go

Create Proc AgregarSolicitante @ced int, @con varchar(6), @nom varchar(50), @tel varchar(9)
As
Begin
If exists (select * from Usuario where cedula = @ced)
	return -1
Else
	Begin Tran
	declare @error int
	Insert Usuario values (@ced, @con, @nom)
	set @error = @@ERROR
	Insert Solicitante values (@ced, @tel)
	set @error = @@ERROR + @error
	declare @VarSentencia varchar(200)
	set @VarSentencia='CREATE LOGIN ['+  cast(@ced as varchar(8)) + '] WITH PASSWORD = ' + QUOTENAME(@con, '''')
	exec(@VarSentencia)
	set @error = @@ERROR + @error
	set @VarSentencia='Create User [' +  cast(@ced as varchar(8)) + '] From Login [' + cast(@ced as varchar(8)) + ']'
	exec(@VarSentencia)
	set @error = @@ERROR + @error
	If (@error = 0)
		Begin
		Commit Tran
		exec sp_addrolemember @rolename = rol_Solicitante, @membername = @ced
		return 1
		End
	Else
		Begin
		Rollback Tran
		return -2
		End
	End
go


Create Proc LogueoSolicitante @ced int, @con varchar(6)
As
Begin
Select *
From Usuario inner join Solicitante
on Usuario.cedula = Solicitante.cedula
Where Solicitante.cedula=@ced and Usuario.contraseña = @con
End
go

Create Proc AgregarSolicitud @fec datetime, @ced int, @cod varchar(9)
As
Begin
If not exists (select * from Solicitante where @ced=cedula)
	return -1
If not exists (select * from TiposdeTramite where @cod=codigo and TiposDeTramite.baja = 1)
	return -2
Else
	declare @error int
	Insert Solicitud (cedula, codigo, fechayhora)
	values (@ced, @cod, @fec)
	set @error = @@ERROR
	if (@error = 0)
		return 1
	else
		return -3
End
go

Create proc AgregarHorasExtra @fec datetime, @ced int, @min varchar(2)
As
Begin
If exists (select * from HorasExtra where @fec = fecha and @ced = cedula)
BEGIN
	declare @error int
	Update HorasExtra set minutos = @min where @fec = fecha and @ced = cedula
	set @error = @@ERROR
	if (@error = 0)
		return 1
	else
		return -2
		END
		
Else if not exists (select * from Empleado where @ced = cedula)
	return -1
Else
	declare @errorr int
	Insert HorasExtra values (@fec, @ced, @min)
	set @error = @@ERROR
	if (@error = 0)
		return 1
	else
		return -2
End
go

GRANT Execute on [LogueoEmpleado] to [IIS APPPOOL\DefaultAppPool]
GRANT Execute on [LogueoSolicitante] to [IIS APPPOOL\DefaultAppPool]
GRANT Execute on [ListarSolicitudes] to [IIS APPPOOL\DefaultAppPool]
GRANT Execute on [ListarSolicitudesAlta] to [IIS APPPOOL\DefaultAppPool]
GRANT Execute on [ListarTiposDeTramites] to [IIS APPPOOL\DefaultAppPool]
GRANT Execute on [AgregarSolicitante] to [IIS APPPOOL\DefaultAppPool]
go 

Create role rol_Solicitante
go
grant execute on [AgregarSolicitud] to rol_Solicitante
go

Create role rol_Empleado
go

exec master..sp_addsrvrolemember [IIS APPPOOL\DefaultAppPool], 'SecurityAdmin'
go
USE Tramites
go

grant execute on [BuscarEmpleado] to rol_Empleado
grant execute on [AgregarEmpleado] to rol_Empleado
grant execute on [ModificarEmpleado] to rol_Empleado
grant execute on [EliminarEmpleado] to rol_Empleado
grant execute on [BuscarDocumentacion] to rol_Empleado
grant execute on [BuscarDocumentacionActiva] to rol_Solicitante----------
grant execute on [BuscarDocumentacionActiva] to rol_Empleado ----------
grant execute on [AgregarDocumentacion] to rol_Empleado
grant execute on [ModificarDocumentacion] to rol_Empleado
grant execute on [EliminarDocumentacion] to rol_Empleado
grant execute on [BuscarTipoDeTramiteActivo] to rol_Empleado
grant execute on [AgregarTipoDeTramite] to rol_Empleado
grant execute on [ModificarTipoDeTramite] to rol_Empleado
grant execute on [EliminarTipoDeTramite] to rol_Empleado
grant execute on [CambiarEstadoSolicitud] to rol_Empleado
grant execute on [BuscarTipoDeTramite] to rol_Empleado
grant execute on [AgregarHorasExtra] to rol_Empleado
grant execute on [ListarDocumentacion] to rol_Empleado
grant execute on [AltaContiene] to rol_Empleado
grant execute on [BajaContiene] to rol_Empleado
grant execute on [BuscarContiene] to rol_Solicitante  ---------------
grant execute on [BuscarContiene] to rol_Empleado -----------------
grant Execute on [BuscarSolicitante] to rol_Empleado 
go



Exec AgregarEmpleado 54709590,'fJV07_','Borja','08:00','16:00'
Exec AgregarEmpleado 32371133,'DrY41]','Mateo','08:00','16:00'
Exec AgregarEmpleado 41316025,'Skv34]','Marcos','08:00','16:00'
Exec AgregarEmpleado 57491629,'sLZ72"','Fernando','08:30','16:30'
Exec AgregarEmpleado 57642847,'QnA92}','Ibai','08:30','16:30'
Exec AgregarEmpleado 52428736,'iEK48%','Silvia','12:00','20:00'
Exec AgregarEmpleado 49963029,'DQy55>','Raquel','12:00','20:00'
Exec AgregarEmpleado 57559140,'oSm18)','Eva','12:00','20:00'
Exec AgregarEmpleado 61982747,'neN62~','Aitor','12:00','20:00'
Exec AgregarEmpleado 51538634,'xfD37@','Juan','18:30','02:30'
Exec AgregarEmpleado 45763525,'dOE89(','Sara','18:30','02:30'
Exec AgregarEmpleado 49935635,'kuz93.','Paula','18:30','02:30'
Exec AgregarEmpleado 56138815,'mfB57.','Elena','22:00','06:00'
Exec AgregarEmpleado 59294087,'dMa35-','Laura','22:00','06:00'
Exec AgregarEmpleado 33820051,'kNR10$','Iker','22:00','06:00'


Exec AgregarDocumentacion 548917,'Certificacion','Hospital/Clinica'
Exec AgregarDocumentacion 877538,'Constancia Medica','Hospital/Clinica'
Exec AgregarDocumentacion 767153,'Servicio','N/A'
Exec AgregarDocumentacion 875666,'Constancia de Domicilio','Seccional Policial'
Exec AgregarDocumentacion 220769,'Cedula de Identidad','Registro Civil'
Exec AgregarDocumentacion 753407,'Partida de Nacimiento','Registro Civil' 
Exec AgregarDocumentacion 990797,'Carnet','Hospital/Clinica'
Exec AgregarDocumentacion 652817,'Pasaporte','Registro Civil'
Exec AgregarDocumentacion 460677,'Licencia de Conducir','Intendencia'
Exec AgregarDocumentacion 611666,'Recibos de sueldo','n/a'
Exec AgregarDocumentacion 835090,'Terreno','Escribano'
Exec AgregarDocumentacion 460677,'Acta de Divorcio','Registro Civil'
Exec AgregarDocumentacion 627487,'Diploma','Univeridad/Instituto'

Execute AgregarTipoDeTramite '2019ymvgp','Venta de Pasajes','Viaje al exterior',35000
Execute AgregarTipoDeTramite '2001ztahs','Solicitar Tarjeta','Solicitar Tarjeta de Crédito',1200
Execute AgregarTipoDeTramite '2018azazs','Jubilación','Tramitar Jubilación',280 
Execute AgregarTipoDeTramite '2018auYhK','Instalacion Cable','Instalacion Cable TV',3200

Exec AgregarTipoDeTramite '2002ebdaa','T5','n/a',1
Exec AgregarTipoDeTramite '2003ipqmb','T6','n/a',1
Exec AgregarTipoDeTramite '2004ehvfs','T7','n/a',1
Exec AgregarTipoDeTramite '2005jmtnc','T8','n/a',1
Exec AgregarTipoDeTramite '2006xoynj','T9','n/a',1
Exec AgregarTipoDeTramite '2007blgyb','T10','n/a',1
Exec AgregarTipoDeTramite '2008yuemu','T11','n/a',1
Exec AgregarTipoDeTramite '2009oaorh','T12T','n/a',1
Exec AgregarTipoDeTramite '2010xgstd','T13','n/a',1
Exec AgregarTipoDeTramite '2011aglzi','T14','n/a',1
Exec AgregarTipoDeTramite '2012jvwap','T15','n/a',1
Exec AgregarTipoDeTramite '2013xhetq','T16','n/a',1
Exec AgregarTipoDeTramite '2014lwdtw','T17','n/a',1

Execute AltaContiene '2018auYhK',767153
Execute AltaContiene '2018auYhK',875666
Execute AltaContiene '2018auYhK',220769

Execute AltaContiene '2018azazs',220769
Execute AltaContiene '2018azazs',753407
Execute AltaContiene '2018azazs',611666

Execute AltaContiene '2019ymvgp',220769 
Execute AltaContiene '2019ymvgp',877538 
Execute AltaContiene '2019ymvgp',652817 


EXECUTE AltaContiene '2001ztahs',875666 
EXECUTE AltaContiene '2001ztahs',220769 
EXECUTE AltaContiene '2001ztahs',611666 




Exec AgregarSolicitante 58420839,'XdP82)','Natalia','095739657'
Exec AgregarSolicitante 23861902,'TeF48,','Kepa','095472925'
Exec AgregarSolicitante 35285675,'ZiI98$','Javier','095401634'
Exec AgregarSolicitante 59013380,'Lhf79:','Brian','095349970'
Exec AgregarSolicitante 41351951,'Hnv06^','Yessica','095391078'
Exec AgregarSolicitante 57895744,'ASN37~','Jannet','095795197'
Exec AgregarSolicitante 58306003,'IXw15>','Rodrigo','095563635'
Exec AgregarSolicitante 57895744,'xOM21>','Sebastian','098182363'
Exec AgregarSolicitante 46556612,'OQJ88*','Christian','098415873'
Exec AgregarSolicitante 49308316,'bkW52+','Facundo','098667675'
Exec AgregarSolicitante 40202363,'JOo79{','Lucas','098423119'
Exec AgregarSolicitante 42687139,'sTT30[','Giovanna','098036690'
Exec AgregarSolicitante 46090888,'eno65_','Albert','098465260'
Exec AgregarSolicitante 58525174,'Shk77!','Alejandro','098839436'
Exec AgregarSolicitante 56584864,'YVd99-','Mariana','098106977'

Exec AgregarSolicitud '20191212 07:35',42687139,'2018auYhK'
Exec AgregarSolicitud '20200110 20:20',42687139,'2019ymvgp'
Exec AgregarSolicitud '20200303 12:30',23861902,'2018azazs'
Exec AgregarSolicitud '20190213 10:30',58420839,'2001ztahs'
Exec AgregarSolicitud '20200303 11:45',57895744,'2018auYhK'


--Exec AgregarSolicitud '15032019',23861902,'2001ztahs' <-- Si se agregan estos poner la fecha como los de arriba 
--Exec AgregarSolicitud '04032019',35285675,'2002ebdaa'
--Exec AgregarSolicitud '24032019',59013380,'2003ipqmb'
--Exec AgregarSolicitud '30042019',41351951,'2004ehvfs'
--Exec AgregarSolicitud '11/06/2019',57895744,'2005jmtnc'
--Exec AgregarSolicitud '01/02/2019',58306003,'2006xoynj'
--Exec AgregarSolicitud '12/03/2019',46556612,'2007blgyb'
--Exec AgregarSolicitud '08/05/2019',58306003,'2008yuemu'
--Exec AgregarSolicitud '02/03/2019',49308316,'2009oaorh'
--Exec AgregarSolicitud '14/02/2019',49308316,'2010xgstd'
--Exec AgregarSolicitud '30/12/2019',49308316,'2011aglzi'
--Exec AgregarSolicitud '05/12/2019',40202363,'2012jvwap'
--Exec AgregarSolicitud '09/03/2019',46090888,'2013xhetq'
--Exec AgregarSolicitud '23/11/2019',58525174,'2014lwdtw'


