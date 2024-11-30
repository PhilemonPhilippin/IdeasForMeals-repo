using IdeasForMeals.API.Contracts;
using IdeasForMeals.API.Mappers;
using IdeasForMeals.Core.Database.Entities;
using IdeasForMeals.Core.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace IdeasForMeals.API.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class DietController(IUserFoodRepository userFoodRepository, IFoodRepository foodRepository) : ControllerBase
{
    private readonly IUserFoodRepository _userFoodRepository = userFoodRepository;
    private readonly IFoodRepository _foodRepository = foodRepository;

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (userId is null) return BadRequest("Error with the JWT provided.");

        List<Food> foods = await _foodRepository.GetDiet(userId);
        List<FoodDto> foodDtos = foods.Select(f => f.MapToDto()).ToList();

        return Ok(foodDtos);
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveFromDiet(List<Guid> foodIds)
    {
        string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (userId is null) return BadRequest("Error with the JWT provided.");

        bool updated = await _userFoodRepository.UpdateOutOfDiet(foodIds, userId);

        return updated ? NoContent() : NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> AddToDiet(FoodRequest foodRequest)
    {
        string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (userId is null) return BadRequest("Error with the JWT provided.");

        (string name, Guid foodGroupId) = foodRequest;

        await _userFoodRepository.CreateIntoDiet(name, foodGroupId, userId);

        return NoContent();
        
    }

}
