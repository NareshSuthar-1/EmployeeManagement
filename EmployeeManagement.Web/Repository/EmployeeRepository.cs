using EmployeeManagement.Web.Models;

namespace EmployeeManagement.Web.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private static List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice Johnson", Age = 29, Salary = 75000.00m, DepartmentId = 1 },
                new Employee { Id = 2, Name = "Bob Smith",     Age = 35, Salary = 62000.00m, DepartmentId = 2 },
                new Employee { Id = 3, Name = "Carol Davis",   Age = 42, Salary = 88000.00m, DepartmentId = 3 },
                new Employee { Id = 4, Name = "David Lee",     Age = 31, Salary = 54000.00m, DepartmentId = 4 }
            };
        void Delete(int employeeID)
        {
            Employee employee = employees.FirstOrDefault(x => x.Id == employeeID);
            employees.Remove(employee);
        }

        IEnumerable<Employee> GetAll()
        {
            return employees;
        }

        Employee GetById(int EmployeeID)
        {
            return employees.FirstOrDefault(emp=> emp.Id == EmployeeID);
        }

        void Insert(Employee employee)
        {
            employees.Add(employee);
        }


        void Update(Employee employee)
        {
            var emp = employees.FirstOrDefault(e => e.Id == employee.Id);
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
