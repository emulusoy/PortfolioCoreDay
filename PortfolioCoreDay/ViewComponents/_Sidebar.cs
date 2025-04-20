using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreDay.ViewComponents
{
    public class _Sidebar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
