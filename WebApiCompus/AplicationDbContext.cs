using System;
using Microsoft.EntityFrameworkCore;
using WebApiCompus.Entidades;

namespace WebApiCompus
{
	public class AplicationDbContext: DbContext
	{
		public AplicationDbContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<Compus> Compus { get; set; }
        public DbSet<Componentes> Componentes { get; set; }
    }
}

