using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Challenge.Suris.Data.Models
{
    [PrimaryKey(nameof(ScheduleId), nameof(ServiceId))]
    public class ServiceSchedule
    {
        [ForeignKey("ScheduleId")]
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }

        public int ServiceId { get; set; }
        [ForeignKey("ServiceId")]
        public Service Service { get; set; }
    }
}
