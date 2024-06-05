using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaDesempeño.Models;

namespace PruebaDesempeño.Services.Owners
{
    public interface IOwnersRepository
    {
        public IEnumerable<Owner> GetOwners();
        Owner GetOwnerById(int Id);
        void CreateOwner(Owner owner);
        void UpdateOwner(int Id, Owner owner);
        
        
    }
}

