using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HakkimizdaManager : IHakkimizdaService
    {
        // dependency injection (gelen entityleri karşılamak için kullanılıyor)
        IHakkimizdaDal _hakkimizdaDal;

       
        //constructor method
       public HakkimizdaManager(IHakkimizdaDal hakkimizdaDal)
        {
                _hakkimizdaDal = hakkimizdaDal;
        }

        public List<Hakkimizda> TGetList(Hakkimizda t)
        {
          return  _hakkimizdaDal.GetList();
        }

        public void TAdd(Hakkimizda t)
        {
            _hakkimizdaDal.Insert(t);
        }

        public void TDelete(Hakkimizda t)
        {
            _hakkimizdaDal.Delete(t);
        }

        public Hakkimizda TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Hakkimizda t)
        {
            _hakkimizdaDal.Update(t);
        }

        public List<Hakkimizda>? TGetList()
        {
            return _hakkimizdaDal.GetList();
        }

        public List<Hakkimizda> GetList(Hakkimizda t)
        {
            throw new NotImplementedException();
        }
    }
}
