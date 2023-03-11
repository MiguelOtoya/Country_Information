using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Country_Information.Models;
using Country_Information.Data;

namespace Country_Information.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CountriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Country>>> Get()
        {
            return await _context.Countries.ToListAsync();
        }

        [HttpPost ("prro")]
        public async Task<ActionResult<Country>> CreateCountry(Country country)
        {
            try
            {
                _context.Countries.Add(country);
                await _context.SaveChangesAsync();

                return Ok(country);
            }
            catch (Exception ex)
            {
                 return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var country = await _context.Countries.FindAsync(id);
            if (country == null)
            {
                return NotFound();
            }

            _context.Countries.Remove(country);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Country country)
        {
            if (id != country.id)
            {
                return BadRequest();
            }

            _context.Update(country);
            await _context.SaveChangesAsync();

            return NoContent();
        }



        
    }
}
