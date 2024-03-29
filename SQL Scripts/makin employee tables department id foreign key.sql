/*
   Friday, November 29, 20199:09:21 AM
   User: 
   Server: RAIN-DROP-FIRST\ROBIN_SQL
   Database: My_Database
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
ALTER TABLE dbo.tbl_Department SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.tbl_Department', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.tbl_Department', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.tbl_Department', 'Object', 'CONTROL') as Contr_Per BEGIN TRANSACTION
GO
ALTER TABLE dbo.tbl_Employee ADD CONSTRAINT
	FK_tbl_Employee_tbl_Department FOREIGN KEY
	(
	DepartmentId
	) REFERENCES dbo.tbl_Department
	(
	DepartmentId
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.tbl_Employee SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.tbl_Employee', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.tbl_Employee', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.tbl_Employee', 'Object', 'CONTROL') as Contr_Per 