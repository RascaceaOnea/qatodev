CREATE TABLE [dbo].[User]
(
	[ID] INT NOT NULL PRIMARY KEY, 
	[UserName] NVARCHAR(20) NOT NULL,
	[UserPassword] NVARCHAR(20) NOT NULL,
    [ProfilePicture] IMAGE NULL, 
    [Rights] INT NOT NULL, 
    [Score] INT NOT NULL, 
	[FirstName] NVARCHAR(20) NOT NULL, 
    [LastName] NVARCHAR(20) NOT NULL, 
    [BirthDate] DATE NULL, 
    [ArrivalDate] DATE NOT NULL, 
    [LeaveDate] DATE NULL, 
    [CompanyID] INT NOT NULL, 
    [DepartmentID] INT NOT NULL,
	Constraint FK_UserCompany Foreign Key (CompanyID) References Company([ID]),
	Constraint FK_UserDepartment Foreign Key (DepartmentID) References Department([ID])
)
