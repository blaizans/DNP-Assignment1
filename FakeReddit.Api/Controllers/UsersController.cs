using FakeReddit.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace FakeReddit.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    [HttpGet]
    [Route("getUsers")]
    public IActionResult getUsers()
    { 
        List<Users> usersList = new List<Users>();

        return Ok();
    }
}