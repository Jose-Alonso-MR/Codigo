/*
   domingo, 13 de octubre de 201904:47:25 a. m.
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
EXECUTE sp_rename N'dbo.CatEstado.UsuariosMod', N'Tmp_UsuarioMod', 'COLUMN' 
GO
EXECUTE sp_rename N'dbo.CatEstado.Tmp_UsuarioMod', N'UsuarioMod', 'COLUMN' 
GO
ALTER TABLE dbo.CatEstado SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.CatEstado', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.CatEstado', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.CatEstado', 'Object', 'CONTROL') as Contr_Per 