using Challenge.Suris.Domain.Models.DTO;

namespace Challenge.Suris.Domain.Interfaces
{
    public interface IScheduleService
    {
        Task<IEnumerable<ScheduleDTO>> GetAllSchedulesAsync();
        Task<IEnumerable<ScheduleDTO>> GetSchedulesByServiceAsync(int serviceId);
    }
}
