using AutoMapper;
using Challenge.Suris.Domain.Interfaces;
using Challenge.Suris.Domain.Models;
using Challenge.Suris.Domain.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace Challenge.Suris.Data
{
    public class ReservationDAO: IReservationDAO
    {
        private readonly AppDbContext _db;
        private IMapper _mapper;
        private ResponseDTO _responseDTO;

        public ReservationDAO(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _responseDTO = new ResponseDTO();
        }

        public async Task<ResponseDTO> CreateReservationAsync(ReservationRequestDTO reservationRequestDTO)
        {
            try
            {
                var reservation = _mapper.Map<Reservation>(reservationRequestDTO);

                reservation.CreationDate = DateTime.Now;

                _db.Reservations.Add(reservation);
                await _db.SaveChangesAsync();

                _responseDTO.IsSuccess = true;
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
            var reservations = await _db.Reservations.Include(r => r.Service).Include(r => r.Schedule).ToListAsync();
            var reservationsDTO = _mapper.Map<IEnumerable<ReservationDTO>>(reservations);

            return reservationsDTO;
        }

        public async Task<IEnumerable<ReservationDTO>> GetReservationsByClientAndDay(string clientName, DateTime day)
        {
            var reservations = await _db.Reservations.Where(r => r.ClientName.ToUpper().Trim() == clientName.ToUpper().Trim()
                                                                 && r.Schedule.DateTime.Date == day.Date).ToListAsync();

            var reservationsDTO = _mapper.Map<IEnumerable<ReservationDTO>>(reservations);

            return reservationsDTO;
        }

        public async Task<IEnumerable<ReservationDTO>> GetReservationsByClientSchedule(string clientName, int scheduleId)
        {
            var reservations = await _db.Reservations.Where(r => r.ClientName.ToUpper().Trim() == clientName.ToUpper().Trim()
                                                                 && r.ScheduleId == scheduleId).ToListAsync();

            var reservationsDTO = _mapper.Map<IEnumerable<ReservationDTO>>(reservations);

            return reservationsDTO;
        }

        public async Task<IEnumerable<ReservationDTO>> GetReservationsByServiceSchedule(int serviceId, int scheduleId)
        {
            var reservations = await _db.Reservations.Where(r => r.ServiceId == serviceId && r.ScheduleId == scheduleId).ToListAsync();
            var reservationsDTO = _mapper.Map<IEnumerable<ReservationDTO>>(reservations);

            return reservationsDTO;
        }
    }
}
