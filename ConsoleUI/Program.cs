using Generic.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            UnitOfWork unitOfWork = new UnitOfWork(new Generic.DAL.GenericContext());
            unitOfWork.departmentRepository.Add(new Entities.Department { DepartmentId = 1, LastName = "q", Name = "T", Phone = "1231", ZipCode = "12341" });
            unitOfWork.Complete();
        }
    }
}
