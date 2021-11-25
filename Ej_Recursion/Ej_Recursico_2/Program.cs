using System;

namespace Ej_Recursico_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			int [] vector = new int[]{2, 3, 8, 1, 5, 10};
			int dim = vector.Length;
			int pos = 0;
			
			Console.WriteLine("La suma total del vector es: " + suma(vector, pos, dim));
			
			
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static int suma(int [] vec, int pos, int dim)
		{
			
			// Sumo los valores mayores a 5 dentro del array
			
			if (pos == dim - 1) {
				if (vec[pos] > 5) {
					
					return vec[pos];
				}
				else
					return 0;
			}
			else{
				
				if (vec[pos] > 5) {
					return vec[pos] + suma(vec, pos + 1, dim);
				}
				else
					return suma(vec, pos + 1, dim);
			}
			
		}
	}
}