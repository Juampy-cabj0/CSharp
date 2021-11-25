using System;

namespace Práctica_5_Ej_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			string ingresarMate;
			
			Universidad uni = new Universidad();
			
//
//			Materia m1 = new Materia("algoritmos", profe);
//
//			Alumnos alum = new Alumnos("Juan", "Mansilla");
//
//			m1.ingresarAlumno(alum);
			
			Console.WriteLine("Ingrese si para continuar");
			ingresarMate = Console.ReadLine();
			
			string materia;
			
			
			Materia m1;
			
			while (ingresarMate == "si") {
				
				Console.WriteLine("Ingrese materia: ");
				materia = Console.ReadLine();
				
				m1 = new Materia(materia);
				
				uni.agregarMateria(m1);
				
				Console.WriteLine("Ingrese si para continuar");
				ingresarMate = Console.ReadLine();
				
				
			}
			
			Profesor profe = new Profesor("Veronica");

			uni.asigProfeMate("algoritmos", profe);
			
			uni.mostrarLista();
			
			try {
				uni.mostrarMateria("fisica");
				
			} catch (MateriaInexistente) {
				
				Console.WriteLine("Materia inexistente");
				
			}
			
			
			
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}