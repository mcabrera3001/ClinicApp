using ClinicApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClinicApp.Sevices
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var admin = new IdentityRole("admin");
            admin.NormalizedName = "admin";

            var doctor = new IdentityRole("doctor");
            admin.NormalizedName = "doctor";

            var patient = new IdentityRole("patient");
            admin.NormalizedName = "patient";

            builder.Entity<IdentityRole>().HasData(admin, doctor, patient);

        }
    }

    
}
