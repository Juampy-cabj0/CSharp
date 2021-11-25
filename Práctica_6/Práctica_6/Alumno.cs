using System;

namespace Práctica_6
{
	public class Alumno : Persona
	{
		private double promedio;
		
		public Alumno(string nombre, int edad, int dni, DateTime fechaDeNacimiento, double promedio) : base(nombre, edad, dni, fechaDeNacimiento)
		{
			this.promedio = promedio;
		}
		
		public Alumno(string nombre, int edad, int dni, double promedio) : base(nombre, edad, dni)
		{
			this.promedio = promedio;
		}
		
		// Sobreescribo el metodo ToString
		public override string ToString()
		{
			//Invoco al metodo del padre cuando se utiliza polimorfismo
			// base.ToString();
			
			return "Alumno: " +nombre+ "(" +edad+ ") DNI: " +dni+ " Promedio: " +promedio;
		}

	}
}
