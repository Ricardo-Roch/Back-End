using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCompus.Entidades;

namespace WebApiCompus.Controllers
{
    //Componentes
    [ApiController]
    [Route("api/componentes")]
    public class ComponentesController : ControllerBase
    {
        private readonly AplicationDbContext dbContext;

        public ComponentesController(AplicationDbContext context)
        {
            this.dbContext = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Componentes>>> GetAll()
        {
            return await dbContext.Componentes.ToListAsync();

        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Componentes>> GetById(int id)
        {
            return await dbContext.Componentes.FirstOrDefaultAsync(x=> x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Componentes componentes)
        {
            var existeC = await dbContext.Compus.AnyAsync(x => x.Id == componentes.Id);
          //  if (!existeC)
           // {
             //   return NotFound($"No existe compu con el id: {componentes.Id}");
            //}

            dbContext.Add(componentes);
            await dbContext.SaveChangesAsync();

            return Ok();
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Componentes componentes, int id)
        {
            var existe = await dbContext.Componentes.AnyAsync(x => x.Id == id);

            if (!existe)
            {
                return NotFound("No existe Prro");
            }

            if (componentes.Id != id)
            {
                return BadRequest("No coincide con la url");
            }
            dbContext.Update(componentes);
            await dbContext.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist = await dbContext.Componentes.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                return NotFound();
            }
            dbContext.Remove(new Componentes()
            {
                Id = id
            });
            await dbContext.SaveChangesAsync();

            return Ok();
        }
    }
}



        
        
           

