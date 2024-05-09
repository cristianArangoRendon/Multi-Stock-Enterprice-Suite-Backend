CREATE PROCEDURE DeleteNeighborhood(
@idNeighborhood INT
)
AS
BEGIN 
	Declare  @ResultMessage nvarchar(100) 
    BEGIN TRY
	delete neighborhood where idNeighborhood = @idNeighborhood 
	    SET @ResultMessage = 'Neighborhood Deleted'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'Error while deleting the Neighborhood.: ' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END