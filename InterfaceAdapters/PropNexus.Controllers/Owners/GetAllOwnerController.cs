using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropNexus.Dtos.Owners;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Owner.GetAll;

namespace PropNexus.Controllers.Owners;
[ApiController]
[Route("api/[controller]")]
public class GetAllOwnerController(IGetAllOwnerInputPort inputPort, IGetAllOwnerOutputPort outputPort) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll()
    {
        await inputPort.Handle();

        if (outputPort is IPresenter<IEnumerable<OwnerDto>> presenter)
        {
            return Ok(presenter.Content);
        }

        return StatusCode(StatusCodes.Status500InternalServerError, "El presentador no está configurado correctamente.");
    }
}