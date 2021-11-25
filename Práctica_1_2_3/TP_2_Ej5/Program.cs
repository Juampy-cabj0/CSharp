using System;

namespace TP_2_Ej5
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			/*5- Implemente un programa de aplicación que simule el funcionamiento de una calculadora que permita al usuario realizar
				  las cuatro operaciones elementales e imprimir el resultado de la operación.
				  Para ello el programa debe mostrar un menú de opciones con cada una de las operaciones,
			      luego de seleccionar la operación el programa pide ingresar dos números, realiza la operación solicitada e imprime el resultado.
				 Cada operación se resuelve con una función.
                  El usuario debe poder realizar tantas operaciones como desee hasta seleccionar una opción de salida.*/
			
			int op = Menu();
			
			while (op != 5) {
				
				switch (op) {
					case 1:
						Console.WriteLine("La suma es: " + Suma(Valor1(), Valor2()));
						break;
					case 2:
						Console.WriteLine("La resta es: " + Resta(Valor1(), Valor2()));
						break;
					case 3:
						if (Valor1() != 0 && Valor2() != 0) {
							Console.WriteLine("La multiplicación es: " + Multiplicar(Valor1(), Valor2()));
						}
						else {
							Console.WriteLine();
							Console.WriteLine("No se puede multiplicar por 0 (cero)");
						}
						break;
						
					case 4:
						if (Valor1() != 0 && Valor2() != 0) {
							Console.WriteLine("La división es: " + Dividir(Valor1(), Valor2()));
						}
						else {
							Console.WriteLine();
							Console.WriteLine("No se puede dividir por 0 (cero)");
						}
						break;
						
				}
				Console.WriteLine();
				op = Menu();
				
			}
			Console.WriteLine("Gracias por utilizar el programa.");
			
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static int Menu()
		{
			Console.Write("*******************************\n"+
			              "********* Calculadora *********\n"+
			              "*******************************\n"+
			              "Opción 1 - Suma\n"+
			              "Opción 2 - Resta\n"+
			              "Opción 3 - Multiplicar\n"+
			              "Opción 4 - Dividir\n"+
			              "Opción 5 - Salir\n"+
			              "*******************************\n"+
			              "Ingrese la opción deseada: ");
			int op = int.Parse(Console.ReadLine());
			Console.WriteLine();
			return op;
			
		}
		
		public static double Valor1()
		{
			Console.Write("Ingrese un valor: ");
			int num1 =  int.Parse(Console.ReadLine());
			return num1;
			
		}
		
		static double Valor2()
		{
			Console.Write("Ingrese un nuevo valor: ");
			int num2 =  int.Parse(Console.ReadLine());
			return num2;
			
		}
		
		static double Suma(double num1, double num2)
		{
			return num1 + num2;
		}
		
		static double Resta(double num1, double num2)
		{
			return num1 - num2;
		}
		
		static double Multiplicar(double num1, double num2)
		{
			return num1 * num2;
		}
		
		static double Dividir(double num1, double num2)
		{
			
			return num1 / num2;
		}
	}
}