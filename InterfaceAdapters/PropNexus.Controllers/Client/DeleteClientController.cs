﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropNexus.Entities.Interfaces;
using PropNexus.UseCases.Client.Delete;

namespace PropNexus.Controllers.Client;
[ApiController]
[Route("api/[controller]")]
public class DeleteClientController(IDeleteClientInputPort inputPort, IDeleteClientOutputPort outputPort) : ControllerBase
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