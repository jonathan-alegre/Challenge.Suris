using Challenge.Suris.Domain.Interfaces;
using Challenge.Suris.Domain.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Suris.API.Controllers
{
    [Route("api/schedule")]
    [ApiController]
    public class ScheduleController: ControllerBase
    {
        private readonly IScheduleService _scheduleService;

        public ScheduleController(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        [HttpGet("Get")]
        public async Task<IEnumerable<ScheduleDTO>> Get()
        {
            var schedulesDTO = await _scheduleService.GetAllSchedulesAsync();
            return schedulesDTO;
        }
    }
}
