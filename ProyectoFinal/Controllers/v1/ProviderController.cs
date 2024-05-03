using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Core.DTOs.Provider;
using ProyectoFinal.Core.Interfaces.IBLL.Provider;
using ProyectoFinal.ErrorResponse.Doc.Provider;
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
public class ProviderController : ControllerBase
{
    private readonly IProviderBLL _providerBLL;

    public ProviderController(IProviderBLL providerBLL)
    {
        _providerBLL = providerBLL;
    }
    /// <summary>
    /// Retrieves provider information.
    /// </summary>
    /// <remarks>
    /// This endpoint retrieves information about providers associated with the current company.
    /// </remarks>
    /// <returns>A response containing information about providers associated with the current company.</returns>

    [HttpGet("/Provider")]
    [SwaggerResponseExample(200, (typeof(GetProviderDoc)))]
    public async Task<IActionResult> GetProvider()
    {
        var company = User.Claims.FirstOrDefault(x => x.Type == "idCompany");
        int idCompany = int.Parse(company.Value.ToString());

        var response = await _providerBLL.GetProviderBLL(idCompany);
        if (!response.IsSuccess)
        {
            return BadRequest(response);
        }
        return Ok(response);
    }

    /// <summary>
    /// Retrieves provider information by its identifier.
    /// </summary>
    /// <param name="IdProvider">
    /// - `idProvider`:The identifier of the provider to retrieve.</param>
    /// <remarks>
    /// This endpoint retrieves information about a specific provider associated with the current company.
    /// </remarks>
    /// <returns>A response containing information about the specified provider.</returns>

    [HttpGet("/Provider/By/Id")]
    [SwaggerResponseExample(200, (typeof(GetProviderByIdDoc)))]
    public async Task<IActionResult> GetProviderById(int IdProvider)
    {
        var company = User.Claims.FirstOrDefault(x => x.Type == "idCompany");
        int idCompany = int.Parse(company.Value.ToString());

        var response = await _providerBLL.GetProviderByIdBLL(IdProvider, idCompany);
        if (!response.IsSuccess)
        {
            return BadRequest(response);
        }
        return Ok(response);
    }

    /// <summary>
    /// Deletes a provider by its identifier.
    /// </summary>
    /// <param name="idProvider">
    /// - `idProvider`:The identifier of the provider to delete.</param>
    /// <remarks>
    /// This endpoint deletes a provider associated with the current company based on its unique identifier.
    /// </remarks>
    /// <returns>A response indicating the success or failure of the deletion operation.</returns>

    [HttpDelete("/Provider")]
    [SwaggerResponseExample(200, (typeof(DeleteProviderDoc)))]
    public async Task<IActionResult> DeleteProvider(int idProvider)
    {
        var company = User.Claims.FirstOrDefault(x => x.Type == "idCompany");
        int idCompany = int.Parse(company.Value.ToString());

        var response = await _providerBLL.DeleteProviderBLL(idProvider, idCompany);
        if (!response.IsSuccess)
        {
            return BadRequest(response);
        }
        return Ok(response);
    }
    /// <summary>
    /// Updates provider information.
    /// </summary>
    /// <param name="provider">
    /// - `idProvider`: The identifier of the provider to update.
    /// - `Description`: The updated description of the provider.
    /// - `idCompany`: The identifier of the company associated with the provider.
    /// </param>
    /// <remarks>
    /// This endpoint updates provider information based on the provided data.
    /// It requires authorization to determine the company associated with the update operation.
    /// </remarks>
    /// <returns>A response indicating the success or failure of the update operation.</returns>
    [HttpPut("/Provider")]
    [SwaggerResponseExample(200, (typeof(UpdateProviderDoc)))]
    public async Task<IActionResult> UpdateProvider(ProviderUpdateDTO provider)
    {
        var company = User.Claims.FirstOrDefault(x => x.Type == "idCompany");
        int idCompany = int.Parse(company.Value.ToString());
        provider.idCompany = idCompany;

        var response = await _providerBLL.UpdateProviderBLL(provider);
        if (!response.IsSuccess)
        {
            return BadRequest(response);
        }
        return Ok(response);
    }

    /// <summary>
    /// Creates a new provider.
    /// </summary>
    /// <param name="Description">
    /// - `Description`:The description of the Provider.</param>
    /// <remarks>
    /// This endpoint creates a new provider with the provided description.
    /// It requires authorization to determine the company associated with the creation operation.
    /// </remarks>
    [HttpPost("/Provider")]
    [SwaggerResponseExample(200, (typeof(CreateProviderDoc)))]
    public async Task<IActionResult> CreateProvider(string Description)
    {
        var company = User.Claims.FirstOrDefault(x => x.Type == "idCompany");
        int idCompany = int.Parse(company.Value.ToString());

        var response = await _providerBLL.CreateProviderBLL(Description, idCompany);
        if (!response.IsSuccess)
        {
            return BadRequest(response);
        }
        return Ok(response);
    }
}
