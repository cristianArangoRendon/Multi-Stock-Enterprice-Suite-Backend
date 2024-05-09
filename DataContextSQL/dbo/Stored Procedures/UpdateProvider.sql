CREATE PROCEDURE [dbo].[UpdateProvider]
	 @idProvider int,
	 @Description varchar(126),
	 @idCompany int
	 
AS
BEGIN
	Declare  @ResultMessage nvarchar(100) 
    BEGIN TRY
        UPDATE [Provider]
        SET [Description] = @Description 
        WHERE idProvider = @idProvider and idCompany = @idCompany
        SET @ResultMessage = 'Updated Provider information'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'Error updating Provider information: ' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END
