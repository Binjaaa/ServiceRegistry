CREATE TABLE [dbo].[SRRApplications] (
    [PK_ID]           INT            IDENTITY (1, 1) NOT NULL,
    [Name]            NVARCHAR (MAX) NOT NULL,
    [Version]         NVARCHAR (MAX) NOT NULL,
    [Description]     NVARCHAR (MAX) NOT NULL,
    [FK_Developer]    INT            NOT NULL,
    [AttachedObjects] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_ApplicationSet] PRIMARY KEY CLUSTERED ([PK_ID] ASC),
    CONSTRAINT [FK_SRRApplications_SRRUsers] FOREIGN KEY ([FK_Developer]) REFERENCES [dbo].[SRRUsers] ([PK_ID]) 
);

