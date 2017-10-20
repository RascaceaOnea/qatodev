CREATE TABLE [dbo].[Topic]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(20) NOT NULL, 
    [Description] NVARCHAR(255) NOT NULL, 
    [Priority] INT NOT NULL, 
    [DepartmentID] INT NOT NULL, 
    [UserID] INT NOT NULL, 
    [Password] NVARCHAR(20) NOT NULL
)
