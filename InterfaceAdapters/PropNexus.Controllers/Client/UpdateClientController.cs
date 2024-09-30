using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropNexus.Dtos.Client;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Client.Update;

namespace PropNexus.Controllers.Client;
[ApiController]
[Route("api/[controller]")]
public class UpdateClientController(IUpdateClientInputPort inputPort, IUpdateClientOutputPort outputPort) : ControllerBase
{
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(long id, [FromBody] ClientDto dto)
    {
        if (id != dto.Id)
        {
            return BadRequest("El valor en la URL no coincide con el valor del cuerpo de la solicitud.");
        }

        await inputPort.Handle(dto);

        if (outputPort is IPresenter<bool> presenter)
        {
            if (!presenter.Content)
            {
                return NotFound();
            }
            return NoContent();
        }

        return StatusCode(StatusCodes.Status500InternalServerError, "El presentador no está configurado correctamente.");
    }
}