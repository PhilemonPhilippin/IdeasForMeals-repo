using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdeasForMeals.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FoodsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        string[] foods = ["Tomato", "Spaghetti", "Onion", "Courgette", "Carrot", "Red pepper", "Parmesan cheese"];
 
        return Ok(foods);
    }
}
