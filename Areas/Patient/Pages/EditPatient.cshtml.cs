using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using ClinicApp.Models;
using System.Threading.Tasks;

public class EditPatientModel : PageModel
{
    private readonly UserManager<ApplicationUser> _userManager;

    public EditPatientModel(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    [BindProperty]
    public ApplicationUser Patient { get; set; }

    public async Task<IActionResult> OnGetAsync(string id)
    {
        if (id == null)
        {
            return NotFound();
        }

        Patient = await _userManager.FindByIdAsync(id);

        if (Patient == null)
        {
            return NotFound();
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var user = await _userManager.FindByIdAsync(Patient.Id);
        if (user == null)
        {
            return NotFound();
        }

        // Actualizar propiedades del usuario aquí.
        user.UserName = Patient.UserName;
        user.Email = Patient.Email;
        user.PhoneNumber = Patient.PhoneNumber;
        user.Address = Patient.Address;

        var result = await _userManager.UpdateAsync(user);

        if (result.Succeeded)
        {
            return RedirectToPage("/ListPatients"); // Redirige a la lista de pacientes después de editar
        }

        foreach (var error in result.Errors)
        {
            ModelState.AddModelError(string.Empty, error.Description);
        }

        return Page();
    }
}
