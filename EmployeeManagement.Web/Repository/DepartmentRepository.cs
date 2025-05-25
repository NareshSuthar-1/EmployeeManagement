using EmployeeManagement.Web.Models;

namespace EmployeeManagement.Web.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private static List<Department> departments = new List<Department>
            {
                new Department { Id = 1, Name = "Human Resources", Location = "New York" },
                new Department { Id = 2, Name = "Finance", Location = "Chicago" },
                new Department { Id = 3, Name = "IT", Location = "San Francisco" },
                new Department { Id = 4, Name = "Marketing", Location = "Los Angeles" }
            };
        public IEnumerable<Department> GetAll()
        {
            return departments;
        }

        public Department GetById(int departmentId)
        {
            return departments.FirstOrDefault(dep => dep.Id == departmentId);
        }
    }
}
