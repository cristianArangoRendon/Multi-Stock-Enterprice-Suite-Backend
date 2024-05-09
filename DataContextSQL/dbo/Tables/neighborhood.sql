CREATE TABLE [dbo].[neighborhood] (
    [idNeighborhood] INT           IDENTITY (1, 1) NOT NULL,
    [Description]    VARCHAR (126) NULL,
    [idCity]         INT           NULL,
    PRIMARY KEY CLUSTERED ([idNeighborhood] ASC),
    FOREIGN KEY ([idCity]) REFERENCES [dbo].[city] ([idCity])
);

