using Microsoft.AspNetCore.Mvc;

namespace Mini_Challenge__11_API_Beginnings
{
    [ApiController]
    [Route("api/[controller]")]
    public class Challenge5Controller : ControllerBase
    {
        [HttpGet("madlib/{name}/{home}/{color}/{favevent}/{number}/{letter}/{friend}/{place}/{food}/{dessert}")]

        public ActionResult<string> MadLib(string name, string home, string color, string favevent, int number, string letter, string friend, string place, string food, string dessert)
        {
            if (int.TryParse(name, out _) && int.TryParse(home, out _) && int.TryParse(color, out _) && int.TryParse(favevent, out _) && int.TryParse(letter, out _))
            {
                return BadRequest($"Invalid Response...");
            }
            else
            {
                return Ok($"{name} who lived in {home}, one day found a free and brand new car, which was in their favorite color, which was {color}. The car even had their favorite number on it, which was {number}, and their favorite letter which was {letter}. And so, they drove their new car to the nearest {favevent}  At this {favevent}, they saw their best friend who was {friend}. After letting them into the car they both went to {place}. to go eat dinner there. Inside of the Resturaunt you eat {food}, and had {dessert} for dessert.");
            }
            
        }
    }
}