CREATE PROCEDURE [dbo].[UpdateUsers]
    @idUser int,
    @Names varchar(68),
    @lastNames varchar(68),
    @Email varchar(68),
    @password nvarchar(128),
    @idRol int,
    @idCompany int
AS
BEGIN
    DECLARE @ResultMessage nvarchar(100) 
    BEGIN TRY
        IF EXISTS (SELECT 1 FROM Users WHERE idUser = @idUser AND idCompany = @idCompany)
        BEGIN
            UPDATE Users
            SET Names = @Names,
                lastNames = @lastNames,
                Email = @Email,
                [password] = @password,
                idRol = @idRol
            WHERE idUser = @idUser AND idCompany = @idCompany

            SET @ResultMessage = 'Updated user information'
        END
        ELSE
        BEGIN
            SET @ResultMessage = 'Error: User does not belong to the specified company'
        END
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'Error updating user information: ' + ERROR_MESSAGE()
    END CATCH
    SELECT @ResultMessage AS ResultMessage;
END
