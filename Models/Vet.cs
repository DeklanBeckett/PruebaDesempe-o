using System.Text.Json.Serialization;

namespace PruebaDesempeño.Models{
    public class Vet{
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Phone {get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public int? ExpirienceYears {get; set;}
        [JsonIgnore]
        public ICollection<Quote>? Quotes { get; set;}
    }
}