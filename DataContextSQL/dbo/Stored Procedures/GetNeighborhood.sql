CREATE PROCEDURE GetNeighborhood(
@idCity INT
)
AS 
BEGIN
	SELECT
	n.idNeighborhood,
	n.Description
	FROM neighborhood n
	where n.idCity = @idCity
END