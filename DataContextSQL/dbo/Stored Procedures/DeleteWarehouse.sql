CREATE PROCEDURE [dbo].[DeleteWarehouse](
    @idWarehouse INT,
	@idUser INT,
    @idCompany INT
)
AS
BEGIN
    DECLARE @ResultMessage NVARCHAR(100)
    IF EXISTS (
        SELECT 1
        FROM warehouse w
        INNER JOIN headquarters h ON w.idHeadquarter = h.idHeadquarter
        INNER JOIN Company c ON h.idCompany = c.idCompany
        INNER JOIN users u ON c.idCompany = u.idCompany
        WHERE w.idWarehouse = @idWarehouse
        AND u.idUser = @idUser AND c.IdCompany = @idCompany
    )
    BEGIN
        BEGIN TRY
            DELETE FROM warehouse WHERE idWarehouse = @idWarehouse
            SET @ResultMessage = 'Warehouse Deleted'
        END TRY
        BEGIN CATCH
            SET @ResultMessage = 'Error while deleting the Warehouse: ' + ERROR_MESSAGE()
        END CATCH
    END
    ELSE
    BEGIN
        SET @ResultMessage = 'Error: User does not have access to the provided Warehouse.'
    END
    
    SELECT @ResultMessage AS ResultMessage;
END

