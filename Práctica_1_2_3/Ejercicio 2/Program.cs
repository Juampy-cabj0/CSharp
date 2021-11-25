using System;

namespace Ejercicio_2
{
	class Program
	{
		public static void Main(string[] args)
		{
//			int a = 1;
//			while (a <=5) {
//				Console.WriteLine(a++);
//			}
			
			
//			int suma = 0;
//			
//			Console.Write("Ingrese un número: ");
//			int num = int.Parse(Console.ReadLine());
//			
//			
//			for (int i = 1; i <= num; i++) {
//				suma +=i;
//				Console.WriteLine(suma); 
//			}
			
			string frase = "";
			
			Console.Write("Ingrese una palabra: ");
			string pal = Console.ReadLine();
			
			while (pal != "") {
				frase += pal + " ";
				Console.Write("Ingrese una palabra: ");
			    pal = Console.ReadLine();
				
			}
			Console.WriteLine(frase);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}