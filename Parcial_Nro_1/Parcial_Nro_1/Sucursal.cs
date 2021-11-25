using System;

namespace Parcial_Nro_1
{
	public class Sucursal : Concesionario
	{
		private int numeroSucursal;
		private string localidad;
		
		public Sucursal(int numeroSucursal, string localidad, string nombreConcesionario, string gerenteConcesionario) : base(nombreConcesionario, gerenteConcesionario)
		{
			this.numeroSucursal = numeroSucursal;
			this.localidad = localidad;
		}
		
		// Polimorfismo en Herencia //
		public override void imprimirDatos()
		{
			Console.WriteLine("Nro de Sucursal: {0}	Localidad: {1}", numeroSucursal, localidad);
			
		}
		
		public int NumeroSucursal 
		{
			get { return numeroSucursal; }
			set { numeroSucursal = value; }
		}

		public string Localidad 
		{
			get { return localidad; }
			set { localidad = value; }
		}
	}
}
