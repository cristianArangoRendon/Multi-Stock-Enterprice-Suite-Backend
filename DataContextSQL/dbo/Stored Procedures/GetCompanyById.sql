CREATE PROCEDURE [dbo].[GetCompanyById]
(
    @GuidCompany VARCHAR(126) 
)
AS
BEGIN
  SELECT * FROM
  dbo.company WHERE guidCompany = @GuidCompany
END