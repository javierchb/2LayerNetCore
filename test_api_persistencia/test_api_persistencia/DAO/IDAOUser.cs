using test_api_persistencia.Models;
namespace test_api_persistencia.DAO
{
    public interface IDAOUser
    {
        public List<User> GetUsers();
    }
}
