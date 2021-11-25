using System;

namespace Ej_Polimorfismo
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			ClaseA var1 = new ClaseA();
			ClaseB var2 = new ClaseB();
			
			var2.ToString();
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}