using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.PropertyTrace.Get;

namespace PropNexus.Controllers.PropertyTrace;
[ApiController]
[Route("api/[controller]")]
public class GetPropertyTraceController(IGetPropertyTraceInputPort inputPort, IGetPropertyTraceOutputPort outputPort) : ControllerBase
{
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(long id)
    {
        await inputPort.Handle(id);

        if (outputPort is IPresenter<PropertyTraceDto?> presenter)
        {
            if (presenter.Content is null)
            {
                return NotFound();
            }
            return Ok(presenter.Content);
        }

        return StatusCode(StatusCodes.Status500InternalServerError, "El presentador no está configurado correctamente.");
    }
}