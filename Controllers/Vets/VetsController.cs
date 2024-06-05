using Microsoft.AspNetCore.Mvc;
using PruebaDesempeño.Models;
using PruebaDesempeño.Services.Vets;
namespace PruebaDesempeño.Controllers.Vets
{
    public class VetsController : ControllerBase
    {
        public readonly IVetsRepository _vets;
        public VetsController(IVetsRepository vets )
        {
            _vets = vets;
        }

        
        [HttpGet]
        [Route("Vets")]
        public IEnumerable<Vet> GetVets(){
            return _vets.GetVets();
        }

        [HttpGet]
        [Route("Vets/{Id}")]
        public IActionResult GetVetById(int Id){
            
        var  vet = _vets.GetVetById(Id);
        if(vet == null){
        return NotFound("no se encontró");
        }
        return Ok(vet);

        
        
    }
}}