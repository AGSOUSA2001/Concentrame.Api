using ConcentrameApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConcentrameApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NoticeController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<Notice>> Get()
        {
            if (DbContext.Notice.Any())
                return Ok(DbContext.Notice);
            else
                return NoContent();
        }

        [HttpGet("lastNotices")]
        public ActionResult<IEnumerable<Notice>> GetLast()
        {
            if (DbContext.Notice.Any())
                return Ok(DbContext.Notice.OrderByDescending(x => x.Id).Take(3));
            else
                return NoContent();
        }

        [HttpGet("{id}")]
        public ActionResult<Notice> GetId(int id)
        {
            if (DbContext.Notice.Any(n => n.Id == id))
                return Ok(DbContext.Notice.FirstOrDefault(n => n.Id == id));
            else
                return NoContent();
        }

        [HttpGet("category/{category}")]
        public ActionResult<IEnumerable<Notice>> GetNoticesByCategoryId(string category)
        {
            if (DbContext.Notice.Any(n => n.Category == category))
                return Ok(DbContext.Notice.Where(n => n.Category == category));
            else
                return NoContent();
        }

        [HttpGet("lastNoticesCategory/{category}")]
        public ActionResult<IEnumerable<Notice>> GetLastNoticesByCategoryId(string category)
        {
            if (DbContext.Notice.Any(n => n.Category == category))
                return Ok(DbContext.Notice.OrderByDescending(x => x.Id).Where(n => n.Category == category).Take(3));
            else
                return NoContent();
        }
    }
}
