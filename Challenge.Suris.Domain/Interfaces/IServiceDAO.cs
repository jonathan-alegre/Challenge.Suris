using Challenge.Suris.Domain.Models.DTO;

namespace Challenge.Suris.Domain.Interfaces
{
    public interface IServiceDAO
    {
        Task<IEnumerable<ServiceDTO>> GetAllServicesAsync();
    }
}
