using IdeasForMeals.Core.Repositories;
using Microsoft.AspNetCore.Authorization;
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

        await _userRepository.EnsureUserCreated(userId);

        return Ok();
    }
}
