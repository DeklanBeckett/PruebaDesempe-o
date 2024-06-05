using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PruebaDesempeño.Data;
using PruebaDesempeño.Services.Pets;
using PruebaDesempeño.Models;

namespace PruebaDesempeño.Controllers.Pets
{
    
    public class PetsUpdateController : ControllerBase
    {
    public readonly IPetsRepository _pets;
        public PetsUpdateController(IPetsRepository pets )
        {
            _pets = pets;
        }

        [HttpPut]
        [Route("Pets/{Id}")]
        public IActionResult UpdatePet(int Id, [FromBody] Pet pet)
        {
            try
            {
                _pets.UpdatePet(Id, pet);
                return Ok("se ha actualizado con exito");
            }
            catch (Exception Error)
            {
                return BadRequest("Error al actualizar  " + Error.Message);
            }
        }

        
    }
}