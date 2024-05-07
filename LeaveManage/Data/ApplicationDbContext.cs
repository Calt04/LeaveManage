using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManage.Data
{
    public class ApplicationDbContext : IdentityDbContext <Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<LeaveTybes> LeaveTybes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }

    }
}
