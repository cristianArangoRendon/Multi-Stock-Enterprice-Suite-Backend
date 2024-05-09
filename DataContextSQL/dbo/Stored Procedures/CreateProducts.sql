CREATE PROCEDURE [dbo].[CreateProducts]
    @Description varchar(128),
    @stock int,
    @idCategory int,
    @idBrand int,
    @idProvider int,
    @uniqueCode varchar(256),
    @idUser INT,
    @Date datetime = NULL -- Deja el valor predeterminado como NULL'
AS
BEGIN
    IF @Date IS NULL
        SET @Date = GETDATE()
    DECLARE @ResultMessage nvarchar(100)
    BEGIN TRY
        INSERT INTO products ([Description], stock, idCategory, idBrand, idProvider, uniqueCode, idUser)
        VALUES (@Description, @stock, @idCategory, @idBrand, @idProvider, @uniqueCode, @idUser)
        EXEC CreateMovement
		@idMovementType = 1,
		@Description = @Description,
		@Date = @Date,
		@idUser = @idUser
        
        SET @ResultMessage = 'Product created'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'Error creating Product: ' + ERROR_MESSAGE()
    END CATCH
    SELECT @ResultMessage AS ResultMessage;
END