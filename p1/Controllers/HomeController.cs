using Microsoft.AspNetCore.Mvc;

namespace HelloMvcApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.StudentName = "Юхимчук Марина";
            ViewBag.GroupNumber = "ІПЗ-22-1";
            ViewBag.University = "Хмельницький національний університет";
            ViewBag.ProjectTopic = "Магазин квітів";
            return View();
        }
    }
}