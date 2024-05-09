CREATE PROCEDURE [dbo].[UpdateHeadquarters]
   @idHeadquarter INT,
   @Description VARCHAR(126),
   @idCompany INT,
   @idCity INT,
   @idUser INT
AS
BEGIN
    DECLARE @ResultMessage NVARCHAR(100)  
    IF EXISTS (SELECT 1 FROM users WHERE idUser = @idUser AND idRol = 1)
    BEGIN
        BEGIN TRY
            UPDATE headquarters
            SET [Description] = @Description,
                idCompany = @idCompany,
                idCity = @idCity
            WHERE idheadquarter = @idHeadquarter
            SET @ResultMessage = 'Headquarters updated successfully'
        END TRY
        BEGIN CATCH
            SET @ResultMessage = 'Error updating headquarters: ' + ERROR_MESSAGE()
        END CATCH
    END
    ELSE
    BEGIN
        SET @ResultMessage = 'User does not have permission to update headquarters'
    END
    SELECT @ResultMessage AS ResultMessage;
END