CREATE PROCEDURE [dbo].[DeleteBrand]
    @idBrand int
AS
BEGIN
	Declare  @ResultMessage nvarchar(100) 
    BEGIN TRY
        DELETE FROM brand
        WHERE idBrand = @idBrand
        SET @ResultMessage = 'Brand Deleted'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'Error while deleting the Brand.: ' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END