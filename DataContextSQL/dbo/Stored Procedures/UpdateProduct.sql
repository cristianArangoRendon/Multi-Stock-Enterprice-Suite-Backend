CREATE PROCEDURE [dbo].[UpdateProduct]
	@idProduct int,
	@Description varchar(128),
	@minimunQuantity int,
	@stock int,
	@idCategory int,
	@idBrand int,
	@idProvider int,
	@uniqueCode varchar(126),
	@idUser int
AS
BEGIN
	Declare  @ResultMessage nvarchar(100) 
    BEGIN TRY
        UPDATE products
			SET 
				  [Description] = @Description,
				  stock = @stock,
				  idCategory = @idCategory,
				  idBrand = @idBrand,
				  idProvider =@idProvider ,
				  UniqueCode = @uniqueCode
			WHERE idProduct = @idProduct and idUser = @idUser
        
        SET @ResultMessage = 'Updated Product information'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'Error updating Product information: ' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END