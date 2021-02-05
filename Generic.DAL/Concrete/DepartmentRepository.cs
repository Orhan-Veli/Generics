using Entities;
using Generic.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.DAL.Concrete
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        private GenericContext _genericContext;
        public DepartmentRepository(GenericContext genericContext):base(genericContext)
        {
            _genericContext = genericContext;
        }
        public Department GetByDepartmentId(int id)
        {
            return _genericContext.Set<Department>().Find(id);
        }
    }
}
