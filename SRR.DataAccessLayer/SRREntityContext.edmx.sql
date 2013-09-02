
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 07/30/2013 23:41:57
-- Generated from EDMX file: C:\Users\timre\Documents\Visual Studio 2012\Projects\SRR.DataAccessLayer.Model\SRR.DataAccessLayer\SRREntityContext.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SRR];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[SRRModelStoreContainer].[FK_ApplicationKeywordSwitcher_ApplicationSet]', 'F') IS NOT NULL
    ALTER TABLE [SRRModelStoreContainer].[ApplicationKeywordSwitcher] DROP CONSTRAINT [FK_ApplicationKeywordSwitcher_ApplicationSet];
GO
IF OBJECT_ID(N'[SRRModelStoreContainer].[FK_ApplicationKeywordSwitcher_KeywordSet]', 'F') IS NOT NULL
    ALTER TABLE [SRRModelStoreContainer].[ApplicationKeywordSwitcher] DROP CONSTRAINT [FK_ApplicationKeywordSwitcher_KeywordSet];
GO
IF OBJECT_ID(N'[SRRModelStoreContainer].[FK_ApplicationUsingServices_Applications]', 'F') IS NOT NULL
    ALTER TABLE [SRRModelStoreContainer].[ApplicationUsingServices] DROP CONSTRAINT [FK_ApplicationUsingServices_Applications];
GO
IF OBJECT_ID(N'[SRRModelStoreContainer].[FK_ApplicationUsingServices_Services]', 'F') IS NOT NULL
    ALTER TABLE [SRRModelStoreContainer].[ApplicationUsingServices] DROP CONSTRAINT [FK_ApplicationUsingServices_Services];
GO
IF OBJECT_ID(N'[SRRModelStoreContainer].[FK_ServiceKeywordSwitcher_Keywords]', 'F') IS NOT NULL
    ALTER TABLE [SRRModelStoreContainer].[ServiceKeywordSwitcher] DROP CONSTRAINT [FK_ServiceKeywordSwitcher_Keywords];
GO
IF OBJECT_ID(N'[SRRModelStoreContainer].[FK_ServiceKeywordSwitcher_Services]', 'F') IS NOT NULL
    ALTER TABLE [SRRModelStoreContainer].[ServiceKeywordSwitcher] DROP CONSTRAINT [FK_ServiceKeywordSwitcher_Services];
GO
IF OBJECT_ID(N'[SRRModelStoreContainer].[FK_ServiceMessageKeywordSwitcher_Keywords]', 'F') IS NOT NULL
    ALTER TABLE [SRRModelStoreContainer].[ServiceMessageKeywordSwitcher] DROP CONSTRAINT [FK_ServiceMessageKeywordSwitcher_Keywords];
GO
IF OBJECT_ID(N'[SRRModelStoreContainer].[FK_ServiceMessageKeywordSwitcher_ServiceMessages]', 'F') IS NOT NULL
    ALTER TABLE [SRRModelStoreContainer].[ServiceMessageKeywordSwitcher] DROP CONSTRAINT [FK_ServiceMessageKeywordSwitcher_ServiceMessages];
GO
IF OBJECT_ID(N'[SRRModelStoreContainer].[FK_ServiceOperationKeywordSwitcher_Keywords]', 'F') IS NOT NULL
    ALTER TABLE [SRRModelStoreContainer].[ServiceOperationKeywordSwitcher] DROP CONSTRAINT [FK_ServiceOperationKeywordSwitcher_Keywords];
GO
IF OBJECT_ID(N'[SRRModelStoreContainer].[FK_ServiceOperationKeywordSwitcher_ServiceOperations]', 'F') IS NOT NULL
    ALTER TABLE [SRRModelStoreContainer].[ServiceOperationKeywordSwitcher] DROP CONSTRAINT [FK_ServiceOperationKeywordSwitcher_ServiceOperations];
GO
IF OBJECT_ID(N'[SRRModelStoreContainer].[FK_ServiceOperationUsingServiceOperation_ServiceOperations]', 'F') IS NOT NULL
    ALTER TABLE [SRRModelStoreContainer].[ServiceOperationUsingServiceOperation] DROP CONSTRAINT [FK_ServiceOperationUsingServiceOperation_ServiceOperations];
GO
IF OBJECT_ID(N'[SRRModelStoreContainer].[FK_ServiceOperationUsingServiceOperation_ServiceOperations1]', 'F') IS NOT NULL
    ALTER TABLE [SRRModelStoreContainer].[ServiceOperationUsingServiceOperation] DROP CONSTRAINT [FK_ServiceOperationUsingServiceOperation_ServiceOperations1];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[SRRModelStoreContainer].[ApplicationKeywordSwitcher]', 'U') IS NOT NULL
    DROP TABLE [SRRModelStoreContainer].[ApplicationKeywordSwitcher];
GO
IF OBJECT_ID(N'[dbo].[Applications]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Applications];
GO
IF OBJECT_ID(N'[SRRModelStoreContainer].[ApplicationUsingServices]', 'U') IS NOT NULL
    DROP TABLE [SRRModelStoreContainer].[ApplicationUsingServices];
GO
IF OBJECT_ID(N'[dbo].[Keywords]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Keywords];
GO
IF OBJECT_ID(N'[SRRModelStoreContainer].[ServiceKeywordSwitcher]', 'U') IS NOT NULL
    DROP TABLE [SRRModelStoreContainer].[ServiceKeywordSwitcher];
GO
IF OBJECT_ID(N'[SRRModelStoreContainer].[ServiceMessageKeywordSwitcher]', 'U') IS NOT NULL
    DROP TABLE [SRRModelStoreContainer].[ServiceMessageKeywordSwitcher];
GO
IF OBJECT_ID(N'[dbo].[ServiceMessages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ServiceMessages];
GO
IF OBJECT_ID(N'[SRRModelStoreContainer].[ServiceOperationKeywordSwitcher]', 'U') IS NOT NULL
    DROP TABLE [SRRModelStoreContainer].[ServiceOperationKeywordSwitcher];
GO
IF OBJECT_ID(N'[dbo].[ServiceOperations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ServiceOperations];
GO
IF OBJECT_ID(N'[SRRModelStoreContainer].[ServiceOperationUsingServiceOperation]', 'U') IS NOT NULL
    DROP TABLE [SRRModelStoreContainer].[ServiceOperationUsingServiceOperation];
GO
IF OBJECT_ID(N'[dbo].[Services]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Services];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Applications'
CREATE TABLE [dbo].[Applications] (
    [PK_ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Version] nvarchar(max)  NOT NULL,
    [ModificationDate] datetime  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [ModificationReason] nvarchar(max)  NOT NULL,
    [Developer] int  NOT NULL,
    [AttachedObjects] nvarchar(max)  NOT NULL,
    [Keywords] nvarchar(max)  NOT NULL,
    [ModificationUser] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Keywords'
CREATE TABLE [dbo].[Keywords] (
    [PK_ID] int  NOT NULL,
    [Name] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'ServiceMessages'
CREATE TABLE [dbo].[ServiceMessages] (
    [PK_ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Namespace] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Version] nvarchar(max)  NOT NULL,
    [Keywords] nvarchar(max)  NOT NULL,
    [ModificationDate] nvarchar(max)  NOT NULL,
    [ModificationReason] nvarchar(max)  NOT NULL,
    [ModificationUser] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ServiceOperations'
CREATE TABLE [dbo].[ServiceOperations] (
    [PK_ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Namespace] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Keywords] nvarchar(max)  NOT NULL,
    [ModificationDate] nvarchar(max)  NOT NULL,
    [ModificationReason] nvarchar(max)  NOT NULL,
    [ModificationUser] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Services'
CREATE TABLE [dbo].[Services] (
    [PK_ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Namespace] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Version] nvarchar(max)  NOT NULL,
    [ServiceKeeper] nvarchar(max)  NOT NULL,
    [Keywords] nvarchar(max)  NOT NULL,
    [ModificationDate] nvarchar(max)  NOT NULL,
    [ModificationReason] nvarchar(max)  NOT NULL,
    [ModificationUser] nvarchar(max)  NOT NULL,
    [EndpointDEV] nvarchar(max)  NOT NULL,
    [EndpointQA] nvarchar(max)  NOT NULL,
    [EndpointPROD] nvarchar(max)  NOT NULL,
    [MaxResponseTime] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ApplicationUsingServices'
CREATE TABLE [dbo].[ApplicationUsingServices] (
    [FK_ApplicationPK_ID] int  NOT NULL,
    [FK_ServicePK_ID] int  NOT NULL,
    [RequestTransformation] nchar(100)  NULL,
    [ResponseTransformation] nchar(100)  NULL,
    [FaultTransformation] nchar(100)  NULL
);
GO

-- Creating table 'SRREntityHistoryTableSet'
CREATE TABLE [dbo].[SRREntityHistoryTableSet] (
    [PK_ID] int IDENTITY(1,1) NOT NULL,
    [ModDate] nvarchar(max)  NOT NULL,
    [ModReason] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SRREntityTypeSet'
CREATE TABLE [dbo].[SRREntityTypeSet] (
    [PK_ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [SRREntityHistoryTableSRREntityType_SRREntityType_PK_ID] int  NOT NULL
);
GO

-- Creating table 'SRRUsersSet'
CREATE TABLE [dbo].[SRRUsersSet] (
    [PK_ID] int IDENTITY(1,1) NOT NULL,
    [SRREntityHistoryTableSRRUsers_SRRUsers_PK_ID] int  NOT NULL
);
GO

-- Creating table 'SRRUserRolesSet'
CREATE TABLE [dbo].[SRRUserRolesSet] (
    [PK_ID] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'ApplicationKeywordSwitcher'
CREATE TABLE [dbo].[ApplicationKeywordSwitcher] (
    [ApplicationKeywordSwitcher_Keywords_PK_ID] int  NOT NULL,
    [ConnectedKeywords_PK_ID] int  NOT NULL
);
GO

-- Creating table 'ServiceKeywordSwitcher'
CREATE TABLE [dbo].[ServiceKeywordSwitcher] (
    [ConnectedKeywords_PK_ID] int  NOT NULL,
    [ServiceKeywordSwitcher_Keywords_PK_ID] int  NOT NULL
);
GO

-- Creating table 'ServiceOperationKeywordSwitcher'
CREATE TABLE [dbo].[ServiceOperationKeywordSwitcher] (
    [ConnectedKeywords_PK_ID] int  NOT NULL,
    [ServiceOperationKeywordSwitcher_Keywords_PK_ID] int  NOT NULL
);
GO

-- Creating table 'ServiceMessageKeywordSwitcher'
CREATE TABLE [dbo].[ServiceMessageKeywordSwitcher] (
    [ConnectedKeywords_PK_ID] int  NOT NULL,
    [ServiceMessageKeywordSwitcher_Keywords_PK_ID] int  NOT NULL
);
GO

-- Creating table 'ServiceOperationUsingServiceOperation'
CREATE TABLE [dbo].[ServiceOperationUsingServiceOperation] (
    [ServiceOperations2_PK_ID] int  NOT NULL,
    [ServiceOperations1_PK_ID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [PK_ID] in table 'Applications'
ALTER TABLE [dbo].[Applications]
ADD CONSTRAINT [PK_Applications]
    PRIMARY KEY CLUSTERED ([PK_ID] ASC);
GO

-- Creating primary key on [PK_ID] in table 'Keywords'
ALTER TABLE [dbo].[Keywords]
ADD CONSTRAINT [PK_Keywords]
    PRIMARY KEY CLUSTERED ([PK_ID] ASC);
GO

-- Creating primary key on [PK_ID] in table 'ServiceMessages'
ALTER TABLE [dbo].[ServiceMessages]
ADD CONSTRAINT [PK_ServiceMessages]
    PRIMARY KEY CLUSTERED ([PK_ID] ASC);
GO

-- Creating primary key on [PK_ID] in table 'ServiceOperations'
ALTER TABLE [dbo].[ServiceOperations]
ADD CONSTRAINT [PK_ServiceOperations]
    PRIMARY KEY CLUSTERED ([PK_ID] ASC);
GO

-- Creating primary key on [PK_ID] in table 'Services'
ALTER TABLE [dbo].[Services]
ADD CONSTRAINT [PK_Services]
    PRIMARY KEY CLUSTERED ([PK_ID] ASC);
GO

-- Creating primary key on [FK_ApplicationPK_ID], [FK_ServicePK_ID] in table 'ApplicationUsingServices'
ALTER TABLE [dbo].[ApplicationUsingServices]
ADD CONSTRAINT [PK_ApplicationUsingServices]
    PRIMARY KEY CLUSTERED ([FK_ApplicationPK_ID], [FK_ServicePK_ID] ASC);
GO

-- Creating primary key on [PK_ID] in table 'SRREntityHistoryTableSet'
ALTER TABLE [dbo].[SRREntityHistoryTableSet]
ADD CONSTRAINT [PK_SRREntityHistoryTableSet]
    PRIMARY KEY CLUSTERED ([PK_ID] ASC);
GO

-- Creating primary key on [PK_ID] in table 'SRREntityTypeSet'
ALTER TABLE [dbo].[SRREntityTypeSet]
ADD CONSTRAINT [PK_SRREntityTypeSet]
    PRIMARY KEY CLUSTERED ([PK_ID] ASC);
GO

-- Creating primary key on [PK_ID] in table 'SRRUsersSet'
ALTER TABLE [dbo].[SRRUsersSet]
ADD CONSTRAINT [PK_SRRUsersSet]
    PRIMARY KEY CLUSTERED ([PK_ID] ASC);
GO

-- Creating primary key on [PK_ID] in table 'SRRUserRolesSet'
ALTER TABLE [dbo].[SRRUserRolesSet]
ADD CONSTRAINT [PK_SRRUserRolesSet]
    PRIMARY KEY CLUSTERED ([PK_ID] ASC);
GO

-- Creating primary key on [ApplicationKeywordSwitcher_Keywords_PK_ID], [ConnectedKeywords_PK_ID] in table 'ApplicationKeywordSwitcher'
ALTER TABLE [dbo].[ApplicationKeywordSwitcher]
ADD CONSTRAINT [PK_ApplicationKeywordSwitcher]
    PRIMARY KEY NONCLUSTERED ([ApplicationKeywordSwitcher_Keywords_PK_ID], [ConnectedKeywords_PK_ID] ASC);
GO

-- Creating primary key on [ConnectedKeywords_PK_ID], [ServiceKeywordSwitcher_Keywords_PK_ID] in table 'ServiceKeywordSwitcher'
ALTER TABLE [dbo].[ServiceKeywordSwitcher]
ADD CONSTRAINT [PK_ServiceKeywordSwitcher]
    PRIMARY KEY NONCLUSTERED ([ConnectedKeywords_PK_ID], [ServiceKeywordSwitcher_Keywords_PK_ID] ASC);
GO

-- Creating primary key on [ConnectedKeywords_PK_ID], [ServiceOperationKeywordSwitcher_Keywords_PK_ID] in table 'ServiceOperationKeywordSwitcher'
ALTER TABLE [dbo].[ServiceOperationKeywordSwitcher]
ADD CONSTRAINT [PK_ServiceOperationKeywordSwitcher]
    PRIMARY KEY NONCLUSTERED ([ConnectedKeywords_PK_ID], [ServiceOperationKeywordSwitcher_Keywords_PK_ID] ASC);
GO

-- Creating primary key on [ConnectedKeywords_PK_ID], [ServiceMessageKeywordSwitcher_Keywords_PK_ID] in table 'ServiceMessageKeywordSwitcher'
ALTER TABLE [dbo].[ServiceMessageKeywordSwitcher]
ADD CONSTRAINT [PK_ServiceMessageKeywordSwitcher]
    PRIMARY KEY NONCLUSTERED ([ConnectedKeywords_PK_ID], [ServiceMessageKeywordSwitcher_Keywords_PK_ID] ASC);
GO

-- Creating primary key on [ServiceOperations2_PK_ID], [ServiceOperations1_PK_ID] in table 'ServiceOperationUsingServiceOperation'
ALTER TABLE [dbo].[ServiceOperationUsingServiceOperation]
ADD CONSTRAINT [PK_ServiceOperationUsingServiceOperation]
    PRIMARY KEY NONCLUSTERED ([ServiceOperations2_PK_ID], [ServiceOperations1_PK_ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ApplicationKeywordSwitcher_Keywords_PK_ID] in table 'ApplicationKeywordSwitcher'
ALTER TABLE [dbo].[ApplicationKeywordSwitcher]
ADD CONSTRAINT [FK_ApplicationKeywordSwitcher_Applications]
    FOREIGN KEY ([ApplicationKeywordSwitcher_Keywords_PK_ID])
    REFERENCES [dbo].[Applications]
        ([PK_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ConnectedKeywords_PK_ID] in table 'ApplicationKeywordSwitcher'
ALTER TABLE [dbo].[ApplicationKeywordSwitcher]
ADD CONSTRAINT [FK_ApplicationKeywordSwitcher_Keywords]
    FOREIGN KEY ([ConnectedKeywords_PK_ID])
    REFERENCES [dbo].[Keywords]
        ([PK_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ApplicationKeywordSwitcher_Keywords'
CREATE INDEX [IX_FK_ApplicationKeywordSwitcher_Keywords]
ON [dbo].[ApplicationKeywordSwitcher]
    ([ConnectedKeywords_PK_ID]);
GO

-- Creating foreign key on [ConnectedKeywords_PK_ID] in table 'ServiceKeywordSwitcher'
ALTER TABLE [dbo].[ServiceKeywordSwitcher]
ADD CONSTRAINT [FK_ServiceKeywordSwitcher_Keywords]
    FOREIGN KEY ([ConnectedKeywords_PK_ID])
    REFERENCES [dbo].[Keywords]
        ([PK_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ServiceKeywordSwitcher_Keywords_PK_ID] in table 'ServiceKeywordSwitcher'
ALTER TABLE [dbo].[ServiceKeywordSwitcher]
ADD CONSTRAINT [FK_ServiceKeywordSwitcher_Services]
    FOREIGN KEY ([ServiceKeywordSwitcher_Keywords_PK_ID])
    REFERENCES [dbo].[Services]
        ([PK_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ServiceKeywordSwitcher_Services'
CREATE INDEX [IX_FK_ServiceKeywordSwitcher_Services]
ON [dbo].[ServiceKeywordSwitcher]
    ([ServiceKeywordSwitcher_Keywords_PK_ID]);
GO

-- Creating foreign key on [ConnectedKeywords_PK_ID] in table 'ServiceOperationKeywordSwitcher'
ALTER TABLE [dbo].[ServiceOperationKeywordSwitcher]
ADD CONSTRAINT [FK_ServiceOperationKeywordSwitcher_Keywords]
    FOREIGN KEY ([ConnectedKeywords_PK_ID])
    REFERENCES [dbo].[Keywords]
        ([PK_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ServiceOperationKeywordSwitcher_Keywords_PK_ID] in table 'ServiceOperationKeywordSwitcher'
ALTER TABLE [dbo].[ServiceOperationKeywordSwitcher]
ADD CONSTRAINT [FK_ServiceOperationKeywordSwitcher_ServiceOperations]
    FOREIGN KEY ([ServiceOperationKeywordSwitcher_Keywords_PK_ID])
    REFERENCES [dbo].[ServiceOperations]
        ([PK_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ServiceOperationKeywordSwitcher_ServiceOperations'
CREATE INDEX [IX_FK_ServiceOperationKeywordSwitcher_ServiceOperations]
ON [dbo].[ServiceOperationKeywordSwitcher]
    ([ServiceOperationKeywordSwitcher_Keywords_PK_ID]);
GO

-- Creating foreign key on [ConnectedKeywords_PK_ID] in table 'ServiceMessageKeywordSwitcher'
ALTER TABLE [dbo].[ServiceMessageKeywordSwitcher]
ADD CONSTRAINT [FK_ServiceMessageKeywordSwitcher_Keywords]
    FOREIGN KEY ([ConnectedKeywords_PK_ID])
    REFERENCES [dbo].[Keywords]
        ([PK_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ServiceMessageKeywordSwitcher_Keywords_PK_ID] in table 'ServiceMessageKeywordSwitcher'
ALTER TABLE [dbo].[ServiceMessageKeywordSwitcher]
ADD CONSTRAINT [FK_ServiceMessageKeywordSwitcher_ServiceMessages]
    FOREIGN KEY ([ServiceMessageKeywordSwitcher_Keywords_PK_ID])
    REFERENCES [dbo].[ServiceMessages]
        ([PK_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ServiceMessageKeywordSwitcher_ServiceMessages'
CREATE INDEX [IX_FK_ServiceMessageKeywordSwitcher_ServiceMessages]
ON [dbo].[ServiceMessageKeywordSwitcher]
    ([ServiceMessageKeywordSwitcher_Keywords_PK_ID]);
GO

-- Creating foreign key on [FK_ApplicationPK_ID] in table 'ApplicationUsingServices'
ALTER TABLE [dbo].[ApplicationUsingServices]
ADD CONSTRAINT [FK_ApplicationUsingServices_Applications]
    FOREIGN KEY ([FK_ApplicationPK_ID])
    REFERENCES [dbo].[Applications]
        ([PK_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [FK_ServicePK_ID] in table 'ApplicationUsingServices'
ALTER TABLE [dbo].[ApplicationUsingServices]
ADD CONSTRAINT [FK_ApplicationUsingServices_Services]
    FOREIGN KEY ([FK_ServicePK_ID])
    REFERENCES [dbo].[Services]
        ([PK_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ApplicationUsingServices_Services'
CREATE INDEX [IX_FK_ApplicationUsingServices_Services]
ON [dbo].[ApplicationUsingServices]
    ([FK_ServicePK_ID]);
GO

-- Creating foreign key on [ServiceOperations2_PK_ID] in table 'ServiceOperationUsingServiceOperation'
ALTER TABLE [dbo].[ServiceOperationUsingServiceOperation]
ADD CONSTRAINT [FK_ServiceOperationUsingServiceOperation_ServiceOperations]
    FOREIGN KEY ([ServiceOperations2_PK_ID])
    REFERENCES [dbo].[ServiceOperations]
        ([PK_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ServiceOperations1_PK_ID] in table 'ServiceOperationUsingServiceOperation'
ALTER TABLE [dbo].[ServiceOperationUsingServiceOperation]
ADD CONSTRAINT [FK_ServiceOperationUsingServiceOperation_ServiceOperations1]
    FOREIGN KEY ([ServiceOperations1_PK_ID])
    REFERENCES [dbo].[ServiceOperations]
        ([PK_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ServiceOperationUsingServiceOperation_ServiceOperations1'
CREATE INDEX [IX_FK_ServiceOperationUsingServiceOperation_ServiceOperations1]
ON [dbo].[ServiceOperationUsingServiceOperation]
    ([ServiceOperations1_PK_ID]);
GO

-- Creating foreign key on [SRREntityHistoryTableSRREntityType_SRREntityType_PK_ID] in table 'SRREntityTypeSet'
ALTER TABLE [dbo].[SRREntityTypeSet]
ADD CONSTRAINT [FK_SRREntityHistoryTableSRREntityType]
    FOREIGN KEY ([SRREntityHistoryTableSRREntityType_SRREntityType_PK_ID])
    REFERENCES [dbo].[SRREntityHistoryTableSet]
        ([PK_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SRREntityHistoryTableSRREntityType'
CREATE INDEX [IX_FK_SRREntityHistoryTableSRREntityType]
ON [dbo].[SRREntityTypeSet]
    ([SRREntityHistoryTableSRREntityType_SRREntityType_PK_ID]);
GO

-- Creating foreign key on [SRREntityHistoryTableSRRUsers_SRRUsers_PK_ID] in table 'SRRUsersSet'
ALTER TABLE [dbo].[SRRUsersSet]
ADD CONSTRAINT [FK_SRREntityHistoryTableSRRUsers]
    FOREIGN KEY ([SRREntityHistoryTableSRRUsers_SRRUsers_PK_ID])
    REFERENCES [dbo].[SRREntityHistoryTableSet]
        ([PK_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SRREntityHistoryTableSRRUsers'
CREATE INDEX [IX_FK_SRREntityHistoryTableSRRUsers]
ON [dbo].[SRRUsersSet]
    ([SRREntityHistoryTableSRRUsers_SRRUsers_PK_ID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------