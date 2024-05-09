CREATE PROCEDURE [dbo].[DeleteCompany]
(
    @GuidCompany VARCHAR(126) 
)
AS
BEGIN
	Declare @ResultMessage VARCHAR(500)
	BEGIN TRY
    	DELETE dbo.company WHERE guidCompany = @GuidCompany
		set @ResultMessage = 'Company successfully eliminated'
	END TRY
	BEGIN CATCH
		SET @ResultMessage = 'Error while deleting the product.:  ' + ERROR_MESSAGE()
	END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END


