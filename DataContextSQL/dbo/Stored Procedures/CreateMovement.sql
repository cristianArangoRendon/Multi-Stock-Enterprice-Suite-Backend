CREATE PROCEDURE [dbo].[CreateMovement](
@idMovementType INT,
@Description VARCHAR(126),
@Date DATETIME = GETDATE,
@IdUser INT
)
AS
BEGIN
	DECLARE @ResultMessage VARCHAR(500)
	BEGIN TRY
		Insert movement(idMovementType, Description, date, idUser)
		VALUES(@idMovementType, @Description, @Date, @IdUser)
		SET @ResultMessage = 'Create movement success'
	END TRY
	 BEGIN CATCH
			SET @ResultMessage = 'error Creating Movement' + ERROR_MESSAGE()
	END CATCH
		SELECT @ResultMessage AS ResultMessage;
END

