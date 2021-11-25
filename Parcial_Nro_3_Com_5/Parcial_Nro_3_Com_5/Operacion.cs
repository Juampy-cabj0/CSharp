using System;
using System.Collections;
using System.Collections.Generic;

namespace Parcial_Nro_3_Com_5
{
	/// <summary>
	/// Description of Operacion.
	/// </summary>
	public class Operacion 
	{
		private string tipo, apellidoTitular;
		private int numeroPartida, importe, codigoSucursal;
		

		public Operacion(int codSucursal, string xTipo, string xApellidoTitular, int xNumeroPartida, int xImporte)
		{
			codigoSucursal = codSucursal;
			tipo = xTipo;
			apellidoTitular = xApellidoTitular;
			numeroPartida = xNumeroPartida;
			importe = xImporte;
		}
		
		public string Tipo
		{
			set { tipo = value; }
			get { return tipo; }
		}
		
		public string ApellidoTitular
		{
			set { apellidoTitular = value; }
			get { return apellidoTitular; }
		}
		
		public int NroPartida
		{
			set { numeroPartida = value; }
			get { return numeroPartida; }
		}
		
		public int Importe
		{
			set { importe = value; }
			get { return importe; }
		}
		
		public int CodSucursal
		{
			set { codigoSucursal = value; }
			get { return codigoSucursal; }
		}
	}
}
