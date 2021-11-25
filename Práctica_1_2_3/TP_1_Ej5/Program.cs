using System;
using System.Collections;

namespace TP_1_Ej5
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*5) Escriba un programa de aplicación que lea por teclado una secuencia de números y que imprima el valor máximo,
			el valor mínimo de dicho conjunto y el valor promedio.*/

			
			int suma = 0;
			int max, min;
			
			
			Console.Write("¡Cúantos números quiere analizar?: ");
			int cant = int.Parse(Console.ReadLine());
			
			
			Console.Write("Ingrese un valor: ");
			int num = int.Parse(Console.ReadLine());
			
			max = num;
			min = num;
			suma += num;
			
			if (cant > 0) {
				
				for (int i = 1; i < cant; i++) {
					
					Console.Write("Ingrese un valor: ");
					num = int.Parse(Console.ReadLine());
					
					if (num < min) {
						min = num;
						suma += num;
					}
					if (num > max) {
						max = num;
						suma += num;
					}
					
				}
			}
			
			Console.WriteLine("El número máximo es: " +max);
			Console.WriteLine("El número minímo es: " +min);
			Console.WriteLine("El promedio es: " +(suma / cant));
			
			
			
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		
		
	}
}