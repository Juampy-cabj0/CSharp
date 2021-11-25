using System;
using System.Collections;

namespace Parcial_Nro_3
{
	/// <summary>
	/// Description of Asiento.
	/// </summary>
	public class Asiento
	{
		private int codVuelo;
		private int numero;
		private int dniPasajero;
		private string estado;
		private string apellidoPasajero;
		
		
		public Asiento(int codVuelo, int nroAsiento, int dniPasajero, string estado, string apellidoPasajero)
		{
			this.codVuelo = codVuelo;
			this.numero = nroAsiento;
			this.dniPasajero = dniPasajero;
			this.estado = estado;
			this.apellidoPasajero = apellidoPasajero;
			
		}
		
		public int CodVuelo
		{
			set { codVuelo = value; }
			get { return codVuelo; }
		}
		
		public int NroAsiento
		{
			set { numero = value; }
			get { return numero; }
		}
		
		public int DniPasajero
		{
			set { dniPasajero = value; }
			get { return dniPasajero; }
		}
		
		public string Estado
		{
			set { estado = value; }
			get { return estado; }
		}
		
		public string ApellidoPasajero
		{
			set { apellidoPasajero = value; }
			get { return apellidoPasajero; }
		}
		
	}
}
