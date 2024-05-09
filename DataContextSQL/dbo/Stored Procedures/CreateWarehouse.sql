CREATE PROCEDURE [dbo].[CreateWarehouse]
   @idHeadquarter INT,
   @Description VARCHAR(126),
   @idUser INT,
   @idCompany INT
AS
BEGIN
    DECLARE @ResultMessage NVARCHAR(100);
    IF EXISTS (
        SELECT 1
        FROM headquarters h
        INNER JOIN Company c ON h.idCompany = c.idCompany
        INNER JOIN users uc ON c.idCompany = uc.idCompany
        WHERE h.idheadquarter = @idHeadquarter
        AND uc.idUser = @idUser AND c.IdCompany = @idCompany
    )
    BEGIN
        BEGIN TRY
            INSERT INTO Warehouse (idHeadquarter, Description)
            VALUES (@idHeadquarter, @Description);
            
            SET @ResultMessage = 'Warehouse created successfully.';
        END TRY
        BEGIN CATCH
            SET @ResultMessage = 'Error creating Warehouse: ' + ERROR_MESSAGE();
        END CATCH
    END
    ELSE
    BEGIN
        SET @ResultMessage = 'Error: User does not have access to the provided Headquarter.';
    END

    SELECT @ResultMessage AS ResultMessage;
END


