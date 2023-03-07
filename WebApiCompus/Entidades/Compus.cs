using System;
namespace WebApiCompus.Entidades
{
	public class Compus
	{
		public int Id {get; set;}
        public String Modelo { get; set; }
        public String Marca { get; set; }
        public String Color { get; set; }
        public int Precio { get; set; }
        public List<Componentes> componentes { get; set; }


    }
}

