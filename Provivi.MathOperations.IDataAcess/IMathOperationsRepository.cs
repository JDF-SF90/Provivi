using System.Threading.Tasks;

namespace Provivi.MathOperations.IDataAccess
{
    public interface IMathOperationsRepository
    {
        Task<bool> InsertAsync(string operation, double value);
    }
}
