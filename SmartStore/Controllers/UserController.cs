using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartStore.Models;
using SmartStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartStore.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController
    {
        // POST api/values
        [AllowAnonymous]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<User> Post([FromBody] User toSave,
                                       [FromServices] UserRepository dao)
        {
            try
            {
                return dao.Create(toSave);
            }
            catch (Exception e)
            {
                return new BadRequestResult() { };
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> Get([FromServices] UserRepository dao)
        {
            return dao.GetAll().ToList();
        }
    }
}
