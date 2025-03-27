using Challenge.Suris.Domain.Interfaces;
using Challenge.Suris.Domain.Models.DTO;

namespace Challenge.Suris.Business.Services
{
    public class ScheduleService: IScheduleService
    {
        private readonly IScheduleDAO _scheduleDAO;

        public ScheduleService(IScheduleDAO scheduleDAO)
        {
            _scheduleDAO = scheduleDAO;
        }

        public async Task<IEnumerable<ScheduleDTO>> GetAllSchedulesAsync()
        {
            var schedulesDTO = await _scheduleDAO.GetAllSchedulesAsync();
            return schedulesDTO;
        }
    }
}
