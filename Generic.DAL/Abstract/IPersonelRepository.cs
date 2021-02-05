using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.DAL.Abstract
{
    public interface IPersonelRepository:IRepository<Personel>
    {
        Personel GetByPersonelId(int id);
    }
}
