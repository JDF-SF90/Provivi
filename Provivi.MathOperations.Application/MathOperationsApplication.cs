using Provivi.MathOperations.Domain;
using Provivi.MathOperations.DTO;
using Provivi.MathOperations.IApplication;
using Provivi.MathOperations.IDomain;
using System;
using System.Threading.Tasks;

namespace Provivi.MathOperations.Application
{
    public class MathOperationsApplication : IMathOperationsApplication
    {
        private readonly IMathOperationsDomain mathOperationsDomain;

        public MathOperationsApplication(IMathOperationsDomain _mathOperationsDomain)
        {
            mathOperationsDomain = _mathOperationsDomain;
        }

        public async Task<Response<MathOperationsDTO>> GetAPower(MathOperationsDTO mathOperationsDTO)
        {
            var response = new Response<MathOperationsDTO>();
            try
            {
                mathOperationsDTO.result = Math.Pow(mathOperationsDTO.value1, mathOperationsDTO.value2);

                response.IsSuccess = await mathOperationsDomain.InsertAsync("getAPower", mathOperationsDTO.result);
                if (response.IsSuccess)
                {
                    response.Data = mathOperationsDTO;
                    response.Message = "getAPower!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }

            return response;
        }

        public async Task<Response<MathOperationsDTO>> getAProduct(MathOperationsDTO mathOperationsDTO)
        {
            var response = new Response<MathOperationsDTO>();
            try
            {
                mathOperationsDTO.value2 = 2;

                mathOperationsDTO.result = mathOperationsDTO.value1 * mathOperationsDTO.value2;

                response.IsSuccess = await mathOperationsDomain.InsertAsync("getAProduct", mathOperationsDTO.result);
                if (response.IsSuccess)
                {
                    response.Data = mathOperationsDTO;
                    response.Message = "getAProduct!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }

            return response;
        }

        public async Task<Response<MathOperationsDTO>> getASum(MathOperationsDTO mathOperationsDTO)
        {
            var response = new Response<MathOperationsDTO>();
            try
            {
                mathOperationsDTO.result = mathOperationsDTO.value1 + mathOperationsDTO.value2;

                response.IsSuccess = await mathOperationsDomain.InsertAsync("getAProduct", mathOperationsDTO.result);
                if (response.IsSuccess)
                {
                    response.Data = mathOperationsDTO;
                    response.Message = "getAProduct!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }

            return response;
        }
    }
}
