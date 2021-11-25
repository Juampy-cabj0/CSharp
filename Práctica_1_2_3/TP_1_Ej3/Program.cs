using System;

namespace TP_1_Ej3
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			/*3) Escriba un programa de aplicación que calcule la suma de dos números reales 
                 introducidos por teclado y muestre el resultado en la consola.
                 Ayuda: utilice Double.Parse(st) para obtener el valor real del string st.*/
			

			Console.Write("Ingrese un valor: ");
			double num1 = double.Parse(Console.ReadLine());
			
			Console.Write("Ingrese otro valor: ");
			double num2 = double.Parse(Console.ReadLine());
			
			Console.WriteLine("El resultado de la suma es: " +(num1 + num2));
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}