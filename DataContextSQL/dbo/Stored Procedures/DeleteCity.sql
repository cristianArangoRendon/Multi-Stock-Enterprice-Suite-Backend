Create PROCEDURE [dbo].DeleteCity(
@idCity INT
)
AS
BEGIN
	Declare  @ResultMessage nvarchar(100) 
    BEGIN TRY
	delete city where idCity = @idCity
	    SET @ResultMessage = 'City Deleted'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'Error while deleting the idCity.: ' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END

