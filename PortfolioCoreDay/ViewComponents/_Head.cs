using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreDay.ViewComponents
{
    public class _Head:ViewComponent
    {
        public IViewComponentResult Invoke() { 
        
            return View();
        }
    }
}
