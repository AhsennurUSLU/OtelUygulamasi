using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class RezervasyonManager : IRezervasyonService
	{
		IRezervasyonDal _rezervasyonDal;

		public RezervasyonManager(IRezervasyonDal rezervasyonDal)
		{
			_rezervasyonDal = rezervasyonDal;
		}
		public List<Rezervasyon> GetList(Rezervasyon t)
		{

			return _rezervasyonDal.GetList();
		}

		public void TAdd(Rezervasyon t)
		{
		 _rezervasyonDal.Insert(t);
		}

		public void TDelete(Rezervasyon t)
		{
			_rezervasyonDal.Delete(t);
		}

		public Rezervasyon TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public object TGetList()
		{
		return	_rezervasyonDal.GetList();
		}

		public void TUpdate(Rezervasyon t)
		{
			_rezervasyonDal.Update(t);
		}
	}
}
