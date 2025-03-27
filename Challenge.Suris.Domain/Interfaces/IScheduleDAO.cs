using Challenge.Suris.Domain.Models.DTO;

namespace Challenge.Suris.Domain.Interfaces
{
    public interface IScheduleDAO
    {
        Task<IEnumerable<ScheduleDTO>> GetAllSchedulesAsync();
    }
}
