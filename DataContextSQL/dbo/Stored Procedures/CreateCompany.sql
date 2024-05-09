CREATE PROCEDURE [dbo].[CreateCompany]
(
    @Description NVARCHAR(255),
	@guidCompany VARCHAR(126),
	@officeAddress VARCHAR(50),
	@telephoneNumber varchar(11),
	@foundingDate VARCHAR(50),
	@nit VARCHAR(50),
	@nameCEO VARCHAR(50)
)
AS
BEGIN
    Declare  @ResultMessage nvarchar(100) 
    BEGIN TRY
        INSERT INTO company([Description], GuidCompany, officeAddress, telephoneNumber, FoundingDate, nit, nameCEO )
        VALUES (@Description,@GuidCompany,@officeAddress,@telephoneNumber,@foundingDate,@nit,@nameCEO)       
        SET @ResultMessage = 'created company Successfully'
    END TRY
    BEGIN CATCH
        SET @ResultMessage = 'error Creating company' + ERROR_MESSAGE()
    END CATCH
	    SELECT @ResultMessage AS ResultMessage;
END