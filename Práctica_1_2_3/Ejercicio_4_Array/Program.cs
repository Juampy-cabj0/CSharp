using System;
using System.Collections;

namespace Ejercicio_4_Array
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArrayList llista = new ArrayList();
			double porcentaje_s = 0, cant_palab = 0;
			
			Console.Write("Ingrese una palabra: ");
			string palabra = Console.ReadLine();
			
			while (palabra != "") {
				
				cant_palab += palabra.Length;
				llista.Add(palabra);
				
				if (palabra[0] == 's') {
					porcentaje_s++;
				}
				
				Console.Write("Ingrese una palabra: ");
				palabra = Console.ReadLine();
				
			}
			
			Console.WriteLine("**************************************************************");
			Console.WriteLine("Porcentaje de palabras con una 'S' al comienzo: " +porcentaje_s * 100 / llista.Count+ "%");
			Console.WriteLine("Total de caracteres ingresado: " +cant_palab);
			Console.WriteLine("Promedio de caracteres por palabra: " +cant_palab / llista.Count);
			Console.WriteLine("**************************************************************");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}