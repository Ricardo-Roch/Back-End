using System;
using Microsoft.AspNetCore.Mvc;
using WebApiCompus.Entidades;

namespace WebApiCompus.Controllers
{

	[ApiController]
	[Route("api/compus")]
	public class CompusControllers: ControllerBase
	{
		[HttpGet]
		public ActionResult<List<Compus>> Get()
		{
			return new List<Compus>()
			{
				new Compus(){ Id=1,Modelo="Lenovo 2023"},
				new Compus(){ Id=2,Modelo="Mac"}
			};
        }


	}
}

