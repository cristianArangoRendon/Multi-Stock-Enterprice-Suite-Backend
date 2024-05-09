CREATE TABLE [dbo].[company] (
    [IdCompany]       INT           IDENTITY (1, 1) NOT NULL,
    [Description]     VARCHAR (60)  NULL,
    [GuidCompany]     VARCHAR (126) NULL,
    [officeAddress]   VARCHAR (50)  NULL,
    [telephoneNumber] VARCHAR (11)  NULL,
    [foundingDate]    VARCHAR (50)  NULL,
    [nit]             VARCHAR (50)  NULL,
    [nameCEO]         VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([IdCompany] ASC)
);

