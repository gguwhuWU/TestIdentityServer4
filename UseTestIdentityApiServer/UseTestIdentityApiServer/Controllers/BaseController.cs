using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UseTestIdentityApiServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        [HttpGet("DevGet")]
        [Authorize(Roles = "admin")]
        public ActionResult<string> DevGet()
        {
            return "Yes, only Admin can accrss this API";
        }

        [HttpGet("UatGet")]
        [Authorize(Roles = "user")]
        public ActionResult<string> UatGet()
        {
            return "Yes, user can accrss this API";
        }
    }
}
