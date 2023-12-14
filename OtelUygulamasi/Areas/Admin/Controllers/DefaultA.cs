using Microsoft.AspNetCore.Mvc;

namespace OtelUygulamasi.Areas.Admin.Controllers
{
    public class DefaultA : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
