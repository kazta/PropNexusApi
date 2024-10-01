using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.PropertyImage.GetAll;

namespace PropNexus.Controllers.PropertyImage;
[ApiController]
[Route("api/[controller]")]
public class GetAllPropertyImageController(IGetAllPropertyImageInputPort inputPort, IGetAllPropertyImageOutputPort outputPort) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll()
    {
        await inputPort.Handle();

        if (outputPort is IPresenter<IEnumerable<PropertyImageDto>> presenter)
        {
            return Ok(presenter.Content);
        }

        return StatusCode(StatusCodes.Status500InternalServerError, "El presentador no está configurado correctamente.");
    }
}