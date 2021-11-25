using System;
using System.Collections;

namespace Parcial_2_Clinica
{
	class Program
	{
		public static void Main(string[] args)
		{
			Clinica c1 = new Oftalmologia("Clinica Oftalmológica", 1234, "08:00 a 18:00");
			
			Console.Write("Desea contratar un Médico (s/n)?: ");
			string respuesta = Console.ReadLine();
			
			while (respuesta != "n")
			{
				Console.Write("Nombre: ");
				string nom = Console.ReadLine();
				
				Console.Write("Apellido:");
				string apellido = Console.ReadLine();
				
				Console.Write("Legajo: ");
				int legajo = int.Parse(Console.ReadLine());
				
				Console.Write("Especialidad: ");
				string espe = Console.ReadLine();
				
				Console.Write("Día Laboral: ");
				string dia = Console.ReadLine();
				
				//-------------------------------------------------------------------------------------------------------//
				// Manejo de Excepción //
				try
				{
					Console.Write("Cantidad de Horas que trabaja por día: ");
					int cantHora = int.Parse(Console.ReadLine());
					
					c1.contratarMedico(new Medico(nom, apellido, legajo, espe, dia, cantHora));
				}
				catch (FormatException fe)   // Excepción definida por el framework //
				{
					Console.WriteLine("\nERROR! \n{0}", fe.Message);
				}
				//-------------------------------------------------------------------------------------------------------//
				
				Console.Write("\nDesea contratar un Médico (s/n)?: ");
				respuesta = Console.ReadLine();
				
			}
			
			//-------------------------------------------------------------------------------------------------------//
			// Implementación del Método de Ordenamiento //
			
			double valor = ((Oftalmologia)c1).cantEspeTransplanteCorneas();

			Console.WriteLine("\nLa cantidad de Oculistas es de: {0}\n" +
			                  "El porcentaje de Oculistas especializados en Transplante de Córneas es de: {1}%\n",
			                  ((Oftalmologia)c1).ListaMedicos.Count, valor);
			ArrayList listaOrdenada = ((Oftalmologia)c1).ListaMedicos;
			
			c1.listaOrdenadaPorHora(ref listaOrdenada);
			
			foreach (Medico medico in listaOrdenada)
			{
				Console.WriteLine("Nombre: {0}\n" +
				                  "Apellido: {1}\n" +
				                  "Legajo: {2}\n" +
				                  "Especialidad: {3}\n" +
				                  "Día Laboral: {4}\n" +
				                  "Cantidad de Horas de Guardia: {5}\n",
				                  medico.NombreMedico, medico.ApellidoMedico, medico.LegajoMedico, medico.Especialidad, medico.Dia, medico.CantHoras);
			}
			
			//-------------------------------------------------------------------------------------------------------//
			// Implementación del Método Polimorfico //
			c1.imprimirDatos();
			
			//-------------------------------------------------------------------------------------------------------//
			// Listar Médicos de guardia dependiendo del día //
			
			Console.Write("\nIngrese el día de guardia que desea saber: ");
			string diaG = Console.ReadLine();
			c1.listarMedicosGuardia(diaG);
			
			
			//-------------------------------------------------------------------------------------------------------//
			// Implementación de la función recursiva //
			int [] listEdades = new int[]{20, 55, 15, 55};
			Console.WriteLine("Cantidad de personas mayores de 50 años: {0}", edadMayor50(listEdades, 0));
			
			
			//------------------------------------------------------------------------------------------------------//
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		//-------------------------------------------------------------------------------------------------------//
		// Función Recursiva //
		public static int edadMayor50(int [] listaEdades, int pos)
		{
			if (pos == listaEdades.Length)
			{
				return 0;
			}
			if (listaEdades[pos] > 50)
			{
				return 1 + edadMayor50(listaEdades, pos+1);
			}
			
			return edadMayor50(listaEdades, pos+1);
		}
	}
}
