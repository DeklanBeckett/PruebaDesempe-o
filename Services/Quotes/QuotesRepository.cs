using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaDesempeño.Data;
using PruebaDesempeño.Models;

namespace PruebaDesempeño.Services.Quotes
{
    public class QuotesRepository : IQuotesRepository
    {
        public readonly DataContex _context;

        public QuotesRepository(DataContex context)
        {
            _context = context;
        }

        public void CreateQuote(Quote quote)
        {
            _context.Add(quote);
            _context.SaveChanges();
        }

        public Quote GetQuoteById(int Id)
        {
            return _context.Quotes.Include(w => w.Pets).Include(x => x.Vets).FirstOrDefault(o => o.Id == Id);
        }

        public IEnumerable<Quote> GetQuotes()
        {
            return _context.Quotes.Include(w => w.Pets).Include(x => x.Vets).ToList();
        }

        public void UpdateQuote(int Id, Quote quote)
        {
            var QuoteActualizada = _context.Quotes.Find(Id);
            QuoteActualizada.PetId = quote.PetId;
            QuoteActualizada.VetId = quote.VetId;
            QuoteActualizada.Date = quote.Date;
            QuoteActualizada.Description = quote.Description;
            _context.Update(QuoteActualizada);
            _context.SaveChanges();

        
        }
        

        public IEnumerable<Quote> listQuotesVet(int VetId)
        {
            return _context.Quotes.Where(c => c.VetId == VetId).Include(e => e.Pets).ToList();
        }

        public IEnumerable<Quote> listQuotesDate(DateTime date)
        {
            return _context.Quotes.Where( o => o.Date == date).Include(e=> e.Pets).Include(i => i.Vets).ToList();
        }
    }
}