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
using PruebaDesempeño.Services.Owners;

namespace PruebaDesempeño.Controllers.Owners
{
    
    public class OwnersCreateControllers : ControllerBase
    {
    public readonly IOwnersRepository _Owners;
        public OwnersCreateControllers(IOwnersRepository Owners )
        {
            _Owners = Owners;

        }

        [HttpPost]
        [Route("Owners")]
        public IActionResult CreateOwner([FromBody] Owner owner){
            
            try{
                _Owners.CreateOwner(owner);
            return Ok("se ha creado con exito");
            }
            catch(Exception Error)
            {
                return BadRequest("Error al crear  " + Error.Message);
            }
        }

        
    }
}