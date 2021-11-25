using System;

namespace Práctica_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Ingrese su nombre: ");
			string nom = Console.ReadLine();
			
			Console.Write("Ingrese su edad: ");
			int edad = int.Parse(Console.ReadLine());
			
			Console.Write("Ingrese su peso: ");
		   float peso = float.Parse(Console.ReadLine());
			
			
			if (edad < 18)
				Console.WriteLine("La persona es menor de edad.");
			
			if (edad >= 18) {
				Console.WriteLine(nom+ " es mayor de edad ("+edad+") y pesa: " +peso+ "Kg." );
				
			}
			
			
		
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}