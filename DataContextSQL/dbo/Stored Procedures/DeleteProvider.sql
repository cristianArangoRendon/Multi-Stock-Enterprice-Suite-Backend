CREATE PROCEDURE [dbo].[DeleteProvider]
    @idProvider int,
	@idCompany int
AS
BEGIN
	Declare  @ResultMessage nvarchar(100) 
    BEGIN TRY
        DELETE FROM [Provider]
        WHERE idProvider = @idProvider and idCompany = @idCompany
        SET @ResultMessage = 'Provider Deleted'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'Error while deleting the Provider.: ' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END