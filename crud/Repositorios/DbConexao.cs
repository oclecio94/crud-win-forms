using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace crud.Repositorios
{
    public class DbConexao : IDisposable
    {
        private string connectionString = "Server=localhost;Database=crud;User Id=root;Password=;";
        private readonly IDbConnection connection;

        public DbConexao()
        {
            connection = new MySqlConnection(connectionString);
        }
   
        public IDbConnection GetConnection() 
        { 
            if(connection.State  != ConnectionState.Open)
              connection.Open();
            return connection;
        }

        public void Dispose()
        {
            connection.Dispose();
        }
    }
}
