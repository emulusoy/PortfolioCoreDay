using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.Controllers
{
    public class AdminProjectController : Controller
    {
        PortfolioContext context =new PortfolioContext();
        public IActionResult ProjectList()
        {
            var values=context.Portfolios.ToList();
            return View(values);
        }
    }
}
