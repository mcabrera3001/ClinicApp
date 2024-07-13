using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

[Authorize(Roles = "patient")]
public class PatientDashboardModel : PageModel
{
    public void OnGet()
    {
    }
}
