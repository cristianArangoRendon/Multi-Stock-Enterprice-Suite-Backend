CREATE TABLE [dbo].[movement] (
    [idMovement]     INT           IDENTITY (1, 1) NOT NULL,
    [idMovementType] INT           NOT NULL,
    [Description]    VARCHAR (126) NULL,
    [date]           DATETIME      NULL,
    [idUser]         INT           NULL,
    PRIMARY KEY CLUSTERED ([idMovement] ASC),
    CONSTRAINT [FK_MovementType] FOREIGN KEY ([idMovementType]) REFERENCES [dbo].[movementType] ([idMovementType]),
    CONSTRAINT [FK_UserMovement] FOREIGN KEY ([idUser]) REFERENCES [dbo].[users] ([idUser])
);

