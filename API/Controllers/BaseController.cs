using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    /// <summary>
    /// To be inherited by other controllers, so that the new controller will
    /// contain the fixed attributes, such as ApiController and Route.
    /// </summary>
    [ApiController] // this make developer easier, as they dont have to specify where to get the data.
    [Route("api/[controller]")] // controller is the placeholder where the api is accessible via api/users
    public class BaseController : ControllerBase
    {
        public BaseController()
        {

        }
    }
}
