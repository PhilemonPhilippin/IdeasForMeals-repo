using IdeasForMeals.Core.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdeasForMeals.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DietController(IUserFoodRepository userFoodRepository) : ControllerBase
{
    private readonly IUserFoodRepository _userFoodRepository = userFoodRepository;


    [HttpPut("out")]
    public async Task<IActionResult> PutOutOfDiet(List<Guid> foodIds)
    {
        bool updated = await _userFoodRepository.UpdateOutOfDiet(foodIds);

        return updated ? NoContent() : NotFound();
    }

}
