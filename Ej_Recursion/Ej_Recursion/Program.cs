using System;

namespace Ej_Recursion
{
	class Program
	{
		public static void Main(string[] args)
		{
			int [] vec = new int[10]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
			int tam = 10;
			int pos = 0;
			
			imprime(vec, pos, tam);
			
			
			
			
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void imprime(int [] vec, int pos, int tam)
		{
			if (pos < tam) {
				imprime(vec, pos + 1, tam);  /* En este caso, 1ro termina de buscar los elementos del array y luego los imprime*/
				Console.WriteLine(vec[pos]);
			}
			
		}
	}
}