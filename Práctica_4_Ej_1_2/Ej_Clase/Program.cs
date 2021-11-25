using System;

namespace Ej_Clase
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Hora h = new Hora(23, 30, 15);
			h.imprimir();
			
			Hora h1 = new Hora("11:23:10");
			h1.imprimir();
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}