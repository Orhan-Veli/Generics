using Generic.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.DAL.Models
{
    public interface IUnitOfWork:IDisposable
    {
        IDepartmentRepository departmentRepository { get; set; }
        IPersonelRepository personelRepository { get; set; }
    

        void Complete();
    }
}
