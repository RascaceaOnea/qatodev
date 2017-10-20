CREATE TABLE [dbo].[Users]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [ProfilePicture] IMAGE NULL, 
    [Rights] INT NOT NULL, 
    [Score] INT NOT NULL, 
    [EmployeeID] INT NOT NULL
)
