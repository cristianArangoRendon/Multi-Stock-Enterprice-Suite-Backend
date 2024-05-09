CREATE TABLE [dbo].[headquarters] (
    [idheadquarter] INT           IDENTITY (1, 1) NOT NULL,
    [Description]   VARCHAR (126) NULL,
    [idCompany]     INT           NULL,
    [idCity]        INT           NULL,
    PRIMARY KEY CLUSTERED ([idheadquarter] ASC),
    FOREIGN KEY ([idCity]) REFERENCES [dbo].[city] ([idCity]),
    CONSTRAINT [FK_headquarters_Company] FOREIGN KEY ([idCompany]) REFERENCES [dbo].[company] ([IdCompany])
);

