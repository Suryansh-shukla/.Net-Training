using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using EFCoreMVCWebDEmo.Models;

namespace EFCoreMVCWebDEmo.Models
{
    public class LPUTrialDbDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\sqlexpress;Trusted_Connection=true;Database=LPU_Trial_DB;TrustServerCertificate=true");
        }

        public LPUTrialDbDbContext()
        {
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EFCoreMVCWebDEmo.Models.EmployeeVM> EmployeeVM { get; set; } = default!;   

    }
}
