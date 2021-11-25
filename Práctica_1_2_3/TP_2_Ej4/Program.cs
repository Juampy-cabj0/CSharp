using System;

namespace TP_2_Ej4
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*4- Haga un programa de aplicación que lea por consola una sucesión de palabras que termina con la palabra vacía.
                 Imprima el porcentaje de palabras que comienzan con ‘s’, la longitud de cada palabra leída y el promedio de caracteres por palabra.
                  Ayuda: si st es una variable de tipo string, st.Length devuelve la cantidad de caracteres del string*/
			
			int porcentaje_s = 0, promedio = 0, cant_palab = 0;
			
			Console.Write("Ingrese una frase: ");
			string frase = Console.ReadLine();
			
			while (frase != "") {
				promedio++;
				cant_palab += frase.Length;
				
				if (frase[0] == 's') {
					porcentaje_s++;
				}
				
				Console.Write("Ingrese una frase: ");
				frase = Console.ReadLine();
				
			}
			
			Console.WriteLine("**************************************************************");
			Console.WriteLine("Porcentaje de palabras con una 'S' al comienzo: " +porcentaje_s * 100 / promedio+ "%");
			Console.WriteLine("Total de caracteres ingresado: " +cant_palab);
			Console.WriteLine("Promedio de caracteres por palabra: " +cant_palab / promedio);
			Console.WriteLine("**************************************************************");
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}