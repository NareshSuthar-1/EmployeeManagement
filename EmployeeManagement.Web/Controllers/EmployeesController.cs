using EmployeeManagement.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Web.Controllers
{
    public class EmployeesController : Controller
    {
        List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice Johnson", Age = 29, Salary = 75000.00m, DepartmentId = 1 },
                new Employee { Id = 2, Name = "Bob Smith",     Age = 35, Salary = 62000.00m, DepartmentId = 2 },
                new Employee { Id = 3, Name = "Carol Davis",   Age = 42, Salary = 88000.00m, DepartmentId = 3 },
                new Employee { Id = 4, Name = "David Lee",     Age = 31, Salary = 54000.00m, DepartmentId = 4 }
            };
        public IActionResult Index()
        {

            return View(employees);
        }

        public IActionResult Create()
        {
            return View();
;        }

        public IActionResult Edit(int id)
        {
            Employee employee = employees[id];
            return View(employee);
        }
    }
}
