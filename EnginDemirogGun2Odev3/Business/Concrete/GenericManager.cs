using Business.Abstract;
using DataAccess.Abstract;
using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class GenericManager<T> : IGenericManager<T> where T : BaseEntity
    {
        private IGenericDal<T> _genericDal;
        public GenericManager(IGenericDal<T> genericDal)
        {
            _genericDal = genericDal;
        }
        public void Add(T item)
        {
            _genericDal.Add(item);
        }

        public T Get(int id)
        {
            return _genericDal.Get(id);
        }

        public List<T> GetAll()
        {
            return _genericDal.GetAll();
        }

        public void Remove(int id)
        {
            _genericDal.Delete(id);
        }

        public void Update(int id, T item)
        {
            _genericDal.Update(id, item);
        }
    }
}
