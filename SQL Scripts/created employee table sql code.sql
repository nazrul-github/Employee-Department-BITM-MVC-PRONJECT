/*
   Friday, November 29, 20199:00:54 AM
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
CREATE TABLE dbo.tbl_Employee
	(
	Id int NOT NULL IDENTITY (1, 1),
	EmployeeName nvarchar(50) NOT NULL,
	Designation varchar(50) NOT NULL,
	NID varchar(50) NOT NULL,
	JoiningDate date NOT NULL,
	CreatedDate date NOT NULL,
	DepartmentId int NOT NULL,
	BloodGroup varchar(50) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.tbl_Employee ADD CONSTRAINT
	PK_tbl_Employee PRIMARY KEY CLUSTERED 
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
CREATE UNIQUE NONCLUSTERED INDEX IX_tbl_Employee ON dbo.tbl_Employee
	(
	Id
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX IX_tbl_Employee_1 ON dbo.tbl_Employee
	(
	EmployeeName
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE dbo.tbl_Employee SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
select Has_Perms_By_Name(N'dbo.tbl_Employee', 'Object', 'ALTER') as ALT_Per, Has_Perms_By_Name(N'dbo.tbl_Employee', 'Object', 'VIEW DEFINITION') as View_def_Per, Has_Perms_By_Name(N'dbo.tbl_Employee', 'Object', 'CONTROL') as Contr_Per 