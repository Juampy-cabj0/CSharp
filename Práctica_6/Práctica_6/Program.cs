using System;
using System.Collections;

namespace Práctica_6
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int edad;
			int dni;
			double promedio;
			
			ArrayList lista = new ArrayList();
			
			Console.Write("Ingrese persona: ");
			string dato_persona = Console.ReadLine();
			
			while (dato_persona != "") {
				
				string[] parte = dato_persona.Split(new char [] {'	'});
				
				string nombre = parte[0];
				
				edad = int.Parse(parte[1]);
				
				dni = int.Parse(parte[2]);
				
				promedio = double.Parse(parte[3]);
				
				
				Alumno a1 = new Alumno(nombre, edad, dni, promedio);
				lista.Add(a1);
				
				Console.Write("Ingrese persona: ");
				dato_persona = Console.ReadLine();
				
			}
			
			foreach (Alumno element in lista) {
				Console.WriteLine(element);
			}
			
			
			
			
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}