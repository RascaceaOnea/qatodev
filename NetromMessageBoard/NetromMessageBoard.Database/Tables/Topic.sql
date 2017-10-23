CREATE TABLE [dbo].[Topic]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(20) NOT NULL, 
    [Description] NVARCHAR(255) NOT NULL, 
    [Priority] INT NOT NULL, 
    [DepartmentID] INT NOT NULL, 
    [UserID] INT NOT NULL, 
    [Password] NVARCHAR(20) NOT NULL,
	Constraint FK_TopicUser Foreign Key (UserID) References [dbo].[User]([ID]),
	Constraint FK_TopicDepartment Foreign Key (DepartmentID) References Department([ID])
)
