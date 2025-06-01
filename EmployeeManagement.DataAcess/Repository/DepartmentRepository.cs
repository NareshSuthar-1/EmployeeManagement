using EmployeeManagement.DataAccess.Data;
using EmployeeManagement.DataAccess.Repository.IRepository;
using EmployeeManagement.Models;
using EmployeeManagement.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DataAccess.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private static List<Department> _StaticDepartmentsList = StaticData.departments;
        private List<Department> _departmentsList = new List<Department>();
        private readonly AplicationDBContext _db;
        public DepartmentRepository(AplicationDBContext db)
        {
            _db = db;
            bool isStaticData = false;
            if (isStaticData)
            {
                _departmentsList = _StaticDepartmentsList;
            }
            else
            {
                //DAL dAL = new DAL();
                //_departmentsList = dAL.GetAllDepartments();
                _departmentsList = _db.Departments.ToList();
            }
        }


        public IEnumerable<Department> GetAll()
        {
            return _departmentsList;
        }

        public Department GetById(int departmentId)
        {

            return _departmentsList.FirstOrDefault(dep => dep.Id == departmentId);
        }
    }
}
