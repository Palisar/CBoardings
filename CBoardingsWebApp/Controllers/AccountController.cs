using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CBoardings.WebApp.Controllers
{
    public class AccountController : Controller
    {
        public async Task Login(string returnUrl = "/")
        {
            await HttpContext.ChallengeAsync("Auth0", new AuthenticationProperties() {RedirectUri = returnUrl});
        }

        public async Task Logout()
        {
            await HttpContext.SignOutAsync(new AuthenticationProperties()
            {
                RedirectUri = Url.Page("/Index")
            });
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }
    }
}
