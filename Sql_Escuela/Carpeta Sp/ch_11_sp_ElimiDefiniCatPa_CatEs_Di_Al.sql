USE Escuela
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF (SELECT COUNT(*) FROM sys.objects o where o.name = 'spDelPais') = 1 BEGIN
	DROP PROCEDURE dbo.spDelPais
END
GO
CREATE PROCEDURE spDelPais

@Id INT = 0,
@IdEst INT = 0,
@IdDir INT = 0
	
AS
BEGIN

   IF @Id = (SELECT IdPais FROM CatPais WHERE IdPais=@Id)  BEGIN

		DELETE Alumno FROM Alumno JOIN Direccion ON Alumno.IdDireccion = Direccion.IdDireccion WHERE Direccion.IdDireccion = @IdDir

		DELETE Direccion FROM Direccion JOIN CatEstado ON Direccion.IdEstado = CatEstado.IdEstado WHERE CatEstado.IdEstado =@IdEst

		DELETE CatEstado FROM CatEstado JOIN CatPais ON CatEstado.IdPais = CatPais.IdPais WHERE CatPais.IdPais = @Id

		DELETE FROM CatPais WHERE IdPais=@Id

   END 
   ELSE BEGIN 

	    SELECT 'Imposible Eliminar, verifique sus datos'
   END

	SELECT 'Eliminado'
END