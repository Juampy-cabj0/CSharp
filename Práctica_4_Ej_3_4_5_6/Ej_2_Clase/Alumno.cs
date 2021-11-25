using System;

namespace Ej_2_Clase
{
	public class Alumno : Persona
	{
		private double promedio;
		
		public Alumno(string nom, int edad, int dni, DateTime fecha, double promedio) : base(nom, edad, dni, fecha)
		{
			this.promedio = promedio;
			
		}
	}
}
