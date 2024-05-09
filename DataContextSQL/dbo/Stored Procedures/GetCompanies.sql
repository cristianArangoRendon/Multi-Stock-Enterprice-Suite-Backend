CREATE PROCEDURE [dbo].[GetCompanies]

AS
BEGIN
  SELECT 
	c.IdCompany,
	c.Description,
	c.GuidCompany,
	c.officeAddress,
	c.telephoneNumber,
	c.foundingDate,
	c.nit,
	c.nameCeo
  
  FROM dbo.company c
END


select * from company