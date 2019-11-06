use Escuela 
go
DECLARE 

@Id INT = 2


EXEC dbo.spDelAlumno @Id

SELECT * FROM Alumno