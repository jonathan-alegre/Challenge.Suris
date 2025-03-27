using Challenge.Suris.Domain.Interfaces;
using Challenge.Suris.Domain.Models.DTO;

namespace Challenge.Suris.Business.Services
{
    public class ReservationService: IReservationService
    {
        private readonly IReservationDAO _reservationDAO;
        private ResponseDTO _responseDTO;

        public ReservationService(IReservationDAO reservationDAO)
        {
            _reservationDAO = reservationDAO;
            _responseDTO = new ResponseDTO();
        }

        public async Task<ResponseDTO> CreateReservationAsync(ReservationRequestDTO reservationRequestDTO)
        {
            try
            {
                var reservationsScheduled = await _reservationDAO.GetReservationsByServiceSchedule(reservationRequestDTO.ServiceId, reservationRequestDTO.ScheduleId);

                if (reservationsScheduled != null && reservationsScheduled.ToList().Count > 0)
                {
                    _responseDTO.IsSuccess = false;
                    _responseDTO.Message = "Ya existe una Reserva del Servicio para el mismo día y horario.";
                }
                else
                {
                    _responseDTO = await _reservationDAO.CreateReservationAsync(reservationRequestDTO);
                }
            }
            catch (Exception ex)
            {
                _responseDTO.IsSuccess = false;
                _responseDTO.Message = ex.Message;
            }

            return _responseDTO;
        }

        public async Task<IEnumerable<ReservationDTO>> GetAllReservationsAsync()
        {
            var reservations = await _reservationDAO.GetAllReservationsAsync();
            return reservations;
        }


    }
}
