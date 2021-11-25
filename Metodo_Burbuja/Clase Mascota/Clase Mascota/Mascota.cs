using System;

namespace Clase_Mascota
{
	/// <summary>
	/// Description of Mascota.
	/// </summary>
	public class Mascota
	{
		private string nombre, nombreDelDueño, especie, diagnos;
		private int edad;

		
		public Mascota()
		{
		}
		
		public Mascota(string nom, string esp, string dueño, int e)
		{
			nombre = nom;
			nombreDelDueño = dueño;
			especie = esp;
			edad = e;
			diagnos = "";

		}
		
		/*propiedades*/
		public string Nombre
		{
			set { nombre = value; }
            get { return nombre; }
		}
		
		public string NombreDelDueño
		{
			set {nombreDelDueño = value; }
			get {return nombreDelDueño; }
		}

		public string Especie
		{
			set {especie = value; }
			get {return especie;}
		}

		public int Edad
		{
			set {  edad = value; }
			get { return edad; }
		}

		public string Diagnostico
		{
			set {   diagnos = value; }
			get {   return diagnos;}
		}
	}
	
}
