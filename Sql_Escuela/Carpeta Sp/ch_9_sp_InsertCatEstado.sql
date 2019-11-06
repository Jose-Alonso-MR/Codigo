USE Escuela
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF (SELECT COUNT(*) FROM sys.objects o where o.name = 'spInsCatEstado') = 1 BEGIN
	DROP PROCEDURE dbo.spInsCatEstado
END
GO
 
CREATE PROCEDURE spInsCatEstado 
    
	@Id INT = 0,
	@IdPais INT,
	@Nombre VARCHAR(50)
	
	
AS
BEGIN
	
	IF @Id = 0 BEGIN --inserta nuevo
		
		DECLARE @idEst INT = (SELECT (ISNULL(MAX(IdEstado),0) + 1) FROM CatEstado); -- obtiene el id auto

		INSERT CatEstado(IdEstado,IdPais,Nombre)
		VALUES			(@idEst,@IdPais,@Nombre)

		
		

	END
	ELSE BEGIN --actualiza registro

			UPDATE CatEstado SET IdPais = @IdPais, Nombre = @Nombre,  UltimaMod = GETDATE()--Actualiza la tabla CatEs
			WHERE IdEstado=@Id
	END

	SELECT 'OK'
END
