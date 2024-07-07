using Microsoft.AspNetCore.Mvc;

namespace talantNexusMVC.Controllers
{
    public class AuthController : Controller


    {
        private HttpClient client = new HttpClient();

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register()
        {
            string url = "http://localhost:5073/api/Auth/register";

            return View();
        }

        public IActionResult ForgetPassword()
        {
            return View();
        }
    }
}
