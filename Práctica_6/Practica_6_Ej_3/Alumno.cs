using System;

namespace Practica_6_Ej_3
{
	public class Alumno
	{
		private string nombre;
		private string apellido;
		private int legajo;
		private double promedio;
		
		public Alumno(int legajo, string nombre, string apellido, double promedio)
		{
			this.legajo = legajo;
			this.nombre = nombre;
			this.apellido = apellido;
			this.promedio = promedio;
		}
		
//		public bool mejorPromedioQue(Alumno otroAlumno)
//		{
//			Profesor p1 = new Profesor("", 0);
//			
//			foreach (Alumno element in p1.Alumnos) {
//				
//				if (element.promedio > otroAlumno.promedio) {
//					return true;
//					
//				}
//			}
//			return false;
//		}

		public double Promedio
		{
			set { promedio = value; }
			get { return promedio; }
		}
	}
}
