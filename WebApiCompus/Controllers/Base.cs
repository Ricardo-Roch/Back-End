using System;
using Microsoft.AspNetCore.Mvc;

namespace WebApiCompus.Controllers
{
	[ApiController]
	[Route("api/clases")]
	public class Base :ControllerBase
	{
		private readonly AplicationDbContext dbContext;
		public Base(AplicationDbContext context)
		{
			this.dbContext = context;
		}
	}
}

