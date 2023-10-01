using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSort.Model
{
    public class Employee
    {
        public int DepartmentId { get; set; }
        public string Surname { get; set; }

        public Employee(int departmentId, string surname)
        {
            DepartmentId = departmentId;
            Surname = surname;
        }
    }
}
