CREATE TABLE [dbo].[products] (
    [idProduct]   INT           IDENTITY (1, 1) NOT NULL,
    [Description] VARCHAR (128) NULL,
    [stock]       INT           NULL,
    [idCategory]  INT           NOT NULL,
    [idBrand]     INT           NOT NULL,
    [idProvider]  INT           NOT NULL,
    [idUser]      INT           NULL,
    [uniqueCode]  VARCHAR (256) NULL,
    PRIMARY KEY CLUSTERED ([idProduct] ASC),
    FOREIGN KEY ([idBrand]) REFERENCES [dbo].[brand] ([idBrand]),
    FOREIGN KEY ([idCategory]) REFERENCES [dbo].[category] ([idCategory]),
    FOREIGN KEY ([idProvider]) REFERENCES [dbo].[provider] ([idProvider]),
    FOREIGN KEY ([idUser]) REFERENCES [dbo].[users] ([idUser])
);

