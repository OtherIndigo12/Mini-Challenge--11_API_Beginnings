
using Microsoft.AspNetCore.Mvc;

namespace Mini_Challenge__11_API_Beginnings
{
    [ApiController]
    [Route("api/[controller]")]
    public class Challenge2Controller : ControllerBase
    {
        [HttpGet("getnum/{num1}/{num2}")]

        public ActionResult<string> GetNumbers(string num1, string num2)
        {
            if (int.TryParse(num1, out int newnum1) && int.TryParse(num2, out int newnum2))
            {
                return Ok($"Both of Your Numbers are, {num1} and {num2}!");   
            }
            else
            {
                return BadRequest($"Invalid Response...");
            }

            
        }

    }
}