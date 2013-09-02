CREATE TABLE [dbo].[ServiceOperationUsingServiceOperation] (
    [FK_CallerServiceOperationPK_ID] INT NOT NULL,
    [FK_CalledServiceOperationPK_ID] INT NOT NULL,
    CONSTRAINT [FK_ServiceOperationUsingServiceOperation_ServiceOperations] FOREIGN KEY ([FK_CalledServiceOperationPK_ID]) REFERENCES [dbo].[ServiceOperations] ([PK_ID]),
    CONSTRAINT [FK_ServiceOperationUsingServiceOperation_ServiceOperations1] FOREIGN KEY ([FK_CallerServiceOperationPK_ID]) REFERENCES [dbo].[ServiceOperations] ([PK_ID])
);

