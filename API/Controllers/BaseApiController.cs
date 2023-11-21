using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  // controller is a placeholder for the name of the controller
  // in this case, the name of the controller is UsersController
  // so the route will be https://localhost:5001/api/users
  public class BaseApiController : ControllerBase
  {
  }
}
