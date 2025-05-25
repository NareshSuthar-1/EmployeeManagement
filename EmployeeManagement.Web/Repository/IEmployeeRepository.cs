using EmployeeManagement.Web.Models;

namespace EmployeeManagement.Web.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int EmployeeID);
        void Insert(Employee employee);
        void Update(Employee employee);
        void Delete(int EmployeeID);
        void Save(); // for  DB / Contextual 
    }
}
