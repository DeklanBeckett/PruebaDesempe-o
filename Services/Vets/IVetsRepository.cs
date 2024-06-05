using System;
using System.Collections.Generic;
using System.Linq;
using PruebaDesempeño.Models;
using System.Threading.Tasks;

namespace PruebaDesempeño.Services.Vets
{
    public interface IVetsRepository
    {
        public IEnumerable<Vet> GetVets();
        Vet GetVetById(int id);
        
    }
}