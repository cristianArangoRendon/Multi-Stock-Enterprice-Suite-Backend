CREATE PROCEDURE [dbo].[DeleteProduct]
    @IdProduct int,
	@Date  datetime = NULL
AS
BEGIN
	 IF @Date IS NULL
        SET @Date = GETDATE()
	Declare  @ResultMessage nvarchar(100) 
    BEGIN TRY
	
	DECLARE @Description varchar(128);
		SELECT @Description = p.Description
		FROM products p
		WHERE idProduct = @IdProduct;
		EXEC CreateMovement
			@idMovementType = 2,
			@Description = @Description,
			@Date = @Date;
        DELETE FROM products
        WHERE idProduct = @IdProduct
        SET @ResultMessage = 'product Deleted'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'Error while deleting the product.: ' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END
