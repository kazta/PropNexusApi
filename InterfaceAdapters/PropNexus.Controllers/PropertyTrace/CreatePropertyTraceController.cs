using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.PropertyTrace.Create;

namespace PropNexus.Controllers.PropertyTrace;
[ApiController]
[Route("api/[controller]")]
public class CreatePropertyTraceController(ICreatePropertyTraceInputPort inputPort, ICreatePropertyTraceOutputPort outputPort) : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Create([FromBody] PropertyTraceDto dto)
    {
        await inputPort.Handle(dto);

        if (outputPort is IPresenter<bool> presenter)
        {
            if (!presenter.Content)
            {
                return BadRequest("Error al crear el seguimiento de propiedad.");
            }
            return CreatedAtAction(nameof(Create), new { id = dto.Id }, dto);
        }

        return StatusCode(StatusCodes.Status500InternalServerError, "El presentador no está configurado correctamente.");
    }
}