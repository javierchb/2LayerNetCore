using System.Data;
using System.Data.Odbc;
using MySql.Data.MySqlClient;

namespace test_api_persistencia.Connection
{
    public class ConnectionDB : IConnectionDB
    {
        private readonly IConfiguration _Configuration;
        public ConnectionDB(IConfiguration Configuration)
        { 
            _Configuration = Configuration;
        }
        public IDbConnection GetConnection
        {
            
            get {
                var mySqlConnection = new MySqlConnection();
                if (mySqlConnection != null)
                {
                    mySqlConnection.ConnectionString = _Configuration["ConnectionString"];
                    mySqlConnection.Open();
                    return mySqlConnection;                
                }
                return null;
            }            
        }
        
    }
}
