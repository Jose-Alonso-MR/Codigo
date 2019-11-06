USE Escuela
GO

BEGIN TRAN 

INSERT INTO CatPais (IdPais,Nombre) VALUES 
(1,'Mexico'),
(2,'USA'),
(3,'Canada');

SELECT * FROM CatPais

--COMMIT TRAN

--ROLLBACK TRAN 

