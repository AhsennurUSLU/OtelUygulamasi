using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace OtelUygulamasi.Areas.Admin.Controllers
{
    public class Musteriler : Controller
    {
        MusteriManager musteriManager = new MusteriManager(new EfMusteriDal());
        [Area("Admin")]
        
        public IActionResult Index()
        {
            var values = musteriManager.TGetList();
            return View(values);
        }
        /*
		public IActionResult DeleteMusteri(int id)
		{
			var values = musteriManager.TGetByID(id);
			musteriManager.TDelete(values);
            return RedirectToAction("Index");
		}
        */
	}
}
