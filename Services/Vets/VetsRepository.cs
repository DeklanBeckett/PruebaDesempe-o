using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using PruebaDesempeño.Data;
using PruebaDesempeño.Models;

namespace PruebaDesempeño.Services.Vets
{
    public class VetsRepository : IVetsRepository
    {
        public readonly DataContex _context;

        public VetsRepository(DataContex context)
        {
            _context = context;
        }

        

        

        public Vet GetVetById(int Id)
        {
            var Vet = _context.Vets.Find(Id);
            
            return Vet;
            
        }

        

        public IEnumerable<Vet> GetVets()
        {
            return _context.Vets.ToList();
        }
        

    }
}