using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace OtelUygulamasi.Areas.Admin.Controllers
{
	
    public class OtellerController : Controller
    {
		OtelManager otelManager = new OtelManager(new EfOtelDal());
		[Area("Admin")]

		public IActionResult Index()
        {
			var values = otelManager.TGetList();
			return View(values);
        }
    }
}
