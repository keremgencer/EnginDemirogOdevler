using Entity.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IGenericDal<T> where T : BaseEntity
    {
        T Get(int id);
        List<T> GetAll();
        void Add(T item);
        void Delete(int id);
        void Update(int id, T item);
    }
}
