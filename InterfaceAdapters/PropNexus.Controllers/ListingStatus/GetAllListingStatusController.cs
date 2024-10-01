using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropNexus.Dtos.ListingStatus;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.ListingStatus.GetAll;

namespace PropNexus.Controllers.ListingStatus;

[ApiController]
[Route("api/[controller]")]
public class GetAllListingStatusController(IGetAllListingStatusInputPort inputPort, IGetAllListingStatusOutputPort outputPort) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll()
    {
        await inputPort.Handle();

        if (outputPort is IPresenter<IEnumerable<ListingStatusDto>> presenter)
        {
            return Ok(presenter.Content);
        }

        return StatusCode(StatusCodes.Status500InternalServerError, "El presentador no está configurado correctamente.");
    }
}
