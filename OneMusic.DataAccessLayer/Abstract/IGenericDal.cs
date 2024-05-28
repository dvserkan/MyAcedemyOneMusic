using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneMusic.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        List<T> GetList();
        T GetById(int id);
        void Create(T t);
        void Update(T t);
        void Delete(int id);
    }
}
