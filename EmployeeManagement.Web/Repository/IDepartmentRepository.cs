using EmployeeManagement.Web.Models;

namespace EmployeeManagement.Web.Repository
{
    public interface IDepartmentRepository
    {
        public IEnumerable<Department> GetAll();
        public Department GetById(int departmentId);
    }
}
