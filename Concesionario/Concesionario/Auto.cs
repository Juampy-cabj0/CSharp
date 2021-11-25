using System;

namespace Concesionario
{
	/// <summary>
	/// Description of Auto.
	/// </summary>
	public class Auto
	{
		private string marca, modelo;
		private float precio;
		
		public Auto(string xMarca, string xModelo, float xPrecio)
		{
			marca = xMarca;
			modelo = xModelo;
			precio = xPrecio;
		}
		
		public string Marca
		{
			set { marca = value; }
			get { return marca; }
		}
		
		public string Modelo
		{
			set { modelo = value; }
			get { return modelo; }
		}
		
		public float Precio
		{
			set { precio = value; }
			get { return precio; }
		}
		
	}
}
