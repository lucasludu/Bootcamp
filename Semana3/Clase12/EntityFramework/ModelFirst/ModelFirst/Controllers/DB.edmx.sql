
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/19/2022 15:51:46
-- Generated from EDMX file: C:\Users\Lucaaas\Desktop\Bootcamp_C#.Net\Semana3\Clase12\EntityFramework\ModelFirst\ModelFirst\Controllers\DB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ModelFirst];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Persons]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Persons];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Persons'
CREATE TABLE [dbo].[Persons] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [age] int  NOT NULL
);
GO

-- Creating table 'Lessons'
CREATE TABLE [dbo].[Lessons] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Person_LessonSet'
CREATE TABLE [dbo].[Person_LessonSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PersonId] int  NOT NULL,
    [LessonId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Persons'
ALTER TABLE [dbo].[Persons]
ADD CONSTRAINT [PK_Persons]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Lessons'
ALTER TABLE [dbo].[Lessons]
ADD CONSTRAINT [PK_Lessons]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Person_LessonSet'
ALTER TABLE [dbo].[Person_LessonSet]
ADD CONSTRAINT [PK_Person_LessonSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PersonId] in table 'Person_LessonSet'
ALTER TABLE [dbo].[Person_LessonSet]
ADD CONSTRAINT [FK_PersonPerson_Lesson]
    FOREIGN KEY ([PersonId])
    REFERENCES [dbo].[Persons]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonPerson_Lesson'
CREATE INDEX [IX_FK_PersonPerson_Lesson]
ON [dbo].[Person_LessonSet]
    ([PersonId]);
GO

-- Creating foreign key on [LessonId] in table 'Person_LessonSet'
ALTER TABLE [dbo].[Person_LessonSet]
ADD CONSTRAINT [FK_LessonPerson_Lesson]
    FOREIGN KEY ([LessonId])
    REFERENCES [dbo].[Lessons]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LessonPerson_Lesson'
CREATE INDEX [IX_FK_LessonPerson_Lesson]
ON [dbo].[Person_LessonSet]
    ([LessonId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------