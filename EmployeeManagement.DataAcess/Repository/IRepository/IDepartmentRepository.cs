using EmployeeManagement.Models;

namespace EmployeeManagement.DataAccess.Repository.IRepository
{
    public interface IDepartmentRepository
    {
        public IEnumerable<Department> GetAll();
        public Department GetById(int departmentId);
    }
}
