CREATE PROCEDURE [dbo].[GetCategoryById]
@IdCategory int
AS
BEGIN 
	SELECT * FROM category WHERE idCategory = @IdCategory
END;