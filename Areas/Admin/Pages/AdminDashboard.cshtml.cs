using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

[Authorize(Roles = "admin")]
public class AdminDashboardModel : PageModel
{
    public void OnGet()
    {
    }
}
