CREATE PROCEDURE [dbo].[GetUserById]
@idUser INT, 
@idCompany INT
AS
BEGIN
	DECLARE @ResultMessage VARCHAR(126)
	IF EXISTS(
		SELECT * FROM users u 
		JOIN company c ON u.idCompany = c.IdCompany
		WHERE idUser = @IdUser AND c.IdCompany = @idCompany
	)
	 BEGIN
        BEGIN TRY
	
    SELECT *
    FROM users WHERE idUser=@IdUser
	 END TRY
	  BEGIN CATCH
        SET @ResultMessage = 'Error while deleting the Bill.: ' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
	END
END
