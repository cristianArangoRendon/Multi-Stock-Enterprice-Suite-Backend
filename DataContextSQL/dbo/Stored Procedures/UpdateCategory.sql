CREATE PROCEDURE [dbo].[UpdateCategory]
	 @idCategory int,
	 @Description varchar(126)
	 
AS
BEGIN
	Declare  @ResultMessage nvarchar(100) 
    BEGIN TRY

        UPDATE category
        SET [Description] = @Description
           
        WHERE idCategory = @idCategory
        
        SET @ResultMessage = 'Updated category information'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'Error updating category information: ' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END
