CREATE PROCEDURE GetBillById(
@idBill INT,
@idUser INT
)
AS
BEGIN
	select 
		b.idBill,
		b.idMethodPayment,
		b.Name,
		b.LastName,
		b.Nit,
		b.Date,
		b.totalPrice,
		b.idUser
	from bill B where idBill = @idBill AND idUser = @idUser
END

SELECT * FROM bill