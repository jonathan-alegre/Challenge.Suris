using AutoMapper;
using Challenge.Suris.Domain.Interfaces;
using Challenge.Suris.Domain.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace Challenge.Suris.Data
{
    public class ScheduleDAO: IScheduleDAO
    {
        private readonly AppDbContext _db;
        private IMapper _mapper;

        public ScheduleDAO(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ScheduleDTO>> GetAllSchedulesAsync()
        {
            var schedules = await _db.Schedules.ToListAsync();
            var schedulesDTO = _mapper.Map<IEnumerable<ScheduleDTO>>(schedules);

            return schedulesDTO;
        }
    }
}
