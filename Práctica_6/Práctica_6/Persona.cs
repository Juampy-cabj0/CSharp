using System;

namespace Práctica_6
{
	public class Persona
	{
		protected string nombre;
		protected int edad;
		protected int dni;
		protected DateTime fechaDeNacimiento;
		
		public Persona(string nombre, int edad, int dni, DateTime fechaDeNacimiento)
		{
			this.nombre = nombre;
			this.edad = edad;
			this.dni = dni;
			this.fechaDeNacimiento = fechaDeNacimiento;
				
		}
		
		public Persona(string nombre, int edad, int dni)
		{
			this.nombre = nombre;
			this.edad = edad;
			this.dni = dni;
		}
		
		/* Metodo polimorfico utilizado en herencias */
		/* Cuando utilizo este metodo, no debe retornar nada (void) */
		  
//		public virtual void ToString()
//		{
//			Console.WriteLine("Lista de alumnos:");
//		}
		
		
	}
}
