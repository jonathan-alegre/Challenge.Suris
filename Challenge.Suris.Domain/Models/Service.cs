using System.ComponentModel.DataAnnotations;

namespace Challenge.Suris.Domain.Models
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
