CREATE PROCEDURE [dbo].[CreateBill]
(
    @idMethodPayment INT,
    @name VARCHAR(50),
    @lastName VARCHAR(50),
    @nit VARCHAR(10),
    @date DATETIME,
    @totalPrice DECIMAL(18,2),
    @idUser INT
)
AS
BEGIN
DECLARE @ResultMessage NVARCHAR(100)
IF EXISTS (
	SELECT 1 FROM users WHERE idUser = @idUser
	)
BEGIN
    BEGIN TRY
        INSERT INTO bill (
			idMethodPayment,
			Name,
			LastName,
			Nit,
			Date,
			totalPrice,
			idUser
		 )
        VALUES (
			@idMethodPayment,
			@name,
			@lastName,
			@nit,
			@date, 
			@totalPrice,
			@idUser
		);
        SET @ResultMessage = 'Bill created successfully';
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'Error creating invoice: ' + ERROR_MESSAGE();
    END CATCH
END
ELSE
BEGIN
    SET @ResultMessage = 'Username does not exist';
END

SELECT @ResultMessage AS ResultMessage;

END


