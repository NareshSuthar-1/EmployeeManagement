using EmployeeManagement.Models;
using EmployeeManagement.Utility;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.DataAccess.Data
{
    public class AplicationDBContext : DbContext
    {

        #region Entities
        public DbSet<BankAccount> BankAccounts { get; set; }
       public  DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        #endregion Entities

        public AplicationDBContext(DbContextOptions _options):base(_options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankAccount>().HasData(
                new BankAccount
                {
                    Id = 1,
                    BankName = "HDFC Bank",
                    AccountNumber = "1234567890",
                    IFSCCode = "HDFC0001234",
                    BranchName = "Mumbai Main",
                    AccountType = "Savings",
                    Currency = "INR",
                    IsActive = 1,
                    CreatedOn = DateTime.Now.AddMonths(-6),
                    EmployeeId = 1,
                },
                new BankAccount
                {
                    Id = 2,
                    BankName = "State Bank of India",
                    AccountNumber = "9876543210",
                    IFSCCode = "SBIN0005678",
                    BranchName = "Delhi Branch",
                    AccountType = "Current",
                    Currency = "INR",
                    IsActive = 1,
                    CreatedOn = DateTime.Now.AddMonths(-12),
                    EmployeeId = 2,
                },
                new BankAccount
                {
                    Id = 3,
                    BankName = "ICICI Bank",
                    AccountNumber = "1122334455",
                    IFSCCode = "ICIC0002468",
                    BranchName = "Pune Central",
                    AccountType = "Savings",
                    Currency = "INR",
                    IsActive = 0,
                    CreatedOn = DateTime.Now.AddYears(-1),
                    EmployeeId = 3,
                },
                new BankAccount
                {
                    Id = 4,
                    BankName = "Axis Bank",
                    AccountNumber = "5566778899",
                    IFSCCode = "UTIB0007890",
                    BranchName = "Chennai South",
                    AccountType = "Current",
                    Currency = "INR",
                    IsActive = 1,
                    CreatedOn = DateTime.Now.AddDays(-30),
                    EmployeeId = 1,
                },
                new BankAccount
                {
                    Id = 5,
                    BankName = "Bank of America",
                    AccountNumber = "BOA99887766",
                    IFSCCode = "BOFA0USA123",
                    BranchName = "New York HQ",
                    AccountType = "Checking",
                    Currency = "USD",
                    IsActive = 1,
                    CreatedOn = DateTime.Now.AddYears(-2),
                    EmployeeId = 2,
                }
                );
            modelBuilder.Entity<Employee>().HasData(
                StaticData.employees
                );
            modelBuilder.Entity<Department>().HasData(
                StaticData.departments
                );
        }

    }
}
