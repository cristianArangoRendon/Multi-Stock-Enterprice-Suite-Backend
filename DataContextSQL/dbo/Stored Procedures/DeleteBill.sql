CREATE PROCEDURE [dbo].[DeleteBill](
@idBill INT,
@idUser INT
)
AS
BEGIN
	Declare  @ResultMessage nvarchar(100) 
    BEGIN TRY
	delete bill where idBill = @idBill and idUser = @idUser
	    SET @ResultMessage = 'Bill Deleted'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'Error while deleting the Bill.: ' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END

