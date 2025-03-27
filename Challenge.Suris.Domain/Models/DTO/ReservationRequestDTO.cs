namespace Challenge.Suris.Domain.Models.DTO
{
    public class ReservationRequestDTO
    {
        public int ServiceId { get; set; }

        public int ScheduleId { get; set; }

        public string ClientName { get; set; }
    }
}
