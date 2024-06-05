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
using PruebaDesempeño.Services.Quotes;

namespace PruebaDesempeño.Controllers.Owners
{
    
    public class QuotesCreateControllers : ControllerBase
    {
    public readonly IQuotesRepository _quotes;
        public QuotesCreateControllers(IQuotesRepository quotes )
        {
            _quotes = quotes;

        }

        [HttpPost]
        [Route("Quotes")]
        public IActionResult CreateOwner([FromBody] Quote quote){
            
            try{
                _quotes.CreateQuote(quote);
            return Ok("se ha creado con exito");
            }
            catch(Exception Error)
            {
                return BadRequest("Error al crear  " + Error.Message);
            }
        }
    }
}