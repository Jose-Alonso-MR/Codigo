USE Escuela
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF (SELECT COUNT(*) FROM sys.objects o where o.name = 'spInsCatPais') = 1 BEGIN
	DROP PROCEDURE dbo.spInsCatPais
END
GO
 
CREATE PROCEDURE spInsCatPais
    
	@Id INT = 0,
	@Nombre VARCHAR(50)
	
	
AS
BEGIN
	
	IF @Id = 0 BEGIN --inserta nuevo
		
		DECLARE @idPais INT = (SELECT (ISNULL(MAX(IdPais),0) + 1) FROM CatPais); -- obtiene el id auto

		INSERT CatPais(IdPais,Nombre)
		VALUES		  (@IdPais,@Nombre)

	END
	ELSE BEGIN --actualiza registro

			UPDATE CatPais SET Nombre = @Nombre,  UltimaMod = GETDATE()--Actualiza la tabla CatEs
			WHERE IdPais=@Id
	END

	SELECT 'OK'
END