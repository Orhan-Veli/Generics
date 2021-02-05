using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.DAL
{
    public class GenericContext:DbContext
    {
        public GenericContext():base("GenericContext")
        {
                
        }
        public DbSet<Personel> Personels { get; set; }

        public DbSet<Department> Departments { get; set; }
    }
}
