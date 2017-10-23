CREATE TABLE [dbo].[BoardTopic]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [BoardID] INT NOT NULL, 
    [TopicID] INT NOT NULL
	Constraint FK_BoardTopic Foreign Key (BoardID) References Board([ID]),
	Constraint FK_TopicBoard Foreign Key (TopicID) References Topic([ID])
)
