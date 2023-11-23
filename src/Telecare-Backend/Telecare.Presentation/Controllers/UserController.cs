using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Telecare.Presentation.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/{v:apiversion}/[controller]")]
    public class UserController : ControllerBase
    {

    }
}
