CREATE PROCEDURE [dbo].[DeleteUsers]
    @UserId int
AS
BEGIN
	Declare  @ResultMessage nvarchar(100) 
    BEGIN TRY
        DELETE FROM users
        WHERE idUser = @UserId   
        SET @ResultMessage = 'User Deleted'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'Error when deleting user: ' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END