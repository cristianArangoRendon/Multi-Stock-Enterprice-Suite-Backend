CREATE PROCEDURE [dbo].[GetBill](
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
	from bill B where idUser = @idUser
END

SELECT * FROM bill