USE Escuela
GO

BEGIN TRAN 

INSERT INTO CatEstado(IdEstado,IdPais,Nombre) VALUES 
(1,1,'Puebla'),
(2,1,'Tlaxcala'),
(3,1,'Monterrey');

SELECT * FROM CatPais

--COMMIT TRAN

--ROLLBACK TRAN 