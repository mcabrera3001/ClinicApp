﻿using ClinicApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

[Authorize(Roles = "admin")]
public class CreatePatientModel : PageModel
{
    private readonly UserManager<ApplicationUser> _userManager;

    public CreatePatientModel(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    [BindProperty]
    public InputModel? Input { get; set; }

    public class InputModel
    {
        [Required]
        [Display(Name = "User Name")]
        public required string UserName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public required string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public required string Password { get; set; }
    }

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (ModelState.IsValid)
        {
            var user = new ApplicationUser { UserName = Input.UserName, Email = Input.Email };
            var result = await _userManager.CreateAsync(user, Input.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "Patient");
                return RedirectToPage("./Index");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        return Page();
    }
}
