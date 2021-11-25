using System;

namespace Class
{
	class Program
	{
		public static void Main(string[] args)
		{
			Punto p1 = new Punto();
			p1.mostrar();
			
			Punto p2 = new Punto(2.5, 3);
			p2.mostrar();
			
			Punto p3;
			p3 = p1.suma(p2);
			p3.mostrar();
			
			Punto p4 = p3.suma(p2);
			p4.mostrar();
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}