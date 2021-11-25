using System;

namespace Ejercicio_3_Vectores
{
	class Program
	{
		public static void Main(string[] args)
		{
			int [] vector = new int[5];
			int suma = 0;
			
			for (int i = 0; i < vector.Length; i++) {
				Console.WriteLine("Ingrese el elemento: " +(i+1));
				vector[i] = int.Parse(Console.ReadLine());
				suma += vector[i];
				
			}
			float promedio = suma / vector.Length;
			
//			Console.WriteLine(promedio);
			
			
			Console.WriteLine();
//			foreach (int elemento in vector) {
//				Console.WriteLine(elemento);
//			}
			
			for (int i = 0; i < vector.Length; i++) {
//				Console.WriteLine(vector[i]);
				
				if (vector[i] > promedio) {
					Console.WriteLine("El número mayor al promedio es: " +vector[i]);
				}
				
			}
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}