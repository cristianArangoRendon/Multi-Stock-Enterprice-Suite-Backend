CREATE PROCEDURE [dbo].[CreateNeighborhood](
@Description VARCHAR(126),
@idCity INT
)
AS 
BEGIN
	Declare  @ResultMessage nvarchar(100) 
    BEGIN TRY
        INSERT INTO neighborhood([Description], idCity)
        VALUES (@Description, @idCity)
        SET @ResultMessage = 'created Neighborhood Successfully'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'error Creating Neighborhood' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END
