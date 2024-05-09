CREATE PROCEDURE [dbo].[UpdateBill]
    @idBill INT,
    @idMethodPayment INT,
    @name VARCHAR(50),
    @lastName VARCHAR(50),
    @nit VARCHAR(126),
    @date DATETIME,
    @totalPrice DECIMAL,
    @idUser INT,
    @idCompany INT
AS
BEGIN
    DECLARE @ResultMessage NVARCHAR(100);
    DECLARE @UserBelongsToCompany BIT;

    -- Verificar si el usuario pertenece a la empresa de la factura
    SELECT @UserBelongsToCompany = CASE 
                                        WHEN EXISTS (
                                            SELECT 1
                                            FROM Bill b
                                            INNER JOIN Users u ON b.idUser = u.idUser
                                            WHERE b.idBill = @idBill AND u.idCompany = @idCompany
                                        )
                                        THEN 1
                                        ELSE 0
                                    END;

    -- Si el usuario no pertenece a la empresa, no permitir la actualización
    IF @UserBelongsToCompany = 0
    BEGIN
        SET @ResultMessage = 'The user does not have permissions to update this Bill.';
    END
    ELSE
    BEGIN
        BEGIN TRY
            UPDATE Bill
            SET
                idMethodPayment = @idMethodPayment,
                [name] = @name,
                lastName = @lastName,
                nit = @nit,
                [date] = @date,
                totalPrice = @totalPrice
            WHERE idBill = @idBill;

            SET @ResultMessage = 'The Bill has been updated successfully.';
        END TRY
        BEGIN CATCH
            SET @ResultMessage = 'Error updating Bill: ' + ERROR_MESSAGE();
        END CATCH
    END

    SELECT @ResultMessage AS ResultMessage;
END

