CREATE TABLE [dbo].[Service_Keywords_Switch] (
    [FK_ServicePK_ID] INT NOT NULL,
    [FK_KeywordPK_ID] INT NOT NULL,
    CONSTRAINT [FK_ServiceKeywordSwitcher_Keywords] FOREIGN KEY ([FK_KeywordPK_ID]) REFERENCES [dbo].[SRREntityTagKeywords] ([PK_ID]),
    CONSTRAINT [FK_ServiceKeywordSwitcher_Services] FOREIGN KEY ([FK_ServicePK_ID]) REFERENCES [dbo].[SRRServices] ([PK_ID])
);

