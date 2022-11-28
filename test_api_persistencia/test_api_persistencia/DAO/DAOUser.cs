using Dapper;
using System.Data;
using test_api_persistencia.Models;
using test_api_persistencia.Connection;

namespace test_api_persistencia.DAO
{
    public class DAOUser : IDAOUser
    {
        private readonly IConnectionDB _Connection;
        public DAOUser(IConnectionDB Connection)
        {
            _Connection = Connection;
        }
        public List<User> GetUsers()
        {
            List<User> Response = new List<User>();
            using (var connection = _Connection.GetConnection)
            {
                string Query = "SELECT " +
                    "user_code Code," +
                    "user_names Names," +
                    "user_last_name_1 Lastname1," +
                    "user_last_name_2 Lastname2," +
                    "user_username Username," +
                    "user_email Email," +
                    "user_phone Phone " +
                    "FROM tg_usuario";
                var ResultQuery = connection.Query<User>(Query, commandType: CommandType.Text);
                connection.Close();
                Response = ResultQuery.ToList();
            }            
            return Response;
        }
    }
}
