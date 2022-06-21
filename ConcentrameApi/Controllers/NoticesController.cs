using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ConcentrameApi.Data;
using ConcentrameApi.Models;

namespace ConcentrameApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoticesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public NoticesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Notice>> Get()
        {
            if (_context.Notice.Any())
                return Ok(_context.Notice.OrderByDescending(x => x.Id));
            else
                return NoContent();
        }

        [HttpGet("lastNotices")]
        public ActionResult<IEnumerable<Notice>> GetLast()
        {
            if (_context.Notice.Any())
                return Ok(_context.Notice.OrderByDescending(x => x.Id).Take(3));
            else
                return NoContent();
        }

        [HttpGet("{id}")]
        public ActionResult<Notice> GetId(int id)
        {
            if (_context.Notice.Any(n => n.Id == id))
                return Ok(_context.Notice.FirstOrDefault(n => n.Id == id));
            else
                return NoContent();
        }

        [HttpGet("category/{category}")]
        public ActionResult<IEnumerable<Notice>> GetNoticesByCategoryId(string category)
        {
            if (_context.Notice.Any(n => n.Category == category))
                return Ok(_context.Notice.OrderByDescending(x => x.Id).Where(n => n.Category == category));
            else
                return NoContent();
        }

        [HttpGet("lastNoticesCategory/{category}")]
        public ActionResult<IEnumerable<Notice>> GetLastNoticesByCategoryId(string category)
        {
            if (_context.Notice.Any(n => n.Category == category))
                return Ok(_context.Notice.OrderByDescending(x => x.Id).Where(n => n.Category == category).Take(3));
            else
                return NoContent();
        }

        // PUT: api/Notices/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNotice(int id, Notice notice)
        {
            if (id != notice.Id)
            {
                return BadRequest();
            }

            _context.Entry(notice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NoticeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Notices
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Notice>> PostNotice(Notice notice)
        {
            _context.Notice.Add(notice);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNotice", new { id = notice.Id }, notice);
        }

        // DELETE: api/Notices/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Notice>> DeleteNotice(int id)
        {
            var notice = await _context.Notice.FindAsync(id);
            if (notice == null)
            {
                return NotFound();
            }

            _context.Notice.Remove(notice);
            await _context.SaveChangesAsync();

            return notice;
        }

        private bool NoticeExists(int id)
        {
            return _context.Notice.Any(e => e.Id == id);
        }
    }
}
