using Provivi.MathOperations.IDataAccess;
using Provivi.MathOperations.IDomain;
using System;
using System.Threading.Tasks;

namespace Provivi.MathOperations.Domain
{
    public class MathOperationsDomain : IMathOperationsDomain, IMathOperationsRepository
    {
        private readonly IMathOperationsRepository mathOperationsRepository;

        public MathOperationsDomain(IMathOperationsRepository _mathOperationsRepository)
        {
            mathOperationsRepository = _mathOperationsRepository;
        }

        public async Task<bool> InsertAsync(string operation, double value)
        {
            return await mathOperationsRepository.InsertAsync(operation, value);
        }
    }
}
