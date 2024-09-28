using Microsoft.AspNetCore.Mvc;

namespace PropNexus.Controllers.Owners;
[ApiController]
[Route("api/[controller]")]
public class GetAllOwnerController : ControllerBase
{
    [HttpGet]
    public ActionResult Get()
    {
        return Ok("Hola mundo");
    }
}