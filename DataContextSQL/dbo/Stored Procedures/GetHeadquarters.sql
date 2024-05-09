CREATE PROCEDURE [dbo].[GetHeadquarters](
@idCompany INT
)
AS
BEGIN
	select * from headquarters where idCompany = @idCompany
END
