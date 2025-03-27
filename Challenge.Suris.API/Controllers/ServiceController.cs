using Challenge.Suris.Domain.Interfaces;
using Challenge.Suris.Domain.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Suris.API.Controllers
{
    [Route("api/service")]
    [ApiController]
    public class ServiceController: Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet("Get")]
        public async Task<IEnumerable<ServiceDTO>> Get()
        {
            var reservations = await _serviceService.GetAllServicesAsync();
            return reservations;
        }
    }
}
