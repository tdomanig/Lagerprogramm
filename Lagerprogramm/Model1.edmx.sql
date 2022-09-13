
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/24/2020 09:37:18
-- Generated from EDMX file: C:\Users\doman\source\repos\Lagerprogramm\Lagerprogramm\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Lager];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Ersatzteile]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Ersatzteile];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Baugruppen'
CREATE TABLE [dbo].[Baugruppen] (
    [Baugruppe] varchar(40)  NOT NULL,
    [Baugruppennummer] varchar(40)  NOT NULL,
    [Maschine] varchar(20)  NOT NULL,
    [Hersteller] varchar(20)  NOT NULL
);
GO

-- Creating table 'Ersatzteile'
CREATE TABLE [dbo].[Ersatzteile] (
    [Artikelbezeichnung] varchar(40)  NOT NULL,
    [Artikelnummer] varchar(40)  NOT NULL,
    [Lagerplatz] varchar(15)  NULL,
    [Anzahl] int  NOT NULL,
    [Baugruppennummer] varchar(40)  NOT NULL,
    [Maschinenummer] varchar(40)  NOT NULL,
    [Maschine] varchar(20)  NOT NULL,
    [Baugruppe] varchar(40)  NOT NULL
);
GO

-- Creating table 'Maschinen'
CREATE TABLE [dbo].[Maschinen] (
    [Maschine] varchar(20)  NOT NULL,
    [Maschinennummer] varchar(40)  NOT NULL,
    [Baujahr] datetime  NOT NULL,
    [Hersteller] varchar(20)  NOT NULL
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

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Baugruppennummer] in table 'Baugruppen'
ALTER TABLE [dbo].[Baugruppen]
ADD CONSTRAINT [PK_Baugruppen]
    PRIMARY KEY CLUSTERED ([Baugruppennummer] ASC);
GO

-- Creating primary key on [Artikelnummer] in table 'Ersatzteile'
ALTER TABLE [dbo].[Ersatzteile]
ADD CONSTRAINT [PK_Ersatzteile]
    PRIMARY KEY CLUSTERED ([Artikelnummer] ASC);
GO

-- Creating primary key on [Maschinennummer] in table 'Maschinen'
ALTER TABLE [dbo].[Maschinen]
ADD CONSTRAINT [PK_Maschinen]
    PRIMARY KEY CLUSTERED ([Maschinennummer] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Baugruppennummer] in table 'Ersatzteile'
ALTER TABLE [dbo].[Ersatzteile]
ADD CONSTRAINT [FK_Ersatzteile_Baugruppe]
    FOREIGN KEY ([Baugruppennummer])
    REFERENCES [dbo].[Baugruppen]
        ([Baugruppennummer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Ersatzteile_Baugruppe'
CREATE INDEX [IX_FK_Ersatzteile_Baugruppe]
ON [dbo].[Ersatzteile]
    ([Baugruppennummer]);
GO

-- Creating foreign key on [Maschinenummer] in table 'Ersatzteile'
ALTER TABLE [dbo].[Ersatzteile]
ADD CONSTRAINT [FK_Ersatzteile_Maschine]
    FOREIGN KEY ([Maschinenummer])
    REFERENCES [dbo].[Maschinen]
        ([Maschinennummer])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Ersatzteile_Maschine'
CREATE INDEX [IX_FK_Ersatzteile_Maschine]
ON [dbo].[Ersatzteile]
    ([Maschinenummer]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------