CREATE PROCEDURE [dbo].[UpdateCompany]
	 @IdCompany int,
	 @Description varchar(126)
	 
AS
BEGIN
	Declare  @ResultMessage nvarchar(100) 
    BEGIN TRY
        UPDATE dbo.company
        SET [Description] = @Description
        WHERE IdCompany = @IdCompany     
        SET @ResultMessage = 'Updated company information'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'Error updating company information: ' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END
