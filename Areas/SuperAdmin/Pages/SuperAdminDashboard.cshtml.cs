using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

[Authorize(Roles = "super_admin")]

public class Super_AdminDashboard : PageModel
{
   public void OnGet()
   {
   }
    
}
