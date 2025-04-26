using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.Controllers
{
    public class StatisticController : Controller
    {
        PortfolioContext context=new PortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1=context.Skills.Count();  
            ViewBag.v2=context.Skills.Sum(x=>x.SkillValue);  
            ViewBag.v3=context.Skills.Average(x => x.SkillValue);  
            ViewBag.v4=context.Skills.Where(x => x.SkillValue>80).Count();

            ViewBag.v5 = context.Educations.Count(); // Eğitim sayısı
            ViewBag.v6 = context.Experiences.Count(); // Deneyim sayısı
            ViewBag.v7 = context.Messages.Count(); // Mesaj sayısı
            ViewBag.v8 = context.Services.Count(); // Hizmet sayısı
            ViewBag.v9 = context.Testimonials.Count(); // Referans sayısı
            ViewBag.v10 = context.Portfolios.Count(); // Portföy proje sayısı

            return View();
        }
    }
}
