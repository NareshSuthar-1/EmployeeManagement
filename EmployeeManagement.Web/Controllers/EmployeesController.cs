using EmployeeManagement.DataAccess.Repository.IRepository;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EmployeeManagement.Web.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDepartmentRepository _departmentRepository;

        public EmployeesController(IEmployeeRepository employeeRepository, IDepartmentRepository departmentRepository)
        {
            _employeeRepository = employeeRepository;
            _departmentRepository = departmentRepository;
        }

        public IActionResult Index()
        {
            return View(_employeeRepository.GetAll());
        }

        public IActionResult Create()
        {
            ViewBag.Departments = new SelectList(_departmentRepository.GetAll(), "Id", "Name");
            return View();
;        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            _employeeRepository.Insert(employee);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int Id)
        {
            ViewBag.Departments = new SelectList(_departmentRepository.GetAll(), "Id", "Name");
            Employee employee = _employeeRepository.GetById(Id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee updated)
        {
            _employeeRepository.Update(updated);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            _employeeRepository.Delete(Id);
            return RedirectToAction("Index");
        }
    }
}
