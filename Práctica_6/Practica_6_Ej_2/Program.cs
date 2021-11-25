using System;

namespace Practica_6_Ej_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Jerarquia de clases usando Polimorfismo
			
			ClaseA claseD = new ClaseD();
			
			claseD.ToString();
			
			
			
			
			Console.SetWindowSize(80,25);
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}