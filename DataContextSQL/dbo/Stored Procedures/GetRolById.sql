CREATE PROCEDURE [dbo].[GetRolById]
@idRol int
AS
BEGIN
    
	SELECT * FROM rol where idRol = @idRol
END;
