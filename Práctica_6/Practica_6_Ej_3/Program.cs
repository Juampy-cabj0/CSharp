using System;

namespace Practica_6_Ej_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			Coordinador coordinador = new Coordinador("Matematica", 2, "Ingenieria");
			Alumno a1 = new Alumno(0, "", "", 0);
			
			int contNoInscriptos = 0;
			
			Console.Write("Ingrese un alumno: ");
			string alumno = Console.ReadLine();
			
			while (alumno != "") {
				
				string [] partes = alumno.Split(new char[] {','});
				
				int legajo = int.Parse(partes[0]);
				string nombre = partes[1];
				string apellido = partes[2];
				double promedio = double.Parse(partes[3]);
				
				a1 = new Alumno(legajo, nombre, apellido, promedio);
				
				if (coordinador.Cupo != 0) {
					
					coordinador.altaAlumno(a1);
					
					Console.WriteLine("El alumno se inscribio con éxito.\n");
					
				}
				
				else{
					Console.WriteLine("\nNo hay cupos disponibles!\n");
					contNoInscriptos++;
					
				}
				
				Console.Write("Ingrese un alumno: ");
				alumno = Console.ReadLine();
				
			}
			
			if (contNoInscriptos != 0) {
				Console.WriteLine("\nLa cantidad de alumnos NO inscriptos es de: {0}", contNoInscriptos);
			}
			
			int cont = coordinador.Alumnos.Count;
			int sumaPromedio = 0;
			
			foreach (Alumno elemento in coordinador.Alumnos) {
				if (elemento.Promedio > 8) {
					sumaPromedio++;
				}
			}
			
			Console.WriteLine("El porcentaje de alumnos con promedio mayor a 8 es de: {0}%", ((sumaPromedio * 100) /cont));
			
			Console.WriteLine();
//			mejorPromedioAlum();
			
			Console.WriteLine();
			Console.SetWindowSize(80,20);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
//		public static void mejorPromedioAlum()
//		{
//			Alumno a2 = new Alumno(123, "Juan", "Mansi", 8);
//			
//			
//			if (a2.mejorPromedioQue(a2)) {
//				Console.WriteLine("El promedio del alumno ingresado es bajo");
//			}
//			else
//				Console.WriteLine("El promedio del alumno ingresado es el más alto");
//		}
	}
}