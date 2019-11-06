USE Escuela
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF (SELECT COUNT(*) FROM sys.objects o where o.name = 'spEDAlumno') = 1 BEGIN  
	DROP PROCEDURE dbo.spEDAlumno
END
GO
CREATE PROCEDURE spEDAlumno

@Id INT = 0
	
AS
BEGIN

   IF @Id = (SELECT IdAlumno FROM Alumno WHERE IdAlumno=@Id)  BEGIN -- Actualiza solo la fechaBaja

         UPDATE Alumno SET FechaBaja=GETDATE() WHERE IdAlumno=@Id

   END 
   ELSE BEGIN 

	    SELECT 'El alumno no existe'
   END

	SELECT 'OK'
END
