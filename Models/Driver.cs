using System.ComponentModel.DataAnnotations;

namespace CNGFinder.Models
{
    public class Driver
    {
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string Phone { get; set; }
        public string CarBrand { get; set; }
        public int MaxCapacity { get; set; }
    }
}
