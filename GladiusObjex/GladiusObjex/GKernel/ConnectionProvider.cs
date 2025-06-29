using System.Configuration;
using System.Data.SqlClient;

namespace GladiusObjex.GKernel
{
    public class ConnectionProvider
    {
        private ConnectionProvider()
        { }

        internal static SqlConnection GetConnection()
        {
            SqlConnection _instance = new SqlConnection();
            _instance.ConnectionString = ConnectionProvider.ConnectionString;
            return _instance;
        }

        internal static SqlConnection GetConnection(string ConnectionName)
        {
            SqlConnection _instance = new SqlConnection();
            _instance.ConnectionString = ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString;
            return _instance;
        }

        internal static SqlConnection GetConnectionWithConnectionString(string _ConnectionString)
        {
            SqlConnection _instance = new SqlConnection();
            _instance.ConnectionString = _ConnectionString;
            return _instance;
        }

        internal static SqlConnection GetConnection(string connectionString, bool IsUsingInnerConnectionString)
        {
            SqlConnection _instance = new SqlConnection();
            _instance.ConnectionString = connectionString;
            return _instance;
        }

        internal static string GetConnectionString()
        {
            return ConnectionProvider.ConnectionString;
        }

        private static string ConnectionStringWithName(string ConnectionName)
        {

            string theConnectionString = "";
            theConnectionString = ConfigurationManager.ConnectionStrings[ConnectionName].ConnectionString;

            return theConnectionString;

        }

        private static string ConnectionString
        {
            get
            {
                string theConnectionString = "";
                theConnectionString = ConfigurationManager.ConnectionStrings["ErpConnStr"].ConnectionString;

                return theConnectionString;

            }
        }
    }
}
