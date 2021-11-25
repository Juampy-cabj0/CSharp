using System;

namespace TP_1_Ej2
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			/*2) Escriba un programa de aplicación que solicite al usuario ingresar su nombre y apellido,
                 e imprima en la consola un saludo personalizado utilizando ese nombre e informe entre ( ) la cantidad de letras que conforman la oración impresa. 
                 Ejemplo: Hola Juan Perez, bienvenido a la materia ( 40 )*/
		
			
			Console.Write("Ingrese un nombre y apellido: ");
			string nom_apell = Console.ReadLine();
			
			string saludo1 = "Hola ", saludo2 = ", bienvenido a la materia";
			
			Console.WriteLine("{0}{1}{2} ({3})", saludo1, nom_apell, saludo2, nom_apell.Length + saludo1.Length + saludo2.Length);
			
			
			
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}