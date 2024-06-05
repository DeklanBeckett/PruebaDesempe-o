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
    
    public class OwnersControllers : ControllerBase
    {
    public readonly IOwnersRepository _Owners;
        public OwnersControllers(IOwnersRepository Owners )
        {
            _Owners = Owners;

        }

        [HttpGet]
        [Route("Owners")]
        public IEnumerable<Owner> GetOwners(){
            return _Owners.GetOwners();
        }

        [HttpGet]
        [Route("Owners/{Id}")]
        public IActionResult GetOwnerById(int Id)
        {
        var  owner = _Owners.GetOwnerById(Id);
                if(owner == null){
                return NotFound("no se encontró");
                }
                return Ok(owner);
                }

        
    }
}