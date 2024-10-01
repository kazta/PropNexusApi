using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropNexus.Dtos.Client;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Client.Create;

namespace PropNexus.Controllers.Client;
[ApiController]
[Route("api/[controller]")]
public class CreateClientController(ICreateClientInputPort inputPort, ICreateClientOutputPort outputPort) : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Create([FromBody] ClientDto dto)
    {
        await inputPort.Handle(dto);

        if (outputPort is IPresenter<bool> presenter)
        {
            if (!presenter.Content)
            {
                return BadRequest("Error al crear el cliente.");
            }
            return CreatedAtAction(nameof(Create), new { id = dto.Id }, dto);
        }

        return StatusCode(StatusCodes.Status500InternalServerError, "El presentador no está configurado correctamente.");
    }
}