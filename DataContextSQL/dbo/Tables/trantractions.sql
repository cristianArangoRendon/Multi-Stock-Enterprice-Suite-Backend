CREATE TABLE [dbo].[trantractions] (
    [idtrantractions] INT           IDENTITY (1, 1) NOT NULL,
    [idUser]          INT           NULL,
    [idProduct]       INT           NULL,
    [DateEntry]       DATE          NULL,
    [DateOut]         DATE          NULL,
    [operation]       INT           NULL,
    [Description]     VARCHAR (126) NULL,
    PRIMARY KEY CLUSTERED ([idtrantractions] ASC),
    FOREIGN KEY ([idProduct]) REFERENCES [dbo].[products] ([idProduct]),
    FOREIGN KEY ([idUser]) REFERENCES [dbo].[users] ([idUser])
);

