using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.Controllers
{
    public class DefaultController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
