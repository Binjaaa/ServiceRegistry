CREATE TABLE [dbo].[ServiceOperation_Keyword_Switch] (
    [FK_ServiceOperationPK_ID] INT NOT NULL,
    [FK_KeywordPK_ID]          INT NOT NULL,
    CONSTRAINT [FK_ServiceOperationKeywordSwitcher_Keywords] FOREIGN KEY ([FK_KeywordPK_ID]) REFERENCES [dbo].[SRREntityTagKeywords] ([PK_ID]),
    CONSTRAINT [FK_ServiceOperationKeywordSwitcher_ServiceOperations] FOREIGN KEY ([FK_ServiceOperationPK_ID]) REFERENCES [dbo].[ServiceOperations] ([PK_ID])
);

