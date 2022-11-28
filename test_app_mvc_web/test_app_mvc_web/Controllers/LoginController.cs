using Microsoft.AspNetCore.Mvc;
using test_app_mvc_web.Models;
namespace test_app_mvc_web.Controllers
{      
    public class LoginController : Controller
    {
        [HttpPost("UserLogin")]
        public IActionResult UserLogin(User Parameters)
        {
            if (!String.IsNullOrEmpty(Parameters.Username) && !String.IsNullOrEmpty(Parameters.Password))
            {
                return RedirectToAction("UserIndex", "User");                
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }            
        }
    }
}
