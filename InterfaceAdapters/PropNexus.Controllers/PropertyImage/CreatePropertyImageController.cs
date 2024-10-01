using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropNexus.Dtos.Properties;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.PropertyImage.Create;
using PropNexus.UseCases.PropertyImage.SendImage;

namespace PropNexus.Controllers.PropertyImage;
[ApiController]
[Route("api/[controller]")]
public class CreatePropertyImageController(ICreatePropertyImageInputPort inputPort, ICreatePropertyImageOutputPort outputPort, ISendImageInputPort sendImageInput) : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Create([FromForm] PropertyImageDto dto, IFormFile file)
    {
        if (dto == null || dto.PropertyId == 0)
            return BadRequest();
        if (file == null || file.Length == 0)
            return BadRequest("No se ha proporcionado un archvivo");
        if (file.Length > 10485760)
            return BadRequest("El archivo es muy grande. Tamño maxímo permitido es de 10 Megabytes");

        List<string> _extensionesPermitidas = [".jpg", ".jpeg", ".png", ".gif"];

        if (!_extensionesPermitidas.Contains(Path.GetExtension(file.FileName)))
            return BadRequest("El archivo no tiene una extensión permitida.");

        dto.ImageUrl = $"Property{dto.PropertyId}-{DateTime.Now.Ticks}";
        if (await sendImageInput.Handle(file.OpenReadStream(), dto.ImageUrl))
            return StatusCode(StatusCodes.Status500InternalServerError, "Se presentó un error subiendo el archvio");

        await inputPort.Handle(dto);

        if (outputPort is IPresenter<bool> presenter)
        {
            if (!presenter.Content)
            {
                return BadRequest("Error al crear la imagen de propiedad.");
            }
            return CreatedAtAction(nameof(Create), new { id = dto.Id }, dto);
        }

        return StatusCode(StatusCodes.Status500InternalServerError, "El presentador no está configurado correctamente.");
    }
}