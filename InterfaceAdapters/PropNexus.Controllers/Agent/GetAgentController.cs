using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropNexus.Dtos.Agent;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Agent.Get;

namespace PropNexus.Controllers.Agent;
[ApiController]
[Route("api/[controller]")]
public class GetAgentController(IGetAgentInputPort inputPort, IGetAgentOutputPort outputPort) : ControllerBase
{
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(long id)
    {
        await inputPort.Handle(id);

        if (outputPort is IPresenter<AgentDto?> presenter)
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