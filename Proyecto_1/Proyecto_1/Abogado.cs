using System;
using System.Collections;

namespace Proyecto_1
{
	public class Abogado
	{
		private string nomYape;
		private int dni;
		private string especialidad; // (laboral, penal, comercial, familia,etc.) //
		private int cantExpAsig;
		
		
		public Abogado(string nomYape, int dni, string especialidad)
		{
			this.nomYape = nomYape;
			this.dni = dni;
			this.especialidad = especialidad;
			this.cantExpAsig = 0;
		}

		public string NomYape
		{
			get { return nomYape; }
			set { nomYape = value; }
		}
		
		public int Dni
		{
			get { return dni; }
			set { dni = value; }
		}

		public string Especialidad
		{
			get { return especialidad; }
			set { especialidad = value; }
		}

		public int CantExpAsig
		{
			get { return cantExpAsig; }
			set { cantExpAsig = value; }
		}
		
		public override bool Equals(object obj)
		{
			Abogado other = obj as Abogado;
		
			// Si el parámetro es nulo, devuelve falso.
			if (other == null)
			{
				return false;
			}
			
			// Si el parámetro no se puede convertir a Abogado, devuelve falso.
			if ((Object)other == null) 
			{
				return false;
			}
			
			// Devuelve verdadero si los campos coinciden:
			return this.dni == other.dni;
		}
		
		public override string ToString()
		{
			return string.Format("\nNombre y Apellido: {0}\n" +
			                     "DNI: {1}\n" +
			                     "Especialidad: {2}\n" +
			                     "Expedientes Asignados: {3}\n",
			                      nomYape, dni, especialidad, cantExpAsig);
		}

	}
}
