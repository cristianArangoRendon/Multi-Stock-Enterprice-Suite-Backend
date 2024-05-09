CREATE PROCEDURE [dbo].[CreateBrand]
   @Description varchar(126)

AS
BEGIN
	Declare  @ResultMessage nvarchar(100) 
    BEGIN TRY
        INSERT INTO brand([Description])
        VALUES (@Description)
        SET @ResultMessage = 'created Brand Successfully'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'error Creating Brand' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END