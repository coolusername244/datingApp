using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
// controller is a placeholder for the name of the controller
// in this case, the name of the controller is UsersController
// so the route will be https://localhost:5001/api/users
public class UsersController : ControllerBase
{
  private readonly DataContext _context;

  public UsersController(DataContext context)
  {
    _context = context;
  }

  [HttpGet]
  public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
  {
    var users = await _context.Users.ToListAsync();
    return users;
  }

  [HttpGet("{id}")] // https://localhost:5001/api/users/3
  public async Task<ActionResult<AppUser>> GetUser(int id)
  {
    var user = await _context.Users.FindAsync(id);
    return user;
  }
}
