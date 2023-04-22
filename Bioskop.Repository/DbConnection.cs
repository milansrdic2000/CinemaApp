using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Bioskop.Repository
{
    public class DbConnection
    {
        private SqlConnection connection;
        private SqlTransaction transaction;
        //private SqlCommand komandos;
        public void OpenConnection()
        {
            if (connection == null || connection.State == ConnectionState.Closed)
            {
                connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString);
                connection.Open();
            }
        }

        public SqlCommand CreateCommand(string command)
        {
            if (transaction?.Connection == null)
                transaction = connection.BeginTransaction();
            return new SqlCommand(command, connection, transaction);
        }

        public void Commit()
        {
            transaction?.Commit();
        }
        public void Rollback()
        {

            transaction?.Rollback();
        }
        public bool IsReady()
        {
            return connection != null && connection.State != ConnectionState.Closed;
        }
        public void Close()
        {
            connection?.Close();
            transaction?.Dispose();
            transaction = null; // da li sme ovako
        }

    }
}
