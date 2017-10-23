﻿CREATE TABLE [dbo].[Employee]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(20) NOT NULL, 
    [LastName] NVARCHAR(20) NOT NULL, 
    [BirthDate] DATE NULL, 
    [ArrivalDate] DATE NOT NULL, 
    [LeaveDate] DATE NULL, 
    [CompanyID] INT NOT NULL, 
    [DepartmentID] INT NOT NULL
	Constraint FK_EmployeeCompany Foreign Key (CompanyID) References Company([ID]),
	Constraint FK_EmployeeDepartment Foreign Key (DepartmentID) References Department([ID])
)
