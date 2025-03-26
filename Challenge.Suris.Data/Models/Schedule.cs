using System.ComponentModel.DataAnnotations;

namespace Challenge.Suris.Data.Models
{
    public class Schedule
    {
        [Key]
        public int ScheduleId { get; set; }

        [Required]
        public DateTime DateTime { get; set; }
    }
}
