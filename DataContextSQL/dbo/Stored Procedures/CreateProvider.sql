CREATE PROCEDURE [dbo].[CreateProvider]
   @Description varchar(126),
   @idCompany INT
AS
BEGIN
	Declare  @ResultMessage nvarchar(100) 
    BEGIN TRY
        INSERT INTO [Provider]([Description], idCompany)
        VALUES (@Description,@idCompany)
        SET @ResultMessage = 'created Provider Successfully'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'error Creating Provider' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END