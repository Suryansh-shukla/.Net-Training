using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;

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

    }
}
