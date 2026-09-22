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
              return ($"Error Message 400: Invalid Response...");
            }
            else
            {
              return ($"Hello There, {id}!");  
            }
            
        }

    }
}