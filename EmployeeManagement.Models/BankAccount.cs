using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EmployeeManagement.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        [Required]
        public string BankName { get; set; }
        [Required]
        public string AccountNumber { get; set; }
        public string IFSCCode { get; set; }
        public string BranchName { get; set; }
        public string AccountType { get; set; }
        public string Currency { get; set; }
        public int IsActive { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? DeletedOn { get; set; }
        // Foreign key to Employee
        public int EmployeeId { get; set; }

        // Navigation property: Each bank account belongs to one employee
        public Employee Employees { get; set; }
    }
}
