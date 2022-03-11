using System.Data.SqlClient;

namespace BaseDeDatos
{
    public abstract class DB
    {
        private string _connectionString;
        protected SqlConnection _connection;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public DB(string server, string db, string user, string password)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            _connectionString = $"Data Source={server}; Initial Catalog={db};" +
                $"User={user}; Password={password}";
        }

        public void Connect()
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        public void Close()
        {
            if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}
