using AutoMapper;
using Challenge.Suris.Domain.Models;
using Challenge.Suris.Domain.Models.DTO;

namespace Mango.Services.OrderAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Reservation, ReservationDTO>().ReverseMap();
                config.CreateMap<Reservation, ReservationRequestDTO>().ReverseMap();
                config.CreateMap<Service, ServiceDTO>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}