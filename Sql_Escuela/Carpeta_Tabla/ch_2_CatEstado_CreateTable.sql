/*
   domingo, 13 de octubre de 201904:37:13 a. m.
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
ALTER TABLE dbo.CatPais SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.CatPais', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.CatPais', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.CatPais', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.CatEstado
	(
	IdEstado int NOT NULL,
	IdPais int NOT NULL,
	Nombre varchar(50) NOT NULL,
	FechaCreacion datetime NOT NULL,
	FechaBaja datetime NULL,
	UltimaMod datetime NOT NULL,
	UsuariosMod varchar(50) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.CatEstado ADD CONSTRAINT
	DF_CatEstado_FechaCreacion DEFAULT GETDATE() FOR FechaCreacion
GO
ALTER TABLE dbo.CatEstado ADD CONSTRAINT
	DF_Table_3_FechaMod DEFAULT GETDATE() FOR UltimaMod
GO
ALTER TABLE dbo.CatEstado ADD CONSTRAINT
	DF_CatEstado_UsuariosMod DEFAULT 'SYSADMIN' FOR UsuariosMod
GO
ALTER TABLE dbo.CatEstado ADD CONSTRAINT
	PK_CatEstado PRIMARY KEY CLUSTERED 
	(
	IdEstado
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.CatEstado ADD CONSTRAINT
	FK_CatEstado_CatPais FOREIGN KEY
	(
	IdPais
	) REFERENCES dbo.CatPais
	(
	IdPais
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.CatEstado SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.CatEstado', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.CatEstado', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.CatEstado', 'Object', 'CONTROL') as Contr_Per 