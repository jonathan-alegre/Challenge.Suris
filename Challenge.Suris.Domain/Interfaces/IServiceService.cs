using Challenge.Suris.Domain.Models.DTO;

namespace Challenge.Suris.Domain.Interfaces
{
    public interface IServiceService
    {
        Task<IEnumerable<ServiceDTO>> GetAllServicesAsync();
    }
}
