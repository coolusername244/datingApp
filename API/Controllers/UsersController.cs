using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

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
  public ActionResult<IEnumerable<AppUser>> GetUsers()
  {
    var users = _context.Users.ToList();
    return users;
  }

  [HttpGet("{id}")] // https://localhost:5001/api/users/3
  public ActionResult<AppUser> GetUser(int id)
  {
    var user = _context.Users.Find(id);
    return user;
  }
}
