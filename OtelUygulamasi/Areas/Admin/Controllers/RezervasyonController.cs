using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace OtelUygulamasi.Areas.Admin.Controllers
{
	public class RezervasyonController : Controller
	{

		RezervasyonManager rezervasyonManager = new RezervasyonManager(new EfRezervasyonDal());
		[Area("Admin")]
		public IActionResult Index()
		{
			var values = rezervasyonManager.TGetList();
			return View(values);
		}
	}
}
