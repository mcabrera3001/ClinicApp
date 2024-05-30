using Microsoft.AspNetCore.Identity;

namespace ClinicApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string Addres { get; set; } = "";
        public DateTime CreatedAt { get; set; }
    }
}
