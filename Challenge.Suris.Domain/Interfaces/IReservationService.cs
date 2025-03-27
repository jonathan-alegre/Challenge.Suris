using Challenge.Suris.Domain.Models.DTO;

namespace Challenge.Suris.Domain.Interfaces
{
    public interface IReservationService
    {
        Task<IEnumerable<ReservationDTO>> GetAllReservationsAsync();
        Task<ResponseDTO> CreateReservationAsync(ReservationRequestDTO reservationRequestDTO);
    }
}
