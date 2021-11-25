using System;

namespace TP_2_Ej7
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*7- Implemente una función que reciba una matriz (arreglo de dos dimensiones) pasada como parámetro, 
			      e imprima por consola la suma de sus elementos.
                  static double sumaMatriz(double[,] matriz)
                 Ayuda: Si A es un arreglo, A.GetLength(i) devuelve la longitud del arreglo en la dimensión i.*/
			
			double [,] vec = new double[,]{{1,2,3,4,5},{1,2,3,4,5}};
			
			sumaMatriz(vec);
			
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static void sumaMatriz(double [,] matriz)
		{
			double suma = 0;
			
			for (int xfila = 0; xfila < matriz.GetLength(0); xfila++) {
				for (int ycolum = 0; ycolum < matriz.GetLength(1); ycolum++) {
					suma += matriz[xfila, ycolum];
				}
			}
			
			Console.WriteLine("La suma de los elemetos es: {0}", suma);
			
		}
		
	}
}