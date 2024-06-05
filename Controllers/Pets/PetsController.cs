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
    
    public class PetsControllers : ControllerBase
    {
    public readonly IPetsRepository _pets;
        public PetsControllers(IPetsRepository pets )
        {
            _pets = pets;
        }

        [HttpGet]
        [Route("Pets")]
        public IEnumerable<Pet> GetPets(){
            return _pets.GetPets();
        }

        [HttpGet]
        [Route("Pets/{Id}")]
        public IActionResult GetPetById(int Id)
        {
        var  pet = _pets.GetPetById(Id);
        if(pet == null){
        return NotFound("no se encontró");
        }
        return Ok(pet);
        }


        [HttpGet]
        [Route("Pets/{IdOwner}/owner")]
        public IEnumerable<Pet> GetPets(int IdOwner){
            return _pets.GetOwners(IdOwner);
        }
        [HttpGet]
        [Route("Pets/{date}/birthday")]
        public IEnumerable<Pet> GetBirthDay(DateOnly date){
            return _pets.GetBirthDay(date);
        }
    }
}