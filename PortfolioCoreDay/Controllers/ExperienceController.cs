using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreDay.Controllers
{
    public class ExperienceController : Controller
    {
        public IActionResult ExperienceList()
        {
            return View();
        }
    }
}
