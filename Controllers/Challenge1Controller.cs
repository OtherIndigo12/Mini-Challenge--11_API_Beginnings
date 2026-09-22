using Microsoft.AspNetCore.Mvc;

namespace Mini_Challenge__11_API_Beginnings
{
    [ApiController]
    [Route("api/[controller]")]
    public class Challenge1Controller : ControllerBase
    {
        [HttpGet("getname/{id}")]

        public ActionResult<string> GetName(string id)
        {
            if (int.TryParse(id, out _))
            {
              return NotFound($"Invalid Response...");
            }
            else
            {
              return Ok($"Hello There, {id}!");  
            }
            
        }

    }
}