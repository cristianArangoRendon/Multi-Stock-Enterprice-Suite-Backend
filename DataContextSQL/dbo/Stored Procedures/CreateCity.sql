CREATE PROCEDURE [dbo].[CreateCity]
   @Description varchar(126)
AS
BEGIN
	Declare  @ResultMessage nvarchar(100) 
    BEGIN TRY
        INSERT INTO city([Description])
        VALUES (@Description)
        SET @ResultMessage = 'created City Successfully'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'error Creating City' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END