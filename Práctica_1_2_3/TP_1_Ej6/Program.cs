using System;

namespace TP_1_Ej6
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*6) Escriba un programa de aplicación que imprima en la consola todos los números pares que además 
				 sean múltiplos de 5 y estén comprendidos entre 250 y 900.*/

			for (int i = 250; i <= 900; i++) {
				if (i % 2 == 0 && i % 5 == 0) {
					Console.WriteLine(i);
				}
			}
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}