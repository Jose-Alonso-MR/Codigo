/*
   domingo, 13 de octubre de 201904:17:59 a. m.
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
CREATE TABLE dbo.CatPais
	(
	IdPais int NOT NULL,
	Nombre varchar(50) NOT NULL,
	FechaCreacion datetime NOT NULL,
	FechaBaja datetime NULL,
	UltimaMod datetime NOT NULL,
	UsuarioMod varchar(50) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.CatPais ADD CONSTRAINT
	DF_CatPais_FechaCreacion DEFAULT getdate() FOR FechaCreacion
GO
ALTER TABLE dbo.CatPais ADD CONSTRAINT
	DF_CatPais_UltimaMod DEFAULT GETDATE() FOR UltimaMod
GO
ALTER TABLE dbo.CatPais ADD CONSTRAINT
	DF_CatPais_UsuarioMod DEFAULT 'SYSADMIN' FOR UsuarioMod
GO
ALTER TABLE dbo.CatPais ADD CONSTRAINT
	PK_CatPais PRIMARY KEY CLUSTERED 
	(
	IdPais
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.CatPais SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.CatPais', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.CatPais', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.CatPais', 'Object', 'CONTROL') as Contr_Per 