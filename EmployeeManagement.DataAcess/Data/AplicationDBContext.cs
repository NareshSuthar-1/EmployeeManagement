using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.DataAccess.Data
{
    public class AplicationDBContext : DbContext
    {
        public AplicationDBContext(DbContextOptions _options):base(_options)
        {
        }
    }
}
