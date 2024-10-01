using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropNexus.Dtos.Owners;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Owner.Create;

namespace PropNexus.Controllers.Owners;

[ApiController]
[Route("api/[controller]")]
public class CreateOwnerController(ICreateOwnerInputPort inputPort, ICreateOwnerOutputPort outputPort) : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Create([FromBody] OwnerDto dto)
    {
        await inputPort.Handle(dto);

        if (outputPort is IPresenter<bool> presenter)
        {
            if (!presenter.Content)
            {
                return BadRequest("Error al crear el propietario.");
            }
            return CreatedAtAction(nameof(Create), new { id = dto.Id }, dto);
        }

        return StatusCode(StatusCodes.Status500InternalServerError, "El presentador no está configurado correctamente.");
    }
}
