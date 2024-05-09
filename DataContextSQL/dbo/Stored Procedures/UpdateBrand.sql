CREATE PROCEDURE [dbo].[UpdateBrand]
	 @idBrand int,
	 @Description varchar(126)
AS
BEGIN
	Declare  @ResultMessage nvarchar(100) 
    BEGIN TRY

        UPDATE brand
        SET [Description] = @Description
           
        WHERE idBrand = @idBrand
        
        SET @ResultMessage = 'Updated Brand information'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'Error updating Brand information: ' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END

