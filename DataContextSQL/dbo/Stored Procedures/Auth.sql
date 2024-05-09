CREATE PROCEDURE [dbo].[Auth]
    @email NVARCHAR(50),
    @password NVARCHAR(max)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Result varchar(128);
    IF EXISTS (SELECT 1 FROM Users WHERE Email = @email AND Password = @password)
    BEGIN
        SET @Result = 'ok'; 
    END
    ELSE IF EXISTS (SELECT 1 FROM Users WHERE Email = @email)
    BEGIN
        SET @Result = 'Incorret Password'; -- Contraseña incorrecta
    END
    ELSE
    BEGIN
        SET @Result = 'user not found'; -- Usuario no encontrado
    END
    SELECT @Result AS ResultCode;
END;