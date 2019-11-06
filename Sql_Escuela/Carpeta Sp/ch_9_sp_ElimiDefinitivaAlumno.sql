USE Escuela
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF (SELECT COUNT(*) FROM sys.objects o where o.name = 'spDelAlumno') = 1 BEGIN
	DROP PROCEDURE dbo.spDelAlumno
END
GO
CREATE PROCEDURE spDelAlumno

@Id INT = 0
	
AS
BEGIN

   IF @Id = (SELECT IdAlumno FROM Alumno WHERE IdAlumno=@Id)  BEGIN --Eliminamos un Alumno

        DELETE FROM Alumno WHERE IdAlumno=@Id

   END 
   ELSE BEGIN 

	    SELECT 'El alumno no existe o ya fue eliminado'
   END

	SELECT 'Alumno Eliminado'
END