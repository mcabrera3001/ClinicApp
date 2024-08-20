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

            var SuperAdmin = new IdentityRole("SuperAdmin");
            SuperAdmin.NormalizedName = "SuperAdmin";

            var Admin = new IdentityRole("Admin");
            Admin.NormalizedName = "Admin";

            var Doctor = new IdentityRole("Doctor");
            Doctor.NormalizedName = "Doctor";

            var Patient = new IdentityRole("Patient");
            Patient.NormalizedName = "Patient";

            builder.Entity<IdentityRole>().HasData(SuperAdmin, Admin, Doctor, Patient);
            
        }
    }

    
}
