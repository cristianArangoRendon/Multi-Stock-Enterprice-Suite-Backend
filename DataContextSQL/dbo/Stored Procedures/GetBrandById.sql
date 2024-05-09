CREATE PROCEDURE [dbo].[GetBrandById]
@IdBrand INT
AS
BEGIN
    SELECT 
	b.idBrand,
	b.Description
    FROM brand b WHERE idBrand = @IdBrand
END
