using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaDesempeño.Data;
using PruebaDesempeño.Models;

namespace PruebaDesempeño.Services.Pets
{
    public class PetsRepository : IPetsRepository
    {   
        public readonly DataContex _context;

        public PetsRepository(DataContex context)
        {
            _context = context;
        }


        public void CreatePet(Pet pet)
        {
            _context.Add(pet);
            _context.SaveChanges();

        }

        public IEnumerable<Pet> GetBirthDay(DateOnly date)
        {
            return _context.Pets.Where(b => b.DateBirth == date).Include(i => i.Owners).ToList();
        }

        public IEnumerable<Pet> GetOwners(int IdOwner)
        {
            return _context.Pets.Where(p => p.OwnerId == IdOwner).ToList();
        }

        public Pet GetPetById(int Id)
        {

        return _context.Pets.Include(e=> e.Owners).FirstOrDefault(e=> e.Id == Id);
        
        }

        public IEnumerable<Pet> GetPets()
        {
            return _context.Pets.Include(e=> e.Owners).ToList();
        }

        public void UpdatePet(int Id, Pet pet)
        {
           {
            var PetUpdate = _context.Pets.FirstOrDefault(p => p.Id ==Id);

            PetUpdate.Name = pet.Name;
            PetUpdate.Specie = pet.Specie;
            PetUpdate.Race = pet.Race;
            PetUpdate.DateBirth = pet.DateBirth;
            PetUpdate.Photo = pet.Photo;
            PetUpdate.OwnerId = pet.OwnerId;
            
            _context.Update(PetUpdate);
            _context.SaveChanges();
        }
        }
    }
}