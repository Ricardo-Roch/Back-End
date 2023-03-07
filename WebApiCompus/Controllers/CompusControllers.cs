using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCompus.Entidades;

namespace WebApiCompus.Controllers
{

	[ApiController]
	[Route("api/compus")]
	public class CompusControllers: ControllerBase
	{
		
		private readonly AplicationDbContext dbContext;
		public CompusControllers(AplicationDbContext context)
		{
			this.dbContext = context;
		}

        [HttpGet]
        public async Task<ActionResult<List<Compus>>> Get()
        {
			return await dbContext.Compus.ToListAsync();
            
        }

        [HttpPost]
		public async Task<ActionResult> Post(Compus compus)
		{

			dbContext.Add(compus);
			await dbContext.SaveChangesAsync();
			return Ok();
		}

		[HttpPut("{id:int}")]
        public async Task<ActionResult> put(Compus compus, int id)
		{
			if (compus.Id != id)
			{
				return BadRequest("El id de la compu no coincide con el establecido en la url");
			}

			dbContext.Update(compus);
			await dbContext.SaveChangesAsync();
			return Ok();
		}


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var compus = await dbContext.Compus.FindAsync(id);
            if (compus == null)
            {
                return NotFound();
            }

            dbContext.Compus.Remove(compus);
            await dbContext.SaveChangesAsync();

            return Ok();
        }

    }
}

