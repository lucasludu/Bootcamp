
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/19/2022 18:38:07
-- Generated from EDMX file: C:\Users\Lucaaas\Desktop\Bootcamp_C#.Net\Semana3\Clase13\Guia\Ejercicio1\KioscoMF\KioscoMF\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [KioscoMF];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ProductoSet'
CREATE TABLE [dbo].[ProductoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Categoria] nvarchar(max)  NOT NULL,
    [FechaBaja] datetime  NOT NULL
);
GO

-- Creating table 'CaracteristicaSet'
CREATE TABLE [dbo].[CaracteristicaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProductoId] nvarchar(max)  NOT NULL,
    [Precio] float  NOT NULL,
    [Ancho] float  NOT NULL,
    [Largo] float  NOT NULL,
    [Peso] float  NOT NULL,
    [ProductoId1] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ProductoSet'
ALTER TABLE [dbo].[ProductoSet]
ADD CONSTRAINT [PK_ProductoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CaracteristicaSet'
ALTER TABLE [dbo].[CaracteristicaSet]
ADD CONSTRAINT [PK_CaracteristicaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ProductoId1] in table 'CaracteristicaSet'
ALTER TABLE [dbo].[CaracteristicaSet]
ADD CONSTRAINT [FK_ProductoCaracteristica]
    FOREIGN KEY ([ProductoId1])
    REFERENCES [dbo].[ProductoSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductoCaracteristica'
CREATE INDEX [IX_FK_ProductoCaracteristica]
ON [dbo].[CaracteristicaSet]
    ([ProductoId1]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------