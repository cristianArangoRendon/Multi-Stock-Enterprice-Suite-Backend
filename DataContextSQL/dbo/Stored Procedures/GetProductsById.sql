CREATE PROCEDURE [dbo].[GetProductsById]
@IdProduct INT,
@IdUser INT
AS
BEGIN
	SELECT * FROM products where idProduct = @IdProduct AND idUser = @idUser
END;