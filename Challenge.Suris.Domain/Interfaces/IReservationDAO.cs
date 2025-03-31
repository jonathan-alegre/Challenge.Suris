using Challenge.Suris.Domain.Models.DTO;

namespace Challenge.Suris.Domain.Interfaces
{
    public interface IReservationDAO
    {
        Task<IEnumerable<ReservationDTO>> GetAllReservationsAsync();
        Task<ResponseDTO> CreateReservationAsync(ReservationRequestDTO reservationRequestDTO);
        Task<IEnumerable<ReservationDTO>> GetReservationsByServiceSchedule(int serviceId, int scheduleId);
        Task<IEnumerable<ReservationDTO>> GetReservationsByClientSchedule(string clientName, int scheduleId);
        Task<IEnumerable<ReservationDTO>> GetReservationsByClientAndDay(string clientName, DateTime day);
    }
}
