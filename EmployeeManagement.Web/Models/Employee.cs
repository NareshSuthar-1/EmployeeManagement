using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Web.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        public int Age { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }

        // Foreign key to Department
        [Required]
        public int DepartmentId { get; set; }

        // Navigation property for the related Department
        [ForeignKey(nameof(DepartmentId))]
        public Department Department { get; set; } = null!;

        #region  CODE FOR ENCUSULATION 
        //public string Department { get; private set; }
        //public Employee(string name, int age, decimal salary, string department)
        //{
        //    Name = name;
        //    Age = age;
        //    Salary = salary;
        //    Department = department;
        //}

        //public void UpdateDetails(string name, int age, decimal salary, string department)
        //{
        //    Name = name;
        //    Age = age;
        //    Salary = salary;
        //    Department = department;
        //}
        #endregion
    }
}
