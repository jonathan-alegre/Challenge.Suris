namespace Challenge.Suris.Domain.Models.DTO
{
    public class ReservationDTO
    {
        public int ReservationId { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }

        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }

        public string ClientName { get; set; }
    }
}
