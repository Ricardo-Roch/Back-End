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
                new Componentes(){ Id=1,Especificaciones="i5 con una gtx5090, con 32 de ram"},
                new Componentes(){ Id=2,Especificaciones="m4 con 16 de ram"}
            };
        }
    }
}

