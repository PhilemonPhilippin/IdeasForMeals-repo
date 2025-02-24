﻿using IdeasForMeals.API.Contracts;
using IdeasForMeals.API.Mappers;
using IdeasForMeals.Core.Database.Entities;
using IdeasForMeals.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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
        string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (userId is null) return BadRequest("Error with the JWT provided.");

        List<Food> ideaForMeal = await _ideaForMealService.GetIdeaForMeal(userId);
        IdeaForMealDto dto = IdeaForMealMapper.MapToDto(ideaForMeal);

        return Ok(dto);
    }

    [HttpPost("recipe")]
    public async Task<IActionResult> GetRecipe(List<string> ingredients)
    {
        string recipe = await _ideaForMealService.GetRecipe(ingredients);
        return Ok(new RecipeDto(recipe));
    }

    [HttpPost("recipe/pdf")]
    public IActionResult GetPdf(PdfRequest recipe)
    {
        string fileFullPath = _ideaForMealService.GetPdf(recipe.Content);

        var stream = new FileStream(fileFullPath, FileMode.Open, FileAccess.Read); 
        var contentType = "application/pdf"; 
        return new FileStreamResult(stream, contentType);
    }
}
