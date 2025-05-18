using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagement.Web.Models
{
    public class Department
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Location { get; set; } = null!;

        // Navigation property for related Employees
        //public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
