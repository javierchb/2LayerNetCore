using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using test_app_mvc_web.Models;
using test_app_mvc_web.Delegates;
namespace test_app_mvc_web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;        
        private readonly DelegateUser _DelegateUser;        
        public HomeController(ILogger<HomeController> logger, IConfiguration Configuration)
        {
            _logger = logger;
            _DelegateUser = new DelegateUser(Configuration);
        }

        public async Task<IActionResult> Index()
        {            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}