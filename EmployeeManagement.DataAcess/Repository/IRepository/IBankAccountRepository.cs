using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DataAccess.Repository.IRepository
{
    public interface IBankAccountRepository
    {
        IEnumerable<BankAccount> GetAll();
        BankAccount GetById(int id);
        void Insert(BankAccount bankAccount);
        void Update(BankAccount bankAccount);
        void Delete(int id);
        void Save(); // for  DB / Contextual 
    }
}
