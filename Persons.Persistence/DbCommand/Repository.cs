using System.Data;
using System.Data.SqlClient;

namespace Persons.Persistence.DbCommand
{
    public class Repository
    {
        private readonly string _connectionString = Properties.Resources.ConnectionString;

        protected SqlConnection _connection;

        protected SqlCommand _command;

        protected void InitCommand(string command)
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
            _command = new SqlCommand(command, _connection);
            _command.CommandType = CommandType.StoredProcedure;
        }

        protected void DisposeCommand()
        {
            _command.Dispose();
            _connection.Dispose();
        }
    }
}
