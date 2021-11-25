using System;

namespace TP_2_Ej3
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*3- Escriba un programa de aplicación que lea 2 palabras y determine si son palíndromos entre ellas.
                (Ej: “abbccd” y “dccbba” son palíndromos).*/
			
			Console.Write("Ingrese una palabra: ");
			string palabra1 = Console.ReadLine();
			
			Console.Write("Ingrese una nueva palabra: ");
			string palabra2 = Console.ReadLine();
			
//			string palindromo = "";
//
//			for (int lectura = palabra2.Length -1; lectura >= 0; lectura--) {
//				palindromo += palabra2[lectura];
//
//				}
//
//			Console.WriteLine();
//
//
//			if (palabra1 == palindromo) {
//				Console.WriteLine("Las palabras ingresadas son palindromas");
//			}
//			else {
//				Console.WriteLine("Las palabras ingresadas no son palindromas");
//			}
			
			int i = 0;
			
			if (palabra1.Length == palabra2.Length) {
				
				while (i < palabra1.Length && palabra1[i] == palabra2[(palabra2.Length - 1) - i]) {
					i++;
				}
				if (i == palabra1.Length) {
					Console.WriteLine();
					Console.WriteLine("Las palabras ingresadas son palindromas");
				}
				else {
					Console.WriteLine();
					Console.WriteLine("Las palabras ingresadas no son palindromas");
				}
				
			}
			else {
				Console.WriteLine();
				Console.WriteLine("Las palabras ingresadas no son palindromas");
			}
				
				Console.WriteLine();
				Console.Write("Press any key to continue . . . ");
				Console.ReadKey(true);
			}
		}
	}