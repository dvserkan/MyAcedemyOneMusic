using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.BusinessLayer.Abstract
{
	public interface IGenericService<T> where T : class
	{
		List<T> TGetList();
		T TGetById(int id);
		void TCreate(T t);
		void TUpdate(T t);
		void TDelete(int id);
	}
}
