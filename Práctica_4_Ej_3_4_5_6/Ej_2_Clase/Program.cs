using System;
using System.Collections;

namespace Ej_2_Clase
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int edad, dni;
			
			ArrayList lista = new ArrayList();
			
			DateTime fecha = new DateTime(1548, 12, 25);
			
			
			Console.Write("Ingrese persona: ");
			string dato_persona = Console.ReadLine();
			
			while (dato_persona != "") {
				
				string[] parte = dato_persona.Split(new char [] {','});
				
				string nombre = parte[0];
				
				edad = int.Parse(parte[1]);
				
				dni = int.Parse(parte[2]);
				
				
				Persona p = new Persona(nombre, edad, dni, fecha);
				lista.Add(p);
				
				Console.Write("Ingrese persona: ");
				dato_persona = Console.ReadLine();
				
			}
			
			Console.WriteLine(Persona.ver_cont());
			
			foreach (Persona elemento in lista) {
				elemento.imprimir();
				
			}
			
			Persona mayor = new Persona("juan",0,0,fecha);
			
			foreach (Persona elemento in lista) {
				if (!(mayor.esMayorQue(elemento))) {
					mayor = elemento;
				}
			}
			
			Console.WriteLine();
			Console.WriteLine("La persona mayor es: ");
			mayor.imprimir();
			
			// Ej 7) Evaluar
			double res;
			
			Operacion op = new Operacion(12, 2, "/");
			
			
			res = op.evaluar();
			Console.WriteLine(res);
			
			
			
			
			
			
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}