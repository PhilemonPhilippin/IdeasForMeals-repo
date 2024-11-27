using IdeasForMeals.API.Contracts;
using IdeasForMeals.API.Mappers;
using IdeasForMeals.Core.Database.Entities;
using IdeasForMeals.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdeasForMeals.API.Controllers;

[Authorize]
[Route("api/[controller]")]
[ApiController]
public class IdeasForMealsController(IIdeaForMealService ideaForMealService) : ControllerBase
{
    private readonly IIdeaForMealService _ideaForMealService = ideaForMealService;

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        List<Food> ideaForMeal = await _ideaForMealService.GetIdeaForMeal();
        IdeaForMealDto dto = IdeaForMealMapper.MapToDto(ideaForMeal);

        return Ok(dto);
    }
}
