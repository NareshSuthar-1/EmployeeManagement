using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Utility
{
    public  class StaticData
    {
        public static List<Department> departments = new List<Department>
            {
                new Department { Id = 1, Name = "Human Resources", Location = "New York" },
                new Department { Id = 2, Name = "Finance", Location = "Chicago" },
                new Department { Id = 3, Name = "IT", Location = "San Francisco" },
                new Department { Id = 4, Name = "Marketing", Location = "Los Angeles" }
            };
        public static List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice Johnson", Age = 29, Salary = 75000.00m, DepartmentId = 1 },
                new Employee { Id = 2, Name = "Bob Smith",     Age = 35, Salary = 62000.00m, DepartmentId = 2 },
                new Employee { Id = 3, Name = "Carol Davis",   Age = 42, Salary = 88000.00m, DepartmentId = 3 },
                new Employee { Id = 4, Name = "David Lee",     Age = 31, Salary = 54000.00m, DepartmentId = 4 }
            };

       
    }
}
