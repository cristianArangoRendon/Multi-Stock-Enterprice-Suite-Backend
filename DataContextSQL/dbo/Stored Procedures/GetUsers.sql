CREATE PROCEDURE [dbo].[GetUsers]
 @idCompany int
	
AS
BEGIN
    
	SELECT 
	 u.idUser,
	 u.Names,
	 u.lastNames,
	 u.Email,
	 u.password,
	 u.idCompany,
	 u.lastLoginDate,
	 u.gender,
	 u.image, 
	 u.idRol
	FROM users  u

	WHERE u.idCompany = @idCompany

END;
