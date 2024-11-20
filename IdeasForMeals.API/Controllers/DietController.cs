using IdeasForMeals.API.Contracts;
using IdeasForMeals.API.Mappers;
using IdeasForMeals.Core.Database.Entities;
using IdeasForMeals.Core.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdeasForMeals.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DietController(IUserFoodRepository userFoodRepository, IFoodRepository foodRepository) : ControllerBase
{
    private readonly IUserFoodRepository _userFoodRepository = userFoodRepository;
    private readonly IFoodRepository _foodRepository = foodRepository;

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        List<Food> foods = await _foodRepository.GetDiet();
        List<FoodDto> foodDtos = foods.Select(f => f.MapToDto()).ToList();

        return Ok(foodDtos);
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveFromDiet(List<Guid> foodIds)
    {
        bool updated = await _userFoodRepository.UpdateOutOfDiet(foodIds);

        return updated ? NoContent() : NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> AddToDiet(FoodRequest foodRequest)
    {

        (string name, Guid foodGroupId) = foodRequest;

        await _userFoodRepository.CreateIntoDiet(name, foodGroupId);

        return NoContent();
        
    }

}
