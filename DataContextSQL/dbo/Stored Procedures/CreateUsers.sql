CREATE PROCEDURE [dbo].[CreateUsers]
     @Names varchar(68),
     @lastNames varchar(68),
     @Email varchar(68),
     @Password nvarchar(128),
     @IdCompany INT,
     @IdRol VARCHAR(50),
     @Gender char(1),
     @Image varchar(250)
AS
BEGIN
    DECLARE @ResultMessage nvarchar(100)
    BEGIN TRY
        IF EXISTS (SELECT * FROM users WHERE Email = @Email)
        BEGIN
            SET @ResultMessage = 'Username already exists'
        END
        ELSE
        BEGIN
            DECLARE @DateTime datetime = GETDATE() 
            INSERT INTO users (Names, lastNames, Email, [password], idCompany, gender, image, lastLoginDate, idRol)
            VALUES (@Names, @lastNames, @Email, @Password, @IdCompany, @Gender, @Image, @DateTime,@IdRol)
            SET @ResultMessage = 'User created with role'
        END
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'Error creating user: ' + ERROR_MESSAGE()
    END CATCH
    SELECT @ResultMessage AS ResultMessage;
END


