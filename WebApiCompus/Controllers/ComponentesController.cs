using System;
using Microsoft.AspNetCore.Mvc;
using WebApiCompus.Entidades;

namespace WebApiCompus.Controllers
{
    //Componentes
    [ApiController]
    [Route("api/componentes")]
    public class ComponentesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Componentes>> Get()
        {
            return new List<Componentes>()
            {
                new Componentes(){ Id=1,Procesador="I5",Ram="16GB",Rom="512",Grafica="GTX3060"},
                new Componentes(){ Id=2,Procesador="M1",Ram="16GB",Rom="256",Grafica="M1"}
            };
        }
    }
}

