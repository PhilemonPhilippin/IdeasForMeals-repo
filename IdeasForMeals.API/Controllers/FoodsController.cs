using IdeasForMeals.API.Contracts;
using IdeasForMeals.API.Mappers;
using IdeasForMeals.Core.Database.Entities;
using IdeasForMeals.Core.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdeasForMeals.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FoodsController(IFoodRepository foodRepository) : ControllerBase
{
    private readonly IFoodRepository _foodRepository = foodRepository;

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        List<Food> foods = await _foodRepository.ReadAll();
        IEnumerable<FoodDto> foodDtos = foods.Select(f => f.MapToFoodDto());

        return Ok(foodDtos);
    }
}
