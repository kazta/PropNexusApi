using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropNexus.Dtos.Client;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Client.GetAll;

namespace PropNexus.Controllers.Client;
[ApiController]
[Route("api/[controller]")]
public class GetAllClientController(IGetAllClientInputPort inputPort, IGetAllClientOutputPort outputPort) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll()
    {
        await inputPort.Handle();

        if (outputPort is IPresenter<IEnumerable<ClientDto>> presenter)
        {
            return Ok(presenter.Content);
        }

        return StatusCode(StatusCodes.Status500InternalServerError, "El presentador no está configurado correctamente.");
    }
}