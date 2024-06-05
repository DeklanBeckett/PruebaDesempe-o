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
    
    public class OwnersUpdateControllers : ControllerBase
    {
    public readonly IOwnersRepository _Owners;
        public OwnersUpdateControllers(IOwnersRepository Owners )
        {
            _Owners = Owners;

        }

        [HttpPut]
        [Route("Owners/{Id}")]
        public IActionResult UpdateOwner(int Id, [FromBody] Owner owner)
        {
            
            try
            {
                _Owners.UpdateOwner(Id, owner);
                return Ok("se ha actualizado con exito");
            }
            catch (Exception Error)
            {
                return BadRequest("Error al actualizar  " + Error.Message);
            }
        }
    }
}