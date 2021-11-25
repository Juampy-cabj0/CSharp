using System;

namespace Ejemplo_Class
{
	public class Mascota
	{
		private string nom_Mascota;
		private string dueño;
		private string especie;
		private string diagnostico;
		private int edad;
			
		public Mascota(string nom_Mascota, string dueño, string especie, int edad)
		{
			this.nom_Mascota = nom_Mascota;
			this.dueño = dueño;
			this.especie = especie;
			this.edad = edad;
			diagnostico = "";
			
		}
		
		public string Nom_Mascota
		{
			set { nom_Mascota = value; }
			get { return nom_Mascota; }
		}
		
		public string Dueño
		{
			set { dueño = value; }
			get { return dueño; }
		}
		
		public string Especie 
		{
			set { especie = value; }
			get { return especie; }
		}
		
		public string Diagnostico
		{
			set { diagnostico = value; }
			get { return diagnostico; }
		}
		
		public int Edad
		{
			set { edad = value; }
			get { return edad; }
		}
		
		/* Muestro el objeto*/
		public override string ToString()
		{
			return nom_Mascota + " " + dueño + " " + especie + " " + edad + " " + diagnostico;
		}
	}
}
