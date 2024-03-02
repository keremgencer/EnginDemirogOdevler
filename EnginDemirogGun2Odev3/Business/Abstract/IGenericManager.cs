using Entity.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGenericManager<T> where T : BaseEntity
    {
        T Get(int id);
        List<T> GetAll();
        void Add(T item);
        void Remove(int id);
        void Update(int id,T item);
    }
}
