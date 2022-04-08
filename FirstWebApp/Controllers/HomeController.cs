using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()     
        {
            string name = Request.Query["name"];
            return View();
        }

        public string List()
        {
            return $"Controller Home";
        }
    }
}
