using IdeasForMeals.Core.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace IdeasForMeals.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController(IUserRepository userRepository) : ControllerBase
{
    private readonly IUserRepository _userRepository = userRepository;

    [Authorize]
    [HttpGet("check")]
    public async Task<IActionResult> CheckUser()
    {
        string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (userId is null) return BadRequest("Error with the JWT provided.");

        // If userExist == false then it means we had to create a User in the database.
        bool userExist = await _userRepository.CheckUser(userId);

        return Ok();
    }
}
