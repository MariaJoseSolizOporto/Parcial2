using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Parcial_Soliz_MJ.Data;
using Parcial_Soliz_MJ.Naipes;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial_Soliz_MJ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RandomController(AppDbContext context)

        {

            _context = context;

        }
        [HttpGet]
        public async Task<ActionResult<Naipe>> GetDato()

        {
            var list = await _context.Naipe.ToListAsync();

            var max = list.Count;
            int index = new Random().Next(0, max);

            var dato = list[index];


            if (dato == null)

            {
                return NoContent();
            }
            return dato;
        }
    }
}
