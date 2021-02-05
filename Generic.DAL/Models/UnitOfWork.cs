using Generic.DAL.Abstract;
using Generic.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.DAL.Models
{
    public class UnitOfWork : IUnitOfWork
    {
        private GenericContext _genericContext;
        public UnitOfWork(GenericContext genericContext)
        {
            _genericContext = genericContext;
            departmentRepository = new DepartmentRepository(_genericContext);
            personelRepository = new PersonelRepository(_genericContext);
        }
        public IDepartmentRepository departmentRepository { get; set; }
        public IPersonelRepository personelRepository { get; set; }

        public void Complete()
        {
            _genericContext.SaveChanges();
            Console.WriteLine("Kaydedildi.");
            Console.ReadLine();

        }

        public void Dispose()
        {
            _genericContext.Dispose();
            Console.WriteLine("*");
            Console.ReadLine();
        }
    }
}
