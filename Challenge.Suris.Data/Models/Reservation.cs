using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge.Suris.Data.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }

        [Required]
        public int ServiceId { get; set; }
        [ForeignKey("ServiceId")]
        public Service Service { get; set; }

        [Required]
        public int ScheduleId { get; set; }
        [ForeignKey("ScheduleId")]
        public Schedule Schedule { get; set; }

        [Required]
        public string ClientName { get; set; }
    }
}
