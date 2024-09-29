using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Property.GetAll;

namespace PropNexus.Controllers.Property;

[ApiController]
[Route("api/[controller]")]
public class GetAllPropertyController(IGetAllPropertyInputPort inputPort, IGetAllPropertyOutputPort outputPort) : ControllerBase
{
    private readonly IGetAllPropertyInputPort _inputPort = inputPort;
    private readonly IGetAllPropertyOutputPort _outputPort = outputPort;

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll()
    {
        await _inputPort.Handle();

        if (_outputPort is IPresenter<IEnumerable<PropertyDto>> presenter)
        {
            return Ok(presenter.Content);
        }

        return StatusCode(StatusCodes.Status500InternalServerError, "El presentador no está configurado correctamente.");
    }
}
