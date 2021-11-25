using System;
using System.Collections;

namespace Ej_Exception
{
	/// <summary>
	/// Description of Aula.
	/// </summary>
	public class Aula
	{
		private ArrayList listaAlumnos;
		private int capacidad;
		
		
		public Aula()
		{
			listaAlumnos = new ArrayList();
			capacidad = 2;
			
		}
		
		public void ingreseAlumno(Alumno al)
		{
			// Analizo la capacidad del array
			if (listaAlumnos.Count < capacidad) {
				
				listaAlumnos.Add(al);
			}
			
			// Lanzo la excepcion
			else 
				throw new AulaLlena("Aula llena");
			
		}
	}
}
