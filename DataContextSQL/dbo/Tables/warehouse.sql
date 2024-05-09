CREATE TABLE [dbo].[warehouse] (
    [idWarehouse]   INT           IDENTITY (1, 1) NOT NULL,
    [idHeadquarter] INT           NULL,
    [Description]   VARCHAR (126) NULL,
    PRIMARY KEY CLUSTERED ([idWarehouse] ASC),
    CONSTRAINT [FK_Warehouse_Sede] FOREIGN KEY ([idHeadquarter]) REFERENCES [dbo].[headquarters] ([idheadquarter])
);

