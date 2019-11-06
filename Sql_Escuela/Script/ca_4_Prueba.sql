USE [Escuela]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spEDAlumno]

@Id INT = 0
	
AS
BEGIN

  IF @Id = (SELECT IdAlumno FROM Alumno)  BEGIN

    UPDATE Alumno SET FechaBaja=GETDATE() WHERE IdAlumno=@Id

	END 
	ELSE BEGIN 

	 SELECT 'El alumno no existe'
	END

	SELECT 'OK'
END

