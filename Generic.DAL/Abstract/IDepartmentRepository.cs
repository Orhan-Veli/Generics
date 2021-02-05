using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.DAL.Abstract
{
    public interface IDepartmentRepository:IRepository<Department>
    {
      Department GetByDepartmentId(int id);
    }
}
