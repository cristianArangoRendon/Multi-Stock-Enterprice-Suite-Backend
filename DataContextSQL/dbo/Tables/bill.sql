CREATE TABLE [dbo].[bill] (
    [idBill]          INT          IDENTITY (1, 1) NOT NULL,
    [idMethodPayment] INT          NULL,
    [Name]            VARCHAR (50) NULL,
    [LastName]        VARCHAR (50) NULL,
    [Nit]             VARCHAR (10) NULL,
    [Date]            DATETIME     NULL,
    [totalPrice]      DECIMAL (18) NULL,
    [idUser]          INT          NULL,
    PRIMARY KEY CLUSTERED ([idBill] ASC),
    CONSTRAINT [FK_Bill_MethodPayment] FOREIGN KEY ([idMethodPayment]) REFERENCES [dbo].[methodPayment] ([idMethodPayment]),
    CONSTRAINT [fk_bill_user] FOREIGN KEY ([idUser]) REFERENCES [dbo].[users] ([idUser])
);

