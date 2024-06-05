namespace PruebaDesempeño.Models{
    public class  Quote{
        public int? Id {get; set;}
        public DateTime? Date {get; set;}
        public string? Description {get; set;}
        public int? PetId {get; set;}
        public int? VetId {get; set;}

        public Pet? Pets {get; set;}
        public Vet? Vets {get; set;}
    }
}