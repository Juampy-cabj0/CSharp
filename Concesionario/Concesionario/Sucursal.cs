using System;

namespace Concesionario
{
	/// <summary>
	/// Description of Sucursal.
	/// </summary>
	public class Sucursal: Concesionario
	{
		private int numero;
		private string localidad;
		
		public Sucursal(int xNumero, string xLocalidad, string nom, string gere):base(nom, gere)
		{
			numero = xNumero;
			localidad = xLocalidad;
			
		}
		
		public int Numero
		{
			set { numero = value; }
			get { return numero; }
		}
		
		public string Localidad
		{
			set { localidad = value; }
			get { return localidad; }
		}
		
		public override void imprimirDatos()
		{
			Console.WriteLine("Sucursal número: {0}\n" +
			                  "Localidad: {1}", numero, localidad);
		}
	}
}
