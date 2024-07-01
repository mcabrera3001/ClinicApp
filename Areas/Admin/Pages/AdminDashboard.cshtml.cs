using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

[Authorize(Roles = "admin")]
public class AdminDashboard : PageModel
{
    public void OnGet()
    {
    }
}
