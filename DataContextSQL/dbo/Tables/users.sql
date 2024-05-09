CREATE TABLE [dbo].[users] (
    [idUser]        INT            IDENTITY (1, 1) NOT NULL,
    [names]         VARCHAR (68)   NULL,
    [lastNames]     VARCHAR (68)   NULL,
    [Email]         VARCHAR (86)   NULL,
    [password]      NVARCHAR (128) NULL,
    [idCompany]     INT            NULL,
    [lastLoginDate] DATETIME       NULL,
    [gender]        CHAR (1)       NULL,
    [image]         VARCHAR (250)  NULL,
    [idRol]         INT            NULL,
    PRIMARY KEY CLUSTERED ([idUser] ASC),
    FOREIGN KEY ([idCompany]) REFERENCES [dbo].[company] ([IdCompany]),
    CONSTRAINT [FK_User_Rol] FOREIGN KEY ([idRol]) REFERENCES [dbo].[rol] ([idRol])
);

