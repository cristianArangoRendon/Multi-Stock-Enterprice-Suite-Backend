CREATE PROCEDURE [dbo].[GetNeighborhoodById]
@idNeighborhood INT,
@idCity INT
AS
BEGIN
	SELECT * FROM neighborhood where idNeighborhood = @IdNeighborhood AND idCity = @idCity
END;

