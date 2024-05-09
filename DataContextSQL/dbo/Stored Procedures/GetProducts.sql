CREATE PROCEDURE [dbo].[GetProducts]
(
@idUser INT
)
AS
BEGIN
	SELECT 
		p.idProduct,
		p.[Description],
		p.stock,
		p.idCategory,
		p.idBrand,
		p.idProvider,
		p.UniqueCode,
		p.idUser
	FROM products p
	where p.idUser = @idUser
END;
