using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaDesempeño.Models;

namespace PruebaDesempeño.Services.Pets
{
    public interface IPetsRepository
    {
        public IEnumerable<Pet> GetPets();
        Pet GetPetById(int Id);
        void CreatePet(Pet pet);
        void UpdatePet(int Id, Pet pet);
        public IEnumerable<Pet> GetOwners(int IdOwner);
        public IEnumerable<Pet> GetBirthDay(DateOnly date);
    }
}