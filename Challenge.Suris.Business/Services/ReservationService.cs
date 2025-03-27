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
                if (await ReservationIsValid(reservationRequestDTO))
                {
                    _responseDTO = await _reservationDAO.CreateReservationAsync(reservationRequestDTO);
                }

                return _responseDTO;
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
            var reservationsDTO = await _reservationDAO.GetAllReservationsAsync();
            return reservationsDTO;
        }

        private async Task<bool> ReservationIsValid(ReservationRequestDTO reservationRequestDTO)
        {
            if (string.IsNullOrEmpty(reservationRequestDTO.ClientName))
            {
                _responseDTO.IsSuccess = false;
                _responseDTO.Message = "Debe ingresar un nombre de Cliente.";

                return false;
            }

            var reservationsScheduled = await _reservationDAO.GetReservationsByServiceSchedule(reservationRequestDTO.ServiceId, reservationRequestDTO.ScheduleId);

            if (reservationsScheduled != null && reservationsScheduled.ToList().Count > 0)
            {
                _responseDTO.IsSuccess = false;
                _responseDTO.Message = "Ya existe una Reserva del Servicio para el mismo día y horario.";

                return false;
            }

            var reservationsClient = await _reservationDAO.GetReservationsByClientSchedule(reservationRequestDTO.ClientName, reservationRequestDTO.ScheduleId);

            if (reservationsClient.Any())
            {
                _responseDTO.IsSuccess = false;
                _responseDTO.Message = "El cliente ya tiene una Reserva para ese día y horario.";

                return false;
            }

            return true;
        }
    }
}
