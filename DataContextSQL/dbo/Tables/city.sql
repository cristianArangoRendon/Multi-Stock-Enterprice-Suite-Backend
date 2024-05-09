CREATE TABLE [dbo].[city] (
    [idCity]        INT           IDENTITY (1, 1) NOT NULL,
    [Description]   VARCHAR (126) NULL,
    [idDepartament] INT           NULL,
    PRIMARY KEY CLUSTERED ([idCity] ASC),
    CONSTRAINT [FK_City_Department] FOREIGN KEY ([idDepartament]) REFERENCES [dbo].[departament] ([idDepartamento])
);

