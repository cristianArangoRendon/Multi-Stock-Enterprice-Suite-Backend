CREATE PROCEDURE [dbo].[GetUserByEmail]
@Email varchar(128)
AS
BEGIN
    SELECT *
    FROM users WHERE Email=@Email
END
