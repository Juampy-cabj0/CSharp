using System;

namespace Ejemplo_Suma_Matriz_Diag
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Suma diagonal de una matriz 
			
			int suma = 0;
			
			int [,] matriz = new int[5, 5];
			
			for (int i = 0; i < matriz.GetLength(0); i++) {
				for (int j = 0; j < matriz.GetLength(1); j++) {
					matriz[i, j] = (matriz.GetLength(0) * i) + (j + 1);
					Console.Write(matriz[i, j] + " ");
				}
				Console.WriteLine();
			}
			
			
			for (int i = 0; i < matriz.GetLength(0); i++) {
				suma += matriz[i, i];
			}
			
			Console.WriteLine();
			Console.WriteLine("La suma de la diágonal principal de la matriz es: {0}", suma);
			
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}