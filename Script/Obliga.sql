use master
go

if exists(Select * FROM SysDataBases WHERE name='BiosLearningDB')
BEGIN
	DROP DATABASE BiosLearningDB
END
go

--creo la base de datos---------------------------------------------------------------------
CREATE DATABASE BiosLearningDB
ON(
	NAME=BiosLearningDB,
	FILENAME='C:\BD\BiosLearningDB.mdf'
)
go

USE BiosLearningDB
go

Create Table Sucursales 
(
Nombre varchar (40) primary key, 
Direccion varchar (20) not null, 
Estado bit not null default (1)
)
go


Create Table Facilidades
(
Facilidad varchar (30) not null,
Sucursal varchar (40) foreign key references Sucursales (Nombre) not null, 
primary key (sucursal,Facilidad) 
)
go


Create Table Empleados
(
Usuario varchar(10)  primary key check(Len(Usuario) = 10 ), 
Contraseña varchar (20) not null,
Estado bit not null default 1
)
go



Create Table Cursos
(
Nombre varchar (40) not null, 
Costo int not null check (Costo >= 0 ),
Codigo varchar (5) primary key check(Codigo like '[A-Z][A-Z][A-Z][0-9][0-9]' ),
FechaInicio date not null,
Cupos int not null check(Cupos > 0 ), 
Sucursal varchar (40) foreign key references Sucursales (Nombre) not null, 
Empleado varchar (10) foreign key references Empleados (Usuario)  not null 
)
go



Create Table CurCorto
(
Codigo varchar(5)primary key foreign key references Cursos (Codigo) not null, 
Area varchar(12) not null  check (Area = 'Programación' or Area = 'Diseño' or Area = 'Economía')
)
go


Create Table CurEspecializado
(
Codigo varchar(5)primary key foreign key references Cursos (Codigo) not null, 
Duracion int not null check (Duracion > 0)
)
go


Create Table Alumnos
(
Cedula int primary key check (Cedula > 0), 
Nombre varchar (20) not null,
Telefono int check (Telefono > 0) , 
)
go


Create Table Inscripcion
(
FechaInscripcion datetime not null Default GetDate(),
Codigo varchar(5) foreign key references Cursos (Codigo) not null, 
Alumno int foreign key references Alumnos (Cedula) not null, 
primary key (Codigo, Alumno)
)
go

select * from Empleados


-----------------------------------------------------
INSERT INTO Empleados (Usuario,Contraseña) VALUES ('Usuario001','Usuario1')
insert into Empleados (Usuario,Contraseña) values ('Usuario002','Usuario2')
insert into Empleados (Usuario,Contraseña) values ('Usuario003','Usuario3')
insert into Empleados (Usuario,Contraseña) values ('Usuario004','Usuario4')
insert into Empleados (Usuario,Contraseña) Values ('Usuario005', 'Usuario5')

 Insert into Sucursales (Nombre,Direccion) values ('Escuela de Diseño', 'Bvar. España 2472')
 Insert into Sucursales (Nombre,Direccion) values ('Escuela de Sistemas', '18 de julio 1253')
 Insert into Sucursales (Nombre,Direccion) values ('Escuela de Economia y Finanzas', 'Rivera 1936')

insert into Facilidades values ('Ascensor','Escuela de Diseño')
insert into Facilidades values ('Cafetería','Escuela de Diseño')
insert into Facilidades values ('Aire Acondicionado','Escuela de Diseño')

insert into Facilidades values ('Wifi','Escuela de Sistemas')
insert into Facilidades values ('Escalera Mecanica','Escuela de Sistemas')
insert into Facilidades values ('Aire Acondicionado','Escuela de Sistemas')

 INSERT INTO Cursos VALUES ('Analista de Sistemas', 80000, 'AAA01','20/03/2020',50,'Escuela de Sistemas','Usuario001')
 INSERT INTO CurEspecializado VALUES ('AAA01', 70)

 INSERT INTO Cursos VALUES ('ProgramadorWeb.Net', 30000,'AAA02','10/10/2019',80,'Escuela de Sistemas','Usuario002')
 INSERT INTO CurCorto VALUES ('AAA02','Programación')

 INSERT INTO Cursos VALUES ('Analista en Infraestructura', 15000, 'AAA03','10/9/2019',50,'Escuela de Sistemas','Usuario001')
INSERT INTO CurEspecializado VALUES ('AAA03', 30)


INSERT INTO Cursos VALUES ('Analista en Contabilidad', 50000, 'BBB01', '10/10/2019', 50, 'Escuela de Economia y Finanzas', 'Usuario003')
INSERT INTO CurCorto VALUES('BBB01', 'Economía')

INSERT INTO Cursos VALUES ('Técnico en Contabilidad', 80000, 'BBB02', '01/10/2019', 40, 'Escuela de Economia y Finanzas', 'Usuario003')
INSERT INTO CurEspecializado VALUES ('BBB02', 30)

INSERT INTO Cursos VALUES ('Analista en Finanzas e Inversiones', 25000,'BBB03', '25/09/2019', 40,'Escuela de Economia y Finanzas', 'Usuario003')
INSERT INTO CurCorto VALUES ('BBB03', 'Economía')


INSERT INTO CURSOS VALUES('Animacion 3D', 80000,'CCC01','10/8/2019',100,'Escuela de Diseño','Usuario004')
INSERT INTO CurEspecializado VALUES ('CCC01',30)

INSERT INTO Cursos VALUES ('Programador de VideoJuegos',80000, 'CCC02', '19/08/2019',100,'Escuela de Diseño','Usuario002')
INSERT INTO CurEspecializado VALUES ('CCC02', 30)

INSERT INTO Cursos VALUES ('Fotografia Digital',40000,'CCC03','13/03/2020',100,'Escuela de Diseño','Usuario004')
INSERT INTO CurCorto VALUES ('CCC03', 'Diseño')

INSERT INTO Cursos VALUES ('Prueba Borrar Cco',40000,'ZZZ00','01/06/2007',100,'Escuela de Diseño','Usuario004')
INSERT INTO CurCorto VALUES ('ZZZ00', 'Diseño')

INSERT INTO Cursos VALUES ('Prueba Borrar CExp',80000, 'ZZZ01', '25/07/2019',100,'Escuela de Diseño','Usuario002')
INSERT INTO CurEspecializado VALUES ('ZZZ01', 30)


INSERT INTO Alumnos (Cedula,Nombre,Telefono) VALUES (11111111,'Bruno',11111111)
INSERT INTO Alumnos (Cedula,Nombre,Telefono) VALUES (22222222,'Sofia',22222222)
INSERT INTO Alumnos (Cedula,Nombre,Telefono) VALUES (33333333,'Avril',33333333)
INSERT INTO Alumnos (Cedula,Nombre,Telefono) VALUES (44444444,'Susana',44444444)
INSERT INTO Alumnos (Cedula,Nombre,Telefono) VALUES (55555555,'Daniel',55555555)
INSERT INTO Alumnos (Cedula,Nombre,Telefono) VALUES (66666666,'Gladys',66666666)

INSERT INTO Inscripcion VALUES (GETDATE(),'AAA01',11111111)
INSERT INTO Inscripcion VALUES (GETDATE(),'AAA01',22222222)

INSERT INTO Inscripcion VALUES (GETDATE(),'BBB01',33333333)
INSERT INTO Inscripcion VALUES (GETDATE(),'BBB01',44444444)
INSERT INTO Inscripcion VALUES (GETDATE(),'BBB02',33333333)
INSERT INTO Inscripcion VALUES (GETDATE(),'BBB02',55555555)


INSERT INTO Inscripcion VALUES (GETDATE(),'CCC02',11111111)
INSERT INTO Inscripcion VALUES (GETDATE(),'CCC02',66666666)
INSERT INTO Inscripcion VALUES (GETDATE(),'CCC03',11111111)

GO

---------- SP_CURSOS CORTOS -----------------------
create Procedure NuevoCursoCorto 
@Cod varchar(5), @Nom varchar (40),@Cupos int, @Costo int, @Fecha datetime, @Local varchar (40),@Emple varchar (10),@Area varchar(12)
as
begin
if (exists (select * from Cursos where Cursos.Codigo = @Cod))
return -1
if (not exists (select * from Sucursales where Sucursales.Nombre = @Local and Sucursales.Estado = 1 )) --No existen o existen y estan inactivos
return -3
if (not exists (select * from Empleados where Empleados.Usuario = @Emple and Empleados.Estado = 1)) 
return -4

Begin Transaction 
insert into Cursos values (@Nom,@Costo,@Cod,@Fecha,@Cupos,@Local,@Emple)
	if @@ERROR <> 0	
		begin
		rollback tran
		return -2
		end

Insert into CurCorto values(@Cod,@Area)
  if @@ERROR <> 0	
		begin
		rollback tran
		return -2
		end

		commit tran
	return 1
	end 
go

Create Procedure EliminarCursoCorto 
@Cod varchar(5)
as
begin
if (Exists(select * from Inscripcion where Inscripcion.Codigo = @Cod))
return -1
if (Not Exists(select * from CurCorto where CurCorto.Codigo = @Cod))
return -3
Begin Transaction 
		delete from CurCorto where CurCorto.Codigo = @Cod
		if (@@ERROR <> 0)
	begin
		rollback tran
		return -2
		end

		delete from Cursos where Cursos.Codigo = @Cod
		if (@@ERROR <> 0)
	begin
		rollback tran
		return -2
		end

		commit tran
	return 1
	end 
go

Create Procedure ModificarCursoCorto  
@Cod varchar(5), @Nom varchar (40),@Cupos int, @Costo int, @Fecha datetime, @Local varchar (40),@Emple varchar (10),@Area varchar(12)
as
begin
if (not exists (select * from CurCorto where CurCorto.Codigo = @Cod))
return -1
if (not exists (select * from Sucursales where Sucursales.Nombre = @Local and Sucursales.Estado = 1 )) --No existen o existen y estan inactivos
return -3
if (not exists (select * from Empleados where Empleados.Usuario = @Emple and Empleados.Estado = 1)) 
return -4

declare @@CupoActual int
Select @@CupoActual = COUNT(*) from Inscripcion where Inscripcion.Codigo = @Cod
if(@Cupos < @@CupoActual)
return - 5

Begin Transaction 
		UPDATE CurCorto SET CurCorto.Area = @Area where CurCorto.Codigo = @Cod
	if (@@ERROR <> 0)
	begin
		rollback tran
		return -2
		end
		
		UPDATE Cursos SET Cursos.Costo = @Costo, Cursos.Cupos = @Cupos, Cursos.Empleado = @Emple, Cursos.FechaInicio = @Fecha, Cursos.Nombre = @Nom, Cursos.Sucursal = @Local 
		where Cursos.Codigo = @Cod
	if (@@ERROR <> 0)
	begin
		rollback tran
		return -2
		end
 commit tran
	return 1
	end 
go

Create Procedure ListadoCortos
as
begin
Select * From CurCorto inner join Cursos on CurCorto.Codigo = Cursos.Codigo  WHERE  Cursos.FechaInicio > GETDATE()
end
go

Create Procedure BuscarcCorto
@cod varchar (5)
as
begin
Select * From CurCorto inner join Cursos on CurCorto.Codigo = Cursos.Codigo WHERE Cursos.Codigo = @cod
end
go
---SP_ CURSO ESPECIALIZADO ..--------------
Create Procedure NuevoCursoEspecializado
@Cod varchar(5), @Nom varchar (40),@Cupos int, @Costo int, @Fecha datetime, @Local varchar (40),@Emple varchar (10),@dura int
as
begin
if (exists (select * from Cursos where Cursos.Codigo = @Cod))
return -1
if (not exists (select * from Sucursales where Sucursales.Nombre = @Local and Sucursales.Estado = 1)) 
return -3
if (not exists (select * from Empleados where Empleados.Usuario = @Emple and Empleados.Estado = 1)) 
return -4

Begin Transaction 
		insert into Cursos values (@Nom,@Costo,@Cod,@Fecha,@Cupos,@Local,@Emple)
if (@@ERROR <> 0)
	begin
		rollback tran
		return -2
		end

		Insert into CurEspecializado values(@Cod,@dura)
		if (@@ERROR <> 0)
			begin
		rollback tran
		return -2
		end
		commit tran
	return 1
	end 
go

Create Procedure EliminarCursoEspec
@Cod varchar(5)
as
begin
if (Exists(select * from Inscripcion where Inscripcion.Codigo = @Cod))
return -1
if (Not Exists(select * from CurEspecializado where CurEspecializado.Codigo = @Cod))
return -3
Begin Transaction 
		delete from CurEspecializado where CurEspecializado.Codigo = @Cod
		if (@@ERROR <> 0)
	begin
		rollback tran
		return -2
		end

		delete from Cursos where Cursos.Codigo = @Cod
		if(@@ERROR <> 0)
	begin
		rollback tran
		return -2
		end

		commit tran
	return 1
	end 
go

Create Procedure ModificarCursoEspecial 
@Cod varchar(5), @Nom varchar (40),@Cupos int, @Costo int, @Fecha datetime, @Local varchar (40),@Emple varchar (10),@dura int
as
begin
if (not exists (select * from CurEspecializado where CurEspecializado.Codigo = @Cod))
return -1
if (not exists (select * from Sucursales where Sucursales.Nombre = @Local and Sucursales.Estado = 1)) 
return -3
if (not exists (select * from Empleados where Empleados.Usuario = @Emple and Empleados.Estado = 1)) 
return -4

declare @@CupoActual int
Select @@CupoActual = COUNT(*) from Inscripcion where Inscripcion.Codigo = @Cod
if(@Cupos < @@CupoActual)
return - 5

Begin Transaction 
		UPDATE CurEspecializado SET Duracion = @dura where CurEspecializado.Codigo = @Cod
	if (@@ERROR <> 0)
	begin
		rollback tran
		return -2
		end
		
		UPDATE Cursos SET Cursos.Costo = @Costo, Cursos.Cupos = @Cupos, Cursos.Empleado = @Emple, Cursos.FechaInicio = @Fecha, Cursos.Nombre = @Nom, Cursos.Sucursal = @Local 
		where Cursos.Codigo = @Cod
	if (@@ERROR <> 0)
	begin
		rollback tran
		return -2
		end

 commit tran
	return 1
	end 
go

Create Procedure ListadoEspecializados
as
begin
Select * From CurEspecializado inner join Cursos on CurEspecializado.Codigo = Cursos.Codigo WHERE  Cursos.FechaInicio > GETDATE()
end
go

Create Procedure BuscarEspecializado 
@cod varchar(5)
as
begin
Select * From CurEspecializado inner join Cursos on CurEspecializado.Codigo = Cursos.Codigo where Cursos.Codigo = @cod
end
go

----SP_ EMPLEADOS _------------------------

Create Procedure BuscarEmpleadoActivo 
@usu varchar(10) 
as
begin
Select * From Empleados where Empleados.Usuario = @usu and Empleados.Estado = 1
end
go

Create Procedure BuscarTodosEmpleados
@usu varchar(10) 
as
begin
Select * From Empleados where Empleados.Usuario = @usu 
end
go

Create Procedure RegistarEmpleado 
@usu varchar (10), @pas varchar (20)
as
begin
if (exists(select * from Empleados where Empleados.Usuario = @usu and Empleados.Estado = 1))
return -1
if (Exists(select * from Empleados where Empleados.Usuario = @usu and Empleados.Estado = 0)) 
update Empleados set Contraseña = @pas, Estado = 1 where Empleados.Usuario = @usu
IF (@@ERROR <> 0 )
begin
return -2
end
else
begin
return 1
end
INSERT INTO Empleados (Usuario,Contraseña) VALUES (@usu,@pas)
IF (@@ERROR <> 0 )
return -2
else
return 1
end
go



Create Procedure ModificarEmpleado
@usu varchar (10), @pas varchar (20)
as
begin
if(not exists ( Select * From Empleados Where Empleados.Usuario = @usu and Empleados.Estado = 1))
return -1
UPDATE Empleados SET Empleados.Contraseña = @pas WHERE Empleados.Usuario = @usu
IF (@@ERROR <> 0 )
return -2
else
return 1
end
go

Create Procedure Logueo 
@usu varchar (10), @pas varchar (20)
as
begin
if (exists(select * from Empleados where Empleados.Usuario = @usu and Empleados.Estado = 0))
return -1
end
begin
Select * From Empleados Where Empleados.Usuario = @usu and Empleados.Contraseña = @pas
end
go

Create Procedure BajaEmpleado 
@usu varchar (20)
as
Begin
		if (Not Exists(Select * From Empleados Where Empleados.Usuario = @usu))
			Begin
				return -1
			end
		
	   if (Exists(select * from Cursos  where Cursos.Empleado = @usu))
	   begin
			update Empleados set Estado = 0  where Empleados.Usuario = @usu
			 IF (@@ERROR <> 0 )
			return -2
			else
			return 1
		end
	  Else 
	   begin
	   delete from Empleados where Empleados.Usuario = @usu
	   IF (@@ERROR <> 0 )
			return -2
			else
			return 1
			end
			end
			go


------SP_ SUCURSAL y FACILIDADES ------------------------------------------------------------

Create Procedure BuscarSucursalActiva
@sucu varchar (40)
as
begin
Select * From Sucursales where Sucursales.Nombre = @sucu and Sucursales.Estado = 1
end
go

Create Procedure BuscarTodasSucursales
@sucu vaRCHAR (40)
AS BEGIN
Select * From Sucursales where Sucursales.Nombre = @sucu
end
go

Create Procedure RegistroSucursal
@nom varchar(40), @dire varchar (20)
as
begin
If(exists(Select * From Sucursales Where Sucursales.Nombre = @nom and Sucursales.Estado = 1))
return -1
end
If(exists(Select * From Sucursales Where Sucursales.Nombre = @nom and Sucursales.Estado = 0))
begin 
update Sucursales set Estado = 1
IF (@@ERROR <> 0 )
			return -2
			else
			return 1
			end
ELSE 
 Insert into Sucursales (Nombre,Direccion) values (@nom,@dire)
 BEGIN
 If @@ERROR <> 0
			return -2
 else 
			return 1
	         end				
			go

Create Procedure EliminarSucursal
@nom varchar (40)
as
begin
if (not exists( select * from Sucursales Where Sucursales.Nombre = @nom))
Return -1
END
if (exists(select * from Cursos where Cursos.Sucursal= @nom))
begin
update Sucursales set Estado = 0 where Sucursales.Nombre = @nom
If @@ERROR <> 0
			return -2
 else 
			return 1
						
			end
Else 
begin transaction 
delete from Facilidades where Facilidades.Sucursal = @nom
if (@@ERROR <> 0)
	begin
		rollback tran
		return -2
		end
delete from Sucursales where Sucursales.Nombre = @nom 
If (@@ERROR <> 0)
begin
		rollback tran
		return -2
		end
		else
commit tran
	return 1	
go

Create Procedure ModificarSucursal 
@nom varchar(40), @dire varchar (20)
as
begin
if (not exists( Select * From Sucursales Where Sucursales.Nombre = @nom))
return -1
UPDATE Sucursales SET Nombre = @nom, Direccion = @dire where Nombre = @nom
if @@ERROR <> 0 
return -2
else 
return 0
end
go 

 Create Procedure BuscarFacilidades
@sucu varchar (30)
as
begin
Select * From Facilidades where Facilidades.Sucursal = @sucu
end
go

Create Procedure FacilidadesAlta
@fac varchar (30), @sucu varchar (40)
as
begin
if (exists(Select * from Facilidades where Facilidades.Sucursal = @sucu and Facilidades.Facilidad = @fac ))
return -1 -- Existe la misma facilidad en la misma sucursal 
if (not exists(select * from Sucursales where Sucursales.Nombre = @sucu))
return -2 -- No existe Sucursal 
IF (EXISTS(Select * from Sucursales Where Sucursales.Nombre = @sucu and Sucursales.Estado = 0))
return -4 -- La Sucursal existe pero no esta activa 
begin
INSERT INTO Facilidades VALUES (@fac,@sucu)
IF @@ERROR <> 0
return -3
ELSE
return 1
end
 end
 
 go

 Create Procedure FacilidadBaja
 @fac varchar (30), @sucu varchar (40)
as
begin
if (not exists(Select * From Facilidades Where Facilidades.Facilidad = @fac and Facilidades.Sucursal = @sucu ))
  return -1 --no existe la facilidad de esa sucursal 
  end 
  BEGIN
  DELETE FROM Facilidades WHERE Facilidades.Facilidad = @fac and Facilidades.Sucursal = @sucu
  IF @@ERROR <> 0
   return -3
ELSE
  return 1
end
go

Create Procedure ElimiXsucursal
@sucu varchar (40)
as 
begin 
delete from Facilidades where Facilidades.Sucursal = @sucu
end
go

Create Procedure ListarSucursal
as
begin
Select * From Sucursales WHERE Sucursales.Estado =1
end 
go

----SP ALUMNOS, INSCRPCION----------------------------------------------------

 Create Procedure AltaAlumno 
 @ced int, @nom varchar (20), @tel int
 as
 begin 
 If (exists(Select * From Alumnos where Cedula = @ced))
  return -1
  end
 Insert into Alumnos values (@ced,@nom,@tel)
 begin
 IF (@@ERROR <> 0 )
return -2
else
return 1
end
go

Create Procedure BuscarAlumno
@ced int
as
begin
Select * from Alumnos where Alumnos.Cedula = @ced
end
go


Create Procedure NuevaInscripcion 
@cod varchar(5), @ced int
as
begin
If(not exists(Select * From Cursos Where Cursos.Codigo = @cod))
return -1 
If(not exists(Select * From Alumnos Where Alumnos.Cedula = @ced))
return -2
If(exists(Select * From Inscripcion Where Inscripcion.Codigo = @cod and Inscripcion.Alumno = @ced))
return -3 

declare @@CupoActual int
Select @@CupoActual = COUNT(*) from Inscripcion Where Inscripcion.Codigo = @cod

IF (EXISTS(SELECT * FROM Cursos WHERE Cursos.Codigo = @cod and Cursos.Cupos = @@CupoActual))
return -5

BEGIN 
INSERT Inscripcion VALUES (GETDATE(),@cod,@ced)
IF @@ERROR <> 0
return -4
else
return 1
end
end
go

