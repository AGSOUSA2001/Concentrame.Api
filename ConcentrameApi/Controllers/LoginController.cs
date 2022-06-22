using ConcentrameApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ConcentrameApi.Controllers
{
    [AllowAnonymous]
    public class LoginController : ControllerBase
    {
        private readonly SignInManager<IdentityUser> _signInManager;

        public LoginController(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpPost]
        public async Task<bool> Index([FromBody] Login loginViewModel)
        {
            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(loginViewModel.Email, loginViewModel.Password, true, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    //return LocalRedirect(returnUrl);
                    return true;
                }
                if (result.RequiresTwoFactor)
                {
                    //return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                    return false;
                }
                if (result.IsLockedOut)
                {
                    //return RedirectToPage("./Lockout");
                    return false;
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return false;
                }
            }

            return false;
        }
    }
}
