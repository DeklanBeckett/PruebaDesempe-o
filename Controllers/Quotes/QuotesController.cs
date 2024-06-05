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
    
    public class QuotesControllers : ControllerBase
    {
    public readonly IQuotesRepository _quotes;
        public QuotesControllers(IQuotesRepository quotes )
        {
            _quotes = quotes;

        }

        [HttpGet]
        [Route("Quotes")]
        public IEnumerable<Quote> GetQuotes(){
            return _quotes.GetQuotes();
        }

        [HttpGet]
        [Route("Quotes/{Id}")]
        public IActionResult GetQuotesById(int Id)
        {
        var  Quote = _quotes.GetQuoteById(Id);
        if(Quote == null){
        return NotFound("no se encontró");
        }
        return Ok(Quote);
        }

        [HttpGet]
        [Route("quotes/{VetId}/vets")]
        public IActionResult CountQuotesVet(int VetId)
        {
        var quotesvet =  _quotes.listQuotesVet(VetId);
            return Ok(quotesvet);
        }

        [HttpGet]
        [Route("/quotes/{date}/date")]
        public IActionResult listQuotesDate(DateTime date)
        {
        var quotesdate  =  _quotes.listQuotesDate(date);
        
            return Ok(quotesdate);
        }
    }
}