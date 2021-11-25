using System;

namespace Ej_Exception
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Inicializo la case Alumno y le cargo los parametros
			Alumno a1 = new Alumno("Juan", 34692667);
			Alumno a2 = new Alumno("Perez", 34691567);
			Alumno a3 = new Alumno("Ale", 35692667);
			
			// Inicializo la clase Aula y luego evaluo una excepcion
			Aula aula1 = new Aula();
			
			try {
				aula1.ingreseAlumno(a1);
				aula1.ingreseAlumno(a2);
				aula1.ingreseAlumno(a3);
				
				
			} catch (AulaLlena objeto) {
				
				Console.WriteLine(objeto.motivo);
			}
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}