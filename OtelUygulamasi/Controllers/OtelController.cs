using Microsoft.AspNetCore.Mvc;

namespace OtelUygulamasi.Controllers
{
    public class OtelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
