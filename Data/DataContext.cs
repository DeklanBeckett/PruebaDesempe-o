using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PruebaDesempeño.Models;

namespace PruebaDesempeño.Data{


    public class DataContex : DbContext{
        public DataContex(DbContextOptions<DataContex>options) : base(options){

        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Vet> Vets {get; set;}
        public DbSet<Quote> Quotes { get; set; }

    }
}