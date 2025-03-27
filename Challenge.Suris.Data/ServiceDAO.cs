using AutoMapper;
using Challenge.Suris.Domain.Interfaces;
using Challenge.Suris.Domain.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace Challenge.Suris.Data
{
    public class ServiceDAO: IServiceDAO
    {
        private readonly AppDbContext _db;
        private IMapper _mapper;

        public ServiceDAO(AppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ServiceDTO>> GetAllServicesAsync()
        {
            var services = await _db.Services.ToListAsync();
            var servicesDTO = _mapper.Map<IEnumerable<ServiceDTO>>(services);

            return servicesDTO;
        }
    }
}
