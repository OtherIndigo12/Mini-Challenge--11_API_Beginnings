using Microsoft.AspNetCore.Mvc;

namespace Mini_Challenge__11_API_Beginnings
{
    [ApiController]
    [Route("api/[controller]")]
    public class Challenge4Controller : ControllerBase
    {
        [HttpGet("numbercompare/{num1}/{num2}")]
        public ActionResult<string> CompareNumbers(int num1, int num2)
        {
            if (num1 > num2)
            {
                return Ok($"{num1} is bigger than {num2}. {num2} is smaller than {num1}.");
            }
            else if (num1 < num2)
            {
                return Ok($"{num1} is smaller than {num2}. {num2} is bigger than {num1}.");
            }
            else if (num1 == num2)
            {
                return Ok($"Both Numbers are Equal");
            }
            else
            {
                return NotFound($"Invalid Response...");
            }
        }

    }
}