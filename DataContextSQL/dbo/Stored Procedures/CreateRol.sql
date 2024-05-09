CREATE PROCEDURE [dbo].[CreateRol]
   @Description varchar(126)
AS
BEGIN
	Declare  @ResultMessage nvarchar(100) 
    BEGIN TRY
        INSERT INTO rol([Description])
        VALUES (@Description)  
        SET @ResultMessage = 'created rol Successfully'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'error Creating rol' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END