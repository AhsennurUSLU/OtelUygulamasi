using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;

namespace OtelUygulamasi.Controllers
{
    public class HakkimizdaController : Controller
    {
        HakkimizdaManager hakkimizdaManager = new HakkimizdaManager(new EfHakkimizdaDal());
        public IActionResult Index()
        {
            var values = hakkimizdaManager.TGetList();
            return View(values);
        }
    }
}
