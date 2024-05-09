CREATE PROCEDURE [dbo].[GetBrands]
AS
BEGIN
    
	SELECT 
	b.idBrand,
	b.Description
	FROM brand b
END;
