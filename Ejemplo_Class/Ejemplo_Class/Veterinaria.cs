using System;

namespace Ejemplo_Class
{
	public class Veterinaria
	{
		private string nom_Veterinaria;
		private Mascota [] lista_Mascota;
		private int cant_Mascotas;
		
		public Veterinaria(string nom_Veterinaria)
		{
			this.nom_Veterinaria = nom_Veterinaria;
			lista_Mascota = new Mascota[100];
			cant_Mascotas = 0;
		}
		
		public void agregarMascota(Mascota mascota)
		{
			lista_Mascota[cant_Mascotas] = mascota;
			cant_Mascotas++;
		}
		
		public string Nombre
		{
			set { nom_Veterinaria = value; }
			get { return nom_Veterinaria; }
		}
		
		public Mascota[] Lista_Mascota
		{
			get { return lista_Mascota; }
		}
		
		public int Cant_Mascotas
		{
			get { return cant_Mascotas; }
		}
	}
}
