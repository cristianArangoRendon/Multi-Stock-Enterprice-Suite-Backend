using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.Interfaces.IBLL.MethodPayment;
using ProyectoFinal.ErrorResponse.Doc.MethodPayment;
using ProyectoFinal.SwaggerExample.ErrorResponse;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.Controllers;

[Route("[controller]")]
[ApiController]
[Authorize]
[SwaggerResponseExample(401, typeof(Error401ResponseExample))]
[ProducesResponseType(typeof(Response200Example), StatusCodes.Status200OK)]
[ProducesResponseType(typeof(Error500ResponseExample), StatusCodes.Status500InternalServerError)]
[SwaggerResponseExample(500, typeof(Error500ResponseExample))]
[ProducesResponseType(typeof(Error400ResponseExample), StatusCodes.Status400BadRequest)]
[SwaggerResponseExample(400, typeof(Error400ResponseExample))]
public class MethodPaymentController : ControllerBase
{
    private readonly IMethodPaymentBLL _methodPayment;

    public MethodPaymentController(IMethodPaymentBLL methodPayment)
    {
        _methodPayment = methodPayment;
    }

    /// <summary>
    /// Creates a new method of payment.
    /// </summary>
    /// <param name="description">
    /// - `description`:The description of the new method of payment.</param>
    /// <remarks>
    /// This endpoint creates a new method of payment with the provided description.
    /// </remarks>
    /// <returns>A response indicating the success or failure of the creation operation.</returns>
    [HttpPost("/MethodPayment")]
    [SwaggerResponseExample(200, (typeof(CreateMethodPaymentDoc)))]
    public async Task<IActionResult> CreateMethodPayment(string description)
    {
        var response = await _methodPayment.CreateMethodPayment(description);
        if (!response.IsSuccess)
        {
            return BadRequest(response);
        }
        return Ok(response);
    }


    /// <summary>
    /// Retrieves method of payment information.
    /// </summary>
    /// <remarks>
    /// This endpoint retrieves information about available methods of payment.
    /// </remarks>
    /// <returns>A response containing information about available methods of payment.</returns>
    [HttpGet("/MethodPayment")]
    [SwaggerResponseExample(200, (typeof(GetMethodPaymentDoc)))]
    public async Task<IActionResult> GetMethodPayment()
    {
        var response = await _methodPayment.GetMethodPayment();
        if (!response.IsSuccess)
        {
            return BadRequest(response);
        }
        return Ok(response);
    }


    /// <summary>
    /// Deletes a method of payment by its identifier.
    /// </summary>
    /// <param name="idMethodPayment">
    /// - `idMethodPayment`:The identifier of the method of payment to delete.</param>
    /// <remarks>
    /// This endpoint deletes a method of payment from the system based on its unique identifier.
    /// </remarks>
    /// <returns>A response indicating the success or failure of the deletion operation.</returns>
    [HttpDelete("/MethodPayment")]
    [SwaggerResponseExample(200, (typeof(DeleteMethodPaymentDoc)))]
    public async Task<IActionResult> DeleteMethodPayment(int idMethodPayment)
    {
        var response = await _methodPayment.DeleteMethodPayment(idMethodPayment);
        if (!response.IsSuccess)
        {
            return BadRequest(response);
        }
        return Ok(response);
    }



    /// <summary>
    /// Updates a method of payment by its identifier.
    /// </summary>
    /// <param name="idMethodPayment">
    ///  - `idMethodPayment`:The identifier of the method of payment to update.</param>
    /// <param name="description">
    /// - `description`:The new description for the method of payment.</param>
    /// <remarks>
    /// This endpoint updates a method of payment in the system based on its unique identifier.
    /// </remarks>
    /// <returns>A response indicating the success or failure of the update operation.</returns>
    [HttpPut("/MethodPayment")]
    [SwaggerResponseExample(200, (typeof(UpdateMethodPaymentDoc)))]
    public async Task<IActionResult> UpdateMethodPayment(int idMethodPayment, string description)
    {
        var response = await _methodPayment.UpdateMethodPayment(idMethodPayment, description);
        if (!response.IsSuccess)
        {
            return BadRequest(response);
        }
        return Ok(response);
    }


}
