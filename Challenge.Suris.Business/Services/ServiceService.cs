using Challenge.Suris.Domain.Interfaces;
using Challenge.Suris.Domain.Models.DTO;

namespace Challenge.Suris.Business.Services
{
    public class ServiceService: IServiceService
    {
        private readonly IServiceDAO _serviceDAO;

        public ServiceService(IServiceDAO serviceDAO)
        {
            _serviceDAO = serviceDAO;
        }

        public async Task<IEnumerable<ServiceDTO>> GetAllServicesAsync()
        {
            var servicesDTO = await _serviceDAO.GetAllServicesAsync();
            return servicesDTO;
        }
    }
}
