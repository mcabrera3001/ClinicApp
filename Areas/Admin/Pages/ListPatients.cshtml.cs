using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicApp.Models;

public class ListPatientsModel : PageModel
{
    private readonly UserManager<ApplicationUser> _userManager;

    public ListPatientsModel(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public IList<ApplicationUser> Patients { get; set; }

    public async Task OnGetAsync()
    {
        var users = _userManager.Users.ToList();
        var patientRole = await _userManager.GetUsersInRoleAsync("patient");

        Patients = users.Where(user => patientRole.Contains(user)).ToList();
    }
}
