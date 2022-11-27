using Microsoft.AspNetCore.Mvc;
using test_app_mvc_web.Models;
using test_app_mvc_web.Models.UI;
using test_app_mvc_web.Delegates;
namespace test_app_mvc_web.Controllers
{
    [Route("[controller]")]
    [ApiController]    
    public class UserController : Controller
    {
        private readonly DelegateUser _DelegateUser;
        public UserController(IConfiguration Configuration)
        {
            _DelegateUser = new DelegateUser(Configuration);
        }
        [HttpGet("UserIndex")]
        public async Task<IActionResult> UserIndex()
        {
            List<User> ListUsers = await _DelegateUser.GetUsers();
            UIUser UIModel = new UIUser();
            UIModel.ListUsers = ListUsers;
            return View(UIModel);
        }
    }
}
