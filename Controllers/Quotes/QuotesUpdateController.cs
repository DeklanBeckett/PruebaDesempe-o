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
    
    public class QuotesUpdateControllers : ControllerBase
    {
    public readonly IQuotesRepository _quotes;
        public QuotesUpdateControllers(IQuotesRepository quotes )
        {
            _quotes = quotes;

        }

        [HttpPut]
        [Route("Quotes/{Id}")]
        public IActionResult UpdateQuote(int Id, [FromBody] Quote Quotes)
            {
                
                try
                {
                    _quotes.UpdateQuote(Id, Quotes);
                    return Ok("se ha actualizado con exito");
                }
                catch (Exception Error)
                {
                    return BadRequest("Error al actualizar  " + Error.Message);
                }
            }
    }
}