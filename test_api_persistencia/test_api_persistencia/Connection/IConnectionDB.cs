using System.Data;
namespace test_api_persistencia.Connection
{
    public interface IConnectionDB
    {
        IDbConnection GetConnection { get; }
    }
}
