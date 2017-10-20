
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/20/2017 10:53:09
-- Generated from EDMX file: C:\Work\QaToDev\NetromMessageBoard\NetromMessageBoard\ProductModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [QaToDev];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Comment_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comment] DROP CONSTRAINT [FK_Comment_User];
GO
IF OBJECT_ID(N'[dbo].[FK_Department_Company]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Department] DROP CONSTRAINT [FK_Department_Company];
GO
IF OBJECT_ID(N'[dbo].[FK_Employee_Company]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [FK_Employee_Company];
GO
IF OBJECT_ID(N'[dbo].[FK_Employee_Department]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [FK_Employee_Department];
GO
IF OBJECT_ID(N'[dbo].[FK_Topic_Department]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Topic] DROP CONSTRAINT [FK_Topic_Department];
GO
IF OBJECT_ID(N'[dbo].[FK_Topic_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Topic] DROP CONSTRAINT [FK_Topic_User];
GO
IF OBJECT_ID(N'[dbo].[FK_User_Employee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User] DROP CONSTRAINT [FK_User_Employee];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Comment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comment];
GO
IF OBJECT_ID(N'[dbo].[Company]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Company];
GO
IF OBJECT_ID(N'[dbo].[Department]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Department];
GO
IF OBJECT_ID(N'[dbo].[Employee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employee];
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

-- Creating table 'Comments'
CREATE TABLE [dbo].[Comments] (
    [ID] int  NOT NULL,
    [Title] nvarchar(20)  NOT NULL,
    [Message] nvarchar(255)  NOT NULL,
    [PostTime] datetime  NOT NULL,
    [Score] smallint  NOT NULL,
    [IsVisible] bit  NOT NULL,
    [UserID] int  NOT NULL
);
GO

-- Creating table 'Companies'
CREATE TABLE [dbo].[Companies] (
    [ID] int  NOT NULL,
    [Name] nvarchar(20)  NOT NULL,
    [Location] nvarchar(40)  NULL
);
GO

-- Creating table 'Departments'
CREATE TABLE [dbo].[Departments] (
    [ID] int  NOT NULL,
    [Name] nchar(20)  NOT NULL,
    [CompanyID] int  NOT NULL
);
GO

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [ID] int  NOT NULL,
    [FirstName] nvarchar(20)  NOT NULL,
    [LastName] nvarchar(20)  NOT NULL,
    [BirthDate] datetime  NULL,
    [LeaveDate] datetime  NULL,
    [CompanyID] int  NOT NULL,
    [DepartmentID] int  NOT NULL
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
    [ID] int  NOT NULL,
    [Name] nvarchar(20)  NOT NULL,
    [Description] nvarchar(255)  NULL,
    [Priority] smallint  NOT NULL,
    [DepartmentID] int  NOT NULL,
    [UserID] int  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [ID] int  NOT NULL,
    [ProfilePicture] varbinary(max)  NOT NULL,
    [Rights] smallint  NOT NULL,
    [Score] smallint  NOT NULL,
    [EmployeeID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

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

-- Creating primary key on [ID] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
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

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserID] in table 'Comments'
ALTER TABLE [dbo].[Comments]
ADD CONSTRAINT [FK_Comment_User]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[Users]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Comment_User'
CREATE INDEX [IX_FK_Comment_User]
ON [dbo].[Comments]
    ([UserID]);
GO

-- Creating foreign key on [CompanyID] in table 'Departments'
ALTER TABLE [dbo].[Departments]
ADD CONSTRAINT [FK_Department_Company]
    FOREIGN KEY ([CompanyID])
    REFERENCES [dbo].[Companies]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Department_Company'
CREATE INDEX [IX_FK_Department_Company]
ON [dbo].[Departments]
    ([CompanyID]);
GO

-- Creating foreign key on [CompanyID] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_Employee_Company]
    FOREIGN KEY ([CompanyID])
    REFERENCES [dbo].[Companies]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Employee_Company'
CREATE INDEX [IX_FK_Employee_Company]
ON [dbo].[Employees]
    ([CompanyID]);
GO

-- Creating foreign key on [DepartmentID] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_Employee_Department]
    FOREIGN KEY ([DepartmentID])
    REFERENCES [dbo].[Departments]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Employee_Department'
CREATE INDEX [IX_FK_Employee_Department]
ON [dbo].[Employees]
    ([DepartmentID]);
GO

-- Creating foreign key on [DepartmentID] in table 'Topics'
ALTER TABLE [dbo].[Topics]
ADD CONSTRAINT [FK_Topic_Department]
    FOREIGN KEY ([DepartmentID])
    REFERENCES [dbo].[Departments]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Topic_Department'
CREATE INDEX [IX_FK_Topic_Department]
ON [dbo].[Topics]
    ([DepartmentID]);
GO

-- Creating foreign key on [EmployeeID] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_User_Employee]
    FOREIGN KEY ([EmployeeID])
    REFERENCES [dbo].[Employees]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_User_Employee'
CREATE INDEX [IX_FK_User_Employee]
ON [dbo].[Users]
    ([EmployeeID]);
GO

-- Creating foreign key on [UserID] in table 'Topics'
ALTER TABLE [dbo].[Topics]
ADD CONSTRAINT [FK_Topic_User]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[Users]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Topic_User'
CREATE INDEX [IX_FK_Topic_User]
ON [dbo].[Topics]
    ([UserID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------