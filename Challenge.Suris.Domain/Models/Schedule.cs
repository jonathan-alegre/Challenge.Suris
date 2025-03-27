using System.ComponentModel.DataAnnotations;

namespace Challenge.Suris.Domain.Models
{
    public class Schedule
    {
        [Key]
        public int ScheduleId { get; set; }

        [Required]
        public DateTime DateTime { get; set; }
    }
}
