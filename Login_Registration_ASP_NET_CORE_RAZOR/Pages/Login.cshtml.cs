using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Login_Registration_ASP_NET_CORE_RAZOR.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Login_Registration_ASP_NET_CORE_RAZOR.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Login Model { get; set; }
        public string msg="";
        public SignInManager<IdentityUser> SignInManager { get; }

        public LoginModel(SignInManager<IdentityUser> signInManager )
        {
            SignInManager = signInManager;
        }
        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPostAsync(string returnUrl=null)
        {
            if (ModelState.IsValid)
            {
                var identityResult = await SignInManager.PasswordSignInAsync(Model.Email, Model.Password, Model.RememberMe, false);
                if(identityResult.Succeeded)
                {
                    if(returnUrl==null || returnUrl == "/")
                    {
                        return RedirectToPage("Home");
                    }
                    else
                    {
                        return RedirectToPage(returnUrl);
                    }
                }
                ModelState.AddModelError("", "Username or Password incorrect");
            }
            msg = "Username or Password Incorrect";
            return Page();
        }
    }
}