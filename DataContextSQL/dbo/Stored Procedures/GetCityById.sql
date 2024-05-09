CREATE PROCEDURE GetCityById(
@idCity INT
)
AS
BEGIN
	select * from city where idCity = @idCity
END