CREATE TABLE [dbo].[SRRUsers] (
    [PK_ID]     INT           IDENTITY (1, 1) NOT NULL,
    [Name]      NVARCHAR (50) NOT NULL,
    [LoginName] NVARCHAR (50) NULL,
    [Password]  NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_SRRUsersSet] PRIMARY KEY CLUSTERED ([PK_ID] ASC)
);

