CREATE TABLE [dbo].[Application_Keyword_Switch] (
    [FK_ApplicationPK_ID] INT NOT NULL,
    [FK_KeywordPK_ID]     INT NOT NULL,
    [PK_ID]               INT NOT NULL,
    CONSTRAINT [PK_Application_Keyword_Switch] PRIMARY KEY CLUSTERED ([PK_ID] ASC),
    CONSTRAINT [FK_ApplicationKeywordSwitcher_ApplicationSet] FOREIGN KEY ([FK_ApplicationPK_ID]) REFERENCES [dbo].[SRRApplications] ([PK_ID]),
    CONSTRAINT [FK_ApplicationKeywordSwitcher_KeywordSet] FOREIGN KEY ([FK_KeywordPK_ID]) REFERENCES [dbo].[SRREntityTagKeywords] ([PK_ID])
);

