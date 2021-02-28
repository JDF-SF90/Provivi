using Provivi.MathOperations.DTO;
using System;
using System.Threading.Tasks;

namespace Provivi.MathOperations.IApplication
{
    public interface IMathOperationsApplication
    {
        Task<Response<MathOperationsDTO>> getASum(MathOperationsDTO mathOperationsDTO);

        Task<Response<MathOperationsDTO>> getAProduct(MathOperationsDTO mathOperationsDTO);

        Task<Response<MathOperationsDTO>> GetAPower(MathOperationsDTO mathOperationsDTO);




    }
}
