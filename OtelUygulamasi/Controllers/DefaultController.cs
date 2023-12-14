using Microsoft.AspNetCore.Mvc;

namespace OtelUygulamasi.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
