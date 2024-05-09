CREATE PROCEDURE [dbo].[GetCities]
@idDepartament INT
As
BEGIN
	SELECT 
	c.idCity,
	c.Description
	FROM city c where idDepartament = @idDepartament
END
