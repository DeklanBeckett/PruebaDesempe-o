using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PruebaDesempeño.Models{
    public class Owner{
        public int? Id { get; set; }
        
        public string? Names {get; set;}
        
        public string? LastName { get; set; }
        
        public string? Email { get; set; }
        public string? Address {get; set;}
        
        public string? Phone { get; set; }
        [JsonIgnore]
        public ICollection<Pet>? Pets {get; set;}

    }
}