
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/23/2017 16:52:07
-- Generated from EDMX file: C:\Work\QaToDev\NetromMessageBoard\NetromMessageBoard.Model\MessageBoardEntities.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [NetromMessageBoard];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_BoardTopic]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BoardTopic] DROP CONSTRAINT [FK_BoardTopic];
GO
IF OBJECT_ID(N'[dbo].[FK_CommentReply]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comment] DROP CONSTRAINT [FK_CommentReply];
GO
IF OBJECT_ID(N'[dbo].[FK_CommentTopic]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comment] DROP CONSTRAINT [FK_CommentTopic];
GO
IF OBJECT_ID(N'[dbo].[FK_CommentUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comment] DROP CONSTRAINT [FK_CommentUser];
GO
IF OBJECT_ID(N'[dbo].[FK_DepartmentCompany]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Department] DROP CONSTRAINT [FK_DepartmentCompany];
GO
IF OBJECT_ID(N'[dbo].[FK_TopicBoard]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BoardTopic] DROP CONSTRAINT [FK_TopicBoard];
GO
IF OBJECT_ID(N'[dbo].[FK_TopicDepartment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Topic] DROP CONSTRAINT [FK_TopicDepartment];
GO
IF OBJECT_ID(N'[dbo].[FK_TopicUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Topic] DROP CONSTRAINT [FK_TopicUser];
GO
IF OBJECT_ID(N'[dbo].[FK_UserCompany]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User] DROP CONSTRAINT [FK_UserCompany];
GO
IF OBJECT_ID(N'[dbo].[FK_UserDepartment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User] DROP CONSTRAINT [FK_UserDepartment];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Board]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Board];
GO
IF OBJECT_ID(N'[dbo].[BoardTopic]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BoardTopic];
GO
IF OBJECT_ID(N'[dbo].[Comment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comment];
GO
IF OBJECT_ID(N'[dbo].[Company]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Company];
GO
IF OBJECT_ID(N'[dbo].[Department]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Department];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[Topic]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Topic];
GO
IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Boards'
CREATE TABLE [dbo].[Boards] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(20)  NOT NULL
);
GO

-- Creating table 'Comments'
CREATE TABLE [dbo].[Comments] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(20)  NOT NULL,
    [Message] nvarchar(255)  NOT NULL,
    [PostTime] datetime  NOT NULL,
    [Score] int  NOT NULL,
    [IsVisible] bit  NOT NULL,
    [TopicID] int  NOT NULL,
    [UserID] int  NOT NULL,
    [CommentID] int  NULL
);
GO

-- Creating table 'Companies'
CREATE TABLE [dbo].[Companies] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(20)  NOT NULL,
    [Location] nvarchar(50)  NULL
);
GO

-- Creating table 'Departments'
CREATE TABLE [dbo].[Departments] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(20)  NOT NULL,
    [CompanyID] int  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Topics'
CREATE TABLE [dbo].[Topics] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(20)  NOT NULL,
    [Description] nvarchar(255)  NOT NULL,
    [Priority] int  NOT NULL,
    [DepartmentID] int  NOT NULL,
    [UserID] int  NOT NULL,
    [Password] nvarchar(20)  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [ProfilePicture] varbinary(max)  NULL,
    [Rights] int  NOT NULL,
    [Score] int  NULL,
    [FirstName] nvarchar(50)  NOT NULL,
    [LastName] nvarchar(50)  NOT NULL,
    [BirthDate] datetime  NULL,
    [ArrivalDate] datetime  NOT NULL,
    [LeaveDate] datetime  NULL,
    [CompanyID] int  NOT NULL,
    [DepartmentID] int  NOT NULL,
    [UserName] nvarchar(20)  NOT NULL,
    [UserPassword] nvarchar(100)  NOT NULL
);
GO

-- Creating table 'BoardTopic'
CREATE TABLE [dbo].[BoardTopic] (
    [Boards_ID] int  NOT NULL,
    [Topics_ID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Boards'
ALTER TABLE [dbo].[Boards]
ADD CONSTRAINT [PK_Boards]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Comments'
ALTER TABLE [dbo].[Comments]
ADD CONSTRAINT [PK_Comments]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Companies'
ALTER TABLE [dbo].[Companies]
ADD CONSTRAINT [PK_Companies]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Departments'
ALTER TABLE [dbo].[Departments]
ADD CONSTRAINT [PK_Departments]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [ID] in table 'Topics'
ALTER TABLE [dbo].[Topics]
ADD CONSTRAINT [PK_Topics]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [Boards_ID], [Topics_ID] in table 'BoardTopic'
ALTER TABLE [dbo].[BoardTopic]
ADD CONSTRAINT [PK_BoardTopic]
    PRIMARY KEY CLUSTERED ([Boards_ID], [Topics_ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CommentID] in table 'Comments'
ALTER TABLE [dbo].[Comments]
ADD CONSTRAINT [FK_CommentReply]
    FOREIGN KEY ([CommentID])
    REFERENCES [dbo].[Comments]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CommentReply'
CREATE INDEX [IX_FK_CommentReply]
ON [dbo].[Comments]
    ([CommentID]);
GO

-- Creating foreign key on [TopicID] in table 'Comments'
ALTER TABLE [dbo].[Comments]
ADD CONSTRAINT [FK_CommentTopic]
    FOREIGN KEY ([TopicID])
    REFERENCES [dbo].[Topics]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CommentTopic'
CREATE INDEX [IX_FK_CommentTopic]
ON [dbo].[Comments]
    ([TopicID]);
GO

-- Creating foreign key on [UserID] in table 'Comments'
ALTER TABLE [dbo].[Comments]
ADD CONSTRAINT [FK_CommentUser]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[Users]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CommentUser'
CREATE INDEX [IX_FK_CommentUser]
ON [dbo].[Comments]
    ([UserID]);
GO

-- Creating foreign key on [CompanyID] in table 'Departments'
ALTER TABLE [dbo].[Departments]
ADD CONSTRAINT [FK_DepartmentCompany]
    FOREIGN KEY ([CompanyID])
    REFERENCES [dbo].[Companies]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepartmentCompany'
CREATE INDEX [IX_FK_DepartmentCompany]
ON [dbo].[Departments]
    ([CompanyID]);
GO

-- Creating foreign key on [CompanyID] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_UserCompany]
    FOREIGN KEY ([CompanyID])
    REFERENCES [dbo].[Companies]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserCompany'
CREATE INDEX [IX_FK_UserCompany]
ON [dbo].[Users]
    ([CompanyID]);
GO

-- Creating foreign key on [DepartmentID] in table 'Topics'
ALTER TABLE [dbo].[Topics]
ADD CONSTRAINT [FK_TopicDepartment]
    FOREIGN KEY ([DepartmentID])
    REFERENCES [dbo].[Departments]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TopicDepartment'
CREATE INDEX [IX_FK_TopicDepartment]
ON [dbo].[Topics]
    ([DepartmentID]);
GO

-- Creating foreign key on [DepartmentID] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_UserDepartment]
    FOREIGN KEY ([DepartmentID])
    REFERENCES [dbo].[Departments]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserDepartment'
CREATE INDEX [IX_FK_UserDepartment]
ON [dbo].[Users]
    ([DepartmentID]);
GO

-- Creating foreign key on [UserID] in table 'Topics'
ALTER TABLE [dbo].[Topics]
ADD CONSTRAINT [FK_TopicUser]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[Users]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TopicUser'
CREATE INDEX [IX_FK_TopicUser]
ON [dbo].[Topics]
    ([UserID]);
GO

-- Creating foreign key on [Boards_ID] in table 'BoardTopic'
ALTER TABLE [dbo].[BoardTopic]
ADD CONSTRAINT [FK_BoardTopic_Board]
    FOREIGN KEY ([Boards_ID])
    REFERENCES [dbo].[Boards]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Topics_ID] in table 'BoardTopic'
ALTER TABLE [dbo].[BoardTopic]
ADD CONSTRAINT [FK_BoardTopic_Topic]
    FOREIGN KEY ([Topics_ID])
    REFERENCES [dbo].[Topics]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BoardTopic_Topic'
CREATE INDEX [IX_FK_BoardTopic_Topic]
ON [dbo].[BoardTopic]
    ([Topics_ID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------