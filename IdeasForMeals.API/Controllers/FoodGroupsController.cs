using IdeasForMeals.API.Mappers;
using IdeasForMeals.Core.Database.Entities;
using IdeasForMeals.Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace IdeasForMeals.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FoodGroupsController(IFoodGroupRepository foodGroupRepository) : ControllerBase
{
    private readonly IFoodGroupRepository _foodGroupRepository = foodGroupRepository;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        List<FoodGroup> groups = await _foodGroupRepository.ReadAll();
        var dtos = groups.Select(g => g.MapToDto());
        return Ok(dtos);
    }
}
