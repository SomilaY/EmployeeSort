using EmployeeSort.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] employeeSurnames = { "Smith", "Lerato", "Carol", "Kabelo", "Jones", "James", "Bongani", "Keith" };

            List<Employee> employeeList = new List<Employee>();
            Random random = new Random();

            for (int i = 0; i < 8; i++)
            {
                int randomDepartmentId = random.Next(1, 6);

                int randomSurnameIndex = random.Next(employeeSurnames.Length);
                string randomSurname = employeeSurnames[randomSurnameIndex];

                employeeList.Add(new Employee(randomDepartmentId, randomSurname));
            }

            Console.WriteLine("Sample data before sort:");
            DisplayList(employeeList);


            SortList(employeeList);

            Console.WriteLine();
            Console.WriteLine("Sample data after sort:");
            DisplayList(employeeList);
            Console.ReadLine();

        }

        private static void DisplayList(List<Employee> employees)
        {
            Console.WriteLine("DEPARTMENT ID\tSURNAME");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.DepartmentId}\t\t{employee.Surname}");
            }
        }

        private static List<Employee> SortList(List<Employee> employees)
        {
            int n = employees.Count;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (employees[j].DepartmentId > employees[j + 1].DepartmentId)
                    {
                        Employee temp = employees[j];
                        employees[j] = employees[j + 1];
                        employees[j + 1] = temp;
                    }
                    else if (employees[j].DepartmentId == employees[j + 1].DepartmentId)
                    {
                        if (string.Compare(employees[j].Surname, employees[j + 1].Surname) > 0)
                        {
                            Employee temp = employees[j];
                            employees[j] = employees[j + 1];
                            employees[j + 1] = temp;
                        }
                    }
                }
            }

            return employees;
        }

    }
}

