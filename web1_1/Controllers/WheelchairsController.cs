using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web1_1.DAL.Data;
using web1_1.DAL.Entities;

namespace web1_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WheelchairsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public WheelchairsController(ApplicationDbContext context)
        {
            _context = context;
        }

        //// GET: api/Wheelchairs
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Wheelchair>>> GetWheelchairs()
        //{
        //    return await _context.Wheelchairs.ToListAsync();
        //}

        //// GET: api/Wheelchairs/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Wheelchair>> GetWheelchair(int id)
        //{
        //    var wheelchair = await _context.Wheelchairs.FindAsync(id);

        //    if (wheelchair == null)
        //    {
        //        return NotFound();
        //    }

        //    return wheelchair;
        //}

        // GET: api/Wheelchairs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Wheelchair>>> GetWheelchairs(int?
        group)
        {
            return await _context
            .Wheelchairs

            .Where(d => !group.HasValue

            || d.WheelchairGroupId.Equals(group.Value))

            ?.ToListAsync();

        }
        // PUT: api/Wheelchairs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWheelchair(int id, Wheelchair wheelchair)
        {
            if (id != wheelchair.WheelchairId)
            {
                return BadRequest();
            }

            _context.Entry(wheelchair).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WheelchairExists(id))
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

        // POST: api/Wheelchairs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Wheelchair>> PostWheelchair(Wheelchair wheelchair)
        {
            _context.Wheelchairs.Add(wheelchair);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetWheelchair", new { id = wheelchair.WheelchairId }, wheelchair);
        }

        // DELETE: api/Wheelchairs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Wheelchair>> DeleteWheelchair(int id)
        {
            var wheelchair = await _context.Wheelchairs.FindAsync(id);
            if (wheelchair == null)
            {
                return NotFound();
            }

            _context.Wheelchairs.Remove(wheelchair);
            await _context.SaveChangesAsync();

            return wheelchair;
        }

        private bool WheelchairExists(int id)
        {
            return _context.Wheelchairs.Any(e => e.WheelchairId == id);
        }
    }
}
