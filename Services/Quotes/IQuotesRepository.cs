using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaDesempeño.Models;

namespace PruebaDesempeño.Services.Quotes
{
    public interface IQuotesRepository
    {
        public IEnumerable<Quote> GetQuotes();
        Quote GetQuoteById(int Id);
        void CreateQuote(Quote quote);
        void UpdateQuote(int Id, Quote quote);
        
        public IEnumerable<Quote> listQuotesVet(int VetId);
        public IEnumerable<Quote> listQuotesDate(DateTime date);
    }
}