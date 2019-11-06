DECLARE 	
    @Id INT = 0,
	@Nombre VARCHAR(50) = 'Omar ',
	@Apellido VARCHAR(50) ='Munguia Rivera',
	@FechaNacimiento VARCHAR(50) = '1999-09-09',
	@IdEstado INT = 3,
	@Calle VARCHAR(50) = 'Benito Juarez',
	@Numero VARCHAR(10) = '12',
	@Colonia VARCHAR(50) = 'Lagunilla Pedernales',
	@Cp VARCHAR(10) = '73330',
	@UsuarioMod VARCHAR(50) = 'Omar'

EXEC dbo.spEDAlumno @Id 
EXEC dbo.spInsAlumno  @Id, @Nombre, @Apellido, @FechaNacimiento, @IdEstado, @Calle, @Numero, @Colonia, @Cp, @UsuarioMod 

SELECT * FROM Alumno
--BEGIN TRAN
/*DECLARE @idDir INT = (SELECT (ISNULL(MAX(IdDireccion),0) + 1) FROM Direccion); -- obtiene el id auto

INSERT Direccion(IdDireccion,IdEstado,Calle,Numero,Colonia,CodigoPostal)
VALUES			(@idDir,@IdEstado,@Calle,@Numero,@Colonia,@Cp)

DECLARE @idAlu INT = (SELECT (ISNULL(MAX(IdAlumno),0) + 1) FROM Alumno); -- obtiene el id auto

INSERT Alumno (IdAlumno,IdDireccion,Nombre,Apellido,FechaNacimiento,UsuarioMod)
VALUES		  (@idAlu,@idDir,@Nombre,@Apellido,@FechaNacimiento,@UsuarioMod)

select * from Alumno
*/
/*
DECLARE @IdDir INT = (SELECT IdDireccion FROM Alumno where IdAlumno=@Id)

UPDATE Direccion SET IdEstado = @IdEstado,  Calle = @Calle, Numero = @Numero, Colonia = @Colonia, CodigoPostal = @Cp
WHERE IdDireccion= @IdDir

 

UPDATE Alumno SET Nombre = @Nombre, Apellido = @Apellido, FechaNacimiento = @FechaNacimiento, UsuarioMod = @UsuarioMod, UltimaMod = GETDATE()
WHERE IdAlumno=@Id

SELECT * FROM Alumno
SELECT * FROM Direccion

COMMIT TRAN
*/