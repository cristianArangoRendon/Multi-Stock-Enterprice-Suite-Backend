CREATE PROCEDURE [dbo].[GetWarehouse](
    @idHeadquarter INT,
	@idCompany INT
)
AS
BEGIN
	DECLARE @ResultMessage VARCHAR(126)
 -- Validar que la sede pertenezca a la empresa
    IF EXISTS (SELECT 1 FROM headquarters WHERE idheadquarter = @idHeadquarter AND idCompany = @idCompany)
    BEGIN
        -- Consulta de almacén solo si la sede existe en la empresa
        SELECT
            w.idWarehouse,
            w.Description
        FROM
            Warehouse w
        WHERE
            w.idHeadquarter = @idHeadquarter;
    END
    ELSE
    BEGIN
        BEGIN
        SET @ResultMessage = 'Error: User does not have access to the provided Headquarter.';
    END
    END
END;
