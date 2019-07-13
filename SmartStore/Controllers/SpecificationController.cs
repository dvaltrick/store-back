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
    public class SpecificationController
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Specification> Post([FromBody] Specification toSave,
                                           [FromServices] SpecificationRepository dao)
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

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Specification> Put([FromBody] Specification toSave,
                                           [FromServices] SpecificationRepository dao)
        {
            try
            {
                return dao.Update(toSave);
            }
            catch (Exception e)
            {
                return new BadRequestResult() { };
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Delete([FromServices] SpecificationRepository dao, string toDelete)
        {
            try
            {
                dao.Delete(toDelete);
                return new StatusCodeResult(200);
            }
            catch (Exception e)
            {
                return new BadRequestResult() { };
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult<IEnumerable<Category>> Get([FromServices] CategoryRepository dao)
        {
            return dao.GetAll().ToList();
        }
    }
}
