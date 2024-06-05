using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaDesempeño.Data;
using PruebaDesempeño.Models;

namespace PruebaDesempeño.Services.Owners
{
    public class OwnerRepository : IOwnersRepository
    {
        public readonly DataContex _context;

        public OwnerRepository(DataContex context)
        {
            _context = context;
        }

        public void CreateOwner(Owner owner)
        {
            _context.Add(owner);
            _context.SaveChanges();
        }

        

        public Owner GetOwnerById(int Id)
        {
            return _context.Owners.FirstOrDefault(o => o.Id == Id);
        }

        public IEnumerable<Owner> GetOwners()
        {
            return _context.Owners.ToList();
        }

        public void UpdateOwner(int Id, Owner owner)
        {
            var OwnerUpdate = _context.Owners.Find(Id);

            OwnerUpdate.Names = owner.Names;
            OwnerUpdate.LastName = owner.LastName;
            OwnerUpdate.Address = owner.Address;
            OwnerUpdate.Phone = owner.Phone;
            OwnerUpdate.Email = owner.Email;

            _context.Update(OwnerUpdate);
            _context.SaveChanges();

        }
    }
}


