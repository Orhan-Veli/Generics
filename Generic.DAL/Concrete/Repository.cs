using Generic.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.DAL.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        GenericContext _genericContext;
        public Repository(GenericContext genericContext)
        {
            _genericContext = genericContext;
        }
        public void Add(T Model)
        {
            _genericContext.Set<T>().Add(Model);
        }

        public IEnumerable<T> GetAll()
        {
           return _genericContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _genericContext.Set<T>().Find(id);
      
        }

        public void Remove(T Model)
        {
            _genericContext.Set<T>().Remove(Model);
        }

        public IEnumerable<T> Update(T Model,int id)
        {

            var entity =_genericContext.Set<T>().Find(id);
            entity = Model;
            return _genericContext.Set<T>().ToList();
        }
    }
}
