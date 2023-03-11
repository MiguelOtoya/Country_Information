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
        
    }
}
