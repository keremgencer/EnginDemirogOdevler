using DataAccess.Abstract;
using Entity.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class GenericDal<T> : IGenericDal<T> where T : BaseEntity
    {
        List<T> List;
        public GenericDal()
        {
            List = new List<T>();
        }
        public void Add(T item)
        {
            List.Add(item);
        }

        public void Delete(int id)
        {
            List.Remove(List.FirstOrDefault(x=>x.Id == id));
        }

        public T Get(int id)
        {
            return List.FirstOrDefault(x => x.Id == id);
        }

        public List<T> GetAll()
        {
            return List;
        }

        public void Update(int id, T item)
        {
            List[id] = item;
        }
    }
}
