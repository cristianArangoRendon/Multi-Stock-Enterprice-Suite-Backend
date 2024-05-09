CREATE PROCEDURE [dbo].[GetProviderById]
@IdProvider int,
@idCompany int
AS
BEGIN
    
	SELECT * FROM [Provider] where idProvider = @IdProvider and idCompany = @idCompany
END;