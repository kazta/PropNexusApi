using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.PropertyImage.Delete;

namespace PropNexus.Controllers.PropertyImage;

[ApiController]
[Route("api/[controller]")]
public class DeletePropertyImageController(IDeletePropertyImageInputPort inputPort, IDeletePropertyImageOutputPort outputPort) : ControllerBase
{
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(long id)
    {
        await inputPort.Handle(id);

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
