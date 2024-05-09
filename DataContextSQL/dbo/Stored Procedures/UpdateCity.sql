CREATE PROCEDURE [dbo].[UpdateCity]
	 @idCity int,
	 @Description varchar(126)
	 
AS
BEGIN
	Declare  @ResultMessage nvarchar(100) 
    BEGIN TRY
        UPDATE city
        SET [Description] = @Description      
        WHERE idCity = @idCity
        SET @ResultMessage = 'Updated City information'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'Error updating City information: ' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END

