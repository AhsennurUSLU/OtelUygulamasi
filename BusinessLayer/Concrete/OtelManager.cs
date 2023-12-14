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
	public class OtelManager:IOtelService
	{
		IOtelDal _otelDal;
		public OtelManager(IOtelDal otelDal)
		{
			_otelDal = otelDal;
		}

		public List<Otel> GetList(Otel t)
		{
			return _otelDal.GetList();
		}

		public void TAdd(Otel t)
		{

			_otelDal.Insert(t);
		}

		public void TDelete(Otel t)
		{
			_otelDal.Delete(t);
		}

		public Otel TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public object TGetList()
		{
		return	_otelDal.GetList();
		}

		public void TUpdate(Otel t)
		{
			_otelDal.Update(t);
		}
	}
}
