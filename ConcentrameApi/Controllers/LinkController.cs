using ConcentrameApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ConcentrameApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LinkController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<Link>> Get()
        {
            if (DbContext.Link.Any())
                return Ok(DbContext.Link);
            else
                return NoContent();
        }
    }
}
