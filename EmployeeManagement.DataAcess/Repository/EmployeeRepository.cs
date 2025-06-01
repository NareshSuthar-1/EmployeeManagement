using EmployeeManagement.DataAccess.Data;
using EmployeeManagement.DataAccess.Repository.IRepository;
using EmployeeManagement.Models;
using EmployeeManagement.Utility;

namespace EmployeeManagement.DataAccess.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private static List<Employee> _StaticEmployeesList = StaticData.employees;
        private static List<Employee> _employeeList = new List<Employee>();
        private readonly AplicationDBContext _db;
        public EmployeeRepository(AplicationDBContext db) 
        {
            _db = db;
            bool isStaticData = false;
            if (isStaticData)
            {
                _employeeList = _StaticEmployeesList;
            }
            else
            {
                //DAL dAL = new DAL();
                //_employeeList = dAL.GetAllEmployees();
                _employeeList = _db.Employees.ToList(); // Using EF Core
            }
        }
        void Delete(int employeeID)
        {
            Employee employee = _employeeList.FirstOrDefault(x => x.Id == employeeID);
            _employeeList.Remove(employee);
        }

        IEnumerable<Employee> GetAll()
        {
            return _employeeList;
        }

        Employee GetById(int EmployeeID)
        {
            return _employeeList.FirstOrDefault(emp => emp.Id == EmployeeID);
        }

        void Insert(Employee employee)
        {
            _employeeList.Add(employee);
        }
        void Update(Employee employee)
        {
            var emp = _employeeList.FirstOrDefault(e => e.Id == employee.Id);
            if (emp != null)
            {
                // Update values
                emp.Name = employee.Name;
                emp.Age = employee.Age;
                emp.DepartmentId = employee.DepartmentId;
            }
        }
        void Save()
        {

        }

        IEnumerable<Employee> IEmployeeRepository.GetAll()
        {
            return GetAll();
        }

        Employee IEmployeeRepository.GetById(int EmployeeID)
        {
            return GetById(EmployeeID);
        }

        void IEmployeeRepository.Insert(Employee employee)
        {
            Insert(employee);
        }

        void IEmployeeRepository.Update(Employee employee)
        {
            Update(employee);
        }

        void IEmployeeRepository.Delete(int EmployeeID)
        {
            Delete(EmployeeID);
        }

        void IEmployeeRepository.Save()
        {
            Save();
        }
    }
}