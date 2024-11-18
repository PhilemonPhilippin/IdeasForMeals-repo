﻿using IdeasForMeals.API.Contracts;
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

    [HttpPut("out")]
    public async Task<IActionResult> RemoveFromDiet(List<Guid> foodIds)
    {
        bool updated = await _userFoodRepository.UpdateOutOfDiet(foodIds);

        return updated ? NoContent() : NotFound();
    }

    [HttpPost("in")]
    public async Task<IActionResult> AddToDiet(List<FoodRequest> foodRequests)
    {
        if (foodRequests.Count > 0)
        {
            List<(string, Guid)> foods = foodRequests.Select(f => (f.Name, f.FoodGroupId)).ToList();

            await _userFoodRepository.CreateIntoDiet(foods);

            return NoContent();
        }
        else
        {
            return BadRequest();
        }
    }

}