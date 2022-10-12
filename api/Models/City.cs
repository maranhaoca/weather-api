using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class City
    {
        [Key]
        public int DbId { get; set; }
        public int Id { get; set; }        
        public string Name { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public double Lon { get; set; }
        public double Lat { get; set; }
    }
}
