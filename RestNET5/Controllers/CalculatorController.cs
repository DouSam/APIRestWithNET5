using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace RestNET5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDouble(firstNumber) + ConvertToDouble(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Values");
        }

        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult Sub(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sub = ConvertToDouble(firstNumber) - ConvertToDouble(secondNumber);
                return Ok(sub.ToString());
            }
            return BadRequest("Invalid Values");
        }

        [HttpGet("mul/{firstNumber}/{secondNumber}")]
        public IActionResult Mul(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var mul = ConvertToDouble(firstNumber) * ConvertToDouble(secondNumber);
                return Ok(mul.ToString());
            }
            return BadRequest("Invalid Values");
        }

        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public IActionResult Div(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                if (double.Parse(secondNumber) == 0)
                    return BadRequest("Division by 0");

                var div = ConvertToDouble(firstNumber) / ConvertToDouble(secondNumber);
                return Ok(div.ToString());
            }
            return BadRequest("Invalid Values");
        }

        [HttpGet("med/{firstNumber}/{secondNumber}")]
        public IActionResult Med(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var med = (ConvertToDouble(firstNumber) + ConvertToDouble(secondNumber)) / 2;
                return Ok(med.ToString());
            }
            return BadRequest("Invalid Values");
        }

        [HttpGet("rai/{firstNumber}")]
        public IActionResult Rai(string firstNumber)
        {
            if (IsNumeric(firstNumber))
            {
                var rai = Math.Sqrt(ConvertToDouble(firstNumber));
                return Ok(rai.ToString());
            }
            return BadRequest("Invalid Values");
        }

        private static double ConvertToDouble(string strNumber)
        {
            return double.Parse(strNumber);
        }

        private static bool IsNumeric(string strNumber)
        {
            return double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out double number);
        }
    }
}
