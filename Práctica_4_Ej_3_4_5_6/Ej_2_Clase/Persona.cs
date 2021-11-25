using System;
using System.Collections;

namespace Ej_2_Clase
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		protected string nom;
		protected int edad;
		protected int dni;
		protected int id;
		protected DateTime fechaNacimiento;
		protected static int cont_persona = 0;
		
		public Persona(string nom, int edad, int dni, DateTime fecha)
		{
			this.nom = nom;
			this.edad = edad;
			this.dni = dni;
			fechaNacimiento = fecha;
			cont_persona++;
			id = cont_persona;
			
		}
		
		public static int ver_cont()
		{
			return cont_persona;
		}
		
		public bool esMayorQue(Persona p)
		{
			if (this == null) {
				return false;
			}
			
			if (this.edad > p.edad) {
				return true;
			}
			return false;
			
		}
		
		
		public void imprimir()
		{
			Console.WriteLine("Id: " +id+ "\nNombre: " +nom+ "\nEdad: (" +edad+ ") \nDNI: " +dni+  " \nFecha de nacimiento: " +fechaNacimiento.ToString("d")); /*con "d" muestro solo la fecha*/
			
		     
		}
	}
}
