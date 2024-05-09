CREATE PROCEDURE [dbo].[DeleteCategory]
    @idCategory int
AS
BEGIN
	Declare  @ResultMessage nvarchar(100) 
    BEGIN TRY
        DELETE FROM category
        WHERE idCategory = @idCategory
        SET @ResultMessage = 'category Deleted'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'Error while deleting the category.: ' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END
