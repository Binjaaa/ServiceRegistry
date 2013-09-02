CREATE TABLE [dbo].[SRREntityHistoryTable] (
    [PK_ID]      INT            IDENTITY (1, 1) NOT NULL,
    [ModDate]    NVARCHAR (MAX) NOT NULL,
    [ModReason]  NVARCHAR (MAX) NOT NULL,
    [FK_ModUser] INT            NOT NULL,
    CONSTRAINT [PK_SRREntityHistoryTableSet] PRIMARY KEY CLUSTERED ([PK_ID] ASC),
    CONSTRAINT [FK_SRREntityHistoryTable_SRRUsers] FOREIGN KEY ([FK_ModUser]) REFERENCES [dbo].[SRRUsers] ([PK_ID])
);

