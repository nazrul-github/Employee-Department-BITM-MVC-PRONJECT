/*
   Friday, November 29, 20199:07:17 AM
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
CREATE UNIQUE NONCLUSTERED INDEX IX_tbl_Department ON dbo.tbl_Department
	(
	DepartmentCode
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE UNIQUE NONCLUSTERED INDEX IX_tbl_Department_1 ON dbo.tbl_Department
	(
	DepartmentName
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE dbo.tbl_Department SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.tbl_Department', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.tbl_Department', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.tbl_Department', 'Object', 'CONTROL') as Contr_Per 