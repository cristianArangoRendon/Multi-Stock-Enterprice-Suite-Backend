CREATE PROCEDURE [dbo].[UpdateRol]
	 @idRol int,
	 @Description varchar(126)
AS
BEGIN
	Declare  @ResultMessage nvarchar(100) 
    BEGIN TRY
        UPDATE rol
        SET [Description] = @Description       
        WHERE idRol = @idRol
        SET @ResultMessage = 'Updated rol information'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'Error updating rol information: ' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END
