using System;

namespace TP_2_Ej6
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*6- Defina una función que reciba una palabra y retorne en un vector
				 la cantidad de cada una de las vocales que contiene.*/
			
			Console.Write("Ingrese una palabra: ");
			string palabra = Console.ReadLine();
			
			Palabra(palabra);
			
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void Palabra(string palabra)
		{
			int cont_a = 0, cont_e = 0, cont_i = 0, cont_o = 0, cont_u = 0;
			
			string [] vector = new string[palabra.Length];

			for (int i = 0; i < vector.Length; i++) {
				
				vector[i] = palabra.Substring(i, 1);
				
				switch (vector[i]) {
					case "a":
						cont_a++;
						break;
						
					case "e":
						cont_e++;
						break;
						
					case "i":
						cont_i++;
						break;
						
					case "o":
						cont_o++;
						break;
						
					case "u":
						cont_u++;
						break;
				}
			}
			
			Console.WriteLine();
			Console.WriteLine("Cantidad de vocales en la palabra ingresada: \n"+
			                  "Vocal 'a': " +cont_a +"\n"+
			                  "Vocal 'e': " +cont_e+ "\n" +
			                  "Vocal 'i': " +cont_i+ "\n" +
			                  "Vocal 'o': " +cont_o+ "\n" +
			                  "Vocal 'u': " +cont_u);
		}
	}
}