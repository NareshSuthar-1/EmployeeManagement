using EmployeeManagement.DataAccess.Data;
using EmployeeManagement.DataAccess.Repository.IRepository;
using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DataAccess.Repository
{
    public class BankAccountRepository : IBankAccountRepository
    {
        private readonly AplicationDBContext _db;
        public BankAccountRepository(AplicationDBContext db)
        {
            _db = db;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BankAccount> GetAll()
        {
            return _db.BankAccounts.ToList();
        }

        public BankAccount GetById(int id)
        {
            return _db.BankAccounts.FirstOrDefault(emp => emp.Id == id);
        }

        public void Insert(BankAccount bankAccount)
        {
            _db.BankAccounts.Add(bankAccount);
        }

        public void Save()
        {
           
        }

        public void Update(BankAccount bankAccount)
        {
            var emp = _db.BankAccounts.FirstOrDefault(e => e.Id == bankAccount.Id);
            if (emp != null)
            {
                // Update values
            }
        }
    }
}
