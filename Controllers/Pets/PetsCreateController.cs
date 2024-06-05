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
    
    public class PetsCreateController : ControllerBase
    {
    public readonly IPetsRepository _pets;
        public PetsCreateController(IPetsRepository pets )
        {
            _pets = pets;
        }

        [HttpPost]
        [Route("Pets")]
        public IActionResult CretePet([FromBody] Pet Pet){
            _pets.CreatePet(Pet);
            return Ok("se ha creado con exito");
        }

        
    }
}