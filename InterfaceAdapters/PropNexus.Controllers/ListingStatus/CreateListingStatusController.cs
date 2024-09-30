using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropNexus.Dtos.ListingStatus;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.ListingStatus.Create;

namespace PropNexus.Controllers.ListingStatus; [ApiController]
[Route("api/[controller]")]
public class CreateListingStatusController(ICreateListingStatusInputPort inputPort, ICreateListingStatusOutputPort outputPort) : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Create([FromBody] ListingStatusDto dto)
    {
        await inputPort.Handle(dto);

        if (outputPort is IPresenter<bool> presenter)
        {
            if (!presenter.Content)
            {
                return BadRequest("Error al crear el estado del listado.");
            }
            return CreatedAtAction(nameof(Create), new { id = dto.Id }, dto);
        }

        return StatusCode(StatusCodes.Status500InternalServerError, "El presentador no está configurado correctamente.");
    }
}
