CREATE PROCEDURE [dbo].[CreateCategory]
   @Description varchar(126)
AS
BEGIN
	Declare  @ResultMessage nvarchar(100) 
    BEGIN TRY
        INSERT INTO category([Description])
        VALUES (@Description)  
        SET @ResultMessage = 'created category Successfully'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'error Creating category' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END