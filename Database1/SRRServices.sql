CREATE TABLE [dbo].[SRRServices] (
    [PK_ID]           INT            IDENTITY (1, 1) NOT NULL,
    [Name]            NVARCHAR (MAX) NOT NULL,
    [Namespace]       NVARCHAR (MAX) NOT NULL,
    [Description]     NVARCHAR (MAX) NOT NULL,
    [Version]         NVARCHAR (MAX) NOT NULL,
    [FK_Owner]        INT            NOT NULL,
    [EndpointDEV]     NVARCHAR (MAX) NOT NULL,
    [EndpointQA]      NVARCHAR (MAX) NOT NULL,
    [EndpointPROD]    NVARCHAR (MAX) NOT NULL,
    [MaxResponseTime] NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_ServiceSet] PRIMARY KEY CLUSTERED ([PK_ID] ASC),
    CONSTRAINT [FK_SRRServices_SRRUsers] FOREIGN KEY ([FK_Owner]) REFERENCES [dbo].[SRRUsers] ([PK_ID])
);

