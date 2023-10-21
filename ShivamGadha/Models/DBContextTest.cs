using Microsoft.EntityFrameworkCore;
using ShivamGadha.Models;

namespace ShivamGadha.Models
{
    public class DBContextTest : DbContext
    {
        protected readonly IConfiguration Configuration;
        public virtual DbSet<Employee>? Employees { get; set; }
        public DBContextTest(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employees");
                entity.HasKey(u => u.EmployeeID);
                entity.Property(u => u.EmpName).IsRequired().HasMaxLength(50);
                entity.Property(u => u.EmpAge);
                entity.Property(u => u.EmpCity);
                entity.Property(u => u.EmpDepartment);
                entity.Property(u => u.EmpManager);
                entity.Property(u => u.JoiningDate);
                entity.Property(u => u.Salary);
            });
            modelBuilder.Entity<Managers>(entity =>
            {
                entity.ToTable("Managers");
                entity.HasKey(u => u.ID);
                entity.Property(u => u.Name).IsRequired().HasMaxLength(50);
            });
        }
        public DbSet<ShivamGadha.Models.Managers>? Managers { get; set; }
        
    }
}
