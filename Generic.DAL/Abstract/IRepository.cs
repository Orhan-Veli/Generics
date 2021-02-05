using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.DAL.Abstract
{
    public interface IRepository<T> where T:class
    {
        IEnumerable<T> GetAll();

        T GetById(int id);

        void Add(T Model);

        void Remove(T Model);

        IEnumerable<T> Update(T Model,int id);

    }
}
