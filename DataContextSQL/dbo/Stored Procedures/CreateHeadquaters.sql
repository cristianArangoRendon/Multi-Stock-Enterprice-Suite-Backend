CREATE PROCEDURE [dbo].[CreateHeadquaters]
   @Description varchar(126),
   @idCompany INT,
   @idCity INT,
   @idUser INT

AS
BEGIN
	 DECLARE @ResultMessage NVARCHAR(100)
    IF EXISTS (SELECT 1 FROM users WHERE idUser = @idUser AND idRol = 1)
    BEGIN
        BEGIN TRY
            INSERT INTO headquarters (Description, idCompany, idCity)
            VALUES (@Description, @idCompany, @idCity)
            SET @ResultMessage = 'Headquarters created successfully'
        END TRY
        BEGIN CATCH
            SET @ResultMessage = 'Error creating headquarters: ' + ERROR_MESSAGE()
        END CATCH
    END
    ELSE
    BEGIN
        SET @ResultMessage = 'User does not have permission to create headquarters'
    END
    SELECT @ResultMessage AS ResultMessage;
END

SELECT * FROM rol