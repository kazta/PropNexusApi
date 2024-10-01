using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropNexus.Dtos.Agent;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Agent.GetAll;

namespace PropNexus.Controllers.Agent;
[ApiController]
[Route("api/[controller]")]
public class GetAllAgentController(IGetAllAgentInputPort inputPort, IGetAllAgentOutputPort outputPort) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll()
    {
        await inputPort.Handle();

        if (outputPort is IPresenter<IEnumerable<AgentDto>> presenter)
        {
            return Ok(presenter.Content);
        }

        return StatusCode(StatusCodes.Status500InternalServerError, "El presentador no está configurado correctamente.");
    }
}