using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace Globalization.Controllers
{
    public class LanguageController : Controller
    {
        public IActionResult ChangeCulture(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddMonths(6),
                });

            return LocalRedirect(returnUrl);
        }
    }
}
