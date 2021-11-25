using System;

namespace TP_1_Ej7
{
	class Program
	{
		public static void Main(string[] args)
		{

			/*7) Implemente un programa de aplicación que permita al usuario ingresar números por la consola.
				 A medida que se van ingresando los valores el sistema debe mostrar por la consola la suma acumulada de los mismos.
				 El proceso termina cuando se ingresa un 0.
				 Informar al final la cantidad total de números ingresados y sumados.*/

			int suma = 0, cont = 0;
			
			Console.Write("Ingrese un número: ");
			int num = int.Parse(Console.ReadLine());
			
			while (num != 0) {
				cont++;
				suma += num;
				
				Console.WriteLine("********************************************\n" +
				                  "La suma parcial es: {0}", suma +"\n"+
				                  "********************************************");
				
				Console.Write("Ingrese un número: ");
			    num = int.Parse(Console.ReadLine());
			}
			
			Console.WriteLine("\nLa cantidad total de números ingresados es de: {0}", cont + "\n"
			                   +"La suma total de los números ingresados es: " +suma + "\n");
			                 
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}