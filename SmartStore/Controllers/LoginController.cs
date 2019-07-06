using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmartStore.Models;
using SmartStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost]
        public ActionResult<User> Login([FromServices] UserRepository dao,
                                        [FromBody] User toLogin)
        {
            return dao.Auth(toLogin);
        }
    }
}
