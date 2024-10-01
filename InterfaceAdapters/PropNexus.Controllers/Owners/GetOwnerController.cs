using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropNexus.Dtos.Owners;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Owner.Get;

namespace PropNexus.Controllers.Owners;

[ApiController]
[Route("api/[controller]")]
public class GetOwnerController(IGetOwnerInputPort inputPort, IGetOwnerOutputPort outputPort) : ControllerBase
{
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(long id)
    {
        await inputPort.Handle(id);

        if (outputPort is IPresenter<OwnerDto?> presenter)
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
