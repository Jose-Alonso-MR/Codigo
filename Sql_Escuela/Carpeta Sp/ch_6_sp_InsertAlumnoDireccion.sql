USE Escuela
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF (SELECT COUNT(*) FROM sys.objects o where o.name = 'spInsAlumno') = 1 BEGIN
	DROP PROCEDURE dbo.spInsAlumno
END
GO
 
CREATE PROCEDURE spInsAlumno
	@Id INT = 0,
	@Nombre VARCHAR(50),
	@Apellido VARCHAR(50),
	@FechaNacimiento VARCHAR(50),
	@IdEstado INT,
	@Calle VARCHAR(50),
	@Numero VARCHAR(10),
	@Colonia VARCHAR(50),
	@Cp VARCHAR(10),
	@UsuarioMod VARCHAR(50)
AS
BEGIN
	
	IF @Id = 0 BEGIN --inserta nuevo
		--BEGIN TRAN 
		DECLARE @idDir INT = (SELECT (ISNULL(MAX(IdDireccion),0) + 1) FROM Direccion); -- obtiene el id auto

		INSERT Direccion(IdDireccion,IdEstado,Calle,Numero,Colonia,CodigoPostal)
		VALUES			(@idDir,@IdEstado,@Calle,@Numero,@Colonia,@Cp)

		DECLARE @idAlu INT = (SELECT (ISNULL(MAX(IdAlumno),0) + 1) FROM Alumno); -- obtiene el id auto

		INSERT Alumno (IdAlumno,IdDireccion,Nombre,Apellido,FechaNacimiento,UsuarioMod)
		VALUES		  (@idAlu,@idDir,@Nombre,@Apellido,@FechaNacimiento,@UsuarioMod)

		


		--COMMIT TRAN

	END
	ELSE BEGIN --actualiza registro
	        SET @idDir = (SELECT IdDireccion FROM Alumno where IdAlumno=@Id)--Obtenemos el valor iddireccion por medio de idalumno

			UPDATE Direccion SET IdEstado = @IdEstado,  Calle = @Calle, Numero = @Numero, Colonia = @Colonia, CodigoPostal = @Cp--Actualiza la tabla Direccion
			WHERE IdDireccion= @IdDir

			UPDATE Alumno SET Nombre = @Nombre, Apellido = @Apellido, FechaNacimiento = @FechaNacimiento, UsuarioMod = @UsuarioMod, UltimaMod = GETDATE()--Actualiza la tabla Alumnos
			WHERE IdAlumno=@Id
	END

	SELECT 'OK'
END
GO
