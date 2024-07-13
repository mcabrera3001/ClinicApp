using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
[Authorize(Roles = "doctor")]

public class DoctorDashboardmModel : PageModel
{
    public void OnGet()
    {
    }
}
