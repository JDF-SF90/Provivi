using Microsoft.AspNetCore.Mvc;
using Provivi.MathOperations.DTO;
using Provivi.MathOperations.IApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Provivi.MathOperations.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathOperationsController : Controller
    {
        private readonly IMathOperationsApplication mathOperationsApplication;

        public MathOperationsController(IMathOperationsApplication _mathOperationsApplication)
        {
            mathOperationsApplication = _mathOperationsApplication;
        }
        
        
        [HttpPost("GetAPower")]
        public async Task<IActionResult> GetAPower([FromBody] MathOperationsDTO mathOperationsDTO)
        {
            if (mathOperationsDTO == null)
                return BadRequest();

            var response = await mathOperationsApplication.GetAPower(mathOperationsDTO);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);

        }

        [HttpPost("GetAProduct")]
        public async Task<IActionResult> GetAProduct([FromBody] MathOperationsDTO mathOperationsDTO)
        {
            if (mathOperationsDTO == null)
                return BadRequest();

            var response = await mathOperationsApplication.getAProduct(mathOperationsDTO);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);

        }

        [HttpPost("GetASum")]
        public async Task<IActionResult> GetASum([FromBody] MathOperationsDTO mathOperationsDTO)
        {
            if (mathOperationsDTO == null)
                return BadRequest();

            var response = await mathOperationsApplication.getASum(mathOperationsDTO);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);

        }
    }
}
