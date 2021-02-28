using Dapper;
using Provivi.MathOperations.IDataAccess;
using Provivi.MathOperations.IInfrastructure;
using System.Data;
using System.Threading.Tasks;

namespace Provivi.MathOperations.DataAccess
{
    public class MathOperationsRepository : IMathOperationsRepository
    {
        private readonly IConnectionFactory _connectionFactory;

        public MathOperationsRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task<bool> InsertAsync(string operation, double value)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "InsertMathOperation";
                var parameters = new DynamicParameters();
                parameters.Add("Operation", operation);
                parameters.Add("Result", value);

                var result = await connection.ExecuteAsync(query, param: parameters, null, null, CommandType.StoredProcedure);

                return result > 0;
            }
        }
    }
}
