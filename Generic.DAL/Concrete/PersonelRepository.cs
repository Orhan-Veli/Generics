using Entities;
using Generic.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.DAL.Concrete
{
    public class PersonelRepository : Repository<Personel>, IPersonelRepository
    {
        private GenericContext _genericContext;
        public PersonelRepository(GenericContext genericContext):base(genericContext)
        {
            _genericContext = genericContext;
        }
        public Personel GetByPersonelId(int id)
        {
            return _genericContext.Set<Personel>().Find(id);
        }
    }
}
