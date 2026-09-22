using Microsoft.AspNetCore.Mvc;

namespace Mini_Challenge__11_API_Beginnings
{
    [ApiController]
    [Route("api/[controller]")]
    public class Challenge3Controller : ControllerBase
    {
        [HttpGet("getnum/{fn}/{time}")]

        public ActionResult<string> GetNumbers(string fn, int time)
        {
            if (int.TryParse(fn, out _) && time > 12)
            {
              return BadRequest($"Invalid Response...");
            }
            else
            {
              return Ok($"Your Name is {fn} and you woke up at {time}!");
            }
            
            
        }
    }
}