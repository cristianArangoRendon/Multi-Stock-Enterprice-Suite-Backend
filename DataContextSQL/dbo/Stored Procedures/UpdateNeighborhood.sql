CREATE PROCEDURE [dbo].[UpdateNeighborhood]
    @IdNeighborhood int,
    @Description varchar(126),
    @idCity INT
AS
BEGIN
    DECLARE @ResultMessage nvarchar(100) 
    BEGIN TRY
        UPDATE dbo.neighborhood
        SET [Description] = @Description,
            idCity = @idCity
        WHERE IdNeighborhood = @IdNeighborhood and idCity = @idCity
        SET @ResultMessage = 'Updated Neighborhood information'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'Error updating Neighborhood information: ' + ERROR_MESSAGE()
    END CATCH
    SELECT @ResultMessage AS ResultMessage;
END
