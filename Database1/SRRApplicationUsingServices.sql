CREATE TABLE [dbo].[SRRApplicationUsingServices] (
    [FK_ApplicationPK_ID]    INT         NOT NULL,
    [FK_ServicePK_ID]        INT         NOT NULL,
    [RequestTransformation]  NCHAR (100) NULL,
    [ResponseTransformation] NCHAR (100) NULL,
    [FaultTransformation]    NCHAR (100) NULL,
    CONSTRAINT [PK_ApplicationUsingServices] PRIMARY KEY CLUSTERED ([FK_ApplicationPK_ID] ASC, [FK_ServicePK_ID] ASC),
    CONSTRAINT [FK_ApplicationUsingServices_Applications] FOREIGN KEY ([FK_ApplicationPK_ID]) REFERENCES [dbo].[SRRApplications] ([PK_ID]),
    CONSTRAINT [FK_ApplicationUsingServices_Services] FOREIGN KEY ([FK_ServicePK_ID]) REFERENCES [dbo].[SRRServices] ([PK_ID])
);

