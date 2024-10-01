using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Property.Create;

namespace PropNexus.Controllers.Property;

[ApiController]
[Route("api/[controller]")]
public class CreatePropertyController(ICreatePropertyInputPort inputPort, ICreatePropertyOutputPort outputPort) : ControllerBase
{

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Create([FromBody] PropertyDto dto)
    {
        await inputPort.Handle(dto);

        if (outputPort is IPresenter<bool> presenter)
        {
            if (!presenter.Content)
            {
                return BadRequest("Error al crear la propiedad.");
            }
            return CreatedAtAction(nameof(Create), new { id = dto.Id }, dto);
        }

        return StatusCode(StatusCodes.Status500InternalServerError, "El presentador no está configurado correctamente.");
    }
}
