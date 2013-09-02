CREATE TABLE [dbo].[ServiceMessageKeywordSwitch] (
    [FK_ServiceMessagePK_ID] INT NOT NULL,
    [FK_KeywordPK_ID]        INT NOT NULL,
    CONSTRAINT [FK_ServiceMessageKeywordSwitcher_Keywords] FOREIGN KEY ([FK_KeywordPK_ID]) REFERENCES [dbo].[SRREntityTagKeywords] ([PK_ID]),
    CONSTRAINT [FK_ServiceMessageKeywordSwitcher_ServiceMessages] FOREIGN KEY ([FK_ServiceMessagePK_ID]) REFERENCES [dbo].[SRRServiceMessages] ([PK_ID])
);

