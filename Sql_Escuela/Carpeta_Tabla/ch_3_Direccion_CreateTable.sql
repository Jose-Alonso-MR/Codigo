/*
   domingo, 13 de octubre de 201904:40:49 a. m.
   User: 
   Server: DESKTOP-2SOL81C
   Database: Escuela
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.CatEstado SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.CatEstado', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.CatEstado', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.CatEstado', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Direccion
	(
	IdDireccion int NOT NULL,
	IdEstado int NULL,
	Calle varchar(50) NULL,
	Numero varchar(10) NULL,
	Colonia varchar(50) NULL,
	CodigoPostal varchar(10) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Direccion ADD CONSTRAINT
	PK_Direccion PRIMARY KEY CLUSTERED 
	(
	IdDireccion
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Direccion ADD CONSTRAINT
	FK_Direccion_CatEstado FOREIGN KEY
	(
	IdEstado
	) REFERENCES dbo.CatEstado
	(
	IdEstado
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Direccion SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Direccion', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Direccion', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Direccion', 'Object', 'CONTROL') as Contr_Per 