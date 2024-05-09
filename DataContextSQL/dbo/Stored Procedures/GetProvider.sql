CREATE PROCEDURE [dbo].[GetProvider](
@idCompany INT
)
AS
BEGIN
    
    SELECT 
        p.idProvider,
        p.Description
    FROM 
        [Provider] p
		where p.idCompany = @idCompany
END;
