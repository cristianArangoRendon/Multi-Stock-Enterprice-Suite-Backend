CREATE TABLE [dbo].[country] (
    [idCountry]   INT           IDENTITY (1, 1) NOT NULL,
    [Description] VARCHAR (126) NULL,
    [idCompany]   INT           NULL,
    PRIMARY KEY CLUSTERED ([idCountry] ASC),
    CONSTRAINT [FK_CompanyID] FOREIGN KEY ([idCompany]) REFERENCES [dbo].[company] ([IdCompany])
);

