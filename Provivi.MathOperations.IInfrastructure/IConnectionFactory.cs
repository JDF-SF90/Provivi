using System.Data;

namespace Provivi.MathOperations.IInfrastructure
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection { get; }

    }
}
