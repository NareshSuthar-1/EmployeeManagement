using EmployeeManagement.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeManagement.Web.Controllers
{
    public class EmployeesController : Controller
    {
        private static List<Employee>  employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice Johnson", Age = 29, Salary = 75000.00m, DepartmentId = 1 },
                new Employee { Id = 2, Name = "Bob Smith",     Age = 35, Salary = 62000.00m, DepartmentId = 2 },
                new Employee { Id = 3, Name = "Carol Davis",   Age = 42, Salary = 88000.00m, DepartmentId = 3 },
                new Employee { Id = 4, Name = "David Lee",     Age = 31, Salary = 54000.00m, DepartmentId = 4 }
            };
        List<Department> departments = new List<Department>
            {
                new Department { Id = 1, Name = "Human Resources", Location = "New York" },
                new Department { Id = 2, Name = "Finance", Location = "Chicago" },
                new Department { Id = 3, Name = "IT", Location = "San Francisco" },
                new Department { Id = 4, Name = "Marketing", Location = "Los Angeles" }
            };

        public IActionResult Index()
        {

            return View(employees);
        }

        public IActionResult Create()
        {
            ViewBag.Departments = new SelectList(departments, "Id", "Name");
            return View();
;        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            employees.Add(employee);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int Id)
        {
            Employee employee = employees.FirstOrDefault(x => x.Id == Id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee updated)
        {
            var emp = employees.FirstOrDefault(e => e.Id == updated.Id);
            if (emp == null) return NotFound();

            // Update values
            emp.Name = updated.Name;
            emp.Age = updated.Age;
            emp.DepartmentId = updated.DepartmentId;

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            Employee employee = employees.FirstOrDefault(x=>x.Id == Id);
            employees.Remove(employee);
            return RedirectToAction("Index");
        }
    }
}
