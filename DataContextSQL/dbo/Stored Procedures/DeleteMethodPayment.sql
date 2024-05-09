CREATE PROCEDURE [dbo].[DeleteMethodPayment](
@IdMethodPayment INT
)
AS
BEGIN
 	Declare  @ResultMessage nvarchar(100) 
    BEGIN TRY
        DELETE FROM methodPayment
        WHERE idMethodPayment = @IdMethodPayment
        SET @ResultMessage = 'MethodPayment Deleted'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'Error while deleting the product.: ' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END