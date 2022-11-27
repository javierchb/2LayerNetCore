using Microsoft.AspNetCore.Mvc;
using test_api_persistencia.Models;
using test_api_persistencia.DAO;
namespace test_api_persistencia.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _Configuration;
        private readonly IDAOUser _DAOuser;
        public UserController(IConfiguration Cofiguration, IDAOUser DAOUser)
        {
            _Configuration = Cofiguration;
            _DAOuser = DAOUser;
        }
        
        [HttpGet("GetUsers")]
        public List<User> GetUsers()
        { 
            List<User> Response = new List<User>();
            Response = _DAOuser.GetUsers();
            return Response;
        }
    }
}
