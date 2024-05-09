CREATE PROCEDURE [dbo].[DeleteRol]
    @idRol int
AS
BEGIN
	Declare  @ResultMessage nvarchar(100) 
    BEGIN TRY
        DELETE FROM rol
        WHERE idRol = @idRol
        SET @ResultMessage = 'Rol Delete'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'Error while deleting the rol.: ' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END
