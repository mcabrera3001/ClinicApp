using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
[Authorize(Roles = "Doctor")]

public class DoctorDashboardmModel : PageModel
{
    public void OnGet()
    {
    }
}
