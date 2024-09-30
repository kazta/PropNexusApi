using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.PropertyImage.Update;

namespace PropNexus.Controllers.PropertyImage;
[ApiController]
[Route("api/[controller]")]
public class UpdatePropertyImageController(IUpdatePropertyImageInputPort inputPort, IUpdatePropertyImageOutputPort outputPort) : ControllerBase
{
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(long id, [FromBody] PropertyImageDto dto)
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