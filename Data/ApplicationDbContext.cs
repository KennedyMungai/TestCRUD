using Microsoft.EntityFrameworkCore;

namespace TestCRUD.Data;

public class ApplicationDbContext : DbContext
{   
    public DbSet<Employee>? Employees { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
}