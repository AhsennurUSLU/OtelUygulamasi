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
    public class MusteriManager:IMusteriService
    {
        IMusteriDal _musteriDal;
        public MusteriManager(IMusteriDal musteriDal)
        {
            _musteriDal = musteriDal; 
        }

      

        public List<Musteri> TGetList(Musteri t)
        {
            return _musteriDal.GetList();
        }

        public void TAdd(Musteri t)
        {
            _musteriDal.Insert(t);
        }

        public void TDelete(Musteri t)
        {
            _musteriDal.Delete(t);
        }

        public Musteri TGetByID(int id)
        {
			throw new NotImplementedException();
		}

        public void TUpdate(Musteri t)
        {
            _musteriDal.Update(t);
        }

        public List<Musteri> GetList(Musteri t)
        {
            throw new NotImplementedException();
        }

        public object TGetList()
        {
            return _musteriDal.GetList();
        }

		
	}
}
