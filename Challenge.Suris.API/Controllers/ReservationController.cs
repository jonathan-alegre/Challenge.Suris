using Challenge.Suris.Domain.Interfaces;
using Challenge.Suris.Domain.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Suris.API.Controllers
{
    [Route("api/reservation")]
    [ApiController]
    public class ReservationController: Controller
    {
        private readonly IReservationService _reservationService;
        private ResponseDTO _responseDTO;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
            _responseDTO = new ResponseDTO();
        }

        [HttpGet("Get")]
        public async Task<IEnumerable<ReservationDTO>> Get()
        {
            var reservations = await _reservationService.GetAllReservationsAsync();
            return reservations;
        }

        [HttpPost("Post")]
        public async Task<ResponseDTO> Post([FromBody] ReservationRequestDTO reservationRequestDTO)
        {
            try
            {
                _responseDTO = await _reservationService.CreateReservationAsync(reservationRequestDTO);
            }
            catch (Exception ex)
            {
                _responseDTO.IsSuccess = false;
                _responseDTO.Message = ex.Message;
            }

            return _responseDTO;
        }
    }
}
