CREATE PROCEDURE [dbo].[UpdateMethodPayment]
    @IdMethodPayment INT,
    @Description VARCHAR(126)
AS
BEGIN
   	Declare  @ResultMessage nvarchar(100) 
    BEGIN TRY
        UPDATE dbo.methodPayment
        SET [Description] = @Description   
        WHERE idMethodPayment = @IdMethodPayment
        SET @ResultMessage = 'Updated MethodPayment information'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'Error updating MethodPayment information: ' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END;