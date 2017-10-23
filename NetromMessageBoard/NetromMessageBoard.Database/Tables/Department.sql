CREATE TABLE [dbo].[Department]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(20) NOT NULL, 
    [CompanyID] INT NOT NULL
	Constraint FK_DepartmentCompany Foreign Key (CompanyID) References Company([ID])
)