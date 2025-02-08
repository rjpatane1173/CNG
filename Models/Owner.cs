using System.ComponentModel.DataAnnotations;

namespace CNGFinder.Models
{
    public class Owner
    {
        
        public long Id { get; set; }
        
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    
        public string PumpName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
