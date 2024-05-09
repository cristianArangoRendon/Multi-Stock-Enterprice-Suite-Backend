CREATE TABLE [dbo].[provider] (
    [idProvider]  INT           IDENTITY (1, 1) NOT NULL,
    [Description] VARCHAR (126) NULL,
    [idCompany]   INT           NULL,
    PRIMARY KEY CLUSTERED ([idProvider] ASC),
    CONSTRAINT [FK_Provider_Company] FOREIGN KEY ([idCompany]) REFERENCES [dbo].[company] ([IdCompany])
);

