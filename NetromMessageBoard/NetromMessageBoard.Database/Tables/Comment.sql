CREATE TABLE [dbo].[Comment]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [Title] NVARCHAR(20) NOT NULL, 
    [Message] NVARCHAR(255) NOT NULL, 
    [PostTime] DATETIME NOT NULL, 
    [Score] INT NOT NULL, 
    [IsVisible] BIT NOT NULL, 
    [TopicID] INT NOT NULL, 
    [UserID] INT NOT NULL, 
    [CommentID] INT null,
	Constraint FK_CommentReply Foreign Key (CommentID) References Comment([ID]),
	Constraint FK_CommentUser Foreign Key (UserID) References [dbo].[User]([ID]),
	Constraint FK_CommentTopic Foreign Key (TopicID) References Topic([ID])
)
