using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.Bill;
using ProyectoFinal.Core.Interfaces.IBLL.Bill;
using ProyectoFinal.ErrorResponse.Doc.Bill;
using ProyectoFinal.SwaggerExample.ErrorResponse;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.Controllers.v1;

[Route("[controller]")]
[ApiController]
[Authorize]
[ProducesResponseType(typeof(Error401ResponseExample), StatusCodes.Status401Unauthorized)]
[SwaggerResponseExample(401, typeof(Error401ResponseExample))]
[ProducesResponseType(typeof(Response200Example), StatusCodes.Status200OK)]
[ProducesResponseType(typeof(Error500ResponseExample), StatusCodes.Status500InternalServerError)]
[SwaggerResponseExample(500, typeof(Error500ResponseExample))]
[ProducesResponseType(typeof(Error400ResponseExample), StatusCodes.Status400BadRequest)]
[SwaggerResponseExample(400, typeof(Error400ResponseExample))]
public class BillController : ControllerBase
{
    private readonly IBillBLL _bill;

    public BillController(IBillBLL bill)
    {
        _bill = bill;
    }

    /// <summary>
    /// Creates a new bill.
    /// </summary>
    ///  <param name="bill">
    ///      Required:
    /// - `idMethodPayment`: Represents the identifier of the payment method used in a transaction. It contains authentication data related to the email, likely indicating the method through which payments are made in a system.
    /// - `name`: Represents the name associated with a user account or profile. It contains authentication data related to the password, suggesting it's part of the credentials used for user authentication.
    /// - `lastName`: Represents the last name associated with a user account or profile. It contains authentication data related to the password, likely serving as additional information for user identification.
    /// - `nit`: Represents the Tax Identification Number (TIN) in some countries. It contains authentication data related to the password, possibly indicating the authentication process for tax-related transactions or user verification.
    /// - `date`: Represents a date in the context of a transaction or event. It contains authentication data related to the password, likely indicating the date of a transaction or event associated with user authentication.
    /// - `totalPrice`: Represents the total price of a transaction or purchase. It contains authentication data related to the password, possibly indicating that the authentication process involves verifying the total price of a transaction.
    /// - `idUser`: Represents the unique identifier of a user in a system or application. It contains authentication data related to the password, likely indicating the authentication process involving user identification through a unique identifier.
    /// </param>
    /// <remarks>This endpoint creates a new bill with the provided data.</remarks>
    [HttpPost("/Bill")]

    [SwaggerResponseExample(200, (typeof(CreateBillDoc)))]
    public async Task<IActionResult> CreateBill(CreateBillDTO bill)
    {
        var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
        int idUser = int.Parse(user.Value);
        bill.idUser = idUser;
        var response = await _bill.CreateBill(bill);
        if (!response.IsSuccess)
            return BadRequest(response);
        return Ok(response);
    }

    /// <summary>
    /// Retrieves bills.
    /// </summary>
    /// <remarks>This endpoint retrieves bills for the authenticated user.</remarks>
    [HttpGet("/Bill")]
    [SwaggerResponseExample(200, (typeof(GetBillDoc)))]
    public async Task<IActionResult> GetBill()
    {
        var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
        int idUser = int.Parse(user.Value);
        var response = await _bill.GetBill(idUser);
        if (!response.IsSuccess)
            return BadRequest(response);
        return Ok(response);
    }

    /// <summary>
    /// Retrieves a bill by its ID.
    /// </summary>
    /// <param name="idBill">
    ///      Required:
    ///  - `idBill`: Represents the identifier of the bill associated.
    /// </param>
    /// <remarks>This endpoint retrieves a bill based on the provided ID.</remarks>
    [HttpGet("/Bill/By/Id")]
    [SwaggerResponseExample(200, (typeof(GetBillByIdDOC)))]
    public async Task<IActionResult> GetBillById(int idBill)
    {
        var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
        int idUser = int.Parse(user.Value);
        var response = await _bill.GetBillById(idBill, idUser);
        if (!response.IsSuccess)
            return BadRequest(response);
        return Ok(response);
    }
    /// <summary>
    /// Deletes a bill by its ID.
    /// </summary>
    ///  <param name="idbill">
    ///      Required:
    /// - `idBill`:The ID of the bill to delete.
    /// </param>
    /// <remarks>This endpoint deletes a bill based on the provided ID.</remarks>
    [HttpDelete("/Bill")]
    [SwaggerResponseExample(200, (typeof(DeleteBillDoc)))]
    public async Task<IActionResult> DeleteBill(int idbill)
    {
        var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
        int idUser = int.Parse(user.Value);
        var response = await _bill.DeleteBill(idbill, idUser);
        if (!response.IsSuccess)
            return BadRequest(response);
        return Ok(response);
    }

    /// <summary>
    /// Updates a bill.
    /// </summary>
    /// <param name="update">
    ///      Required:
    ///  - `idBill`: Represents the identifier of the bill associated with the transaction. It has an initial value of 0, indicating that a specific bill has not been assigned yet.
    /// - `idMethodPayment`: Represents the identifier of the payment method used in the transaction. It has an initial value of 0, indicating that a specific payment method hasn't been selected yet.
    /// - `name`: Represents the first name associated with the user account or profile in the transaction. The value "string" suggests it's a placeholder for actual user data.
    /// - `lastName`: Represents the last name associated with the user account or profile in the transaction. The value "string" suggests it's a placeholder for actual user data.
    /// - `nit`: Represents the Tax Identification Number (TIN) associated with the transaction, which may be used in certain countries for tax-related purposes. The value "string" suggests it's a placeholder for actual data.
    /// - `date`: Represents the date and time of the transaction. The provided value follows the ISO 8601 format ("2024-03-20T13:48:14.386Z"), indicating the precise time the transaction occurred.
    /// - `totalPrice`: Represents the total price of the transaction. The initial value is 0, suggesting that the total price hasn't been calculated or specified yet.
    /// - `idUser`: Represents the unique identifier of the user associated with the transaction in the system or application. The initial value is 0, suggesting that a specific user hasn't been identified yet.
    /// - `idCompany`: Represents the identifier of the company associated with the transaction. The initial value is 0, suggesting that a specific company hasn't been identified yet.
    /// </param>
    /// <remarks>This endpoint updates a bill with the provided data.</remarks>
    [HttpPut("/Bill")]
    [SwaggerResponseExample(200, (typeof(UpdateBillDoc)))]
    public async Task<IActionResult> UpdateBill(UpdateBill update)
    {
        var user = User.Claims.FirstOrDefault(x => x.Type == "UserId");
        int idUser = int.Parse(user.Value);
        var Company = User.Claims.FirstOrDefault(x => x.Type == "idCompany");
        int IdCompany = int.Parse(Company.Value);
        update.idCompany = IdCompany;
        update.idUser = idUser;
        var response = await _bill.UpdateBill(update);
        if (!response.IsSuccess)
            return BadRequest(response);
        return Ok(response);
    }
}
