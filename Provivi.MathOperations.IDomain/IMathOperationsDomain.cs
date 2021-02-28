using System.Threading.Tasks;

namespace Provivi.MathOperations.IDomain
{
    public interface IMathOperationsDomain
    {
        Task<bool> InsertAsync(string operation, double value);
    }
}
