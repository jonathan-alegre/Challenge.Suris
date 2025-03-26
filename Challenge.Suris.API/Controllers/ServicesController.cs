using Microsoft.AspNetCore.Mvc;

namespace Challenge.Suris.API.Controllers
{
    public class ServicesController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
