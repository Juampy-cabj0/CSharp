using System;
using System.Collections;

namespace TP_3_Ej1
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*1- Escriba un programa de aplicación que reciba una lista de palabras e informe cuáles son palíndromos usando una función.
				 En el programa principal, al ingresar las palabras resuelva el ejercicio:
                     i. A) utilizando la sentencia while
                     ii. B) utilizando la sentencia for
                     iii. C) utilizando la sentencia foreach */
			
			
			ArrayList listaPalabra = new ArrayList();
			
			Console.Write("Ingrese una palabra: ");
			string palabra = Console.ReadLine();
			
			
			while (palabra != "") {
				
				listaPalabra.Add(palabra);
				
				Console.Write("Ingrese una palabra: ");
				palabra = Console.ReadLine();
				
			}
			
			comparar(listaPalabra);
			
			
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
			
			
		}
		
		public static bool es_palindromo(string pal1)
		{
			string copia_pal1 = pal1;
			
			for (int i = 0; i < pal1.Length; i++) {
				if(pal1[i] != copia_pal1[pal1.Length -1 -i] )
				{
					return false;
				}
				
			}
			
			return true;
			
		}
		
		public static void comparar(ArrayList lista)
		{
			foreach (string elemento in lista) {
				if (es_palindromo(elemento)) {
					
					Console.WriteLine(elemento);
				}
				
			}
			
		}
		
	}
}