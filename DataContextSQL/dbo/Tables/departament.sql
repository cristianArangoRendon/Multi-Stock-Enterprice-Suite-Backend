CREATE TABLE [dbo].[departament] (
    [idDepartamento] INT           IDENTITY (1, 1) NOT NULL,
    [Description]    VARCHAR (126) NULL,
    [idCountry]      INT           NULL,
    PRIMARY KEY CLUSTERED ([idDepartamento] ASC),
    FOREIGN KEY ([idCountry]) REFERENCES [dbo].[country] ([idCountry])
);

