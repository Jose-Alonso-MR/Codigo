/*
   domingo, 13 de octubre de 201904:46:13 a. m.
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
ALTER TABLE dbo.Direccion SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Direccion', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Direccion', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Direccion', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
CREATE TABLE dbo.Alumno
	(
	IdAlumno int NOT NULL,
	IdDireccion int NOT NULL,
	Nombre varchar(50) NOT NULL,
	Apellido varchar(50) NOT NULL,
	FechaNacimiento date NOT NULL,
	FechaCreacion datetime NOT NULL,
	FechaBaja datetime NULL,
	UltimaMod datetime NOT NULL,
	UsuarioMod varchar(50) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Alumno ADD CONSTRAINT
	DF_Alumno_FechaCreacion DEFAULT getdate() FOR FechaCreacion
GO
ALTER TABLE dbo.Alumno ADD CONSTRAINT
	DF_Alumno_UltimaMod DEFAULT getdate() FOR UltimaMod
GO
ALTER TABLE dbo.Alumno ADD CONSTRAINT
	DF_Alumno_UsuarioMod DEFAULT 'SYSADMIN' FOR UsuarioMod
GO
ALTER TABLE dbo.Alumno ADD CONSTRAINT
	PK_Alumno PRIMARY KEY CLUSTERED 
	(
	IdAlumno
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Alumno ADD CONSTRAINT
	FK_Alumno_Direccion FOREIGN KEY
	(
	IdDireccion
	) REFERENCES dbo.Direccion
	(
	IdDireccion
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Alumno SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.Alumno', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.Alumno', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.Alumno', 'Object', 'CONTROL') as Contr_Per 