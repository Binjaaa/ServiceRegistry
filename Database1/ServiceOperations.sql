CREATE TABLE [dbo].[ServiceOperations] (
    [PK_ID]              INT            IDENTITY (1, 1) NOT NULL,
    [Name]               NVARCHAR (MAX) NOT NULL,
    [Namespace]          NVARCHAR (MAX) NOT NULL,
    [Description]        NVARCHAR (MAX) NOT NULL,
    [Keywords]           NVARCHAR (MAX) NOT NULL,
    [ModificationDate]   NVARCHAR (MAX) NOT NULL,
    [ModificationReason] NVARCHAR (MAX) NOT NULL,
    [ModificationUser]   NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_OperationSet] PRIMARY KEY CLUSTERED ([PK_ID] ASC)
);

