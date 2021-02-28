using Microsoft.Extensions.Configuration;
using Provivi.MathOperations.IInfrastructure;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Provivi.MathOperations.Infrastructure
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public ConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection GetConnection
        {
            get
            {
                var sqlConnection = new SqlConnection();
                if (sqlConnection == null) return null;

                sqlConnection.ConnectionString = _configuration.GetConnectionString("ProviviConnection");
                sqlConnection.Open();
                return sqlConnection;
            }

        }


    }

}
